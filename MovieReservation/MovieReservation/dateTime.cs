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
        public int countDate = 0;
        public int countTime = 0;
        public string Title;
        public string Genre;
        public string Age;
        public string PictureName;
        public string Description;
        public string Time;
        public string Date;
        public string KindOfMovie;
        public dateTime(string title, string genre, string age, string pictureName, string description, string kindofmovie)
        {
            InitializeComponent();

            Title = title;
            Genre = genre;
            Age = age;
            PictureName = pictureName;
            Description = description;
            KindOfMovie = kindofmovie;
            

            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image imagePicture = Image.FromFile(path + @"\MoviePictures\" + PictureName + ".png");
            this.pictureBoxMovie.Image = imagePicture;

            Image imageGenre = Image.FromFile(path + @"\MoviePictures\" + Genre + ".png");
            this.pictureBoxAge.Image = imageGenre;

            Image imageAge = Image.FromFile(path + @"\MoviePictures\" + Age + ".png");
            this.pictureBoxClassification.Image = imageAge;

            labelTitle.Text = Title;
            labelDescription.Text = Description;
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = new DateTime(2028, 6, 20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Date = dateTimePicker1.Text;
            Time = comboBox2.Text;
            
            if (countDate >= 1 && countTime >= 1)
            {
                if (Age == "16")
                {
                    Ticket tk = new Ticket(Title, Genre, Age, PictureName, Description, Date, Time, KindOfMovie);
                    this.Hide();
                    tk.ShowDialog();
                    this.Close();
                }
                else
                {
                    TicketIfNot16 tk16 = new TicketIfNot16(Title, Genre, Age, PictureName, Description, Date, Time, KindOfMovie);
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
            countDate += 1;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            countTime += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            movieChoice mc = new movieChoice(KindOfMovie);
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
