namespace DocSoThanhChu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            txtRead.ResetText();
            txtWrite.ResetText();
        }
        private String donVi(int n)
        {
            switch (n)
            {
                case 0: return "";
                case 1: return "Một";
                case 2: return "Hai";
                case 3: return "Ba";
                case 4: return "Bốn";
                case 5: return "Năm";
                case 6: return "Sáu";
                case 7: return "Bảy";
                case 8: return "Tám";
                default: return "Chín";
            }
        }
        private String hangChuc(int n)
        {
            switch (n)
            {
                case 0: return "Linh";
                case 1: return "Mười";
                case 2: return "Hai Mươi";
                case 3: return "Ba Mươi";
                case 4: return "Bốn Mươi";
                case 5: return "Năm Mươi";
                case 6: return "Sáu Mươi";
                case 7: return "Bảy Mươi";
                case 8: return "Tám Mươi";
                default: return "Chín Mươi";
            }
        }
        private String hangTram(int n)
        {
            switch (n)
            {
                case 0: return "Không Trăm";
                case 1: return "Một Trăm";
                case 2: return "Hai Trăm";
                case 3: return "Ba Trăm";
                case 4: return "Bốn Trăm";
                case 5: return "Năm Trăm";
                case 6: return "Sáu Trăm";
                case 7: return "Bảy Trăm";
                case 8: return "Tám Trăm";
                default: return "Chín Trăm";
            }
        }

        private void bntGiai_Click(object sender, EventArgs e)
        {
            string s, s1, s2, s3, k1, k2, k3;
            int d, c, t;
            s = txtWrite.Text;

            if (s.Length == 1)
            {
                k1 = s.Substring(s.Length - 1, 1);
                d = int.Parse(k1);
                s1 = donVi(d);
                txtRead.Text = s1;
            }
            else if (s.Length == 2)
            {
                k1 = s.Substring(s.Length - 1, 1);
                k2 = s.Substring(s.Length - 2, 1);
                d = int.Parse(k1);

                c = int.Parse(k2);
                s1 = donVi(d);
                s2 = hangChuc(c);
                txtRead.Text = s2 + " " + s1 + " ";
            }
            else if (s.Length == 3)
            {
                k1 = s.Substring(s.Length - 1, 1);
                k2 = s.Substring(s.Length - 2, 1);
                k3 = s.Substring(s.Length - 3, 1);
                d = int.Parse(k1);
                c = int.Parse(k2);
                t = int.Parse(k3);
                s1 = donVi(d);
                s2 = hangChuc(c);
                s3 = hangTram(t);
                txtRead.Text = s3 + " " + s2 + " " + s1 + " ";
            }
            else
            {
                txtRead.Text = "Số quá lớn để đọc!!!";
            }
        }
    }
}