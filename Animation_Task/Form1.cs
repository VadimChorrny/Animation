using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStop.Enabled = false; // default stop = false

            // STYLED HEAD PANEL

            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Minimized;
            //this.ControlBox = false;
            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        }

        private void button2_Click(object sender, EventArgs e) // STOP
        {
            timer1.Stop();
            timer1.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e) // START
        {
            timer1.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btnHero.Left >= this.ClientSize.Width - btnHero.Width
                || btnHero.Top >= this.ClientSize.Height - btnHero.Height)
            {
                btnHero.Left = 0;
                btnHero.Top = 0; //  Height - height image
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        } // EXIT button

        private void button1_Click_1(object sender, EventArgs e) // >
        {
            if (timer1.Enabled)
                btnHero.Left -= 10;
        }

        private void button3_Click(object sender, EventArgs e) // down
        {
            if (timer1.Enabled)
                btnHero.Top -= 10;
        }

        private void button2_Click_1(object sender, EventArgs e) // top
        {
            if (timer1.Enabled)
                btnHero.Top += 10;
        }

        private void button4_Click(object sender, EventArgs e) // <
        {
            if (timer1.Enabled)
                btnHero.Left += 10;
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                btnHero.Top -= 30;
            }

        } // SPACE || JUMP button

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        } // setting picture box
    }
}
