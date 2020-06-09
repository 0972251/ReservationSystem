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
        public string Title = dateTime.Title;
        public string Date = dateTime.Date;
        public string Time = dateTime.Time;
        public string PictureName = dateTime.PictureName;
        public List<string> reservedSeats;
        public string Room;
        public int Amount;
        public string Seats;
        public string KindOfMovie = "";
        public int RoomNumber;
        public TicketConfrim(string room, int amount, string seats, List<string> reservedSeats, int roomNumber)
        {
            this.reservedSeats = reservedSeats;
            Room = room;
            Amount = amount;
            Seats = seats;
            RoomNumber = roomNumber;

            InitializeComponent();

            labelTitle.Text = Title;
            labelDate.Text = Date;
            labelTime.Text = Time;
            labelRoom.Text = RoomNumber.ToString();
            labelAmount.Text = Amount.ToString();
            labelSeats.Text = Seats;
            RoomTech.Text = Room;



            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image image1 = Image.FromFile(path + @"\MoviePictures\" + PictureName + ".png");
            this.pictureBox1.Image = image1;
        }

        private void Terug_Click(object sender, EventArgs e)
        {
            movieChoice movie = new movieChoice(KindOfMovie, reservedSeats);
            this.Hide();
            movie.ShowDialog();
            this.Close();
        }
    }
}

