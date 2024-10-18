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
    public partial class FrmThongTinCaNhan : Form
    {
        public FrmThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void FrmThongTinCaNhan_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
