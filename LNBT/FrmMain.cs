using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNBT
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap FrmDangNhap = new FrmDangNhap();
            FrmDangNhap.Show();
            this.Close();
            
        }

        private void xemDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txbThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void ThongTinCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongTinCaNhan f = new FrmThongTinCaNhan();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdmin f = new FrmAdmin();
            f.ShowDialog();
        }
    }
}
