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
        public dateTime(string Name, string Genre, string AgeLimit, string Picture)
        {
            InitializeComponent();
            
            name = Name;
            genre = Genre;
            ageLimit = AgeLimit;
            picture = Picture;

            Image image1 = Image.FromFile(@"C:\MovieReservation\MoviePictures\" + Picture + ".png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(@"C:\MovieReservation\MoviePictures\" + Genre + ".png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(@"C:\MovieReservation\MoviePictures\" + AgeLimit + ".png");
            this.pictureBox3.Image = image3;

            label3.Text = Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count >= 1 && count2 >= 1)
            {
                Ticket tk = new Ticket(name, genre, ageLimit, picture);
                tk.ShowDialog();
                this.Close();
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
            mc.ShowDialog();
            this.Close();
        }
    }
}
