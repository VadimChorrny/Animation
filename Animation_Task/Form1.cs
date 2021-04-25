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
        // variable
        Random random = new Random();
        //PictureBox newPic = new PictureBox();
        int counter;
        int counterMoney;
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

        //STOP
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }
        //START
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e) // TIMER need development
        {
            counter++; // counter for long time
            lblScore.Text = "Score : " + counterMoney; // output money on form1
            lblInfo.Text = btnHero.Location.ToString();

            // check borders | need development - worked only left and top 
            if (btnHero.Left >= this.ClientSize.Width - btnHero.Width
                || btnHero.Top >= this.ClientSize.Height - btnHero.Height)
            {
                btnHero.Left = 0;
                btnHero.Top = 0; //  Height - height image
            }
            // that money appear periodically
            if (counter == 3100)
            {
                // here i create new picturebox (money)
                newPic.Location = new Point(254,254); // if state 254,254,and hero 254,254 - worked
                this.Controls.Add(newPic);
                newPic.BringToFront();
                lblInfoMoney.Text = newPic.Location.ToString();

                //btnHero.Location = new Point(254, 254);

                // here i check if the hero and the money are in the same position,
                // it becomes invisible
                if (btnHero.Location.X > newPic.Location.X && btnHero.Location.X < newPic.Location.X + newPic.Width )
                {
                    newPic.Dispose();
                    counterMoney++; // add counter
                    //newPic.Visible = false;
                }
                counter = 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        } // EXIT button

        private void button1_Click_1(object sender, EventArgs e) // >
        {
            if (timer1.Enabled)
                btnHero.Left -= 1;
        }

        private void button3_Click(object sender, EventArgs e) // down
        {
            if (timer1.Enabled)
                btnHero.Top -= 1;
        }

        private void button2_Click_1(object sender, EventArgs e) // top
        {
            if (timer1.Enabled)
                btnHero.Top += 1;
        }

        private void button4_Click(object sender, EventArgs e) // <
        {
            if (timer1.Enabled)
                btnHero.Left += 1;
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
