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
    public partial class IMAXScreen : Form
    {
        public string kindofmovie;
        public List<string> reservedSeats;
        public IMAXScreen(string kindofmovie, List<string> reservedSeats)
        {
            InitializeComponent();
            this.kindofmovie = kindofmovie;
            this.reservedSeats = reservedSeats;

            Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            this.IMAXLabel.Parent = TechPictureBox;
        }

        private void IMAXScreen_Load(object sender, EventArgs e)
        {
            Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Technologie.IMAX.PictureName + ".jpg");
            this.TechPictureBox.Image = image1;

            IMAXLabel.Text = Movies.Technologie.IMAX.Description;
        }

        private void IMAXBackButton_Click(object sender, EventArgs e)
        {
            movieChoice mc = new movieChoice(kindofmovie, reservedSeats);
            this.Hide();
            mc.ShowDialog();
            this.Close();
        }
    }
}
