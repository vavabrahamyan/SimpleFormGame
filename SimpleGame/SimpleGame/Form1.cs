using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SwapPosMethod(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SwapPosMethod(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SwapPosMethod(pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SwapPosMethod(pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SwapPosMethod(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SwapPosMethod(pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SwapPosMethod(pictureBox7);
        }
        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            SwapPosMethod(pictureBox8);
        }
        private void SwapPosMethod(PictureBox pictureBox)
        {
            if (pictureBox.Location.X == emptyPicture.Location.X)
            {
                if (pictureBox.Location.Y - emptyPicture.Location.Y == -161)
                {
                    SwapPosition(pictureBox);
                }
                else if (pictureBox.Location.Y - emptyPicture.Location.Y == 161)
                {
                    SwapPosition(pictureBox);
                }
            }
            if (pictureBox.Location.Y == emptyPicture.Location.Y)
            {
                if (pictureBox.Location.X - emptyPicture.Location.X == -161)
                {
                    SwapPosition(pictureBox);
                }
                else if (pictureBox.Location.X - emptyPicture.Location.X == 161)
                {
                    SwapPosition(pictureBox);
                }
            }
        }
        private void SwapPosition(PictureBox pictureBox)
        {
            int swap_x = emptyPicture.Location.X;
            int swap_y = emptyPicture.Location.Y;

            emptyPicture.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y);

            pictureBox.Location = new Point(swap_x, swap_y);
        }

    }
}
