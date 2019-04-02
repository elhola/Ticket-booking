using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MetroFramework.Controls;

namespace Ticket_booking
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }
        Bitmap availableIcon = new Bitmap(Properties.Resources.available);
        Bitmap provisionalIcon = new Bitmap(Properties.Resources.provisional);
        Bitmap bookedlIcon = new Bitmap(Properties.Resources.booked);
        private string stSQL;

        public Control c { get; private set; }
        public EventHandler PictureBox12_Click { get; private set; }

        private void Form2_Load(object sender, EventArgs e)
        {

            Control var = c;//серые значки на seats
            foreach (var c in Controls.OfType<PictureBox>())
            {
                if ((c) is PictureBox)
                {
                    c.Image = availableIcon;
                    c.Click += pictureBox12_Click;
                }


            }
            UpdateBookings();



            string stOut = null;
            

        }
        public void UpdateBookings()
        {
            OleDbConnection conBookings = new OleDbConnection();
            conBookings.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\User\\source\repos\\Ticket booking\\Ticket booking\bd.mdb";
            conBookings.Open();

            OleDbCommand cmdSelectBookings = new OleDbCommand();
            cmdSelectBookings.CommandText = "select*from[tblBookings]";
            cmdSelectBookings.Connection = conBookings;

            DataSet dsBookings = new DataSet();
            OleDbDataAdapter daBookings = new OleDbDataAdapter(cmdSelectBookings);

            daBookings.Fill(dsBookings);
            dsBookings.Tables[0].TableName = "Bookings";
            conBookings.Close();

            DataTable t1 = dsBookings.Tables["Bookings"];
            string stOut = null;
            foreach (DataRow row in t1.Rows)
            {
                ((PictureBox)Controls["PictureBox" + row[2]]).Image = bookedlIcon;

            }
            //   MessageBox.Show(stOut);
        }




        private void pictureBox12_Click(object sender, EventArgs e)
        {

            if (((PictureBox)sender).Image == availableIcon)
            {
                ((PictureBox)sender).Image = provisionalIcon;
            }
            else if (((PictureBox)sender).Image == provisionalIcon)
            {
                ((PictureBox)sender).Image = availableIcon;

            }
        }



        private void btnContinue_Click_1(object sender, EventArgs e)
        {
            bool bSelected = false;
            Control var = c;
            foreach (var c in Controls.OfType<PictureBox>())
            {
                if (c.Image == provisionalIcon)
                {
                    bSelected = true;
                    break;
                }
            }
            if (bSelected == true)//===PRICE
            {
                new Price().Show();
                this.Hide();
            }
            if (bSelected == false)
            {
                MetroFramework.MetroMessageBox.Show(this, "Зарегистрируйтесь и выберите место(а) в зале!", "Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            string stConString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\User\\source\repos\\Ticket booking\\Ticket booking\bd.mdb";
            OleDbConnection conBookings = new OleDbConnection();
            conBookings.ConnectionString = stConString;
            conBookings.Open();
            string stSQLInsert = ("INSERT INTO tblBookings(Customer,Seat)VALUES('5',188)");


            OleDbCommand cmdMakeBookings = new OleDbCommand();
            cmdMakeBookings.CommandText = stSQLInsert;
            cmdMakeBookings.Connection = conBookings;

            cmdMakeBookings.ExecuteNonQuery();
            int iSeatNum = 0;
            foreach (Control c in this.Controls)
            {
                if ((c) is PictureBox)
                {
                    if (((PictureBox)c).Image == provisionalIcon)
                    {
                        iSeatNum = Convert.ToInt32(((PictureBox)c).Name.Substring(10));
                        stSQLInsert = "INSERT INTO tblBookings(Customer,Seat)VALUES('" + this.txtContinue.Text + "', " + iSeatNum + ")";
                        cmdMakeBookings.CommandText = stSQLInsert;
                        cmdMakeBookings.ExecuteNonQuery();

                    }
                }
            }
            conBookings.Close();
            UpdateBookings();
        }



        private object CTypeOf(Control c, PictureBox pictureBox)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Отправлено сообщение с ID на Ваш мобильный номер!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}

    
