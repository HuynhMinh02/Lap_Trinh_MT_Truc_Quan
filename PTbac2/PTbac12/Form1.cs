namespace PTbac12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, denta;
            double x1, x2;
            String ketQua;

            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            c = Convert.ToDouble(txtc.Text);

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        ketQua = "Phuong trinh co vo so nghiem";
                    }
                    else
                    {
                        ketQua = "Phuong trinh vo nghiem";
                    }
                }
                else
                {
                    ketQua = String.Format("Phuong trinh co nghiem duy nhat la: ", ((-c) / b));
                }

            }
            else
            {
                denta = b * b - 4 * a * c;

                if (denta < 0)
                {
                    ketQua = "Phuong trinh vo nghiem";
                }
                else if (denta == 0)
                {
                    ketQua = String.Format("Phuong trinh co nghiem kep la: ", ((-b) / (2 * a)));
                }
                else
                {
                    x1 = (-b + Math.Sqrt(denta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(denta)) / (2 * a);

                    Console.WriteLine("Phuong trinh co 2 nghiem");
                    ketQua = String.Format("Phuong trinh co 2 nghiem: \n\t x1 = {0} \n\t x2 = {1}", x1, x2);
                }
            }
            txtKetQua.Text = ketQua;
        }
    }
}