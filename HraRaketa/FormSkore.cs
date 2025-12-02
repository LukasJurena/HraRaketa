using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HraRaketa
{
    public partial class FormSkore : Form
    {
        public FormSkore()
        {
            InitializeComponent();
            string cesta = "Data Source=databaze.db";
        }

        private void button_NacistVysledky_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=databaze.db"))
            {
                conn.Open();

                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM ScoreLog ORDER BY Id DESC", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void button_VymazVysledky_Click(object sender, EventArgs e)
        {
            //potvrzovaci okenko
            DialogResult result = MessageBox.Show(
                "Opravdu chceš smazat všechny výsledky?",
                "Potvrzení",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=databaze.db"))
            {
                conn.Open();

                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM ScoreLog", conn);
                cmd.ExecuteNonQuery();

                SQLiteCommand cmd2 = new SQLiteCommand(
                    "DELETE FROM sqlite_sequence WHERE name='ScoreLog'", conn);
                cmd2.ExecuteNonQuery();
            }

            // vycisti tabulku
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            MessageBox.Show(
                "Výsledky byly úspěšně smazány.",
                "Hotovo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }
}
