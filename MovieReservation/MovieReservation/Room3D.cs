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
    public partial class Room3D : Form
    {
        public Color Gray = Color.FromArgb(119, 136, 153);
        public Color White = Color.FromArgb(255, 255, 255);

        public int AmountSeats;
        public int count = 0;
        public string Title;
        public string Genre;
        public string Age;
        public string PictureName;
        public string Description;
        public string Date;
        public string Time;
        public string KindOfMovie;
        public string Seats = "";
        public List<int> reservedSeats = new List<int>();

        public Room3D(int amountSeats, string title, string genre, string age, string pictureName, string description, string date, string time, string kindofmovie, List<int> reserve)
        {
            InitializeComponent();
            Title = title;
            Genre = genre;
            Age = age;
            PictureName = pictureName;
            Description = description;
            AmountSeats = amountSeats;
            Date = date;
            Time = time;
            KindOfMovie = kindofmovie;
            reservedSeats = reserve;
        }

        public void seatDisable()
        {
            if (count == AmountSeats)
            {
                foreach (var b in Controls.OfType<Button>())
                {
                    b.Enabled = false;
                    NextPage.Enabled = true;
                    Annuleren.Enabled = true;
                }
            }
/*            else
            {
                foreach (var b in Controls.OfType<Button>())
                {
                    foreach (var t in reservedSeats)
                    {
                        if (b.Name == t)
                        {
                            Controls[t].Enabled = false;
                            Controls[t].BackColor = Gray;
                        }
                    }
                }
            }*/

        }

        private void allButtons_Click(object sender, EventArgs e)
        {
            count += 1;
            seatDisable();
            Button seatButton = (Button)sender;
            seatButton.Enabled = false;
            seatButton.BackColor = Gray;
            Seats += seatButton.Text + " ";
/*            reservedSeats.Add(seatButton.Name);*/
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            TicketConfrim ticket = new TicketConfrim(Title, Date, Time, "3D", AmountSeats, Seats, PictureName, reservedSeats, KindOfMovie);
            this.Hide();
            ticket.ShowDialog();
            this.Close();
        }

        private void Annuleren_Click(object sender, EventArgs e)
        {
            foreach (var b in Controls.OfType<Button>())
            {
                b.Enabled = true;
                b.BackColor = White;
                count = 0;
                Seats = "";
            }
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            Ticket tk = new Ticket(Title, Genre, Age, PictureName, Description, Date, Time, KindOfMovie, reservedSeats);
            this.Hide();
            tk.ShowDialog();
            this.Close();
        }
    }
}
