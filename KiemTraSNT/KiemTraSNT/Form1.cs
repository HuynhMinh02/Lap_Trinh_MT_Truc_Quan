namespace KiemTraSNT
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
        int n;
        public static bool SNT(int n)
        {
            for (int i = 2; i <= n / 2; i++)

                if (n % i == 0) return false;
            return true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(txtn.Text);

            if (SNT(n))

                txtSNT.Text = n.ToString() + " là số nguyên tố";

            else
                txtSNT.Text = n.ToString() + " không là số nguyên tố";

            String temp = " ";

            for (int i = 1; i < n; i++)
            {
                if (SNT(i))
                    temp = temp + i.ToString() + " ";
                txtnt.Text = temp;
            }

        }
    }
}