using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Formcha : Form
    {
        public Formcha()
        {
            LayoutMdi(MdiLayout.TileHorizontal);
            InitializeComponent();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmsanpham frmsanpham = new Frmsanpham();
            frmsanpham.MdiParent = this;
            frmsanpham.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmhoadon frmhoadon = new Frmhoadon();
            frmhoadon.MdiParent = this;
            frmhoadon.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
