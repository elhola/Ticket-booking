using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_booking
{
    public partial class admin : MetroFramework.Forms.MetroForm
    {
        OleDbConnection conBookings = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\User\\source\repos\\Ticket booking\\Ticket booking\bd.mdb");

        public admin()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            conBookings.Open();
            OleDbCommand cmd = conBookings.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Movies values('" + metroTextBox1.Text + "','" + metroTextBox2.Text + "','" + metroTextBox3.Text + "','" + metroTextBox4.Text + "')";
            cmd.ExecuteNonQuery();
            conBookings.Close();
            disp_data();
            MetroFramework.MetroMessageBox.Show(this, "Добавление выполнено", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet.Movies". При необходимости она может быть перемещена или удалена.
              // this.moviesTableAdapter.Fill(this.bdDataSet.Movies);
           disp_data();
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            conBookings.Open();
            OleDbCommand cmd = conBookings.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Movies where Фильм='" + metroTextBox1.Text + "'";
            conBookings.Close();
            MetroFramework.MetroMessageBox.Show(this, "Удаление выполнено", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            conBookings.Open();
            OleDbCommand cmd = conBookings.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update from Movies set name='"+ metroTextBox2.Text+ "' where Фильм='" + metroTextBox1.Text + "'";
            conBookings.Close();
            MetroFramework.MetroMessageBox.Show(this, "Обовление выполнено", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            conBookings.Open();
            OleDbCommand cmd = conBookings.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from Movies where Фильм='" + metroTextBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conBookings.Close();
        }

        public void disp_data()
        {
            conBookings.Open();
            OleDbCommand cmd = conBookings.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Movies ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conBookings.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Close();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new adminpols().Show();
            Close();
        }
    }
}
