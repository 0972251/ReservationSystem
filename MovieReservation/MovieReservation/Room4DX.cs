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
    public partial class Room4DX : Form
    {
        public string Age = dateTime.Age;
        public int indexDay = dateTime.indexDay;
        public int indexTime = dateTime.indexTime;
        public Color Gray = Color.FromArgb(119, 136, 153);
        public Color White = Color.FromArgb(255, 255, 255);
        public int AmountSeats;
        public int count = 0;
        public string Seats = "";
        public List<string> currentSeats = new List<string>();
        public List<string> ReservedSeats;
        public List<string> Leeg = new List<string>();

        public Room4DX(int amountSeats, List<string> reservedSeats)
        {
            InitializeComponent();
            ReservedSeats = reservedSeats;
            AmountSeats = amountSeats;
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

                foreach (var d in currentSeats)
                {
                    ReservedSeats.Add(d);
                }
            }
            else
            {
                foreach (var b in Controls.OfType<Button>())
                {
                    foreach (var t in ReservedSeats)
                    {
                        if (b.Name == t)
                        {
                            b.Enabled = false;
                            b.BackColor = Gray;
                        }
                    }
                }
                NextPage.Enabled = false;
            }

        }

        public void Cancel()
        {
            foreach (var a in currentSeats)
            {
                currentSeats.Remove(a);
            }
            foreach (var b in Controls.OfType<Button>())
            {
                foreach (var t in currentSeats)
                {
                    if (b.Name == t)
                    {
                        b.Enabled = true;
                        b.BackColor = White;
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
            currentSeats = Leeg;

        }

        private void allButtons_Click(object sender, EventArgs e)
        {
            count += 1;
            Button seatButton = (Button)sender;
            seatButton.Enabled = false;
            seatButton.BackColor = Gray;
            Seats += seatButton.Text + " ";
            currentSeats.Add(seatButton.Name);
            seatDisable();
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            TicketConfrim ticket = new TicketConfrim("4DX", AmountSeats, Seats, currentSeats);
            this.Hide();
            ticket.ShowDialog();
            this.Close();
        }

        private void Annuleren_Click(object sender, EventArgs e)
        {
            Cancel();
            NextPage.Enabled = false;
            Seats = "";
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            if (Age == "16")
            {
                Ticket tk = new Ticket(currentSeats, dateTime.RoomIndex);
                this.Hide();
                tk.ShowDialog();
                this.Close();
            }
            else
            {
                TicketIfNot16 tk16 = new TicketIfNot16(currentSeats, dateTime.RoomIndex);
                this.Hide();
                tk16.ShowDialog();
                this.Close();
            }
        }
        public void seatSaved()
        {
            foreach (var b in Controls.OfType<Button>())
            {
                foreach (var t in ReservedSeats)
                {
                    if (b.Name == t)
                    {
                        b.Enabled = false;
                        b.BackColor = Gray;
                    }
                }
            }
        }
    }
}
