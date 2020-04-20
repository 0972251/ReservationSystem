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
    public partial class dateTime : Form
    {
        int count = 0;
        int count2 = 0;
        string name;
        string genre;
        string ageLimit;
        string picture;
        string beschrijving;
        public dateTime(string Name, string Genre, string AgeLimit, string Picture, string Beschrijving)
        {
            InitializeComponent();
            
            name = Name;
            genre = Genre;
            ageLimit = AgeLimit;
            picture = Picture;
            beschrijving = Beschrijving;

            Image image1 = Image.FromFile(@"C:\ReservationSystem\MovieReservation\MoviePictures\" + Picture + ".png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(@"C:\ReservationSystem\MovieReservation\MoviePictures\" + Genre + ".png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(@"C:\ReservationSystem\MovieReservation\MoviePictures\" + AgeLimit + ".png");
            this.pictureBox3.Image = image3;

            label3.Text = Name;
            label4.Text = Beschrijving;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count >= 1 && count2 >= 1)
            {
                if (ageLimit == "16")
                {
                    Ticket tk = new Ticket(name, genre, ageLimit, picture, beschrijving);
                    this.Hide();
                    tk.ShowDialog();
                    this.Close();
                }
                else
                {
                    TicketIfNot16 tk16 = new TicketIfNot16(name, genre, ageLimit, picture, beschrijving);
                    this.Hide();
                    tk16.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Je moet nog een datum of tijd kiezen");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            count += 1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            count2 += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            movieChoice mc = new movieChoice();
            this.Hide();
            mc.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTime_Load(object sender, EventArgs e)
        {

        }
    }
}
