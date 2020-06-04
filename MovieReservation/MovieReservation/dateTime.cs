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
        public static int RoomIndex;
        public static string[] MovieTime;
        public static int indexDay;
        public static int indexTime;
        public static string[][] RoomDayTimeArray = new string[5][];
        public static List<string>[][] ReservedList;
        public List<string> reservedSeats;
        public static bool checkMakingList;
        public int countDate = 0;
        public int countTime = 0;
        public static string Title = "";
        public static string Genre;
        public static string Age;
        public static string PictureName;
        public static string Description;
        public static string Time;
        public static string Date;
        public static string KindOfMovie;
        public static string[][] RoomTimeArray = new string[7][];
        public string[] TimeArray = new string[] { "09:12", "09:06", "09:15", "09:09", "09:03", "09:20", "09:17", "09:08", "11:22", "11:18", "11:43", "11:39", "10:59", "11:30", "11:47", "11:21", "13:52", "13:14", "13:53", "13:54", "13:27", "13:26", "14:15", "13:41", "16:12", "16:05", "17:54", "16:34", "16:27", "16:08", "18:16", "16:41", "18:54", "19:05", "20:14", "19:25", "20:28", "20:09", "20:26", "19:08", "21:04", "21:30", "22:18", "21:52", "22:39", "22:34", "22:37", "21:12", "23:27", "23:31", "00:28", "00:17", "00:43", "00:53", "01:07", "23:57"};

        public dateTime(string title, string genre, string age, string pictureName, string description, string kindofmovie, List<string> reservedSeats, string[] movieTime)
        {
            InitializeComponent();

            foreach (var item in reservedSeats.ToList())
            {
                ReservedList[indexDay][indexTime].Add(item);
            }
            MovieTime = movieTime;
            this.reservedSeats = reservedSeats;
            Title = title;
            Genre = genre;
            Age = age;
            PictureName = pictureName;
            Description = description;
            KindOfMovie = kindofmovie;

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
            dateTimePicker1.MaxDate = DateTime.Today.AddDays(5);

        }
        public void comboboxSetTime(DateTime date, DateTime datenow)
        {
            for (int i = 0; i < MovieTime.Length; i++)
            {
                DateTime test = DateTime.Parse(MovieTime[i]);
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

        public int ManageDay(DateTime date)
        {
            DateTime[] dateArray = new DateTime[] { DateTime.Today, DateTime.Today.AddDays(1), DateTime.Today.AddDays(2), DateTime.Today.AddDays(3), DateTime.Today.AddDays(4), DateTime.Today.AddDays(5) };
            for (int index = 0; index < dateArray.Length; index++)
            {
                if (date == dateArray[index])
                {
                    return index;
                }
            }
            return 0;
        }
        public int ManageTime(string time)
        {
            for (int index = 0; index < TimeArray.Length; index++)
            {
                if (time == TimeArray[index])
                {
                    return index;
                }
            }
            return 0;
        }
        public int ManageRoom()
        {
            if (indexTime % 8 == 0) { return 8; }
            if (indexTime % 7 == 0) { return 7; }
            if (indexTime % 6 == 0) { return 6; }
            if (indexTime % 5 == 0) { return 5; }
            if (indexTime % 4 == 0) { return 4; }
            if (indexTime % 3 == 0) { return 3; }
            if (indexTime % 2 == 0) { return 2; }
            else { return 1; }
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
                RoomIndex = ManageRoom();
                if (Age == "16")
                {
                    Ticket tk = new Ticket(ReservedList[indexDay][indexTime], RoomIndex);
                    this.Hide();
                    tk.ShowDialog();
                    this.Close();
                }
                else
                {
                    TicketIfNot16 tk16 = new TicketIfNot16(ReservedList[indexDay][indexTime], RoomIndex);
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
        private void datePicker(object sender, EventArgs e)
        {
            countDate += 1;
            comboBox2.Items.Clear();
            comboboxSetTime(dateTimePicker1.Value.Date, DateTime.Today);
            indexDay = ManageDay(dateTimePicker1.Value.Date);
        }

        private void TimePicker(object sender, EventArgs e)
        {
            countTime += 1;
            indexTime = ManageTime(comboBox2.Text);
            int index = indexTime;
        }

        private void previousPage_Click(object sender, EventArgs e)
        {
            movieChoice mc = new movieChoice(KindOfMovie, ReservedList[indexDay][indexTime]);
            this.Hide();
            mc.ShowDialog();
            this.Close();
        }

        private void dateTime_Load(object sender, EventArgs e)
        {

            comboboxSetTime(DateTime.Today, DateTime.Today);
            if (!checkMakingList)
            {
                for (int i = 0; i < RoomTimeArray.Length; i++)
                {
                    RoomTimeArray[i] = new string[48];
                    for (int j = 0; j < RoomTimeArray.Length; j++)
                    {
                        RoomTimeArray[i][j] = TimeArray[j];
                    }
                }
                for (int x = 0; x < RoomTimeArray.Length; x++)
                {
                    RoomTimeArray[x] = new string[8];
                    for (int z = 0; z < RoomTimeArray[x].Length; z++)
                    {
                        RoomTimeArray[x][z] = TimeArray[z];
                    }
                }
                List<string>[] list1 = new List<string>[56];
                List<string>[] list2 = new List<string>[56];
                List<string>[] list3 = new List<string>[56];
                List<string>[] list4 = new List<string>[56];
                List<string>[] list5 = new List<string>[56];
                List<string>[] list6 = new List<string>[56];
                for (int y = 0; y < list1.Length; y++)
                {
                    list1[y] = new List<string>();
                    list2[y] = new List<string>();
                    list3[y] = new List<string>();
                    list4[y] = new List<string>();
                    list5[y] = new List<string>();
                    list6[y] = new List<string>();
                }
                List<string>[][] reservedList = new List<string>[][] { list1, list2, list3, list4, list5, list6 };
                ReservedList = reservedList;
                checkMakingList = true;
            }
            // welke dag het is geklikt geef index daar van en index van tijd controleer welke zaal
        }
    }
}
