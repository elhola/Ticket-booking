using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_booking
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
                Thread t = new Thread(new ThreadStart(Loading));//potok
                t.Start();
                InitializeComponent();
                for (int i = 0; i <= 500; i++)
                    Thread.Sleep(1);//demo 
            t.Abort();//Complete  
        }

        void Loading()//method
        {
            frmSplachScreen frm = new frmSplachScreen();
            Application.Run(frm);
        }
    
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (metroButton1.Visible == true)
            {
                metroButton1.Visible = false;
                metroButton4.Visible = true;
            }
            else if (metroButton4.Visible == true)
            {
                metroButton4.Visible = false;
                metroButton6.Visible = true;
            }
            else if (metroButton6.Visible == true)
            {
                metroButton6.Visible = false;
                metroButton7.Visible = true;
            }
            else if (metroButton7.Visible == true)
            {
                metroButton7.Visible = false;
                metroButton8.Visible = true;
            }
            else if (metroButton8.Visible == true)
            {
                metroButton8.Visible = false;
                metroButton1.Visible = true;
            }
        }
        private void войтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Close();
        }

        private void забронироватьбилетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void фильмыАфишаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}
