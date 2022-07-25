namespace CheckListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbChonTen.Items.Add("Tèo");
            lbChonTen.Items.Add("Tí");
            lbChonTen.Items.Add("Cu");
            lbChonTen.Items.Add("Đen");
            lbChonTen.Items.Add("Đỏ");
            lbChonTen.Items.Add("Chuột");

        }

        private void btn_ChonMot_Click(object sender, EventArgs e)
        {
            int i = lbChonTen.SelectedIndex;
            string item = lbChonTen.Items[i].ToString();
            lbTenChon.Items.Add(item);
            lbChonTen.Items.Remove(item);
        }

        private void btn_ChonNhieu_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                int n = lbChonTen.Items.Count;
                for (i = 0; i <= n; i++)
                {
                    lbChonTen.SelectedIndex = 0;
                    lbTenChon.Items.Add(lbChonTen.SelectedItem.ToString());
                    lbChonTen.Items.Remove(lbChonTen.SelectedItem.ToString());
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Them Thanh Cong");
            }

        }

        private void btn_BoMot_Click(object sender, EventArgs e)
        {
            int i = lbTenChon.SelectedIndex;
            string item = lbTenChon.Items[i].ToString();
            lbChonTen.Items.Add(item);
            lbTenChon.Items.Remove(item);
        }

        private void btn_BoNhieu_Click(object sender, EventArgs e)
        {
            int i;
            int n = lbTenChon.Items.Count;
            try
            {
                for (i = 0; i <= n; i++)
                {
                    lbTenChon.SelectedIndex = 0;
                    lbChonTen.Items.Add(lbTenChon.SelectedItem.ToString());
                    lbTenChon.Items.Remove(lbTenChon.SelectedItem.ToString());
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Xoa Thanh Cong");
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            lbChonTen.Items.Clear();
            lbTenChon.Items.Clear();

            lbChonTen.Items.Add("Tèo");
            lbChonTen.Items.Add("Tí");
            lbChonTen.Items.Add("Cu");
            lbChonTen.Items.Add("Đen");
            lbChonTen.Items.Add("Đỏ");
            lbChonTen.Items.Add("Chuột");
        }
    }
}