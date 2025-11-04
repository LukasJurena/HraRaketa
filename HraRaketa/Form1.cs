using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HraRaketa
{
    public partial class Form1 : Form
    {
        int raketaRychlost = 10;
        int meteoritRychlost = 10;
        int skore = 0;
        int zivoty = 3;
        int palivo = 100;
        Random rnd = new Random();

        bool pohybVlevo = false;
        bool pohybVpravo = false;

        PictureBox[] meteory;
        PictureBox[] zivotyObrazky;
        Timer casovac;

        public Form1()
        {
            InitializeComponent();
            //Zachycení pohybu rakety na stlačení kláves
            this.KeyPreview = true; //začne zachycovat klávesy
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;

            // inicializace rakety (používáme název z Designeru: hraciPlocha)
            Raketa.Left = hraciPlocha.Width / 2 - Raketa.Width / 2;
            Raketa.Top = hraciPlocha.Height - Raketa.Height - 10;

            // inicializace meteorů (Meteorit je vytvořen v Designeru)
            PictureBox meteor1 = Meteorit;
            PictureBox meteor2 = new PictureBox();
            meteor2.Size = meteor1.Size;
            meteor2.SizeMode = PictureBoxSizeMode.StretchImage;
            meteor2.Image = meteor1.Image;
            meteor2.Top = -Meteorit.Height;
            hraciPlocha.Controls.Add(meteor2);

            meteory = new PictureBox[] { meteor1, meteor2 };

            foreach (var meteor in meteory)
            {                 
                ResetMeteor(meteor);
            }

            // obrázky životů z Designeru
            zivotyObrazky = new PictureBox[] { Zivot1, Zivot2, Zivot3 };
            // timer hry
            casovac = new Timer();
            casovac.Interval = 20; // ms
            casovac.Tick += GameLoop;
            casovac.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) pohybVlevo = true;
            if (e.KeyCode == Keys.Right) pohybVpravo = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) pohybVlevo = false;
            if (e.KeyCode == Keys.Right) pohybVpravo = false;
        }

        private void GameLoop(object sender, EventArgs e)
        {
            // pohyb rakety
            if (pohybVlevo && Raketa.Left > 0 && palivo > 0)
            {
                Raketa.Left -= raketaRychlost;
                palivo--;
            }
            if (pohybVpravo && Raketa.Right < hraciPlocha.Width && palivo > 0)
            {
                Raketa.Left += raketaRychlost;
                palivo--;
            }
            palivo = Math.Max(0, palivo);
            // aktualizace meteorů
            for (int i = 0; i < meteory.Length; i++)
            {
                MoveMeteor(meteory[i]);
            }
            //aktualizace životů UI
            for (int i = 0; i < zivotyObrazky.Length; i++)
            {
                zivotyObrazky[i].Visible = i < zivoty;
            }
            //aktualizace UI
            boxSkore.Text = skore.ToString();
            boxPalivo.Text = palivo.ToString();
        }
        private void MoveMeteor(PictureBox meteor)
        {
            meteor.Top += meteoritRychlost;
            if (meteor.Bounds.IntersectsWith(Raketa.Bounds))
            {
                zivoty--;
                palivo = 100;
                ResetMeteor(meteor);

                if (zivoty <= 0)
                {
                    casovac.Stop();
                    MessageBox.Show("Konec hry. Skóre: " + skore, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            if (meteor.Top > hraciPlocha.Height)
            {
                ResetMeteor(meteor);
                skore++;
            }

        }

        private void ResetMeteor(PictureBox meteor)
        {
            meteor.Top = -meteor.Height;
            meteor.Left = rnd.Next(0,hraciPlocha.Width - meteor.Width);
        }

        /*
        private void ResetHru()
        {
            // jednoduchý reset stavů
            skore = 0;
            zivoty = 3;
            palivo = 100;
            Raketa.Left = hraciPlocha.Width / 2 - Raketa.Width / 2;
            foreach (var meteor in meteory)
            {
                ResetMeteor(meteor);
            }
            boxSkore.Text = skore.ToString();
            boxPalivo.Text = palivo.ToString();
            casovac.Start();
        }
        */
    }
}
