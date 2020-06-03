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
        public string Age = dateTime.Age;
        public int AmountSeats;
        public int count = 0;
        public Color Gray = Color.FromArgb(119, 136, 153);
        public Color White = Color.FromArgb(255, 255, 255);
        public string Seats;
        public List<string> reservedSeats = new List<string>();
        public List<string> opgeslagen = new List<string>();
        public List<string> Leeg = new List<string>();

        public Room(int amountSeats)
        {
            InitializeComponent();
            AmountSeats = amountSeats;
            Seats = "";
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

                foreach (var d in reservedSeats)
                {
                    opgeslagen.Add(d);
                }
            }
            else
            {
                foreach (var b in Controls.OfType<Button>())
                {
                    foreach (var t in opgeslagen)
                    {
                        if (b.Text == t)
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

            foreach (var a in reservedSeats)
            {
                opgeslagen.Remove(a);
            }
            foreach (var b in Controls.OfType<Button>())
            {
                foreach (var t in reservedSeats)
                {
                    if (b.Text == t)
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
            reservedSeats = Leeg;

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
                Ticket tk = new Ticket(reservedSeats);
                this.Hide();
                tk.ShowDialog();
                this.Close();
            }
            else
            {
                TicketIfNot16 tk16 = new TicketIfNot16();
                this.Hide();
                tk16.ShowDialog();
                this.Close();
            }
        }

        private void Annuleren_Click(object sender, EventArgs e)
        {
            Cancel();
            NextPage.Enabled = false;
            Seats = "";
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            reservedSeats = Leeg;
            TicketConfrim ticket = new TicketConfrim("2D", AmountSeats, Seats, reservedSeats);
            this.Hide();
            ticket.ShowDialog();
            this.Close();
        }

        public void seatSaved()
        {
            foreach (var b in Controls.OfType<Button>())
            {
                foreach (var t in opgeslagen)
                {
                    if (b.Text == t)
                    {
                        b.Enabled = false;
                        b.BackColor = Gray;
                    }
                }
            }
        }
    }
}
