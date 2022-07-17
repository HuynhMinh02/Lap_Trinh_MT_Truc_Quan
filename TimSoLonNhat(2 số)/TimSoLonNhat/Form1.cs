namespace TimSoLonNhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntGiai_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                a = Convert.ToInt32(txta.Text);
                b = Convert.ToInt32(txtb.Text);

                if (a > b)
                {
                    txtKetQua.Text = "Số lớn nhất là: " + a.ToString() + " " + "Số bé nhất là" + b.ToString();


                }
                else if (a < b)
                {
                    txtKetQua.Text = "Số lớn nhất là: " + b.ToString() + " " + "Số bé nhất là" + a.ToString();

                }
                else
                {
                    txtKetQua.Text = " Hai so bang nhau !";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("NO VALUE!!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}