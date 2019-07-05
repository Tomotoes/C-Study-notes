using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 播放图片
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap[] Picture = new Bitmap[] {   new Bitmap("Koala.jpg"), 
                                            new Bitmap("Jellyfish.jpg"),
                                            new Bitmap("Lighthouse.jpg"),
                                            new Bitmap("Penguins.jpg"),
                                            new Bitmap("Tulips.jpg"),
                                         };
        static int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        public void Stop()
        {
            timer1.Stop();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Stop();
            for(int i=0;i<5;++i){
                if (Picture[i] == pictureBox1.Image)
                {
                    if (i == 0) { i = 5; }
                    pictureBox1.Image = Picture[i - 1];
                    break;
                }
               
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stop();
            for (int i = 0; i < 5; ++i)
            {
                if (Picture[i] == pictureBox1.Image)
                {
                    pictureBox1.Image = Picture[(i + 1) % 5];
                    break;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 5) { i = 0; }

            pictureBox1.Image = Picture[i++];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stop();
        }
    }
}
