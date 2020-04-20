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
    public partial class Ticket : Form
    {
        public string Name;
        public string Genre;
        public string AgeLimit;
        public string Picture;
        public string Description;

        public Ticket(string name, string genre, string ageLimit, string picture)
        {
            InitializeComponent();

            Name = name;
            Genre = genre;
            AgeLimit = ageLimit;
            Picture = picture;

            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image image1 = Image.FromFile(path + @"\MoviePictures\" + Picture + ".png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(path + @"\MoviePictures\" + Genre + ".png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(path + @"\MoviePictures\" + AgeLimit + ".png");
            this.pictureBox3.Image = image3;

            label1.Text = Name;

            if (ageLimit == "16")
            {
                checkBox1.Enabled = true;
                button2.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = false;
                button2.Enabled = true;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ticket1 = comboBox1.Text.ToString();
            string ticket2 = comboBox2.Text.ToString();
            string ticket4 = comboBox4.Text.ToString();

            int Normaal = int.Parse(ticket1);
            int Student = int.Parse(ticket2);
            int Senior = int.Parse(ticket4);

            int totalSeats = Normaal + Student + Senior;

            Room room = new Room(totalSeats);
            this.Hide();
            room.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTime dt = new dateTime(Name, Genre, AgeLimit, Picture, Description);
            this.Hide();
            dt.ShowDialog();
            this.Close();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
            
        }

        private void Ticket_Load(object sender, EventArgs e)
        {

        }
    }
}
