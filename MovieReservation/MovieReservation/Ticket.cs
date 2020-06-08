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
        public string Title = dateTime.Title;
        public string Genre = dateTime.Genre;
        public string Age = dateTime.Age;
        public string PictureName = dateTime.PictureName;
        public string Description = dateTime.Description;
        public string KindOfMovie = dateTime.KindOfMovie;
        public int RoomIndex;
        public List<string> reservedSeats;


        public Ticket(List<string> reservedSeats, int roomIndex)
        {
            InitializeComponent();
            this.reservedSeats = reservedSeats;
            RoomIndex = roomIndex;

            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image image1 = Image.FromFile(path + @"\MoviePictures\" + PictureName + ".png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(path + @"\MoviePictures\" + Genre + ".png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(path + @"\MoviePictures\" + Age + ".png");
            this.pictureBox3.Image = image3;

            label1.Text = Title;
            FindSeat.Enabled = false;
        }

        private void nextPage_Click(object sender, EventArgs e)
        {

            // hier stuur je de speciale zalen

            int Normaal = int.Parse(comboBox1.Text);
            int Student = int.Parse(comboBox2.Text);
            int Senior = int.Parse(comboBox4.Text);

            int totalSeats = Normaal + Student + Senior;

            if (totalSeats > 9)
            {
                MessageBox.Show("U mag niet meer dan 9 tickets reserveren");
            }
            else if (totalSeats < 1)
            {
                MessageBox.Show("U moet minstens 1 ticket reserveren");
            }
            else
            {
                if (RoomIndex == 1)
                {
                    Room room = new Room(totalSeats, reservedSeats);
                    this.Hide();
                    room.ShowDialog();
                    this.Close();
                }
                if (RoomIndex == 2)
                {
                    Room2 room = new Room2(totalSeats, reservedSeats);
                    this.Hide();
                    room.ShowDialog();
                    this.Close();
                }
                if (RoomIndex == 3)
                {
                    Room3 room = new Room3(totalSeats, reservedSeats);
                    this.Hide();
                    room.ShowDialog();
                    this.Close();
                }
                if (RoomIndex == 4)
                {
                    Room4 room = new Room4(totalSeats, reservedSeats);
                    this.Hide();
                    room.ShowDialog();
                    this.Close();
                }
                if (RoomIndex == 5)
                {
                    RoomDolby room = new RoomDolby(totalSeats, reservedSeats);
                    this.Hide();
                    room.ShowDialog();
                    this.Close();
                }
                if (RoomIndex == 6)
                {
                    Room4DX room = new Room4DX(totalSeats, reservedSeats);
                    this.Hide();
                    room.ShowDialog();
                    this.Close();
                }
                if (RoomIndex == 7)
                {
                    Room3D room = new Room3D(totalSeats, reservedSeats);
                    this.Hide();
                    room.ShowDialog();
                    this.Close();
                }
                if (RoomIndex == 8)
                {
                    RoomIMAX room = new RoomIMAX(totalSeats, reservedSeats);
                    this.Hide();
                    room.ShowDialog();
                    this.Close();
                }
                // welke zaal moet gestuurt worden
                
            }

            
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            dateTime dt = new dateTime(Title, Genre, Age, PictureName, Description, KindOfMovie, reservedSeats, dateTime.MovieTime);
            this.Hide();
            dt.ShowDialog();
            this.Close();
            
        }

        private void ageCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                FindSeat.Enabled = false;
            }
            else
            {
                FindSeat.Enabled = true;
            }
            
        }
    }
}
