using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame_2._0
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Player.Left += -8;

                if (Player.Left <= 0)
                {
                    Player.Left = 0;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                Player.Left += 8;

                if (Player.Left >= 585)
                {
                    Player.Left = 585;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                Player.Top += -8;

                if (Player.Top <= -1)
                {
                    Player.Top = -1;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                Player.Top += 8;

                if (Player.Top >= 350 - 10)
                {
                    Player.Top = 350 - 10;
                }
            }
        }

        void interactions()
        {
            if (Player.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox11.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox17.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox18.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox19.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox20.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox21.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox22.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox23.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox24.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox25.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox26.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox27.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox28.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox29.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox30.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox31.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(pictureBox32.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
            }

            if (Player.Bounds.IntersectsWith(exit.Bounds))
            {
                Player.Left = 2;
                Player.Top = 334;
                MessageBox.Show("You Win!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            interactions();
        }
    }
}
