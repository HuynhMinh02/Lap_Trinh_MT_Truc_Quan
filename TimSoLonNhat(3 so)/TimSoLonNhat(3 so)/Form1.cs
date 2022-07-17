namespace TimSoLonNhat_3_so_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntGiai_Click(object sender, EventArgs e)
        {
            timMax();

        }
        private void timMax()
        {
            try
            {
                int a, b, c;
                a = Convert.ToInt32(txta.Text);
                b = Convert.ToInt32(txtb.Text);
                c = Convert.ToInt32(txtc.Text);

                int max = a;

                if ((max < b) || (max == b))
                {
                    max = b;
                    txtKetQua.Text = "Số lớn nhất là: " + max.ToString();

                    if ((max < c) || (max == c))
                    {
                        max = c;
                        txtKetQua.Text = "Số lớn nhất là: " + max.ToString();
                    }
                }
                else
                {
                    txtKetQua.Text = "Số lớn nhất là: " + max.ToString();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("NO VALUE!!!");
            }
        }

        private void timMin()
        {
            try
            {
                int a, b, c;
                a = Convert.ToInt32(txta.Text);
                b = Convert.ToInt32(txtb.Text);
                c = Convert.ToInt32(txtc.Text);
                int min = a;
                if ((min > b) || (min == b))
                {
                    min = b;
                    txtKetQua.Text = "Số bé nhất là: " + min.ToString();

                    if ((min > c) || (min == c))
                    {
                        min = c;
                        txtKetQua.Text = "Số bé nhất là: " + min.ToString();
                    }
                }
                else
                {
                    txtKetQua.Text = "Số bé nhất là: " + min.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("NO VALUE!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timMin();
        }
    }
}