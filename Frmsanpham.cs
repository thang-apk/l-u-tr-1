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
    public partial class Frmsanpham : Form
    {
        ketnoi kn = new ketnoi();
        public Frmsanpham()
        {
            InitializeComponent();
        }

        

        private void Frmsanpham_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        public void LoadDuLieu()
        {

            try
            {


                SqlConnection conn = kn.MoKetNoi();

                string sql = "SELECT * FROM sanpham";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvsanpham.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kn.DongKetNoi();
            }


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmasp.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa sản phẩm này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.No)
            {
                return;
            }

            try
            {
                SqlConnection conn = kn.MoKetNoi();

                string sql = "DELETE FROM sanpham WHERE masp = @masp";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@masp", txtmasp.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa thành công!");

                LoadDuLieu();

                
                txtmasp.Clear();
                txttensp.Clear();
                txtgia.Clear();
                txttonkho.Clear();
                cbloaisp.SelectedIndex = -1;
                dtpngaynhap.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kn.DongKetNoi();
            }
        }

       

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmasp.Clear();
            txttensp.Clear();
            txtgia.Clear();
            txttonkho.Clear();
            txthang.Clear();
            cbloaisp.SelectedIndex = -1;

            dtpngaynhap.Value = DateTime.Now;

            txtmasp.Focus();

            LoadDuLieu();
        }

        

        

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = kn.MoKetNoi();

                string sql = @"INSERT INTO sanpham (masp,tensp,loaisp,hangsx,gia,tonkho,ngaynhap)
                       VALUES(@masp,@tensp,@loaisp,@hangsx,@gia,@tonkho,@ngaynhap)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@masp", txtmasp.Text);
                cmd.Parameters.AddWithValue("@tensp", txttensp.Text);
                cmd.Parameters.AddWithValue("@loaisp", cbloaisp.Text);
                cmd.Parameters.AddWithValue("@hangsx", txthang.Text);
                cmd.Parameters.AddWithValue("@gia", Convert.ToDecimal(txtgia.Text));
                cmd.Parameters.AddWithValue("@tonkho", Convert.ToInt32(txttonkho.Text));
                cmd.Parameters.AddWithValue("@ngaynhap", dtpngaynhap.Value.Date);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm thành công");

                LoadDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kn.DongKetNoi();
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            if (txtmasp.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                return;
            }
            try
            {
                SqlConnection conn = kn.MoKetNoi();

                string sql = @"UPDATE sanpham SET
                       
                   tensp = @tensp,
                   loaisp = @loaisp,
                   gia = @gia,
                   hangsx=@hangsx,
                   tonkho = @tonkho,
                   ngaynhap = @ngaynhap
                   WHERE masp = @masp";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@masp", txtmasp.Text);
                cmd.Parameters.AddWithValue("@tensp", txttensp.Text);
                cmd.Parameters.AddWithValue("@loaisp", cbloaisp.Text);
                cmd.Parameters.AddWithValue("@hangsx", txthang.Text);
                cmd.Parameters.AddWithValue("@gia", Convert.ToDecimal(txtgia.Text));
                cmd.Parameters.AddWithValue("@tonkho", Convert.ToInt32(txttonkho.Text));
                cmd.Parameters.AddWithValue("@ngaynhap", dtpngaynhap.Value.Date);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Sửa thành công");

                LoadDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kn.DongKetNoi();
            }
        }

        private void dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvsanpham.Rows[e.RowIndex].IsNewRow)
                    return;
                DataGridViewRow row = dgvsanpham.Rows[e.RowIndex];

                txtmasp.Text = row.Cells["masp"].Value.ToString();
                txttensp.Text = row.Cells["tensp"].Value.ToString();
                cbloaisp.Text = row.Cells["loaisp"].Value.ToString();
                txthang.Text = row.Cells["hangsx"].Value.ToString();
                txtgia.Text = row.Cells["gia"].Value.ToString();
                txttonkho.Text = row.Cells["tonkho"].Value.ToString();
                dtpngaynhap.Value =Convert.ToDateTime(row.Cells["ngaynhap"].Value);
            }
            dgvsanpham.AllowUserToAddRows = false;
        }
        private void TimKiemSanPham()
        {
            SqlConnection conn = kn.MoKetNoi();

            string sql = "SELECT * FROM sanpham WHERE tensp LIKE @tensp";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@tensp", "%" + txttimkiem.Text.Trim() + "%");

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvsanpham.DataSource = dt;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            TimKiemSanPham();
        }
    }
}
