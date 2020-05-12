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
        public Color White = Color.FromArgb(255,255,255);
        public string Seats;
        public string KindOfMovie;

        public Room(int amountSeats, string title, string genre, string age, string pictureName, string description, string date, string time, string kindofmovie)
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

        }

        public void seatDisable()
        {
            if (count == AmountSeats)
            {
                foreach (var b in Controls.OfType<Button>())
                {
                    b.Enabled = false;
                    button57.Enabled = true;
                    Annuleren.Enabled = true;
                    NextPage.Enabled = true;
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

        public void Cancel()
        {
            foreach (var b in Controls.OfType<Button>())
            {
                b.Enabled = true;
                b.BackColor = White;
                count = 0;
                Seats = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A1.Enabled = false;
            A1.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "A1 ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "A2 ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button3.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "A3 ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button4.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "A4 ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button6.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "A5 ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button5.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "A6 ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button7.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "A7 ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button8.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "A8 ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            button9.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "A9 ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button10.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "A10 ";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
            button11.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "B1 ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Enabled = false;
            button12.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "B2 ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;
            button13.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "B3 ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;
            button14.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "B4 ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button15.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "B5 ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Enabled = false;
            button16.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "B6 ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Enabled = false;
            button17.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "B7 ";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Enabled = false;
            button18.BackColor = Gray; count += 1;
            seatDisable();
            Seats += "B8 ";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Enabled = false;
            button19.BackColor = Gray; count += 1;
            seatDisable();
            Seats += "B9 ";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Enabled = false;
            button20.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "B10 ";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Enabled = false;
            button21.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "C1 ";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Enabled = false;
            button22.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "C2 ";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Enabled = false;
            button23.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "C3 ";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.Enabled = false;
            button24.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "C4 ";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.Enabled = false;
            button25.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "C5 ";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.Enabled = false;
            button26.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "C6 ";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.Enabled = false;
            button27.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "C7 ";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.Enabled = false;
            button28.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "C8 ";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.Enabled = false;
            button29.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "C9 ";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.Enabled = false;
            button30.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "C10 ";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.Enabled = false;
            button31.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "D2 ";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.Enabled = false;
            button32.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "D3 ";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.Enabled = false;
            button33.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "D4 ";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button34.Enabled = false;
            button34.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "D5 ";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button35.Enabled = false;
            button35.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "D6 ";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.Enabled = false;
            button36.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "D7 ";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button37.Enabled = false;
            button37.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "D8 ";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button38.Enabled = false;
            button38.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "D9 ";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            button39.Enabled = false;
            button39.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "E2 ";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            button40.Enabled = false;
            button40.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "E3 ";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            button41.Enabled = false;
            button41.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "E4 ";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            button42.Enabled = false;
            button42.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "E5 ";
        }

        private void button43_Click(object sender, EventArgs e)
        {
            button43.Enabled = false;
            button43.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "E6";
        }

        private void button44_Click(object sender, EventArgs e)
        {
            button44.Enabled = false;
            button44.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "E7 ";
        }

        private void button45_Click(object sender, EventArgs e)
        {
            button45.Enabled = false;
            button45.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "E8 ";
        }

        private void button46_Click(object sender, EventArgs e)
        {
            button46.Enabled = false;
            button46.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "E9 ";
        }

        private void button47_Click(object sender, EventArgs e)
        {
            button47.Enabled = false;
            button47.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "F1 ";
        }

        private void button48_Click(object sender, EventArgs e)
        {
            button48.Enabled = false;
            button48.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "F2 ";
        }

        private void button49_Click(object sender, EventArgs e)
        {
            button49.Enabled = false;
            button49.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "F3 ";
        }

        private void button50_Click(object sender, EventArgs e)
        {
            button50.Enabled = false;
            button50.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "F4 ";
        }

        private void button51_Click(object sender, EventArgs e)
        {
            button51.Enabled = false;
            button51.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "F5 ";
        }

        private void button52_Click(object sender, EventArgs e)
        {
            button52.Enabled = false;
            button52.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "F6 ";
        }

        private void button53_Click(object sender, EventArgs e)
        {
            button53.Enabled = false;
            button53.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "F7 ";
        }

        private void button54_Click(object sender, EventArgs e)
        {
            button54.Enabled = false;
            button54.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "F8 ";
        }

        private void button55_Click(object sender, EventArgs e)
        {
            button55.Enabled = false;
            button55.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "F9 ";
        }

        private void button56_Click(object sender, EventArgs e)
        {
            button56.Enabled = false;
            button56.BackColor = Gray;
            count += 1;
            seatDisable();
            Seats += "F10 ";
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (Age == "16")
            {
                Ticket tk = new Ticket(Title, Genre, Age, PictureName, Description, Date, Time, KindOfMovie);
                this.Hide();
                tk.ShowDialog();
                this.Close();
            }
            else
            {
                TicketIfNot16 tk16 = new TicketIfNot16(Title, Genre, Age, PictureName, Description, Date, Time, KindOfMovie);
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
            TicketConfrim ticket = new TicketConfrim(Title, Date, Time, "2D", AmountSeats, Seats, PictureName);
            ticket.ShowDialog();
            
        }
    }
}
