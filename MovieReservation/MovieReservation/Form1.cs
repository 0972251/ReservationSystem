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
    public partial class Form1 : Form
    {
        public string KindOfMovie = "";
        public List<int> reservedMovie = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Klant_Click(object sender, EventArgs e)
        {
            movieChoice movie = new movieChoice(KindOfMovie, reservedMovie);
            this.Hide();
            movie.ShowDialog();
            this.Close();
        }

        private void Medewerker_Click(object sender, EventArgs e)
        {
            collaboratorLogin login = new collaboratorLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
