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
    public partial class techScreen : Form
    {
        public techScreen()
        {
            InitializeComponent();
            Movies movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            this.IMAXLabel.Parent = TechPictureBox;
        }

        private void techScreen_Load(object sender, EventArgs e)
        {
            Movies Movies = JsonConvert.DeserializeObject<Movies>(File.ReadAllText("Movies.json"));
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image image1 = Image.FromFile(path + @"\MoviePictures\" + Movies.Technologie.IMAX.PictureName + ".jpg");
            this.TechPictureBox.Image = image1;

            IMAXLabel.Text = Movies.Technologie.IMAX.Description;
        }
    }
}
