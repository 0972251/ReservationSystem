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
    public partial class dateTime : Form
    {
        public int countDate = 0;
        public int countTime = 0;
        public string Title;
        public string Genre;
        public string Age;
        public string PictureName;
        public string Description;
        public string Time;
        public string Date;
        public string KindOfMovie;
        public List<string> reservedSeats = new List<string>();
        public string[] TimeArray = new string[] { "09:00", "11:30", "14:00", "21:00", "23:00" };
        public dateTime(string title, string genre, string age, string pictureName, string description, string kindofmovie, List<string> reserve)
        {
            InitializeComponent();

            Title = title;
            Genre = genre;
            Age = age;
            PictureName = pictureName;
            Description = description;
            KindOfMovie = kindofmovie;
            reservedSeats = reserve;


            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            Image imagePicture = Image.FromFile(path + @"\MoviePictures\" + PictureName + ".png");
            this.pictureBoxMovie.Image = imagePicture;

            Image imageGenre = Image.FromFile(path + @"\MoviePictures\" + Genre + ".png");
            this.pictureBoxAge.Image = imageGenre;

            Image imageAge = Image.FromFile(path + @"\MoviePictures\" + Age + ".png");
            this.pictureBoxClassification.Image = imageAge;
 
            labelTitle.Text = Title;
            labelDescription.Text = Description;
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = new DateTime(2028, 6, 20);



/*            DateTime time1 = DateTime.Now;
            string i = "10:00";
            string j = "20:00";
            DateTime test = DateTime.Parse(i);
            DateTime testj = DateTime.Parse(j);
            string test1 = removeDateFromDate(test);
            string test2 = removeDateFromDate(testj);
            comboBox2.Items.Add(test1);
            comboBox2.Items.Add(test2);

            result = DateTime.Compare(DateTime.Now, test);*/


        }
        public void comboboxSetTime(DateTime date, DateTime datenow)
        {
            for (int i = 0; i < TimeArray.Length; i++)
            {
                DateTime test = DateTime.Parse(TimeArray[i]);
                string test1 = removeDateFromDate(test);
      
                int result = DateTime.Compare(DateTime.Now, test);
                if (result >= 1 && DateTime.Today == date)
                {

                    comboBox2.Items.Remove(test1);
                }
                else
                {
                    comboBox2.Items.Add(test1);
                }
            }
        }

        public string removeDateFromDate(DateTime time)
        {
            return time.ToString().Substring(9, 5);
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            Date = dateTimePicker1.Text;
            Time = comboBox2.Text;

            if (countDate >= 1 && countTime >= 1)
            {
                if (Age == "16")
                {
                    Ticket tk = new Ticket(Title, Genre, Age, PictureName, Description, Date, Time, KindOfMovie, reservedSeats);
                    this.Hide();
                    tk.ShowDialog();
                    this.Close();
                }
                else
                {
                    TicketIfNot16 tk16 = new TicketIfNot16(Title, Genre, Age, PictureName, Description, Date, Time, KindOfMovie, reservedSeats);
                    this.Hide();
                    tk16.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Je moet nog een datum of tijd kiezen");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            countDate += 1;
            comboBox2.Items.Clear();
            comboboxSetTime(dateTimePicker1.Value.Date, DateTime.Today);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            countTime += 1;
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            movieChoice mc = new movieChoice(KindOfMovie, reservedSeats);
            this.Hide();
            mc.ShowDialog();
            this.Close();
        }
    }
}
