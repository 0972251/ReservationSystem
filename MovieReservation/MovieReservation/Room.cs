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
        public List<string> opgeslagen = new List<string>();
        public List<string> Leeg = new List<string>();
        public List<string> opgeslagen2 = new List<string>();

        public Room(int amountSeats, string title, string genre, string age, string pictureName, string description, string date, string time, string kindofmovie, List<string> reserve)
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
                    opgeslagen.Add(s);
                    Seats = Seats + s;
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
                foreach (var a in reservedSeats)
                {
                    if (a == "A1 ")
                    {
                        A1.Enabled = true;
                        A1.BackColor = White;
                    }
                    if (a == "A2 ")
                    {
                        button2.Enabled = true;
                        button2.BackColor = White;
                    }
                    if (a == "A3 ")
                    {
                        button3.Enabled = true;
                        button3.BackColor = White;
                    }
                    if (a == "A4 ")
                    {
                        button4.Enabled = true;
                        button4.BackColor = White;
                    }
                    if (a == "A5 ")
                    {
                        button5.Enabled = true;
                        button5.BackColor = Gray;
                    }
                    if (a == "A6 ")
                    {
                        button6.Enabled = false;
                        button6.BackColor = White;
                    }
                    if (a == "A7 ")
                    {
                        button7.Enabled = true;
                        button7.BackColor = White;
                    }
                    if (a == "A8 ")
                    {
                        button8.Enabled = true;
                        button8.BackColor = White;
                    }
                    if (a == "A9 ")
                    {
                        button9.Enabled = true;
                        button9.BackColor = White;
                    }
                    if (a == "A10 ")
                    {
                        button10.Enabled = true;
                        button10.BackColor = White;
                    }
                    if (a == "B1 ")
                    {
                        button11.Enabled = true;
                        button11.BackColor = White;
                    }
                    if (a == "B2 ")
                    {
                        button12.Enabled = true;
                        button12.BackColor = White;
                    }
                    if (a == "B3 ")
                    {
                        button13.Enabled = true;
                        button13.BackColor = White;
                    }
                    if (a == "B4 ")
                    {
                        button14.Enabled = true;
                        button14.BackColor = White;
                    }
                    if (a == "B5 ")
                    {
                        button15.Enabled = true;
                        button15.BackColor = White;
                    }
                    if (a == "B6 ")
                    {
                        button16.Enabled = true;
                        button16.BackColor = White;
                    }
                    if (a == "B7 ")
                    {
                        button17.Enabled = true;
                        button17.BackColor = White;
                    }
                    if (a == "B8 ")
                    {
                        button18.Enabled = true;
                        button18.BackColor = White;
                    }
                    if (a == "B9 ")
                    {
                        button19.Enabled = true;
                        button19.BackColor = White;
                    }
                    if (a == "B10 ")
                    {
                        button20.Enabled = true;
                        button20.BackColor = White;
                    }
                    if (a == "C1 ")
                    {
                        button21.Enabled = true;
                        button21.BackColor = White;
                    }
                    if (a == "C2 ")
                    {
                        button22.Enabled = true;
                        button22.BackColor = White;
                    }
                    if (a == "C3 ")
                    {
                        button23.Enabled = true;
                        button23.BackColor = White;
                    }
                    if (a == "C4 ")
                    {
                        button24.Enabled = true;
                        button24.BackColor = White;
                    }
                    if (a == "C5 ")
                    {
                        button25.Enabled = true;
                        button25.BackColor = White;
                    }
                    if (a == "C6 ")
                    {
                        button26.Enabled = true;
                        button26.BackColor = White;
                    }
                    if (a == "C7 ")
                    {
                        button27.Enabled = true;
                        button27.BackColor = White;
                    }
                    if (a == "C8 ")
                    {
                        button28.Enabled = true;
                        button28.BackColor = White;
                    }
                    if (a == "C9 ")
                    {
                        button29.Enabled = true;
                        button29.BackColor = White;
                    }
                    if (a == "C10 ")
                    {
                        button30.Enabled = true;
                        button30.BackColor = White;
                    }
                    if (a == "D2 ")
                    {
                        button31.Enabled = true;
                        button31.BackColor = White;
                    }
                    if (a == "D3 ")
                    {
                        button32.Enabled = true;
                        button32.BackColor = White;
                    }
                    if (a == "D4 ")
                    {
                        button33.Enabled = true;
                        button33.BackColor = White;
                    }
                    if (a == "D5 ")
                    {
                        button34.Enabled = true;
                        button34.BackColor = White;
                    }
                    if (a == "D6 ")
                    {
                        button35.Enabled = true;
                        button35.BackColor = White;
                    }
                    if (a == "D7 ")
                    {
                        button36.Enabled = true;
                        button36.BackColor = White;
                    }
                    if (a == "D8 ")
                    {
                        button37.Enabled = true;
                        button37.BackColor = White;
                    }
                    if (a == "D9 ")
                    {
                        button38.Enabled = true;
                        button38.BackColor = White;
                    }
                    if (a == "E2 ")
                    {
                        button39.Enabled = true;
                        button39.BackColor = White;
                    }
                    if (a == "E3 ")
                    {
                        button40.Enabled = true;
                        button40.BackColor = White;
                    }
                    if (a == "E4 ")
                    {
                        button41.Enabled = true;
                        button41.BackColor = White;
                    }
                    if (a == "E5 ")
                    {
                        button42.Enabled = true;
                        button42.BackColor = White;
                    }
                    if (a == "E6 ")
                    {
                        button43.Enabled = true;
                        button43.BackColor = White;
                    }
                    if (a == "E7 ")
                    {
                        button44.Enabled = true;
                        button44.BackColor = White;
                    }
                    if (a == "E8 ")
                    {
                        button45.Enabled = true;
                        button45.BackColor = White;
                    }
                    if (a == "E9 ")
                    {
                        button46.Enabled = true;
                        button46.BackColor = White;
                    }
                    if (a == "F1 ")
                    {
                        button47.Enabled = true;
                        button47.BackColor = White;
                    }
                    if (a == "F2 ")
                    {
                        button48.Enabled = true;
                        button48.BackColor = White;
                    }
                    if (a == "F3 ")
                    {
                        button49.Enabled = true;
                        button49.BackColor = White;
                    }
                    if (a == "F4 ")
                    {
                        button50.Enabled = true;
                        button50.BackColor = White;
                    }
                    if (a == "F5 ")
                    {
                        button51.Enabled = true;
                        button51.BackColor = White;
                    }
                    if (a == "F6 ")
                    {
                        button52.Enabled = true;
                        button52.BackColor = White;
                    }
                    if (a == "F7 ")
                    {
                        button53.Enabled = true;
                        button53.BackColor = White;
                    }
                    if (a == "F8 ")
                    {
                        button54.Enabled = true;
                        button54.BackColor = White;
                    }
                    if (a == "F9 ")
                    {
                        button55.Enabled = true;
                        button55.BackColor = White;
                    }
                    if (a == "F10 ")
                    {
                        button56.Enabled = true;
                        button56.BackColor = White;
                    }


                }
                foreach (var a in reservedSeats)
                {
                    if (a == "A1 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "A2 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "A3 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "A4 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "A5 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "A6 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "A7 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "A8 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "A9 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "A10 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "B1 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "B2 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "B3 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "B4 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "B5 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "B6 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "B7 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "B8 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "B9 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "B10 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "C1 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "C2 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "C3 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "C4 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "C5 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "C6 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "C7 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "C8 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "C9 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "C10 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "D2 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "D3 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "D4 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "D5 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "D6 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "D7 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "D8 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "D9 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "E1 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "E2 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "E3 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "E4 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "E5 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "E6 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "E7 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "E8 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "E9 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "F1 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "F2 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "F3 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "F4 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "F5 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "F6 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "F7 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "F8 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "F9 ")
                    {
                        opgeslagen.Remove(a);
                    }
                    if (a == "F10 ")
                    {
                        opgeslagen.Remove(a);
                    }
                }
                b.Enabled = true;
                count = 0;
                Seats = "";
                reservedSeats = Leeg;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            A1.Enabled = false;
            A1.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A1 ");
            seatDisable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A2 ");
            seatDisable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button3.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A3 ");
            seatDisable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button4.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A4 ");
            seatDisable();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button6.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A5 ");
            seatDisable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button5.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A6 ");
            seatDisable();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button7.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A7 ");
            seatDisable();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button8.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A8 ");
            seatDisable();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            button9.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A9 ");
            seatDisable();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button10.BackColor = Gray;
            count += 1;
            reservedSeats.Add("A10 ");
            seatDisable();
        }



        private void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
            button11.BackColor = Gray;
            count += 1;
            reservedSeats.Add("B1 ");
            seatDisable();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Enabled = false;
            button12.BackColor = Gray;
            count += 1;
            reservedSeats.Add("B2 ");
            seatDisable();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;
            button13.BackColor = Gray;
            count += 1;
            reservedSeats.Add("B3 ");
            seatDisable();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;
            button14.BackColor = Gray;
            count += 1;
            reservedSeats.Add("B4 ");
            seatDisable();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button15.BackColor = Gray;
            count += 1;
            reservedSeats.Add("B5 ");
            seatDisable();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Enabled = false;
            button16.BackColor = Gray;
            count += 1;
            reservedSeats.Add("B6 ");
            seatDisable();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Enabled = false;
            button17.BackColor = Gray;
            count += 1;
            reservedSeats.Add("B7 ");
            seatDisable();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Enabled = false;
            button18.BackColor = Gray; count += 1;
            reservedSeats.Add("B8 ");
            seatDisable();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Enabled = false;
            button19.BackColor = Gray; count += 1;
            reservedSeats.Add("B9 ");
            seatDisable();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Enabled = false;
            button20.BackColor = Gray;
            reservedSeats.Add("B10 ");
            count += 1;
            seatDisable();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Enabled = false;
            button21.BackColor = Gray;
            reservedSeats.Add("C1 ");
            count += 1;
            seatDisable();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Enabled = false;
            button22.BackColor = Gray;
            reservedSeats.Add("C2 ");
            count += 1;
            seatDisable();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Enabled = false;
            button23.BackColor = Gray;
            reservedSeats.Add("C3 ");
            count += 1;
            seatDisable();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.Enabled = false;
            button24.BackColor = Gray;
            reservedSeats.Add("C4 ");
            count += 1;
            seatDisable();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.Enabled = false;
            button25.BackColor = Gray;
            reservedSeats.Add("C5 ");
            count += 1;
            seatDisable();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.Enabled = false;
            button26.BackColor = Gray;
            reservedSeats.Add("C6 ");
            count += 1;
            seatDisable();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.Enabled = false;
            button27.BackColor = Gray;
            count += 1;
            reservedSeats.Add("C7 ");
            seatDisable();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.Enabled = false;
            button28.BackColor = Gray;
            count += 1;
            reservedSeats.Add("C8 ");
            seatDisable();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.Enabled = false;
            button29.BackColor = Gray;
            count += 1;
            reservedSeats.Add("C9 ");
            seatDisable();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.Enabled = false;
            button30.BackColor = Gray;
            count += 1;
            reservedSeats.Add("C10 ");
            seatDisable();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.Enabled = false;
            button31.BackColor = Gray;
            count += 1;
            reservedSeats.Add("D2 ");
            seatDisable();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.Enabled = false;
            button32.BackColor = Gray;
            count += 1;
            reservedSeats.Add("D3 ");
            seatDisable();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.Enabled = false;
            button33.BackColor = Gray;
            count += 1;
            reservedSeats.Add("D4 ");
            seatDisable();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button34.Enabled = false;
            button34.BackColor = Gray;
            count += 1;
            reservedSeats.Add("D5 ");
            seatDisable();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button35.Enabled = false;
            button35.BackColor = Gray;
            count += 1;
            reservedSeats.Add("D6 ");
            seatDisable();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.Enabled = false;
            button36.BackColor = Gray;
            count += 1;
            reservedSeats.Add("D7 ");
            seatDisable();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button37.Enabled = false;
            button37.BackColor = Gray;
            count += 1;
            reservedSeats.Add("D8 ");
            seatDisable();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button38.Enabled = false;
            button38.BackColor = Gray;
            count += 1;
            reservedSeats.Add("D9 ");
            seatDisable();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            button39.Enabled = false;
            button39.BackColor = Gray;
            count += 1;
            reservedSeats.Add("E2 ");
            seatDisable();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            button40.Enabled = false;
            button40.BackColor = Gray;
            count += 1;
            reservedSeats.Add("E3 ");
            seatDisable();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            button41.Enabled = false;
            button41.BackColor = Gray;
            count += 1;
            reservedSeats.Add("E4 ");
            seatDisable();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            button42.Enabled = false;
            button42.BackColor = Gray;
            count += 1;
            reservedSeats.Add("E5 ");
            seatDisable();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            button43.Enabled = false;
            button43.BackColor = Gray;
            count += 1;
            reservedSeats.Add("E6 ");
            seatDisable();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            button44.Enabled = false;
            button44.BackColor = Gray;
            count += 1;
            reservedSeats.Add("E7 ");
            seatDisable();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            button45.Enabled = false;
            button45.BackColor = Gray;
            count += 1;
            reservedSeats.Add("E8 ");
            seatDisable();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            button46.Enabled = false;
            button46.BackColor = Gray;
            count += 1;
            reservedSeats.Add("E9 ");
            seatDisable();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            button47.Enabled = false;
            button47.BackColor = Gray;
            count += 1;
            reservedSeats.Add("F1 ");
            seatDisable();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            button48.Enabled = false;
            button48.BackColor = Gray;
            count += 1;
            reservedSeats.Add("F2 ");
            seatDisable();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            button49.Enabled = false;
            button49.BackColor = Gray;
            count += 1;
            reservedSeats.Add("F3 ");
            seatDisable();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            button50.Enabled = false;
            button50.BackColor = Gray;
            count += 1;
            reservedSeats.Add("F4 ");
            seatDisable();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            button51.Enabled = false;
            button51.BackColor = Gray;
            count += 1;
            reservedSeats.Add("F5 ");
            seatDisable();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            button52.Enabled = false;
            button52.BackColor = Gray;
            count += 1;
            reservedSeats.Add("F6 ");
            seatDisable();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            button53.Enabled = false;
            button53.BackColor = Gray;
            count += 1;
            reservedSeats.Add("F7 ");
            seatDisable();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            button54.Enabled = false;
            button54.BackColor = Gray;
            count += 1;
            reservedSeats.Add("F8 ");
            seatDisable();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            button55.Enabled = false;
            button55.BackColor = Gray;
            count += 1;
            reservedSeats.Add("F9 ");
            seatDisable();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            button56.Enabled = false;
            button56.BackColor = Gray;
            count += 1;
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
            foreach (var a in opgeslagen)
            {
                if (a == "A1 ")
                {
                    A1.Enabled = false;
                    A1.BackColor = Gray;
                }
                if (a == "A2 ")
                {
                    button2.Enabled = false;
                    button2.BackColor = Gray;
                }
                if (a == "A3 ")
                {
                    button3.Enabled = false;
                    button3.BackColor = Gray;
                }
                if (a == "A4 ")
                {
                    button4.Enabled = false;
                    button4.BackColor = Gray;
                }
                if (a == "A5 ")
                {
                    button5.Enabled = false;
                    button5.BackColor = Gray;
                }
                if (a == "A6 ")
                {
                    button6.Enabled = false;
                    button6.BackColor = Gray;
                }
                if (a == "A7 ")
                {
                    button7.Enabled = false;
                    button7.BackColor = Gray;
                }
                if (a == "A8 ")
                {
                    button8.Enabled = false;
                    button8.BackColor = Gray;
                }
                if (a == "A9 ")
                {
                    button9.Enabled = false;
                    button9.BackColor = Gray;
                }
                if (a == "A10 ")
                {
                    button10.Enabled = false;
                    button10.BackColor = Gray;
                }
                if (a == "B1 ")
                {
                    button11.Enabled = false;
                    button11.BackColor = Gray;
                }
                if (a == "B2 ")
                {
                    button12.Enabled = false;
                    button12.BackColor = Gray;
                }
                if (a == "B3 ")
                {
                    button13.Enabled = false;
                    button13.BackColor = Gray;
                }
                if (a == "B4 ")
                {
                    button14.Enabled = false;
                    button14.BackColor = Gray;
                }
                if (a == "B5 ")
                {
                    button15.Enabled = false;
                    button15.BackColor = Gray;
                }
                if (a == "B6 ")
                {
                    button16.Enabled = false;
                    button16.BackColor = Gray;
                }
                if (a == "B7 ")
                {
                    button17.Enabled = false;
                    button17.BackColor = Gray;
                }
                if (a == "B8 ")
                {
                    button18.Enabled = false;
                    button18.BackColor = Gray;
                }
                if (a == "B9 ")
                {
                    button19.Enabled = false;
                    button19.BackColor = Gray;
                }
                if (a == "B10 ")
                {
                    button20.Enabled = false;
                    button20.BackColor = Gray;
                }
                if (a == "C1 ")
                {
                    button21.Enabled = false;
                    button21.BackColor = Gray;
                }
                if (a == "C2 ")
                {
                    button22.Enabled = false;
                    button22.BackColor = Gray;
                }
                if (a == "C3 ")
                {
                    button23.Enabled = false;
                    button23.BackColor = Gray;
                }
                if (a == "C4 ")
                {
                    button24.Enabled = false;
                    button24.BackColor = Gray;
                }
                if (a == "C5 ")
                {
                    button25.Enabled = false;
                    button25.BackColor = Gray;
                }
                if (a == "C6 ")
                {
                    button26.Enabled = false;
                    button26.BackColor = Gray;
                }
                if (a == "C7 ")
                {
                    button27.Enabled = false;
                    button27.BackColor = Gray;
                }
                if (a == "C8 ")
                {
                    button28.Enabled = false;
                    button28.BackColor = Gray;
                }
                if (a == "C9 ")
                {
                    button29.Enabled = false;
                    button29.BackColor = Gray;
                }
                if (a == "C10 ")
                {
                    button30.Enabled = false;
                    button30.BackColor = Gray;
                }
                if (a == "D2 ")
                {
                    button31.Enabled = false;
                    button31.BackColor = Gray;
                }
                if (a == "D3 ")
                {
                    button32.Enabled = false;
                    button32.BackColor = Gray;
                }
                if (a == "D4 ")
                {
                    button33.Enabled = false;
                    button33.BackColor = Gray;
                }
                if (a == "D5 ")
                {
                    button34.Enabled = false;
                    button34.BackColor = Gray;
                }
                if (a == "D6 ")
                {
                    button35.Enabled = false;
                    button35.BackColor = Gray;
                }
                if (a == "D7 ")
                {
                    button36.Enabled = false;
                    button36.BackColor = Gray;
                }
                if (a == "D8 ")
                {
                    button37.Enabled = false;
                    button37.BackColor = Gray;
                }
                if (a == "D9 ")
                {
                    button38.Enabled = false;
                    button38.BackColor = Gray;
                }
                if (a == "E2 ")
                {
                    button39.Enabled = false;
                    button39.BackColor = Gray;
                }
                if (a == "E3 ")
                {
                    button40.Enabled = false;
                    button40.BackColor = Gray;
                }
                if (a == "E4 ")
                {
                    button41.Enabled = false;
                    button41.BackColor = Gray;
                }
                if (a == "E5 ")
                {
                    button42.Enabled = false;
                    button42.BackColor = Gray;
                }
                if (a == "E6 ")
                {
                    button43.Enabled = false;
                    button43.BackColor = Gray;
                }
                if (a == "E7 ")
                {
                    button44.Enabled = false;
                    button44.BackColor = Gray;
                }
                if (a == "E8 ")
                {
                    button45.Enabled = false;
                    button45.BackColor = Gray;
                }
                if (a == "E9 ")
                {
                    button46.Enabled = false;
                    button46.BackColor = Gray;
                }
                if (a == "F1 ")
                {
                    button47.Enabled = false;
                    button47.BackColor = Gray;
                }
                if (a == "F2 ")
                {
                    button48.Enabled = false;
                    button48.BackColor = Gray;
                }
                if (a == "F3 ")
                {
                    button49.Enabled = false;
                    button49.BackColor = Gray;
                }
                if (a == "F4 ")
                {
                    button50.Enabled = false;
                    button50.BackColor = Gray;
                }
                if (a == "F5 ")
                {
                    button51.Enabled = false;
                    button51.BackColor = Gray;
                }
                if (a == "F6 ")
                {
                    button52.Enabled = false;
                    button52.BackColor = Gray;
                }
                if (a == "F7 ")
                {
                    button53.Enabled = false;
                    button53.BackColor = Gray;
                }
                if (a == "F8 ")
                {
                    button54.Enabled = false;
                    button54.BackColor = Gray;
                }
                if (a == "F9 ")
                {
                    button55.Enabled = false;
                    button55.BackColor = Gray;
                }
                if (a == "F10 ")
                {
                    button56.Enabled = false;
                    button56.BackColor = Gray;
                }
            }

        }
    }
}
