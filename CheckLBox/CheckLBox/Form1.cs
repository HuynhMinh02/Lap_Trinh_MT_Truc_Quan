namespace CheckLBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ChonMot_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    checkedListBox2.Items.Add(checkedListBox1.Items[i]);
                }
                checkedListBox1.Items.RemoveAt(i);
            }
        }

        private void btn_ChonNhieu_Click(object sender, EventArgs e)
        {
            checkedListBox2.Items.AddRange(checkedListBox1.Items);
            checkedListBox1.Items.Clear();
        }

        private void btn_XoaNhieu_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.AddRange(checkedListBox2.Items);
            checkedListBox2.Items.Clear();
        }

        private void btn_XoaMot_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (checkedListBox2.GetItemChecked(i))
                {
                    checkedListBox1.Items.Add(checkedListBox2.Items[i]);
                }
                checkedListBox2.Items.RemoveAt(i);
            }
        }
    }
}