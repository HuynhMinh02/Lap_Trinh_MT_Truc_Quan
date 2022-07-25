namespace ListBox
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMessage.Text = listBox1.Text + " was clicked";
        }

        private void frmListBox_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add("Item " + i);
            }
        }
    }
}