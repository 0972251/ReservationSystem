using System;
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
        public string KindOfMovie = "";
        public collaboratorLogin()
        {
            InitializeComponent();
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
            if (isValid())
            {
                conn = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= %CONTENTROOTPATH%/Database1.mdf;Integrated Security=True"
                    Cqlconnection connect = new SqlConnection(conn);
                    if conn.contains("%CONTENTROOTPATH%");
{
                    conn = conn.replace("%CONTENTROOTPATH%", "C:\Users\almin\Desktop\GitHub\MovieReservation\MovieReservation\")
}
                string query = "SELECT * FROM Login WHERE Username = '" + txtUserName.Text.Trim() +
                        "' AND Password = '" + txtPassword.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if (dta.Rows.Count == 1)
                        {
                        movieChoice movie = new movieChoice(KindOfMovie);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
