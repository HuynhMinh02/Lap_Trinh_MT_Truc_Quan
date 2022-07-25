namespace TinhTienPhongKham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
        }
        int tt1, tt2, tt3, tt4;

        private void niengRang_CheckedChanged(object sender, EventArgs e)
        {
            if (niengRang.Checked == true)
            {
                tt2 = 2000000;
            }
            else
            {
                tt2 = 0;
            }
        }

        private void nhoRang_ValueChanged(object sender, EventArgs e)
        {
            if (nhoRang.Value == 0)
            {
                tt3 = 0;
            }
            else
            {
                tt3 = (int)nhoRang.Value * 500000;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {


        }

        private void trongRang_ValueChanged(object sender, EventArgs e)
        {
            if (trongRang.Value == 0)
            {
                tt4 = 0;
            }
            else
            {
                tt4 = (int)trongRang.Value * 200000;
            }
        }

        private void btn_TinhTien_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_ten.Text) && !String.IsNullOrEmpty(comboBox1.Text))
            {

                txt_TinhTien.Text = Convert.ToString(tt1 + tt2 + tt3 + tt4) + " " + "VND";
            }
            else
            {
                MessageBox.Show("Nhap day du thong tin");
            }

        }

        private void tayRang_CheckedChanged(object sender, EventArgs e)
        {
            if (tayRang.Checked == true)
            {
                tt1 = 100000;
            }
            else
            {
                tt1 = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}