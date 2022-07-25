namespace CheckLB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ChonMot_Click(object sender, EventArgs e)
        {
            //checkedListBox2.Items.Clear();

            foreach (string s in checkedListBox1.CheckedItems)
                checkedListBox2.Items.Add(s);
        }

        private void btn_XoaMot_Click(object sender, EventArgs e)
        {
            //foreach (string s in checkedListBox2.CheckedItems)
            //checkedListBox2.Items.Remove(s);
            int n = checkedListBox2.Items.Count;
            while (n == 1)
            {
                checkedListBox2.Items.Remove(checkedListBox2.SelectedItems.ToString());
            }

        }

        private void btn_ChonNhieu_Click(object sender, EventArgs e)
        {

            foreach (string s in checkedListBox1.CheckedItems)
                checkedListBox2.Items.Add(s);
            foreach (string s in checkedListBox1.CheckedItems)
                checkedListBox1.Items.Remove(s);
        }

        private void btn_XoaNhieu_Click(object sender, EventArgs e)
        {
            checkedListBox2.Items.Clear();
        }
    }
}