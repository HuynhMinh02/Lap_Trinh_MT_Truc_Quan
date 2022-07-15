namespace TinhSoNguyen
{
    public partial class TinhTongN : Form
    {
        public TinhTongN()
        {
            InitializeComponent();
        }
        double sum = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void txtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int tempN = int.Parse(txtn.Text);
            long ketQua = Tinhn(tempN);
            txtKetQua.Text = Convert.ToString(ketQua);
        }

        long Tinhn(int tempN)
        {
            long sum = 0;
            for (int i = 0; i <= tempN; i++)
                sum += i;
            return sum;
        }
    }
}