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
        public int AmountSeats;
        public int count = 0;
        public string Title;
        public string Genre;
        public string Age;
        public string PictureName;
        public string Description;
        public Color Red = Color.FromArgb(119, 136, 153);
        public Room3D(int amountSeats, string title, string genre, string age, string pictureName, string description)
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

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button95.Enabled = false;
            button95.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button86_Click(object sender, EventArgs e)
        {

        }

        private void Room3D_Load(object sender, EventArgs e)
        {

        }

        private void Annuleren_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void button99_Click(object sender, EventArgs e)
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

        private void button95_Click(object sender, EventArgs e)
        {
            button95.Enabled = false;
            button95.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            button42.Enabled = false;
            button42.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            button41.Enabled = false;
            button41.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            button40.Enabled = false;
            button40.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            button39.Enabled = false;
            button39.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button38.Enabled = false;
            button38.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button37.Enabled = false;
            button37.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            button48.Enabled = false;
            button48.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            button47.Enabled = false;
            button47.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            button46.Enabled = false;
            button46.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            button45.Enabled = false;
            button45.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            button44.Enabled = false;
            button44.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            button43.Enabled = false;
            button43.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button88_Click(object sender, EventArgs e)
        {
            button88.Enabled = false;
            button88.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button98_Click(object sender, EventArgs e)
        {
            button98.Enabled = false;
            button98.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button3.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button4.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button5.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button6.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Enabled = false;
            button12.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
            button11.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button10.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            button9.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button8.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button7.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button91_Click(object sender, EventArgs e)
        {
            button91.Enabled = false;
            button91.BackColor = Red;
            count += 1;
            seatDisable();
        }
    }
}
