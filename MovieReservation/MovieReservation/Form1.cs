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
        public Form1()
        {
            InitializeComponent();
        }

        private void Klant_Click(object sender, EventArgs e)
        {
            movieChoice movie = new movieChoice();
            movie.ShowDialog();
            this.Close();
        }

        private void Medewerker_Click(object sender, EventArgs e)
        {
            collaboratorLogin login = new collaboratorLogin();
            login.ShowDialog();
            this.Close();
        }
    }
}
