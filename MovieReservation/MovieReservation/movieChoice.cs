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
        public string KindOfMovie;
        public List<string> reservedSeats = new List<string>();

        public movieChoice(string kindofmovie, List<string> reserve)
        {
            InitializeComponent();
            reservedSeats = reserve;
            KindOfMovie = kindofmovie;
            Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            label2.Text = movies.Nieuw.N1.Title;
            label3.Text = movies.Nieuw.N2.Title;
            label4.Text = movies.Nieuw.N3.Title;
            label5.Text = movies.Nieuw.N4.Title;
            label6.Text = movies.Nieuw.N5.Title;
            label7.Text = "Nieuwe films";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void actieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //newMovie.BringToFront();
            KindOfMovie = "new";

            Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Nieuw.N1.PictureName + ".png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(path + @"\MoviePictures\" + Movies.Nieuw.N2.PictureName + ".png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(path + @"\MoviePictures\" + Movies.Nieuw.N3.PictureName + ".png");
            this.pictureBox3.Image = image3;

            Image image4 = Image.FromFile(path + @"\MoviePictures\" + Movies.Nieuw.N4.PictureName + ".png");
            this.pictureBox4.Image = image4;

            Image image5 = Image.FromFile(path + @"\MoviePictures\" + Movies.Nieuw.N5.PictureName + ".png");
            this.pictureBox5.Image = image5;

            Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            label2.Text = movies.Nieuw.N1.Title;
            label3.Text = movies.Nieuw.N2.Title;
            label4.Text = movies.Nieuw.N3.Title;
            label5.Text = movies.Nieuw.N4.Title;
            label6.Text = movies.Nieuw.N5.Title;
            label7.Text = "Nieuwe films";
        }

        private void actieToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //action.BringToFront();
            KindOfMovie = "action";

            Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Actie.A1.PictureName + ".png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(path + @"\MoviePictures\" + Movies.Actie.A2.PictureName + ".png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(path + @"\MoviePictures\" + Movies.Actie.A3.PictureName + ".png");
            this.pictureBox3.Image = image3;

            Image image4 = Image.FromFile(path + @"\MoviePictures\" + Movies.Actie.A4.PictureName + ".png");
            this.pictureBox4.Image = image4;

            Image image5 = Image.FromFile(path + @"\MoviePictures\" + Movies.Actie.A5.PictureName + ".png");
            this.pictureBox5.Image = image5;

            Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            label2.Text = movies.Actie.A1.Title;
            label3.Text = movies.Actie.A2.Title;
            label4.Text = movies.Actie.A3.Title;
            label5.Text = movies.Actie.A4.Title;
            label6.Text = movies.Actie.A5.Title;
            label7.Text = "Actie films";
        }

        private void comedyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Comedy.BringToFront();
            KindOfMovie = "comedy";

            Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Comedy.C1.PictureName + ".png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(path + @"\MoviePictures\" + Movies.Comedy.C2.PictureName + ".png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(path + @"\MoviePictures\" + Movies.Comedy.C3.PictureName + ".png");
            this.pictureBox3.Image = image3;

            Image image4 = Image.FromFile(path + @"\MoviePictures\" + Movies.Comedy.C4.PictureName + ".png");
            this.pictureBox4.Image = image4;

            Image image5 = Image.FromFile(path + @"\MoviePictures\" + Movies.Comedy.C5.PictureName + ".png");
            this.pictureBox5.Image = image5;

            Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            label2.Text = movies.Comedy.C1.Title;
            label3.Text = movies.Comedy.C2.Title;
            label4.Text = movies.Comedy.C3.Title;
            label5.Text = movies.Comedy.C4.Title;
            label6.Text = movies.Comedy.C5.Title;
            label7.Text = "Comedy films";
        }

        private void turksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Turks.BringToFront();
            KindOfMovie = "turkish";

            Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Turks.T1.PictureName + ".png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(path + @"\MoviePictures\" + Movies.Turks.T2.PictureName + ".png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(path + @"\MoviePictures\" + Movies.Turks.T3.PictureName + ".png");
            this.pictureBox3.Image = image3;

            Image image4 = Image.FromFile(path + @"\MoviePictures\" + Movies.Turks.T4.PictureName + ".png");
            this.pictureBox4.Image = image4;

            Image image5 = Image.FromFile(path + @"\MoviePictures\" + Movies.Turks.T5.PictureName + ".png");
            this.pictureBox5.Image = image5;

            Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            label2.Text = movies.Turks.T1.Title;
            label3.Text = movies.Turks.T2.Title;
            label4.Text = movies.Turks.T3.Title;
            label5.Text = movies.Turks.T4.Title;
            label6.Text = movies.Turks.T5.Title;
            label7.Text = "Turkse films";
        }

        private void bollywoodToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Bollywood.BringToFront();
            KindOfMovie = "bollywood";

            Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Bollywood.B1.PictureName + ".png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(path + @"\MoviePictures\" + Movies.Bollywood.B2.PictureName + ".png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(path + @"\MoviePictures\" + Movies.Bollywood.B3.PictureName + ".png");
            this.pictureBox3.Image = image3;

            Image image4 = Image.FromFile(path + @"\MoviePictures\" + Movies.Bollywood.B4.PictureName + ".png");
            this.pictureBox4.Image = image4;

            Image image5 = Image.FromFile(path + @"\MoviePictures\" + Movies.Bollywood.B5.PictureName + ".png");
            this.pictureBox5.Image = image5;

            Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            label2.Text = movies.Bollywood.B1.Title;
            label3.Text = movies.Bollywood.B2.Title;
            label4.Text = movies.Bollywood.B3.Title;
            label5.Text = movies.Bollywood.B4.Title;
            label6.Text = movies.Bollywood.B5.Title;
            label7.Text = "Bollywood films";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (KindOfMovie == "action")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Actie.A1.Title;
                Genre = Movies.Actie.A1.Genre;
                Age = Movies.Actie.A1.Age;
                PictureName = Movies.Actie.A1.PictureName;
                Description = Movies.Actie.A1.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "comedy")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Comedy.C1.Title;
                Genre = Movies.Comedy.C1.Genre;
                Age = Movies.Comedy.C1.Age;
                PictureName = Movies.Comedy.C1.PictureName;
                Description = Movies.Comedy.C1.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "turkish")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Turks.T1.Title;
                Genre = Movies.Turks.T1.Genre;
                Age = Movies.Turks.T1.Age;
                PictureName = Movies.Turks.T1.PictureName;
                Description = Movies.Turks.T1.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "bollywood")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Bollywood.B1.Title;
                Genre = Movies.Bollywood.B1.Genre;
                Age = Movies.Bollywood.B1.Age;
                PictureName = Movies.Bollywood.B1.PictureName;
                Description = Movies.Bollywood.B1.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "kids")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Kinderfilm.K1.Title;
                Genre = Movies.Kinderfilm.K1.Genre;
                Age = Movies.Kinderfilm.K1.Age;
                PictureName = Movies.Kinderfilm.K1.PictureName;
                Description = Movies.Kinderfilm.K1.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "animation")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Animatie.Q1.Title;
                Genre = Movies.Animatie.Q1.Genre;
                Age = Movies.Animatie.Q1.Age;
                PictureName = Movies.Animatie.Q1.PictureName;
                Description = Movies.Animatie.Q1.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "family")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Familie.F1.Title;
                Genre = Movies.Familie.F1.Genre;
                Age = Movies.Familie.F1.Age;
                PictureName = Movies.Familie.F1.PictureName;
                Description = Movies.Familie.F1.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "new")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Nieuw.N1.Title;
                Genre = Movies.Nieuw.N1.Genre;
                Age = Movies.Nieuw.N1.Age;
                PictureName = Movies.Nieuw.N1.PictureName;
                Description = Movies.Nieuw.N1.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Nieuw.N1.Title;
                Genre = Movies.Nieuw.N1.Genre;
                Age = Movies.Nieuw.N1.Age;
                PictureName = Movies.Nieuw.N1.PictureName;
                Description = Movies.Nieuw.N1.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (KindOfMovie == "action")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Actie.A2.Title;
                Genre = Movies.Actie.A2.Genre;
                Age = Movies.Actie.A2.Age;
                PictureName = Movies.Actie.A2.PictureName;
                Description = Movies.Actie.A2.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "comedy")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Comedy.C2.Title;
                Genre = Movies.Comedy.C2.Genre;
                Age = Movies.Comedy.C2.Age;
                PictureName = Movies.Comedy.C2.PictureName;
                Description = Movies.Comedy.C2.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "turkish")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Turks.T2.Title;
                Genre = Movies.Turks.T2.Genre;
                Age = Movies.Turks.T2.Age;
                PictureName = Movies.Turks.T2.PictureName;
                Description = Movies.Turks.T2.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "bollywood")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Bollywood.B2.Title;
                Genre = Movies.Bollywood.B2.Genre;
                Age = Movies.Bollywood.B2.Age;
                PictureName = Movies.Bollywood.B2.PictureName;
                Description = Movies.Bollywood.B2.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "kids")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Kinderfilm.K2.Title;
                Genre = Movies.Kinderfilm.K2.Genre;
                Age = Movies.Kinderfilm.K2.Age;
                PictureName = Movies.Kinderfilm.K2.PictureName;
                Description = Movies.Kinderfilm.K2.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "animation")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Animatie.Q2.Title;
                Genre = Movies.Animatie.Q2.Genre;
                Age = Movies.Animatie.Q2.Age;
                PictureName = Movies.Animatie.Q2.PictureName;
                Description = Movies.Animatie.Q2.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "family")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Familie.F2.Title;
                Genre = Movies.Familie.F2.Genre;
                Age = Movies.Familie.F2.Age;
                PictureName = Movies.Familie.F2.PictureName;
                Description = Movies.Familie.F2.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "new")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Nieuw.N2.Title;
                Genre = Movies.Nieuw.N2.Genre;
                Age = Movies.Nieuw.N2.Age;
                PictureName = Movies.Nieuw.N2.PictureName;
                Description = Movies.Nieuw.N2.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Nieuw.N2.Title;
                Genre = Movies.Nieuw.N2.Genre;
                Age = Movies.Nieuw.N2.Age;
                PictureName = Movies.Nieuw.N2.PictureName;
                Description = Movies.Nieuw.N2.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (KindOfMovie == "action")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Actie.A3.Title;
                Genre = Movies.Actie.A3.Genre;
                Age = Movies.Actie.A3.Age;
                PictureName = Movies.Actie.A3.PictureName;
                Description = Movies.Actie.A3.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "comedy")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Comedy.C3.Title;
                Genre = Movies.Comedy.C3.Genre;
                Age = Movies.Comedy.C3.Age;
                PictureName = Movies.Comedy.C3.PictureName;
                Description = Movies.Comedy.C3.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "turkish")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Turks.T3.Title;
                Genre = Movies.Turks.T3.Genre;
                Age = Movies.Turks.T3.Age;
                PictureName = Movies.Turks.T3.PictureName;
                Description = Movies.Turks.T3.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "bollywood")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Bollywood.B3.Title;
                Genre = Movies.Bollywood.B3.Genre;
                Age = Movies.Bollywood.B3.Age;
                PictureName = Movies.Bollywood.B3.PictureName;
                Description = Movies.Bollywood.B3.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "kids")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Kinderfilm.K3.Title;
                Genre = Movies.Kinderfilm.K3.Genre;
                Age = Movies.Kinderfilm.K3.Age;
                PictureName = Movies.Kinderfilm.K3.PictureName;
                Description = Movies.Kinderfilm.K3.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "animation")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Animatie.Q3.Title;
                Genre = Movies.Animatie.Q3.Genre;
                Age = Movies.Animatie.Q3.Age;
                PictureName = Movies.Animatie.Q3.PictureName;
                Description = Movies.Animatie.Q3.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "family")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Familie.F3.Title;
                Genre = Movies.Familie.F3.Genre;
                Age = Movies.Familie.F3.Age;
                PictureName = Movies.Familie.F3.PictureName;
                Description = Movies.Familie.F3.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "new")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Nieuw.N3.Title;
                Genre = Movies.Nieuw.N3.Genre;
                Age = Movies.Nieuw.N3.Age;
                PictureName = Movies.Nieuw.N3.PictureName;
                Description = Movies.Nieuw.N3.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Nieuw.N3.Title;
                Genre = Movies.Nieuw.N3.Genre;
                Age = Movies.Nieuw.N3.Age;
                PictureName = Movies.Nieuw.N3.PictureName;
                Description = Movies.Nieuw.N3.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (KindOfMovie == "action")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Actie.A4.Title;
                Genre = Movies.Actie.A4.Genre;
                Age = Movies.Actie.A4.Age;
                PictureName = Movies.Actie.A4.PictureName;
                Description = Movies.Actie.A4.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "comedy")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Comedy.C4.Title;
                Genre = Movies.Comedy.C4.Genre;
                Age = Movies.Comedy.C4.Age;
                PictureName = Movies.Comedy.C4.PictureName;
                Description = Movies.Comedy.C4.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "turkish")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Turks.T4.Title;
                Genre = Movies.Turks.T4.Genre;
                Age = Movies.Turks.T4.Age;
                PictureName = Movies.Turks.T4.PictureName;
                Description = Movies.Turks.T4.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "bollywood")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Bollywood.B4.Title;
                Genre = Movies.Bollywood.B4.Genre;
                Age = Movies.Bollywood.B4.Age;
                PictureName = Movies.Bollywood.B4.PictureName;
                Description = Movies.Bollywood.B4.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "kids")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Kinderfilm.K4.Title;
                Genre = Movies.Kinderfilm.K4.Genre;
                Age = Movies.Kinderfilm.K4.Age;
                PictureName = Movies.Kinderfilm.K4.PictureName;
                Description = Movies.Kinderfilm.K4.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "animation")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Animatie.Q4.Title;
                Genre = Movies.Animatie.Q4.Genre;
                Age = Movies.Animatie.Q4.Age;
                PictureName = Movies.Animatie.Q4.PictureName;
                Description = Movies.Animatie.Q4.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "family")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Familie.F4.Title;
                Genre = Movies.Familie.F4.Genre;
                Age = Movies.Familie.F4.Age;
                PictureName = Movies.Familie.F4.PictureName;
                Description = Movies.Familie.F4.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "new")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Nieuw.N4.Title;
                Genre = Movies.Nieuw.N4.Genre;
                Age = Movies.Nieuw.N4.Age;
                PictureName = Movies.Nieuw.N4.PictureName;
                Description = Movies.Nieuw.N4.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Nieuw.N4.Title;
                Genre = Movies.Nieuw.N4.Genre;
                Age = Movies.Nieuw.N4.Age;
                PictureName = Movies.Nieuw.N4.PictureName;
                Description = Movies.Nieuw.N4.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (KindOfMovie == "action")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Actie.A5.Title;
                Genre = Movies.Actie.A5.Genre;
                Age = Movies.Actie.A5.Age;
                PictureName = Movies.Actie.A5.PictureName;
                Description = Movies.Actie.A5.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "comedy")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Comedy.C5.Title;
                Genre = Movies.Comedy.C5.Genre;
                Age = Movies.Comedy.C5.Age;
                PictureName = Movies.Comedy.C5.PictureName;
                Description = Movies.Comedy.C5.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "turkish")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Turks.T5.Title;
                Genre = Movies.Turks.T5.Genre;
                Age = Movies.Turks.T5.Age;
                PictureName = Movies.Turks.T5.PictureName;
                Description = Movies.Turks.T5.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "bollywood")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Bollywood.B5.Title;
                Genre = Movies.Bollywood.B5.Genre;
                Age = Movies.Bollywood.B5.Age;
                PictureName = Movies.Bollywood.B5.PictureName;
                Description = Movies.Bollywood.B5.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "kids")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Kinderfilm.K5.Title;
                Genre = Movies.Kinderfilm.K5.Genre;
                Age = Movies.Kinderfilm.K5.Age;
                PictureName = Movies.Kinderfilm.K5.PictureName;
                Description = Movies.Kinderfilm.K5.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "animation")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Animatie.Q5.Title;
                Genre = Movies.Animatie.Q5.Genre;
                Age = Movies.Animatie.Q5.Age;
                PictureName = Movies.Animatie.Q5.PictureName;
                Description = Movies.Animatie.Q5.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "family")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Familie.F5.Title;
                Genre = Movies.Familie.F5.Genre;
                Age = Movies.Familie.F5.Age;
                PictureName = Movies.Familie.F5.PictureName;
                Description = Movies.Familie.F5.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
            else if (KindOfMovie == "new")
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Nieuw.N5.Title;
                Genre = Movies.Nieuw.N5.Genre;
                Age = Movies.Nieuw.N5.Age;
                PictureName = Movies.Nieuw.N5.PictureName;
                Description = Movies.Nieuw.N5.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                dt.ShowDialog();
                this.Close();
            }
            else
            {
                Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                Title = Movies.Nieuw.N5.Title;
                Genre = Movies.Nieuw.N5.Genre;
                Age = Movies.Nieuw.N5.Age;
                PictureName = Movies.Nieuw.N5.PictureName;
                Description = Movies.Nieuw.N5.Description;

                dateTime dt = new dateTime(Title, Genre, Age.ToString(), PictureName, Description, KindOfMovie, reservedSeats);
                this.Hide();
                dt.ShowDialog();
                this.Close();
            }
        }

        private void movieChoice_Load(object sender, EventArgs e)
        {
            Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            if (KindOfMovie == "new")
            {
                Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Nieuw.N1.PictureName + ".png");
                this.pictureBox1.Image = image1;

                Image image2 = Image.FromFile(path + @"\MoviePictures\" + Movies.Nieuw.N2.PictureName + ".png");
                this.pictureBox2.Image = image2;

                Image image3 = Image.FromFile(path + @"\MoviePictures\" + Movies.Nieuw.N3.PictureName + ".png");
                this.pictureBox3.Image = image3;

                Image image4 = Image.FromFile(path + @"\MoviePictures\" + Movies.Nieuw.N4.PictureName + ".png");
                this.pictureBox4.Image = image4;

                Image image5 = Image.FromFile(path + @"\MoviePictures\" + Movies.Nieuw.N5.PictureName + ".png");
                this.pictureBox5.Image = image5;

                Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                label2.Text = movies.Nieuw.N1.Title;
                label3.Text = movies.Nieuw.N2.Title;
                label4.Text = movies.Nieuw.N3.Title;
                label5.Text = movies.Nieuw.N4.Title;
                label6.Text = movies.Nieuw.N5.Title;
                label7.Text = "Nieuwe films";
            }
            else if (KindOfMovie == "action")
            {

                Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Actie.A1.PictureName + ".png");
                this.pictureBox1.Image = image1;

                Image image2 = Image.FromFile(path + @"\MoviePictures\" + Movies.Actie.A2.PictureName + ".png");
                this.pictureBox2.Image = image2;

                Image image3 = Image.FromFile(path + @"\MoviePictures\" + Movies.Actie.A3.PictureName + ".png");
                this.pictureBox3.Image = image3;

                Image image4 = Image.FromFile(path + @"\MoviePictures\" + Movies.Actie.A4.PictureName + ".png");
                this.pictureBox4.Image = image4;

                Image image5 = Image.FromFile(path + @"\MoviePictures\" + Movies.Actie.A5.PictureName + ".png");
                this.pictureBox5.Image = image5;

                Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                label2.Text = movies.Actie.A1.Title;
                label3.Text = movies.Actie.A2.Title;
                label4.Text = movies.Actie.A3.Title;
                label5.Text = movies.Actie.A4.Title;
                label6.Text = movies.Actie.A5.Title;
                label7.Text = "Actie films";
            }
            else if (KindOfMovie == "comedy")
            {
                Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Comedy.C1.PictureName + ".png");
                this.pictureBox1.Image = image1;

                Image image2 = Image.FromFile(path + @"\MoviePictures\" + Movies.Comedy.C2.PictureName + ".png");
                this.pictureBox2.Image = image2;

                Image image3 = Image.FromFile(path + @"\MoviePictures\" + Movies.Comedy.C3.PictureName + ".png");
                this.pictureBox3.Image = image3;

                Image image4 = Image.FromFile(path + @"\MoviePictures\" + Movies.Comedy.C4.PictureName + ".png");
                this.pictureBox4.Image = image4;

                Image image5 = Image.FromFile(path + @"\MoviePictures\" + Movies.Comedy.C5.PictureName + ".png");
                this.pictureBox5.Image = image5;

                Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                label2.Text = movies.Comedy.C1.Title;
                label3.Text = movies.Comedy.C2.Title;
                label4.Text = movies.Comedy.C3.Title;
                label5.Text = movies.Comedy.C4.Title;
                label6.Text = movies.Comedy.C5.Title;
                label7.Text = "Comedy films";
            }
            else if (KindOfMovie == "turkish")
            {
                Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Turks.T1.PictureName + ".png");
                this.pictureBox1.Image = image1;

                Image image2 = Image.FromFile(path + @"\MoviePictures\" + Movies.Turks.T2.PictureName + ".png");
                this.pictureBox2.Image = image2;

                Image image3 = Image.FromFile(path + @"\MoviePictures\" + Movies.Turks.T3.PictureName + ".png");
                this.pictureBox3.Image = image3;

                Image image4 = Image.FromFile(path + @"\MoviePictures\" + Movies.Turks.T4.PictureName + ".png");
                this.pictureBox4.Image = image4;

                Image image5 = Image.FromFile(path + @"\MoviePictures\" + Movies.Turks.T5.PictureName + ".png");
                this.pictureBox5.Image = image5;

                Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                label2.Text = movies.Turks.T1.Title;
                label3.Text = movies.Turks.T2.Title;
                label4.Text = movies.Turks.T3.Title;
                label5.Text = movies.Turks.T4.Title;
                label6.Text = movies.Turks.T5.Title;
                label7.Text = "Turkse films";
            }
            else if (KindOfMovie == "bollywood")
            {
                Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Bollywood.B1.PictureName + ".png");
                this.pictureBox1.Image = image1;

                Image image2 = Image.FromFile(path + @"\MoviePictures\" + Movies.Bollywood.B2.PictureName + ".png");
                this.pictureBox2.Image = image2;

                Image image3 = Image.FromFile(path + @"\MoviePictures\" + Movies.Bollywood.B3.PictureName + ".png");
                this.pictureBox3.Image = image3;

                Image image4 = Image.FromFile(path + @"\MoviePictures\" + Movies.Bollywood.B4.PictureName + ".png");
                this.pictureBox4.Image = image4;

                Image image5 = Image.FromFile(path + @"\MoviePictures\" + Movies.Bollywood.B5.PictureName + ".png");
                this.pictureBox5.Image = image5;

                Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                label2.Text = movies.Bollywood.B1.Title;
                label3.Text = movies.Bollywood.B2.Title;
                label4.Text = movies.Bollywood.B3.Title;
                label5.Text = movies.Bollywood.B4.Title;
                label6.Text = movies.Bollywood.B5.Title;
                label7.Text = "Bollywood films";
            }
            else if (KindOfMovie == "kids")
            {
                Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Kinderfilm.K1.PictureName + ".png");
                this.pictureBox1.Image = image1;

                Image image2 = Image.FromFile(path + @"\MoviePictures\" + Movies.Kinderfilm.K2.PictureName + ".png");
                this.pictureBox2.Image = image2;

                Image image3 = Image.FromFile(path + @"\MoviePictures\" + Movies.Kinderfilm.K3.PictureName + ".png");
                this.pictureBox3.Image = image3;

                Image image4 = Image.FromFile(path + @"\MoviePictures\" + Movies.Kinderfilm.K4.PictureName + ".png");
                this.pictureBox4.Image = image4;

                Image image5 = Image.FromFile(path + @"\MoviePictures\" + Movies.Kinderfilm.K5.PictureName + ".png");
                this.pictureBox5.Image = image5;

                Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                label2.Text = movies.Kinderfilm.K1.Title;
                label3.Text = movies.Kinderfilm.K2.Title;
                label4.Text = movies.Kinderfilm.K3.Title;
                label5.Text = movies.Kinderfilm.K4.Title;
                label6.Text = movies.Kinderfilm.K5.Title;
                label7.Text = "Kinderfilms";
            }
            else if (KindOfMovie == "animation")
            {
                Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Animatie.Q1.PictureName + ".png");
                this.pictureBox1.Image = image1;

                Image image2 = Image.FromFile(path + @"\MoviePictures\" + Movies.Animatie.Q2.PictureName + ".png");
                this.pictureBox2.Image = image2;

                Image image3 = Image.FromFile(path + @"\MoviePictures\" + Movies.Animatie.Q3.PictureName + ".png");
                this.pictureBox3.Image = image3;

                Image image4 = Image.FromFile(path + @"\MoviePictures\" + Movies.Animatie.Q4.PictureName + ".png");
                this.pictureBox4.Image = image4;

                Image image5 = Image.FromFile(path + @"\MoviePictures\" + Movies.Animatie.Q5.PictureName + ".png");
                this.pictureBox5.Image = image5;

                Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                label2.Text = movies.Animatie.Q1.Title;
                label3.Text = movies.Animatie.Q2.Title;
                label4.Text = movies.Animatie.Q3.Title;
                label5.Text = movies.Animatie.Q4.Title;
                label6.Text = movies.Animatie.Q5.Title;
                label7.Text = "Animatie films";
            }
            else if (KindOfMovie == "family")
            {
                Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Familie.F1.PictureName + ".png");
                this.pictureBox1.Image = image1;

                Image image2 = Image.FromFile(path + @"\MoviePictures\" + Movies.Familie.F2.PictureName + ".png");
                this.pictureBox2.Image = image2;

                Image image3 = Image.FromFile(path + @"\MoviePictures\" + Movies.Familie.F3.PictureName + ".png");
                this.pictureBox3.Image = image3;

                Image image4 = Image.FromFile(path + @"\MoviePictures\" + Movies.Familie.F4.PictureName + ".png");
                this.pictureBox4.Image = image4;

                Image image5 = Image.FromFile(path + @"\MoviePictures\" + Movies.Familie.F5.PictureName + ".png");
                this.pictureBox5.Image = image5;

                Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
                label2.Text = movies.Familie.F1.Title;
                label3.Text = movies.Familie.F2.Title;
                label4.Text = movies.Familie.F3.Title;
                label5.Text = movies.Familie.F4.Title;
                label6.Text = movies.Familie.F5.Title;
                label7.Text = "Familiefilms";
            }
            else
            {
                Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Nieuw.N1.PictureName + ".png");
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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void kinderFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KindOfMovie = "kids";

            Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Kinderfilm.K1.PictureName + ".png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(path + @"\MoviePictures\" + Movies.Kinderfilm.K2.PictureName + ".png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(path + @"\MoviePictures\" + Movies.Kinderfilm.K3.PictureName + ".png");
            this.pictureBox3.Image = image3;

            Image image4 = Image.FromFile(path + @"\MoviePictures\" + Movies.Kinderfilm.K4.PictureName + ".png");
            this.pictureBox4.Image = image4;

            Image image5 = Image.FromFile(path + @"\MoviePictures\" + Movies.Kinderfilm.K5.PictureName + ".png");
            this.pictureBox5.Image = image5;

            Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            label2.Text = movies.Kinderfilm.K1.Title;
            label3.Text = movies.Kinderfilm.K2.Title;
            label4.Text = movies.Kinderfilm.K3.Title;
            label5.Text = movies.Kinderfilm.K4.Title;
            label6.Text = movies.Kinderfilm.K5.Title;
            label7.Text = "Kinderfilms";

        }

        private void animatieFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KindOfMovie = "animation";

            Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Animatie.Q1.PictureName + ".png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(path + @"\MoviePictures\" + Movies.Animatie.Q2.PictureName + ".png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(path + @"\MoviePictures\" + Movies.Animatie.Q3.PictureName + ".png");
            this.pictureBox3.Image = image3;

            Image image4 = Image.FromFile(path + @"\MoviePictures\" + Movies.Animatie.Q4.PictureName + ".png");
            this.pictureBox4.Image = image4;

            Image image5 = Image.FromFile(path + @"\MoviePictures\" + Movies.Animatie.Q5.PictureName + ".png");
            this.pictureBox5.Image = image5;

            Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            label2.Text = movies.Animatie.Q1.Title;
            label3.Text = movies.Animatie.Q2.Title;
            label4.Text = movies.Animatie.Q3.Title;
            label5.Text = movies.Animatie.Q4.Title;
            label6.Text = movies.Animatie.Q5.Title;
            label7.Text = "Animatie films";
        }

        private void familieFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KindOfMovie = "family";

            Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Familie.F1.PictureName + ".png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(path + @"\MoviePictures\" + Movies.Familie.F2.PictureName + ".png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(path + @"\MoviePictures\" + Movies.Familie.F3.PictureName + ".png");
            this.pictureBox3.Image = image3;

            Image image4 = Image.FromFile(path + @"\MoviePictures\" + Movies.Familie.F4.PictureName + ".png");
            this.pictureBox4.Image = image4;

            Image image5 = Image.FromFile(path + @"\MoviePictures\" + Movies.Familie.F5.PictureName + ".png");
            this.pictureBox5.Image = image5;

            Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            label2.Text = movies.Familie.F1.Title;
            label3.Text = movies.Familie.F2.Title;
            label4.Text = movies.Familie.F3.Title;
            label5.Text = movies.Familie.F4.Title;
            label6.Text = movies.Familie.F5.Title;
            label7.Text = "Familie films";
        }
    }
}
