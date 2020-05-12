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
        public string Title;
        public string Genre;
        public string Age;
        public string PictureName;
        public string Description;
        public string Date;
        public string Time;
        public string KindOfMovie;

        public Ticket(string title, string genre, string age, string pictureName, string description, string date, string time, string kindofmovie)
        {
            InitializeComponent();

            Title = title;
            Genre = genre;
            Age = age;
            PictureName = pictureName;
            Description = description;
            Date = date;
            Time = time;
            KindOfMovie = kindofmovie;

            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image image1 = Image.FromFile(path + @"\MoviePictures\" + PictureName + ".png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(path + @"\MoviePictures\" + Genre + ".png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(path + @"\MoviePictures\" + Age + ".png");
            this.pictureBox3.Image = image3;

            label1.Text = Title;
            FindSeat.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ticket1 = comboBox1.Text.ToString();
            string ticket2 = comboBox2.Text.ToString();
            string ticket4 = comboBox4.Text.ToString();

            int Normaal = int.Parse(ticket1);
            int Student = int.Parse(ticket2);
            int Senior = int.Parse(ticket4);

            int totalSeats = Normaal + Student + Senior;

            if (totalSeats > 9)
            {
                MessageBox.Show("Je mag niet meer dan 9 tickets reserveren");
            }
            else if (totalSeats < 1)
            {
                MessageBox.Show("Je moet minstens 1 ticket reserveren");
            }
            else
            {
                Room room = new Room(totalSeats, Title, Genre, Age, PictureName, Description, Date, Time, KindOfMovie);
                this.Hide();
                room.ShowDialog();
                this.Close();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTime dt = new dateTime(Title, Genre, Age, PictureName, Description, KindOfMovie);
            this.Hide();
            dt.ShowDialog();
            this.Close();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                FindSeat.Enabled = false;
            }
            else
            {
                FindSeat.Enabled = true;
            }
            
        }

        private void Ticket_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
