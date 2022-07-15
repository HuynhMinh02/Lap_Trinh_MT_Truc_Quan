using System.IO;

namespace SercurityPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "*";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "*";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "*";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "*";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "*";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtHienThi.Text + "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void txtHienThi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHienThi_KeyDown(object sender, KeyEventArgs e)
        {
            String value;
            String mess;
            if (e.KeyCode == Keys.Enter)
            {
                value = txtHienThi.Text;
                switch (value)
                {
                    case "1645":
                    case "1689":
                        mess = "Technicians";
                        break;
                    case "8345":
                        mess = "Custodians";
                        break;
                    case "9998":
                    case "1006":
                    case "1008":
                        mess = "Scientist";
                        break;
                    default:
                        mess = "ERROR";
                        break;
                }
                listLog.Items.Add(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + "\t\t" + mess);

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtHienThi.Clear();
        }

        private void btn1(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtHienThi.Text = bt.Text;
            txtHienThi.Focus();
            txtHienThi.SelectionStart = txtHienThi.Text.Length - 1;
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            string save;
            StreamWriter streamWriter;

            save = @"C:\LapTrinhMTTQ\SercurityPanel\InforSercurity.txt";

            if (!File.Exists(save))
            {
                streamWriter = new StreamWriter(save);
                {
                    foreach (String item in listLog.Items)
                    {
                        streamWriter.WriteLine(item);
                    }
                    streamWriter.Close();
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(save))
                {
                    foreach (String item in listLog.Items)
                    {
                        sw.WriteLine(item);
                    }
                }

            }
            MessageBox.Show("Save Access");
        }
    }
}