using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhSoNguyen
{
    public partial class TinhTongChan : Form
    {
        public TinhTongChan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtn.Text = "";
            txtKetQua.Text = "";
            txtn.Focus();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int value = int.Parse(txtn.Text);
            txtKetQua.Text = Convert.ToString(tinhTongChan(value));
        }
        private long tinhTongChan(int n)
        {
            long temp = 0;
            for (int i = 2; i <= n; i++)
            {
                if (1 % 2 == 0)
                {
                    temp += i;
                }
            }
            return temp;
        }
    }
}
