using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ticket_booking
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        //VARS
        string _path;
        BackgroundWorker worker;
        private delegate void DELEGETE();

        //------------------------------------------------------------------------------
        public Menu()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
        }
        //------------------------------------------------------------------------------
        private void Menu_Load(object sender, EventArgs e)
        {
            //Check for movie settings...
            if (File.Exists("settings"))
            {
                StreamReader sr = new StreamReader("settings");
                _path = sr.ReadLine();
            }
            else
            {
                SelectDirectory();
            }
            worker.DoWork += worker_DoWork;
            worker.RunWorkerAsync();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Delegate del = new DELEGETE(CreateLayout);
            this.Invoke(del);
        }

        //------------------------------------------------------------------------------     
        public void SelectDirectory()
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.Description = "Select your Movie Folder";
            DialogResult result = fb.ShowDialog();
            if(result==DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter("settings");
                sw.WriteLine(fb.SelectedPath);
                sw.Close();
                _path = fb.SelectedPath;
            }
        }
        //------------------------------------------------------------------------------
        public void CreateLayout()
        {
            string[] movies = Directory.GetFiles(_path, "*.mp4").Select(paths => Path.GetFileName(paths)).ToArray();

            foreach(string s in movies)
            {
                moviePanel movie = new moviePanel();

                movie.Title = s.Substring(0,s.Length-4);
                movie.Link = _path + @"\" + s;
                    movie.Image =_path+@"\Covers\"+s.Substring(0,s.Length-4)+".jpg";//C:\Users\User\source\repos\Ticket booking\Ticket booking\Movies\Covers\Image.jpg

                movie.Height =230;
                movie.Width = 150;

                flowLayoutPanel1.Controls.Add(movie);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Close();
        }
    }
}

