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
using System.Data.SQLite;

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
            //databaze
            string cesta = "Data Source=databaze.db";

            using (var conn = new SQLiteConnection(cesta))
            {
                conn.Open();

                string sql = @"CREATE TABLE IF NOT EXISTS ScoreLog (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Jmeno TEXT,
                    Skore INT,
                    Zivoty INT,
                    Palivo INT,
                    Datum TEXT
                  );";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            this.Load += Form1_Load;
            // Fokus hned na hrací plochu, moc to nefunguje bohuzel, neprisel jsem na to proc :(
            this.ActiveControl = hraciPlocha;
            hraciPlocha.Focus();
            //Zachycení pohybu rakety na stlačení kláves
            this.KeyPreview = true; //začne zachycovat klávesy
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
            this.KeyPress += (s, e) =>
            {
                if (ActiveControl is TextBox)
                    return; // povolit psaní do textboxů

                e.Handled = true; // jinak blokovat
            };

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
            //nastaveni rychlosti skrz trackbar
            trackBarRaketa.Scroll += (s, e) =>
            {
                raketaRychlost = trackBarRaketa.Value;
            };

            trackBarMeteorit.Scroll += (s, e) =>
            {
                meteoritRychlost = trackBarMeteorit.Value;
            };
            trackBarRaketa.Minimum = 5;
            trackBarRaketa.Maximum = 25;
            trackBarRaketa.Value = raketaRychlost; 

            trackBarMeteorit.Minimum = 5;
            trackBarMeteorit.Maximum = 25;
            trackBarMeteorit.Value = meteoritRychlost; 

            // obrázky životů z Designeru
            zivotyObrazky = new PictureBox[] { Zivot1, Zivot2, Zivot3 };
            // timer hry
            casovac = new Timer();
            casovac.Interval = 20; // ms
            casovac.Tick += GameLoop;
            buttonStart.Click += buttonStart_Click;
            buttonStop.Click += buttonStop_Click;
            buttonReset.Click += buttonReset_Click;
            trackBarRaketa.Scroll += (s, e) =>
            {
                raketaRychlost = trackBarRaketa.Value;
            };

            trackBarMeteorit.Scroll += (s, e) =>
            {
                meteoritRychlost = trackBarMeteorit.Value;
            };
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Nastaví fokus po vykreslení formuláře
            BeginInvoke(new Action(() =>
            {
                hraciPlocha.Focus();
                this.ActiveControl = hraciPlocha;
            }));
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // ignoruj klávesy, pokud je focus na textBoxu nebo trackbaru
            if (ActiveControl is TextBox || ActiveControl is TrackBar)
                return;
            if (e.KeyCode == Keys.Left)
            {
                pohybVlevo = true;
                e.Handled = true; // zabrání, aby klávesa neovládala ovládací prvky
            }
            if (e.KeyCode == Keys.Right)
            {
                pohybVpravo = true;
                e.Handled = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                pohybVlevo = false;
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                pohybVpravo = false;
                e.Handled = true;
            }
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
            UpdateUI();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxJmeno.Text))
            {
                MessageBox.Show(
                    "Před začátkem hry musíš vyplnit své jméno!",
                    "Chybějící jméno",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                textBoxJmeno.Focus();
                return; 
            }

            casovac.Start();
            hraciPlocha.Focus();
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            casovac.Stop();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            casovac.Stop();
            skore = 0;
            zivoty = 3;
            palivo = 100;
            foreach (var meteor in meteory)
            {
                ResetMeteor(meteor);
            }
            Raketa.Left = hraciPlocha.Width / 2 - Raketa.Width / 2;
            Raketa.Top = hraciPlocha.Height - Raketa.Height - 10;
            UpdateUI();
        }

        private void UpdateUI()
        {
            boxSkore.Text = skore.ToString();
            boxPalivo.Text = palivo.ToString();

            progressBarPalivo.Value = Math.Max(progressBarPalivo.Minimum, Math.Min(progressBarPalivo.Maximum, palivo));
            labelInfo.Text = $"Skóre: {skore} | Životy: {zivoty} | Palivo: {palivo}%";
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
                    UlozSkoreDoDatabaze();
                    var result = MessageBox.Show("Konec hry. Zkusíš to znovu? Skóre: " + skore, "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    { 
                        // Reset hry
                        skore = 0;
                        zivoty = 3;
                        palivo = 100;
                        foreach (var m in meteory)
                        {
                            ResetMeteor(m); //tady jsem zmenil nazev promenne skrz stejny nazev v bloku
                        }
                        Raketa.Left = hraciPlocha.Width / 2 - Raketa.Width / 2;
                        Raketa.Top = hraciPlocha.Height - Raketa.Height - 10;
                        UpdateUI();
                        casovac.Start();
                    }
                    else
                    {
                        this.Close();
                    }
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
        private void UlozSkoreDoDatabaze()
        {
            string cesta = "Data Source=databaze.db";

            using (SQLiteConnection conn = new SQLiteConnection(cesta))
            {
                conn.Open();

                string sql = "INSERT INTO ScoreLog (Jmeno, Skore, Zivoty, Palivo, Datum) VALUES (@j, @s, @z, @p, @d)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@j", textBoxJmeno.Text);
                    cmd.Parameters.AddWithValue("@s", skore);
                    cmd.Parameters.AddWithValue("@z", zivoty);
                    cmd.Parameters.AddWithValue("@p", palivo);
                    cmd.Parameters.AddWithValue("@d", DateTime.Now.ToString("dd.MM.yyyy HH:mm"));

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button_ZobrazVysledky_Click(object sender, EventArgs e)
        {
            FormSkore f = new FormSkore(); f.Show();
        }
    }
}
