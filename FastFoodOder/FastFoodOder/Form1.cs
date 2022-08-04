using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodOder
{
    public partial class Form1 : Form
    {
        int soLuong = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private int search(ListViewItem item)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text == item.Text)
                    return i;
            }
            return -1;
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            soLuong++;
            Button button = (Button)sender;
            ListViewItem item = new ListViewItem();
            item.Text = button.Text;
            if (search(item) != -1)
            {
                listView1.Items.RemoveAt(search(item));
                listView1.Items.Add(item);
                item.SubItems.Add(soLuong.ToString());
            }
            else
            {
                soLuong = 0;
                listView1.Items.Add(item);
                item.SubItems.Add("1");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                    listView1.Items.RemoveAt(i);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            String s = comboBox1.Text + "\n";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                s += listView1.Items[i].Text + " " + listView1.Items[i].SubItems + "\n";
            }
            MessageBox.Show(s, "Xác nhận Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
