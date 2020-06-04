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
        public List<string> reservedSeats = new List<string>();
        public string KindOfMovie = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Klant_Click(object sender, EventArgs e)
        {
            movieChoice movie = new movieChoice(KindOfMovie, reservedSeats);
            this.Hide();
            movie.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            collaboratorLogin login = new collaboratorLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
