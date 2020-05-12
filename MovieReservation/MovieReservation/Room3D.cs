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
<<<<<<< HEAD
        public Room3D(int amountSeats, string title, string genre, string age, string pictureName, string description)
=======
        public string Date;
        public string Time;
        public Color Red = Color.FromArgb(119, 136, 153);
        public Room3D(int amountSeats, string title, string genre, string age, string pictureName, string description, string date, string time)
>>>>>>> parent of 67cd503... Bij movieChoice blijft genre staan als je film annuleert en teruggaat naar dit scherm, interface iets veranderd
        {
            InitializeComponent();
            Title = title;
            Genre = genre;
            Age = age;
            PictureName = pictureName;
            Description = description;
            AmountSeats = amountSeats;
<<<<<<< HEAD
=======
            Date = date;
            Time = time;
        }

        public void seatDisable()
        {
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
>>>>>>> parent of 67cd503... Bij movieChoice blijft genre staan als je film annuleert en teruggaat naar dit scherm, interface iets veranderd
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
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
<<<<<<< HEAD
=======

        private void Annuleren_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void button99_Click(object sender, EventArgs e)
        {
            if (Age == "16")
            {
                Ticket tk = new Ticket(Title, Genre, Age, PictureName, Description, Date, Time);
                this.Hide();
                tk.ShowDialog();
                this.Close();
            }
            else
            {
                TicketIfNot16 tk16 = new TicketIfNot16(Title, Genre, Age, PictureName, Description, Date, Time);
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

        private void button97_Click(object sender, EventArgs e)
        {
            button97.Enabled = false;
            button97.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button96_Click(object sender, EventArgs e)
        {
            button96.Enabled = false;
            button96.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button94_Click(object sender, EventArgs e)
        {
            button94.Enabled = false;
            button94.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button93_Click(object sender, EventArgs e)
        {
            button93.Enabled = false;
            button93.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button92_Click(object sender, EventArgs e)
        {
            button92.Enabled = false;
            button92.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Enabled = false;
            button18.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.Enabled = false;
            button30.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            button54.Enabled = false;
            button54.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            button60.Enabled = false;
            button60.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button78_Click(object sender, EventArgs e)
        {
            button78.Enabled = false;
            button78.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Enabled = false;
            button17.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.Enabled = false;
            button29.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            button53.Enabled = false;
            button53.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            button59.Enabled = false;
            button59.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button77_Click(object sender, EventArgs e)
        {
            button77.Enabled = false;
            button77.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Enabled = false;
            button16.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.Enabled = false;
            button28.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            button52.Enabled = false;
            button52.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            button58.Enabled = false;
            button58.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button76_Click(object sender, EventArgs e)
        {
            button76.Enabled = false;
            button76.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button15.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.Enabled = false;
            button27.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            button51.Enabled = false;
            button51.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            button57.Enabled = false;
            button57.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button75_Click(object sender, EventArgs e)
        {
            button75.Enabled = false;
            button75.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;
            button14.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.Enabled = false;
            button26.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            button50.Enabled = false;
            button50.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            button56.Enabled = false;
            button56.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            button74.Enabled = false;
            button74.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.Enabled = false;
            button25.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            button49.Enabled = false;
            button49.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            button55.Enabled = false;
            button55.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button73_Click(object sender, EventArgs e)
        {
            button73.Enabled = false;
            button73.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.Enabled = false;
            button24.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button87_Click(object sender, EventArgs e)
        {
            button87.Enabled = false;
            button87.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button89_Click(object sender, EventArgs e)
        {
            button89.Enabled = false;
            button89.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button90_Click(object sender, EventArgs e)
        {
            button90.Enabled = false;
            button90.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button79_Click(object sender, EventArgs e)
        {
            button79.Enabled = false;
            button79.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button80_Click(object sender, EventArgs e)
        {
            button80.Enabled = false;
            button80.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button81_Click(object sender, EventArgs e)
        {
            button81.Enabled = false;
            button81.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button82_Click(object sender, EventArgs e)
        {
            button82.Enabled = false;
            button82.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button83_Click(object sender, EventArgs e)
        {
            button83.Enabled = false;
            button83.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button84_Click(object sender, EventArgs e)
        {
            button84.Enabled = false;
            button84.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button67_Click(object sender, EventArgs e)
        {
            button67.Enabled = false;
            button67.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            button68.Enabled = false;
            button68.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            button69.Enabled = false;
            button69.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            button70.Enabled = false;
            button70.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button71_Click(object sender, EventArgs e)
        {
            button71.Enabled = false;
            button71.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            button72.Enabled = false;
            button72.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            button61.Enabled = false;
            button61.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            button62.Enabled = false;
            button62.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            button63.Enabled = false;
            button63.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            button64.Enabled = false;
            button64.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            button65.Enabled = false;
            button65.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            button66.Enabled = false;
            button66.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.Enabled = false;
            button31.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.Enabled = false;
            button32.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.Enabled = false;
            button33.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button34.Enabled = false;
            button34.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button35.Enabled = false;
            button35.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.Enabled = false;
            button36.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Enabled = false;
            button19.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Enabled = false;
            button20.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Enabled = false;
            button21.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Enabled = false;
            button22.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Enabled = false;
            button23.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void button85_Click(object sender, EventArgs e)
        {
            button85.Enabled = false;
            button85.BackColor = Red;
            count += 1;
            seatDisable();
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            TicketConfrim ticket = new TicketConfrim(Title, Date, Time, "3D", AmountSeats, "A1", PictureName);
            this.Hide();
            ticket.ShowDialog();
            this.Close();
        }
>>>>>>> parent of 67cd503... Bij movieChoice blijft genre staan als je film annuleert en teruggaat naar dit scherm, interface iets veranderd
    }
}
