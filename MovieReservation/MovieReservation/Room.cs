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

    public partial class Room : Form
    {
        public int AmountSeats;
        public int count = 0;
        public string Title;
        public string Genre;
        public string Age;
        public string PictureName;
        public string Description;
        public string Date;
        public string Time;
        public Color Gray = Color.FromArgb(119, 136, 153);
        public Color White = Color.FromArgb(255, 255, 255);
        public string Seats;
        public string KindOfMovie;
        public List<string> reservedSeats = new List<string>();
        public List<int> opgeslagen = new List<int>();
        public List<string> Leeg = new List<string>();
        public List<int> Leeg2 = new List<int>();
        public List<int> opgeslagen2 = new List<int>();
        public List<int> numberSeats = new List<int>();

        public Room(int amountSeats, string title, string genre, string age, string pictureName, string description, string date, string time, string kindofmovie, List<int> reserve)
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
            Seats = "";
            KindOfMovie = kindofmovie;
            opgeslagen = reserve;
            seatSaved();

        }

        public void seatDisable()
        {
            seatSaved();
            if (count == AmountSeats)
            {
                foreach (var b in Controls.OfType<Button>())
                {
                    b.Enabled = false;
                    button57.Enabled = true;
                    Annuleren.Enabled = true;
                    NextPage.Enabled = true;
                }
                foreach (var s in reservedSeats)
                {
                    Seats = Seats + s;
                }
                foreach (var d in numberSeats)
                {
                    opgeslagen.Add(d);
                }
            }
            else
            {
                for (int i = 1; i <= 56; i++)
                {
                    foreach (var t in opgeslagen)
                    {
                        if (i == t)
                        {
                            string buttonName = "button" + i;
                            this.Controls[buttonName].Enabled = false;
                            this.Controls[buttonName].BackColor = Gray;
                            NextPage.Enabled = false;
                        }
                    }
                }

            }
        }

        public void Cancel()
        {

            foreach (var a in numberSeats)
            {
                opgeslagen.Remove(a);
            }
            for (int i = 1; i <= 56; i++)
            {
                foreach (var t in numberSeats)
                {
                    if (i == t)
                    {
                        string buttonName = "button" + i;
                        this.Controls[buttonName].Enabled = true;
                        this.Controls[buttonName].BackColor = White;
                    }
                }
            }
            foreach (var b in Controls.OfType<Button>())
            {
                b.Enabled = true;
            }
            seatSaved();
            count = 0;
            Seats = "";
            reservedSeats = Leeg;
            numberSeats = Leeg2;



        }

        private void allButtons_Click(object sender, EventArgs e)
        {
            count += 1;
            Button seatButton = (Button)sender;
            seatButton.Enabled = false;
            seatButton.BackColor = Gray;
            Seats += seatButton.Text + " ";
            reservedSeats.Add(seatButton.Text);
            seatDisable();
        }



        private void button57_Click(object sender, EventArgs e)
        {
            if (Age == "16")
            {
                Ticket tk = new Ticket(Title, Genre, Age, PictureName, Description, Date, Time, KindOfMovie, opgeslagen);
                this.Hide();
                tk.ShowDialog();
                this.Close();
            }
            else
            {
                TicketIfNot16 tk16 = new TicketIfNot16(Title, Genre, Age, PictureName, Description, Date, Time, KindOfMovie, opgeslagen);
                this.Hide();
                tk16.ShowDialog();
                this.Close();
            }
        }

        private void Annuleren_Click(object sender, EventArgs e)
        {
            Cancel();
            NextPage.Enabled = false;
        }

        private void Room_Load(object sender, EventArgs e)
        {

        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            opgeslagen2 = opgeslagen;
            reservedSeats = Leeg;
            TicketConfrim ticket = new TicketConfrim(Title, Date, Time, "2D", AmountSeats, Seats, PictureName, opgeslagen2, KindOfMovie);
            this.Hide();
            ticket.ShowDialog();
            this.Close();
        }

        public void seatSaved()
        {
            for (int i = 1; i <= 56; i++)
            {
                foreach (var t in opgeslagen)
                {
                    if (i == t)
                    {
                        string buttonName = "button" + i;
                        this.Controls[buttonName].Enabled = false;
                        this.Controls[buttonName].BackColor = Gray;
                    }
                }
            }
        }
    }
}
