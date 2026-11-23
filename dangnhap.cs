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
    public partial class frmdangnhap : Form
    {
        ketnoi kn = new ketnoi();
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Text.Trim() == "" ||
               txtmatkhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            SqlConnection conn = kn.MoKetNoi();

            try
            {
                

                string sql =
                    @"SELECT COUNT(*)
                      FROM nguoidung
                      WHERE taikhoan=@tk
                      AND matkhau=@mk";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@tk",
                    txttaikhoan.Text.Trim());

                cmd.Parameters.AddWithValue("@mk",
                    txtmatkhau.Text.Trim());

                int kq = (int)cmd.ExecuteScalar();

                if (kq > 0)
                {
                    MessageBox.Show(
                        "Đăng nhập thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    
                    Formcha frm = new Formcha();
                    frm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Sai tên đăng nhập hoặc mật khẩu!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
        