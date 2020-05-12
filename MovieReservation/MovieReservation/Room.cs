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

        public Room(int amountSeats, string title, string genre, string age, string pictureName, string description)
        {
            InitializeComponent();
            Title = title;
            Genre = genre;
            Age = age;
            PictureName = pictureName;
            Description = description;
            AmountSeats = amountSeats;
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
                }
            }
            else
            {
                foreach (var b in Controls.OfType<Button>())
                {
                    b.Enabled = true;
                }
            }
        }

        public void Cancel()
        {
            foreach (var b in Controls.OfType<Button>())
            {
                b.Enabled = true;
                b.BackColor = DefaultBackColor;
                count = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A1.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            A1.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button2.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button3.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button4.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button6.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button5.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button7.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button8.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button9.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button10.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button11.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button12.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button13.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button14.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button15.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button16.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button17.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button18.BackColor = Red; count += 1;
            seatDisable();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button19.BackColor = Red; count += 1;
            seatDisable();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button20.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button21.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button22.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button23.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button24.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button25.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button26.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button27.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button28.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button29.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button30.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button31.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button32.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button33.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button34.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button34.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button35.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button35.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button36.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button37.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button37.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button38.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button38.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            button39.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button39.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            button40.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button40.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            button41.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button41.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            button42.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button42.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            button43.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button43.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            button44.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button44.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            button45.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button45.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            button46.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button46.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            button47.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button47.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            button48.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button48.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            button49.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button49.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            button50.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button50.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            button51.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button51.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            button52.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button52.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            button53.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button53.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            button54.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button54.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            button55.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button55.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            button56.Enabled = false;
            Color Red = Color.FromArgb(119, 136, 153);
            button56.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (Age == "16")
            {
                Ticket tk = new Ticket(Title, Genre, Age, PictureName, Description);
                this.Hide();
                tk.ShowDialog();
                this.Close();
            }
            else
            {
                TicketIfNot16 tk16 = new TicketIfNot16(Title, Genre, Age, PictureName, Description);
                this.Hide();
                tk16.ShowDialog();
                this.Close();
            }
        }

        private void Annuleren_Click(object sender, EventArgs e)
        {
            Cancel();
        }
    }
}
