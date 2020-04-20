using Newtonsoft.Json;
using QuickType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieReservation
{
    public partial class movieChoice : Form
    {
        public string Title;
        public string Genre;
        public long Age;
        public string Time;
        public string Description;
        public string PictureName;

        public movieChoice()
        {
            InitializeComponent();
            Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            label2.Text = movies.Nieuw.N1.Title;
            label3.Text = movies.Nieuw.N2.Title;
            label4.Text = movies.Nieuw.N3.Title;
            label5.Text = movies.Nieuw.N4.Title;
            label6.Text = movies.Nieuw.N5.Title;
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
            Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            Title = Movies.Nieuw.N1.Title;
            Genre = Movies.Nieuw.N1.Genre;
            Age = Movies.Nieuw.N1.Age;
            PictureName = Movies.Nieuw.N1.PictureName;
            Description = Movies.Nieuw.N1.Description;

            dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description);
            this.Hide();
            dt.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            Title = Movies.Nieuw.N2.Title;
            Genre = Movies.Nieuw.N2.Genre;
            Age = Movies.Nieuw.N2.Age;
            PictureName = Movies.Nieuw.N2.PictureName;
            Description = Movies.Nieuw.N2.Description;

            dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description);
            this.Hide();
            dt.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            Title = Movies.Nieuw.N3.Title;
            Genre = Movies.Nieuw.N3.Genre;
            Age = Movies.Nieuw.N3.Age;
            PictureName = Movies.Nieuw.N3.PictureName;
            Description = Movies.Nieuw.N3.Description;

            dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description);
            this.Hide();
            dt.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            Title = Movies.Nieuw.N4.Title;
            Genre = Movies.Nieuw.N4.Genre;
            Age = Movies.Nieuw.N4.Age;
            PictureName = Movies.Nieuw.N4.PictureName;
            Description = Movies.Nieuw.N4.Description;

            dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description);
            this.Hide();
            dt.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            Title = Movies.Nieuw.N5.Title;
            Genre = Movies.Nieuw.N5.Genre;
            Age = Movies.Nieuw.N5.Age;
            PictureName = Movies.Nieuw.N5.PictureName;
            Description = Movies.Nieuw.N5.Description;

            dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description);
            this.Hide();
            dt.ShowDialog();
            this.Close();
        }

        private void movieChoice_Load(object sender, EventArgs e)
        {
            Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image image1 = Image.FromFile(path + @"\MoviePictures\" +Movies.Nieuw.N1.PictureName+ ".png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(path + @"\MoviePictures\" + Movies.Nieuw.N2.PictureName + ".png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(path + @"\MoviePictures\" + Movies.Nieuw.N3.PictureName + ".png");
            this.pictureBox3.Image = image3;

            Image image4 = Image.FromFile(path + @"\MoviePictures\" + Movies.Nieuw.N4.PictureName + ".png");
            this.pictureBox4.Image = image4;

            Image image5 = Image.FromFile(path + @"\MoviePictures\" + Movies.Nieuw.N5.PictureName + ".png");
            this.pictureBox5.Image = image5;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
