namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtAddress.Text))
            {

                String mess = "";
                if (cbmale.Checked == true)
                {
                    mess = "Male";
                }
                else if (cbFemale.Checked == true)
                {
                    mess = "Female";
                }
                else
                {
                    mess = "Khong Xac Dinh";
                }

                String mess1 = "";
                if (cbc.Checked == true)
                {
                    mess1 = "C#";
                }
                else if (cbASP.Checked == true)
                {
                    mess1 = "ASP";
                }
                else
                {
                    mess1 = "Khong Xac Dinh";

                }
                listInfo.Items.Add((txtName.Text) + "\t" + (txtAddress.Text) + " " + mess + " " + mess1);
                txtName.Clear();
                txtAddress.Clear();
                txtName.Focus();
                txtAddress.Focus();

            }
            else
            {
                MessageBox.Show("Please enter info!!!");
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cbmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bntPic_Click(object sender, EventArgs e)
        {
            String imageLocation = " ";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    image.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void image_Click(object sender, EventArgs e)
        {

        }
    }

}