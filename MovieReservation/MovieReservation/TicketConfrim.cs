using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieReservation
{
    public partial class TicketConfrim : Form
    {
        public string Title;
        public string Date;
        public string Time;
        public string Room;
        public int Amount;
        public string Seats;
        public string PictureName;
        public TicketConfrim(string title, string date, string time, string room, int amount, string seats, string pictureName)
        {
            Title = title;
            Date = date;
            Time = time;
            Room = room;
            Amount = amount;
            Seats = seats;
            PictureName = pictureName;

            InitializeComponent();

            labelTitle.Text = Title;
            labelDate.Text = Date;
            labelTime.Text = Time;
            labelRoom.Text = Room;
            labelAmount.Text = Amount.ToString();
            labelSeats.Text = Seats;

            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image image1 = Image.FromFile(path + @"\MoviePictures\" + PictureName + ".png");
            this.pictureBox1.Image = image1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
