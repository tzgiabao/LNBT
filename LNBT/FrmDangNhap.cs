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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string  username = txtTenDangNhap.Text;
            string  password = txtMatKhau.Text;

            if (username == "admin" && password == "123456")
            {
                var frmMain = new FrmMain();
                frmMain.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát !");
            Application.Exit();
        }

    }
}
