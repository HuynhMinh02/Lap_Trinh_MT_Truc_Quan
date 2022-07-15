namespace MayTinhBoTui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String phepTinh;
        float data1, data2;

        private void button14_Click(object sender, EventArgs e)
        {
            if (phepTinh == "+")
            {
                data2 = data1 + float.Parse(txtHienThi.Text);
                txtHienThi.Text = data2.ToString();

            }
            if (phepTinh == "-")
            {
                data2 = data1 - float.Parse(txtHienThi.Text);
                txtHienThi.Text = data2.ToString();
            }
            if (phepTinh == "*")
            {
                data2 = data1 * float.Parse(txtHienThi.Text);
                txtHienThi.Text = data2.ToString();
            }
            else
            {
                data2 = data1 / float.Parse(txtHienThi.Text);
                txtHienThi.Text = data2.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            phepTinh = "*";
            data1 = float.Parse(txtHienThi.Text);
            //txtHienThi.Text = txtHienThi.Text + "-";
            txtHienThi.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            phepTinh = "/";
            data1 = float.Parse(txtHienThi.Text);
            //txtHienThi.Text = txtHienThi.Text + "-";
            txtHienThi.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtHienThi.Clear();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            phepTinh = "-";
            data1 = float.Parse(txtHienThi.Text);
            //txtHienThi.Text = txtHienThi.Text + "-";
            txtHienThi.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            phepTinh = "+";
            data1 = float.Parse(txtHienThi.Text);
            //txtHienThi.Text = txtHienThi.Text + "+";
            txtHienThi.Clear();

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }
    }
}