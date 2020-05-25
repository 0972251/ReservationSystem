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

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A1 ");
            numberSeats.Add(1);
            seatDisable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A2 ");
            numberSeats.Add(2);
            seatDisable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button3.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A3 ");
            numberSeats.Add(3);
            seatDisable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button4.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A4 ");
            numberSeats.Add(4);
            seatDisable();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button6.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A5 ");
            numberSeats.Add(5);
            seatDisable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button5.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A6 ");
            numberSeats.Add(6);
            seatDisable();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button7.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A7 ");
            numberSeats.Add(7);
            seatDisable();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button8.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A8 ");
            numberSeats.Add(8);
            seatDisable();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            button9.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A9 ");
            numberSeats.Add(9);
            seatDisable();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button10.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A10 ");
            numberSeats.Add(10);
            seatDisable();
        }



        private void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
            button11.BackColor = Gray;
            count += 1;
            reservedSeats.Add("B1 ");
            numberSeats.Add(11);
            seatDisable();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Enabled = false;
            button12.BackColor = Gray;
            count += 1;
            reservedSeats.Add("B2 ");
            numberSeats.Add(12);
            seatDisable();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;
            button13.BackColor = Gray;
            count += 1;
            reservedSeats.Add("B3 ");
            numberSeats.Add(13);
            seatDisable();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;
            button14.BackColor = Gray;
            count += 1;
            reservedSeats.Add("B4 ");
            numberSeats.Add(14);
            seatDisable();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button15.BackColor = Gray;
            count += 1;
            reservedSeats.Add("B5 ");
            numberSeats.Add(15);
            seatDisable();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Enabled = false;
            button16.BackColor = Gray;
            count += 1;
            reservedSeats.Add("B6 ");
            numberSeats.Add(16);
            seatDisable();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Enabled = false;
            button17.BackColor = Gray;
            count += 1;
            reservedSeats.Add("B7 ");
            numberSeats.Add(17);
            seatDisable();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Enabled = false;
            button18.BackColor = Gray; count += 1;
            reservedSeats.Add("B8 ");
            numberSeats.Add(18);
            seatDisable();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Enabled = false;
            button19.BackColor = Gray; count += 1;
            reservedSeats.Add("B9 ");
            numberSeats.Add(19);
            seatDisable();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Enabled = false;
            button20.BackColor = Gray;
            reservedSeats.Add("B10 ");
            count += 1;
            numberSeats.Add(20);
            seatDisable();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Enabled = false;
            button21.BackColor = Gray;
            reservedSeats.Add("C1 ");
            count += 1;
            numberSeats.Add(21);
            seatDisable();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Enabled = false;
            button22.BackColor = Gray;
            reservedSeats.Add("C2 ");
            count += 1;
            numberSeats.Add(22);
            seatDisable();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Enabled = false;
            button23.BackColor = Gray;
            reservedSeats.Add("C3 ");
            count += 1;
            numberSeats.Add(23);
            seatDisable();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.Enabled = false;
            button24.BackColor = Gray;
            reservedSeats.Add("C4 ");
            count += 1;
            numberSeats.Add(24);
            seatDisable();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.Enabled = false;
            button25.BackColor = Gray;
            reservedSeats.Add("C5 ");
            count += 1;
            numberSeats.Add(25);
            seatDisable();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.Enabled = false;
            button26.BackColor = Gray;
            reservedSeats.Add("C6 ");
            count += 1;
            numberSeats.Add(26);
            seatDisable();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.Enabled = false;
            button27.BackColor = Gray;
            count += 1;
            numberSeats.Add(27);
            reservedSeats.Add("C7 ");
            seatDisable();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.Enabled = false;
            button28.BackColor = Gray;
            count += 1;
            numberSeats.Add(28);
            reservedSeats.Add("C8 ");
            seatDisable();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.Enabled = false;
            button29.BackColor = Gray;
            count += 1;
            numberSeats.Add(29);
            reservedSeats.Add("C9 ");
            seatDisable();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.Enabled = false;
            button30.BackColor = Gray;
            count += 1;
            numberSeats.Add(30);
            reservedSeats.Add("C10 ");
            seatDisable();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.Enabled = false;
            button31.BackColor = Gray;
            count += 1;
            numberSeats.Add(31);
            reservedSeats.Add("D2 ");
            seatDisable();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.Enabled = false;
            button32.BackColor = Gray;
            count += 1;
            numberSeats.Add(32);
            reservedSeats.Add("D3 ");
            seatDisable();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.Enabled = false;
            button33.BackColor = Gray;
            count += 1;
            numberSeats.Add(33);
            reservedSeats.Add("D4 ");
            seatDisable();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button34.Enabled = false;
            button34.BackColor = Gray;
            count += 1;
            numberSeats.Add(34);
            reservedSeats.Add("D5 ");
            seatDisable();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button35.Enabled = false;
            button35.BackColor = Gray;
            count += 1;
            numberSeats.Add(35);
            reservedSeats.Add("D6 ");
            seatDisable();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.Enabled = false;
            button36.BackColor = Gray;
            count += 1;
            numberSeats.Add(36);
            reservedSeats.Add("D7 ");
            seatDisable();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button37.Enabled = false;
            button37.BackColor = Gray;
            count += 1;
            numberSeats.Add(37);
            reservedSeats.Add("D8 ");
            seatDisable();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button38.Enabled = false;
            button38.BackColor = Gray;
            count += 1;
            numberSeats.Add(38);
            reservedSeats.Add("D9 ");
            seatDisable();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            button39.Enabled = false;
            button39.BackColor = Gray;
            count += 1;
            numberSeats.Add(39);
            reservedSeats.Add("E2 ");
            seatDisable();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            button40.Enabled = false;
            button40.BackColor = Gray;
            count += 1;
            numberSeats.Add(40);
            reservedSeats.Add("E3 ");
            seatDisable();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            button41.Enabled = false;
            button41.BackColor = Gray;
            count += 1;
            numberSeats.Add(41);
            reservedSeats.Add("E4 ");
            seatDisable();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            button42.Enabled = false;
            button42.BackColor = Gray;
            count += 1;
            numberSeats.Add(42);
            reservedSeats.Add("E5 ");
            seatDisable();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            button43.Enabled = false;
            button43.BackColor = Gray;
            count += 1;
            numberSeats.Add(43);
            reservedSeats.Add("E6 ");
            seatDisable();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            button44.Enabled = false;
            button44.BackColor = Gray;
            count += 1;
            numberSeats.Add(44);
            reservedSeats.Add("E7 ");
            seatDisable();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            button45.Enabled = false;
            button45.BackColor = Gray;
            count += 1;
            numberSeats.Add(45);
            reservedSeats.Add("E8 ");
            seatDisable();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            button46.Enabled = false;
            button46.BackColor = Gray;
            count += 1;
            numberSeats.Add(46);
            reservedSeats.Add("E9 ");
            seatDisable();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            button47.Enabled = false;
            button47.BackColor = Gray;
            count += 1;
            numberSeats.Add(47);
            reservedSeats.Add("F1 ");
            seatDisable();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            button48.Enabled = false;
            button48.BackColor = Gray;
            count += 1;
            numberSeats.Add(48);
            reservedSeats.Add("F2 ");
            seatDisable();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            button49.Enabled = false;
            button49.BackColor = Gray;
            count += 1;
            numberSeats.Add(49);
            reservedSeats.Add("F3 ");
            seatDisable();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            button50.Enabled = false;
            button50.BackColor = Gray;
            count += 1;
            numberSeats.Add(50);
            reservedSeats.Add("F4 ");
            seatDisable();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            button51.Enabled = false;
            button51.BackColor = Gray;
            count += 1;
            numberSeats.Add(51);
            reservedSeats.Add("F5 ");
            seatDisable();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            button52.Enabled = false;
            button52.BackColor = Gray;
            count += 1;
            numberSeats.Add(52);
            reservedSeats.Add("F6 ");
            seatDisable();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            button53.Enabled = false;
            button53.BackColor = Gray;
            count += 1;
            numberSeats.Add(53);
            reservedSeats.Add("F7 ");
            seatDisable();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            button54.Enabled = false;
            button54.BackColor = Gray;
            count += 1;
            numberSeats.Add(54);
            reservedSeats.Add("F8 ");
            seatDisable();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            button55.Enabled = false;
            button55.BackColor = Gray;
            count += 1;
            numberSeats.Add(55);
            reservedSeats.Add("F9 ");
            seatDisable();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            button56.Enabled = false;
            button56.BackColor = Gray;
            count += 1;
            numberSeats.Add(56);
            reservedSeats.Add("F10 ");
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
