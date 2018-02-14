using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TWF
{
    public partial class FormListView : Form
    {
        public FormListView()
        {
            InitializeComponent();
        }
        int dispalyStyle;
        private void DisplayChange()
        {
            switch (dispalyStyle)
            {
                case 1:
                    listView1.View = View.LargeIcon;
                    break;
                case 2:
                    listView1.View = View.SmallIcon;
                    break;
                case 3:
                    listView1.View = View.List;
                    break;
                case 4:
                    listView1.View = View.Details;
                    break;
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            radioButtonDetailList.Checked = true;
        }

        private void radioButtonLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            dispalyStyle = 1;
            DisplayChange();
        }

        private void radioButtonSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            dispalyStyle = 2;
            DisplayChange();
        }

        private void radioButtonList_CheckedChanged(object sender, EventArgs e)
        {
            dispalyStyle = 3;
            DisplayChange();
        }

        private void radioButtonDetailList_CheckedChanged(object sender, EventArgs e)
        {
            dispalyStyle = 4;
            DisplayChange();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxNumber.Text == "            ")
            {
                MessageBox.Show("学号不允许为空！");
                maskedTextBoxNumber.Focus();
            }
            else
            {
                int itemNumber = listView1.Items.Count;
                string[] subItem =
                {
                    maskedTextBoxNumber.Text,
                    textBoxName.Text,
                    maskedTextBoxScore.Text
                };
                listView1.Items.Insert(itemNumber,new ListViewItem(subItem));
                listView1.Items[itemNumber].ImageIndex = 0;
                maskedTextBoxNumber.Clear();
                maskedTextBoxScore.Clear();
                textBoxName.Clear();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for(int i = listView1.SelectedItems.Count - 1; i >= 0; --i)
            {
                ListViewItem it = listView1.SelectedItems[i];
                listView1.Items.Remove(it);
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listView1.Sorting == SortOrder.Descending)
            {
                listView1.Sorting = SortOrder.Ascending;
            }
            else
            {
                listView1.Sorting = SortOrder.Descending;
            }
        }
    }
}
