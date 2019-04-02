using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_booking
{
    class moviePanel : FlowLayoutPanel
    {
        private string _link;
        private string _image;
        private string _title;

        Label title = new Label();
        PictureBox image = new PictureBox();

        public string Link
        {
            get
            {
                return _link;
            }
            set
            {
                _link = value;
            }
        }
        public string Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
                if(_image!=null)
                {
                    image.Load(_image);
                }
            }
        }
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                if (_title!=null)
                {
                    title.Text = _title;
                }
                title.Text = _title;
            }
        }

        public moviePanel()
        {
            image.Width = 140;
            image.Height = 190;
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.Click += new EventHandler(imClicked);

            title.Width = 140;
            title.Font = new Font("Arial", 8,FontStyle.Bold);

            Create();
        }
        private void imClicked(object sender,EventArgs e)
        {
            System.Diagnostics.Process.Start(_link);
        }
        private void Create()
        {
            this.FlowDirection = FlowDirection.TopDown;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(title);
            this.Controls.Add(image);
        }
    }
}
