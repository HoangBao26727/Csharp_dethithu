using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_dethithu
{
    public partial class FRMMAIN : Form
    {
        public FRMMAIN()
        {
            InitializeComponent();
        }

        private void FRMMAIN_Load(object sender, EventArgs e)
        {
            String hovaten = "Nguyen Van A";
            String mssv = " 2312323213123";
            String monthi = " Lap trinh window 2 - C#";

            lblInfo.Text = " Họ Và Tên:" + hovaten;
            lblInfo.Text += "\nMSSV: " + mssv;
            lblInfo.Text += "\nNgày Thi: " + System.DateTime.Now.ToString();
            lblInfo.Text += "\nMôn Thi: " + monthi;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giaiPTBac2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaiPhuongTrinhBac2 gpt = new GiaiPhuongTrinhBac2();
            gpt.Show();
        }

        private void dinhDangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DinhDang dinhDang = new DinhDang();
            dinhDang.Show();
        }

        private void gioiThieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ác quỷ phi phai ", " man phi phai -"); 

        }

        private void dangKyMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dkmh2 dkmh2 = new dkmh2();
            dkmh2.Show();
        }
    }
}
