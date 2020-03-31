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
    public partial class movieChoice : Form
    {
        public movieChoice()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void actieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //newMovie.BringToFront();
        }

        private void actieToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //action.BringToFront();
        }

        private void comedyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Comedy.BringToFront();
        }

        private void turksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Turks.BringToFront();
        }

        private void bollywoodToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Bolywood.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Name = "No Time to Die";
            string Genre = "actie";
            string AgeLimit = "12";
            string Picture = "afb1";

            dateTime dt = new dateTime(Name, Genre, AgeLimit, Picture);
            dt.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string Name = "Wonder Woman";
            string Genre = "actie";
            string AgeLimit = "12";
            string Picture = "afb2";

            dateTime dt = new dateTime(Name, Genre, AgeLimit, Picture);
            dt.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string Name = "Bloodshot";
            string Genre = "actie";
            string AgeLimit = "16";
            string Picture = "afb3"; 

            dateTime dt = new dateTime(Name, Genre, AgeLimit, Picture);
            dt.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string Name = "Mulan";
            string Genre = "actie";
            string AgeLimit = "6";
            string Picture = "afb4";

            dateTime dt = new dateTime(Name, Genre, AgeLimit, Picture);
            dt.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string Name = "Sonic";
            string Genre = "actie";
            string AgeLimit = "All";
            string Picture = "afb8";

            dateTime dt = new dateTime(Name, Genre, AgeLimit, Picture);
            dt.ShowDialog();
            this.Close();
        }

        private void movieChoice_Load(object sender, EventArgs e)
        {
            Image image1 = Image.FromFile(@"C:\ReservationSystem\MovieReservation\MoviePictures\afb1.png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(@"C:\ReservationSystem\MovieReservation\MoviePictures\afb2.png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(@"C:\ReservationSystem\MovieReservation\MoviePictures\afb3.png");
            this.pictureBox3.Image = image3;

            Image image4 = Image.FromFile(@"C:\ReservationSystem\MovieReservation\MoviePictures\afb4.png");
            this.pictureBox4.Image = image4;

            Image image5 = Image.FromFile(@"C:\ReservationSystem\MovieReservation\MoviePictures\afb8.png");
            this.pictureBox5.Image = image5;
        }
    }
}
