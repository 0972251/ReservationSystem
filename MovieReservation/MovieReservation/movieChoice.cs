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
    public partial class movieChoice : Form
    {
        public movieChoice()
        {
            InitializeComponent();

            label3.Text = "No Time to Die";
            label2.Text = "Wonder Woman";
            label4.Text = "Bloodshot";
            label5.Text = "Mulan";
            label6.Text = "Sonic";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void actieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //newMovie.BringToFront();
        }

        private void actieToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //action.BringToFront();
        }

        private void comedyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Comedy.BringToFront();
        }

        private void turksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Turks.BringToFront();
        }

        private void bollywoodToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Bolywood.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string Name = "No Time to Die";
            string Genre = "actie";
            string AgeLimit = "12";
            string Picture = "afb1";
            string Beschrijving = "In de 25e James Bond-film No Time to Die heeft James Bond zijn turbulente leven\nals geheim agent achter zich gelaten en leidt hij een rustig bestaan op Jamaica.\nDit wordt abrupt onderbroken wanneer zijn oude vriend en CIA agent Felix Leiter\nhem vraagt om een ontvoerde wetenschapper te helpen bevrijden. Deze missie\nblijkt verraderlijker dan gedacht en brengt Bond op het spoor van een mysterieuze\nschurk die gewapend is met levensgevaarlijke nieuwe technologie. In No Time to Die\nkeert Daniel Craig terug voor zijn vijfde film als Ian Flemings James Bond 007. De cast\nbestaat verder uit Rami Malek, Léa Seydoux, Lashana Lynch, Ben Whishaw, Naomie Harris,\nBilly Magnussen, Ana de Armas, Rory Kinnear, David Dencik, Dali Benssalah, Jeffrey Wright\nen Ralph Fiennes. Deze co-productie van Albert R. Broccoli’s EON Productions,\nMetro Goldwyn Mayer Studios (MGM) en Universal Pictures International is geregisseerd\ndoor Cary Joji Fukunaga (Beasts of No Nation, True Detective). Het scenario is geschreven\ndoor Neal Purvis & Robert Wade (Spectre, Skyfall), Cary Joji Fukunaga, Scott Z. Burns\n(Contagion, The Bourne Ultimatum) en Phoebe Waller-Bridge (Killing Eve, Fleabag).";

            dateTime dt = new dateTime(Name, Genre, AgeLimit, Picture, Beschrijving);
            this.Hide();
            dt.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string Name = "Wonder Woman";
            string Genre = "actie";
            string AgeLimit = "12";
            string Picture = "afb2";
            string Beschrijving = "We maken een sprong naar de jaren 80 voor Wonder Woman’s volgende avontuur\nop het witte doek waarin ze tegenover twee geheel nieuwe vijanden staat: Max Lord\nen The Cheetah. Met wederom Patty Jenkins als regisseur en Gal Gadot in de hoofdrol\nis Wonder Woman 1984 het vervolg op de eerste film met deze DC-superheld,\nWonder Woman uit 2017, die records heeft gebroken en wereldwijd 822 miljoen dollar\nheeft opgebracht.";

            dateTime dt = new dateTime(Name, Genre, AgeLimit, Picture, Beschrijving);
            this.Hide();
            dt.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string Name = "Bloodshot";
            string Genre = "actie";
            string AgeLimit = "16";
            string Picture = "afb3";
            string Beschrijving = "In deze verfilming van de populaire gelijknamige comic speelt Vin Diesel de rol\nvan Ray Garrison, een marinier die door de RTS Corporation opnieuw tot leven\ngewekt wordt als de superheld Bloodshot. Met nanotechnologie in zijn aderen\nis hij sterker dan ooit en geneest hij meteen van verwondingen. De RTS\nCorporation heeft niet alleen de controle over zijn lichaam, maar ook\nover zijn geest en herinneringen. Ray zet alles op het spel om de controle\nover zijn leven terug te krijgen.";

            dateTime dt = new dateTime(Name, Genre, AgeLimit, Picture, Beschrijving);
            this.Hide();
            dt.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string Name = "Mulan";
            string Genre = "actie";
            string AgeLimit = "6";
            string Picture = "afb4";
            string Beschrijving = "Geprezen filmmaker Niki Caro brengt het epische verhaal van de legendarische\nkrijger van China tot leven in Disney's Mulan, waarin een heldhaftige jonge\nvrouw uit liefde voor haar familie en haar land, alles riskeert om een ​​van de\ngrootste krijgers te worden die China ooit heeft gekend. Wanneer de keizer van\nChina besluit dat één man per gezin moet dienen in het keizerlijke leger, om het\nland te kunnen verdedigen tegen indringers uit het Noorden, neemt Hua Mulan,\nde oudste dochter van een respectabele krijger, de in het geheim de plaats van\nhaar zieke vader in. Gemaskeerd als man, Hua Jun, wordt ze bij elke training\ngetest en gebruikt ze haar innerlijke kracht om haar ware potentie te kunnen\nomarmen. Het is een epische reis die haar zal veranderen in een krijger en\nhaar het respect zal opleveren voor een dankbare natie ... en een trotse vader.";

            dateTime dt = new dateTime(Name, Genre, AgeLimit, Picture, Beschrijving);
            this.Hide();
            dt.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string Name = "Sonic";
            string Genre = "actie";
            string AgeLimit = "All";
            string Picture = "afb8";
            string Beschrijving = "Sonic is het nieuwe live-action avontuur gebaseerd op de populaire\nSega videogame franchise. Sonic en zijn nieuwe beste vriend Tom\nproberen samen de slechterik Dr. Robotnik te stoppen en de wereld\nte redden.";

            dateTime dt = new dateTime(Name, Genre, AgeLimit, Picture, Beschrijving);
            this.Hide();
            dt.ShowDialog();
            this.Close();
        }

        private void movieChoice_Load(object sender, EventArgs e)
        {
            Image image1 = Image.FromFile(@"C:\ReservationSystem\MovieReservation\MoviePictures\afb1.png");
            this.pictureBox1.Image = image1;

            Image image2 = Image.FromFile(@"C:\ReservationSystem\MovieReservation\MoviePictures\afb2.png");
            this.pictureBox2.Image = image2;

            Image image3 = Image.FromFile(@"C:\ReservationSystem\MovieReservation\MoviePictures\afb3.png");
            this.pictureBox3.Image = image3;

            Image image4 = Image.FromFile(@"C:\ReservationSystem\MovieReservation\MoviePictures\afb4.png");
            this.pictureBox4.Image = image4;

            Image image5 = Image.FromFile(@"C:\ReservationSystem\MovieReservation\MoviePictures\afb8.png");
            this.pictureBox5.Image = image5;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
