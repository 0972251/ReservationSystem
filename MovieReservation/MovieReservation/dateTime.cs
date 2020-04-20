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
        public int count = 0;
        public int count2 = 0;
        public string Title;
        public string Genre;
        public string Age;
        public string PictureName;
        public string Description;
        public dateTime(string title, string genre, string age, string pictureName, string description)
        {
            InitializeComponent();

            Title = title;
            Genre = genre;
            Age = age;
            PictureName = pictureName;
            Description = description;

            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image image1 = Image.FromFile(path + @"\MoviePictures\" + PictureName + ".png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(path + @"\MoviePictures\" + Genre + ".png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(path + @"\MoviePictures\" + Age + ".png");
            this.pictureBox3.Image = image3;

            label3.Text = Name;
            label4.Text = Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count >= 1 && count2 >= 1)
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
