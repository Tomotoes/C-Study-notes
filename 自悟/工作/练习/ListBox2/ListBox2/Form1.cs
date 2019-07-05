using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = listBox2.SelectedIndices.Count - 1; i >= 0; --i)
                {
                    listBox1.Items.Add(listBox2.Items[listBox2.SelectedIndices[i]]);
                    listBox2.Items.Remove(listBox2.Items[listBox2.SelectedIndices[i]]);
                }

            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Add(listBox1.Items[listBox1.SelectedIndex]);
                listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);

            }
            catch { };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; --i)
                {
                    listBox2.Items.Add(listBox1.Items[listBox1.SelectedIndices[i]]);
                    listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndices[i]]);
                }
            }
            catch { };
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add(listBox2.Items[listBox2.SelectedIndex]);
                listBox2.Items.Remove(listBox2.Items[listBox2.SelectedIndex]);
            }
            catch { }
        }
    }
}
