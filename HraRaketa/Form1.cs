using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Form1()
        {
            InitializeComponent();
            //Zachycení pohybu rakety na stlačení kláves
            this.KeyPreview = true; //začne zachycovat klávesy
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;

            //Inicializace rakety
            Raketa.Left = GroupbBox_hraciPlocha.Width / 2 - Raketa.Width / 2;
            Raketa.Right = GroupbBox_hraciPlocha.Width / 2 + Raketa.Width / 2;
        }
    }
}
