using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Frmhoadon : Form
    {
        ketnoi kn = new ketnoi();
        public Frmhoadon()
        {

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Frmhoadon_Load(object sender, EventArgs e)
        {
            TaoMaHD();
            dtngay.Value = DateTime.Now;
            dgvcthd.Columns.Clear();

            dgvcthd.Columns.Add("MaSP", "Mã SP");
            dgvcthd.Columns.Add("TenSP", "Tên sản phẩm");
            dgvcthd.Columns.Add("DonGia", "Đơn giá");
            dgvcthd.Columns.Add("SoLuong", "Số lượng");
            dgvcthd.Columns.Add("ThanhTien", "Thành tiền");
        }


        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void TaoMaHD()
        {
            SqlConnection conn = kn.MoKetNoi();

            string sql = "SELECT TOP 1 mahd FROM hoadon ORDER BY mahd DESC";

            SqlCommand cmd = new SqlCommand(sql, conn);

            object kq = cmd.ExecuteScalar();

            if (kq == null)
            {
                txtmahd.Text = "HD001";
            }
            else
            {
                string mahd = kq.ToString();

                int so = int.Parse(mahd.Substring(2));

                so++;

                txtmahd.Text = "HD" + so.ToString("000");
            }
        }

        private void textmasp_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmasp.Text))
                return;
            SqlConnection conn = kn.MoKetNoi();

            string sql = "SELECT tensp, Gia FROM sanpham WHERE masp = @masp";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@masp", txtmasp.Text.Trim());

            SqlDataReader dr = cmd.ExecuteReader();

            
            if (dr.Read())
            {
                txttensp.Text = dr["tensp"].ToString();
                txtgia.Text = dr["gia"].ToString();
            }
            else
            {
                MessageBox.Show("Mã sản phẩm không tồn tại!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtmasp.Clear();
                txttensp.Clear();
                txtgia.Clear();
                txtsoluong.Clear();
                txtthanhtien.Clear();

                txtmasp.Focus();
            }


            dr.Close();
            conn.Close();
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            if (txtgia.Text != "" && txtsoluong.Text != "")
            {
                decimal dongia = decimal.Parse(txtgia.Text);
                int soluong = int.Parse(txtsoluong.Text);

                txtthanhtien.Text = (dongia * soluong).ToString();
            }
            else
            {
                txtthanhtien.Clear();
            }
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            dgvcthd.Rows.Add(
            txtmasp.Text,
            txttensp.Text,
            txtgia.Text,
            txtsoluong.Text,
            txtthanhtien.Text
        );

            TinhTongTien();

            txtmasp.Clear();
            txttensp.Clear();
            txtgia.Clear();
            txtsoluong.Clear();
            txtthanhtien.Clear();
            txtmasp.Focus();
        }
        private void TinhTongTien()
        {
            decimal tong = 0;


            foreach (DataGridViewRow row in dgvcthd.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    tong += Convert.ToDecimal(row.Cells[4].Value);
                }
            }

            txttongtien.Text = tong.ToString();
            MessageBox.Show("Tổng tiền = " + txttongtien.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvcthd.SelectedRows.Count > 0)
            {
                dgvcthd.Rows.RemoveAt(dgvcthd.SelectedRows[0].Index);

                TinhTongTien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmasp.Clear();
            txttensp.Clear();
            txtgia.Clear();
            txtsoluong.Clear();
            txtthanhtien.Clear();

            txttongtien.Text = "0";

            dtngay.Value = DateTime.Now;

            TaoMaHD();

            dgvcthd.Rows.Clear();

            txtmasp.Focus();
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            
            if (dgvcthd.Rows.Count == 0 || (dgvcthd.Rows.Count == 1 && dgvcthd.Rows[0].IsNewRow))
            {
                MessageBox.Show("Chưa có sản phẩm trong hóa đơn!");
                return;
            }

            SqlConnection conn = kn.MoKetNoi();

            SqlTransaction trans = conn.BeginTransaction();

            try
            {
                //======================
                // Lưu bảng Hóa Đơn
                //======================

                string sqlHD = @"INSERT INTO hoadon(mahd, ngaylap, tongtien)
                         VALUES(@mahd,@ngaylap,@tongtien)";

                SqlCommand cmdHD = new SqlCommand(sqlHD, conn, trans);

                cmdHD.Parameters.AddWithValue("@mahd", txtmahd.Text.Trim());
                cmdHD.Parameters.AddWithValue("@ngaylap", dtngay.Value);
                cmdHD.Parameters.AddWithValue("@tongtien", decimal.Parse(txttongtien.Text));

                cmdHD.ExecuteNonQuery();
                MessageBox.Show("Đang lưu sản phẩm");
                foreach (DataGridViewRow row in dgvcthd.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    string masp = row.Cells[0].Value.ToString();
                    decimal gia = Convert.ToDecimal(row.Cells[2].Value);
                    int soluong = Convert.ToInt32(row.Cells[3].Value);
                    decimal thanhtien = Convert.ToDecimal(row.Cells[4].Value);

                    //------------------------
                    // Kiểm tra tồn kho
                    //------------------------

                    string sqlCheck = "SELECT tonkho FROM sanpham WHERE masp=@masp";

                    SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn, trans);

                    cmdCheck.Parameters.AddWithValue("@masp", masp);

                    int tonkho = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (soluong > tonkho)
                    {
                        MessageBox.Show("Sản phẩm " + masp + " chỉ còn " + tonkho + " sản phẩm.");

                        trans.Rollback();
                        conn.Close();
                        return;
                    }

                    //------------------------
                    // Lưu Chi Tiết HĐ
                    //------------------------

                    string sqlCT = @"INSERT INTO chitiethd
                            (mahd,masp,soluong,gia,thanhtien)
                            VALUES
                            (@mahd,@masp,@soluong,@gia,@thanhtien)";

                    SqlCommand cmdCT = new SqlCommand(sqlCT, conn, trans);

                    cmdCT.Parameters.AddWithValue("@mahd", txtmahd.Text.Trim());
                    cmdCT.Parameters.AddWithValue("@masp", masp);
                    cmdCT.Parameters.AddWithValue("@soluong", soluong);
                    cmdCT.Parameters.AddWithValue("@gia", gia);
                    cmdCT.Parameters.AddWithValue("@thanhtien", thanhtien);

                    cmdCT.ExecuteNonQuery();

                    //------------------------
                    // Trừ tồn kho
                    //------------------------

                    string sqlUpdate = @"UPDATE sanpham
                                 SET tonkho = tonkho - @soluong
                                 WHERE masp=@masp";

                    SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn, trans);

                    cmdUpdate.Parameters.AddWithValue("@soluong", soluong);
                    cmdUpdate.Parameters.AddWithValue("@masp", masp);

                    cmdUpdate.ExecuteNonQuery();
                }

                trans.Commit();


                MessageBox.Show("Xuất hóa đơn thành công!");

                btnlammoi.PerformClick();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        
        private void btninhd_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Size = new Size(900, 500);
            printPreviewDialog1.PrintPreviewControl.Zoom = 0.75;
            printPreviewDialog1.ShowDialog();
          
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font tieude = new Font("Arial", 16, FontStyle.Bold);
            Font font = new Font("Arial", 11);

            int y = 30;

            // Tiêu đề
            e.Graphics.DrawString("CỬA HÀNG BÁN HÀNG", tieude, Brushes.Black, 180, y);

            y += 40;

            e.Graphics.DrawString("Mã hóa đơn: " + txtmahd.Text, font, Brushes.Black, 30, y);

            y += 25;

            e.Graphics.DrawString("Ngày: " + dtngay.Value.ToString("dd/MM/yyyy"),
                font, Brushes.Black, 30, y);

            y += 35;

            e.Graphics.DrawLine(Pens.Black, 30, y, 750, y);

            y += 20;

            // Tiêu đề bảng
            e.Graphics.DrawString("Tên SP", font, Brushes.Black, 30, y);
            e.Graphics.DrawString("SL", font, Brushes.Black, 320, y);
            e.Graphics.DrawString("Giá", font, Brushes.Black, 400, y);
            e.Graphics.DrawString("Thành tiền", font, Brushes.Black, 550, y);

            y += 25;

            e.Graphics.DrawLine(Pens.Black, 30, y, 750, y);

            y += 10;

            // Danh sách sản phẩm
            foreach (DataGridViewRow r in dgvcthd.Rows)
            {
                if (r.IsNewRow) continue;

                e.Graphics.DrawString(r.Cells[1].Value.ToString(), font, Brushes.Black, 30, y);
                e.Graphics.DrawString(r.Cells[3].Value.ToString(), font, Brushes.Black, 320, y);
                e.Graphics.DrawString(
                    Convert.ToDecimal(r.Cells[2].Value).ToString("N0"),
                    font, Brushes.Black, 400, y);
                e.Graphics.DrawString(
                    Convert.ToDecimal(r.Cells[4].Value).ToString("N0"),
                    font, Brushes.Black, 550, y);

                y += 25;
            }

            e.Graphics.DrawLine(Pens.Black, 30, y, 750, y);

            y += 30;

            e.Graphics.DrawString(
                "Tổng tiền: " + decimal.Parse(txttongtien.Text).ToString("N0") + " VNĐ",
                new Font("Arial", 12, FontStyle.Bold),
                Brushes.Black,
                420,
                y);

            y += 50;

            e.Graphics.DrawString(
                "Xin cảm ơn quý khách!",
                new Font("Arial", 12, FontStyle.Italic),
                Brushes.Black,
                250,
                y);

        }
    }
}
 
