﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MovieReservation
{
    
    public partial class collaboratorLogin : Form
    {
        public List<string> reservedSeats = new List<string>();
        public string KindOfMovie = "";
        public collaboratorLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 15;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            if (isValid())
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= " + path + @"\Database1.mdf;Integrated Security=True"))
                {
                    string query = "SELECT * FROM Login WHERE Username = '" + txtUserName.Text.Trim() +
                        "' AND Password = '" + txtPassword.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if (dta.Rows.Count == 1)
                        {
                        movieChoice movie = new movieChoice(KindOfMovie, reservedSeats);
                        this.Hide();
                        movie.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Onjuiste inloggegevens!");
                    }
                }
            }
            
        }

        private bool isValid()
        {
            if (txtUserName.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Voer de juiste gebruikersnaam in a.u.b.", "Error");
                return false;

            } else if (txtPassword.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Voer de juiste wachtwoord in a.u.b.", "Error");
                return false;
            }
            return true;
        }
    }
}
