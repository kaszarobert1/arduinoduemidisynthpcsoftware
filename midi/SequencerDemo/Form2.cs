using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SequencerDemo
{
    public partial class Form2 : Form
    {
        string szoveg;
        public Form2()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("help1.txt");
            szoveg = sr.ReadToEnd();
            pictureBox1.Image = new Bitmap("helppicture2.jpg");
            Graphics g = Graphics.FromImage(pictureBox1.Image);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_RegionChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("helppicture2.jpg");
            Graphics g = Graphics.FromImage(pictureBox1.Image);

        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {

        }
          

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int scrollpoint = e.NewValue;
            if (scrollpoint<10)
            {
                pictureBox1.Image = new Bitmap("helppicture1.png");               
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                richTextBox1.Text=  szoveg.Split('#')[0];
            }
            if (scrollpoint >= 10 && scrollpoint < 20)            
            {
                pictureBox1.Image = new Bitmap("helppicture2.jpg");
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                richTextBox1.Text = szoveg.Split('#')[1];
            }
            if (scrollpoint >= 20 && scrollpoint < 30)
            {
                pictureBox1.Image = new Bitmap("helppicture2.jpg");
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                richTextBox1.Text = szoveg.Split('#')[2];
            }
            if (scrollpoint >= 30 && scrollpoint < 40)
            {
                pictureBox1.Image = new Bitmap("helppicture2.jpg");
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                richTextBox1.Text = szoveg.Split('#')[3];
            }
            if (scrollpoint >= 40 && scrollpoint < 50)
            {
                pictureBox1.Image = new Bitmap("helppicture2.jpg");
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                richTextBox1.Text = szoveg.Split('#')[4];
            }
        }
    }
}
