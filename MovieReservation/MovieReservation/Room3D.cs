﻿using System;
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
        public string KindOfMovie;
        public string Seats;
        public Room3D(int amountSeats, string title, string genre, string age, string pictureName, string description, string date, string time, string kindofmovie)
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
            Seats = "";
        }

        public void seatDisable()
        {
            // 2 arrays van seats numbers en button numbers
            // loopen en daarin controleren of de button is geklikt
            // onder die if een button met enabled = false zetten

            if (count == AmountSeats)
            {
                foreach (var b in Controls.OfType<Button>())
                {
                    b.Enabled = false;
                    Annuleren.Enabled = true;
                    NextPage.Enabled = true;
                    button99.Enabled = true;
                }
            }
            else
            {
                foreach (var b in Controls.OfType<Button>())
                {
                    b.Enabled = true;
                    NextPage.Enabled = false;
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            //button1.Enabled = false;
            //button1.BackColor = Gray;
            count += 1;
            seatDisable();
            Button seatButton = (Button)sender;
            seatButton.Enabled = false;
            seatButton.BackColor = Gray;
            Seats += seatButton.Text + ", ";
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            TicketConfrim ticket = new TicketConfrim(Title, Date, Time, "3D", AmountSeats, Seats, PictureName);
            ticket.ShowDialog();
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

        private void button99_Click(object sender, EventArgs e)
        {
            Ticket tk = new Ticket(Title, Genre, Age, PictureName, Description, Date, Time, KindOfMovie);
            tk.ShowDialog();
        }
    }
}
