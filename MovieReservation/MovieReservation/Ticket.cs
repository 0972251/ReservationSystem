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
    public partial class Ticket : Form
    {
        string name;
        string genre;
        string ageLimit;
        string picture;
        string beschrijving;
        public Ticket(string Name, string Genre, string AgeLimit, string Picture)
        {
            InitializeComponent();

            name = Name;
            genre = Genre;
            ageLimit = AgeLimit;
            picture = Picture;

            Image image1 = Image.FromFile(@"C:\ReservationSystem\MovieReservation\MoviePictures\" + Picture + ".png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(@"C:\ReservationSystem\MovieReservation\MoviePictures\" + Genre + ".png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(@"C:\ReservationSystem\MovieReservation\MoviePictures\" + AgeLimit + ".png");
            this.pictureBox3.Image = image3;

            label1.Text = Name;

            if (ageLimit == "16")
            {
                checkBox1.Enabled = true;
                button2.Enabled = false;
                // kind uithalen van scherm
            }
            else
            {
                checkBox1.Enabled = false;
                button2.Enabled = true;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ticket1 = comboBox1.Text.ToString();
            string ticket2 = comboBox1.Text.ToString();
            string ticket3 = comboBox1.Text.ToString();
            string ticket4 = comboBox1.Text.ToString();

            int Normaal = int.Parse(ticket1);
            int Student = int.Parse(ticket2);
            int Kind = int.Parse(ticket3);
            int Senior = int.Parse(ticket4);

            int totalSeats = Normaal + Student + Kind + Senior;

            Room room = new Room(totalSeats);
            this.Hide();
            room.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTime dt = new dateTime(name, genre, ageLimit, picture, beschrijving);
            this.Hide();
            dt.ShowDialog();
            this.Close();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
            
        }

        private void Ticket_Load(object sender, EventArgs e)
        {

        }
    }
}
