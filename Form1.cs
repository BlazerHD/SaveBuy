using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveBuy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        short typ = 0; // Typ 0 ist weder Einnahme noch Ausgabe ; Typ 1 ist Einnahme ; Typ 2 ist Ausbgabe
        int betrag; //Kontostand
        int einnahme; //Einnahmen
        int ausgabe; //Ausgaben

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(/*@"C:\Users\pasch\Desktop\SaveBuy\Settings.txt"*/Application.StartupPath + @"\Settings.txt"))
            {
                betrag = Convert.ToInt16(System.IO.File.ReadAllText(/*@"C:\Users\pasch\Desktop\SaveBuy\Settings.txt"*/Application.StartupPath + @"\Settings.txt")); //Einlesen der damaligen Daten über den Betrag
            }
            else
            {

                betrag = 0;

            }

            lBetrag.Text = Convert.ToString(betrag);

        }

        private void bEinnahme_Click(object sender, EventArgs e)
        {

            typ = 1;
            if(eingabe1.Text != null)
            {

                einnahme = Convert.ToInt16(eingabe1.Text);

            }
            else
            {

                Console.Write("Error");

            }
            eingabe1.Text = null; //Zurücksetzen der Eingabe
            betrag = betrag + einnahme;
            lBetrag.Text = Convert.ToString(betrag);
            System.IO.File.WriteAllText(/*@"C:\Users\pasch\Desktop\SaveBuy\Settings.txt"*/Application.StartupPath + @"\Settings.txt", Convert.ToString(betrag)); //Datei wird mit dem jetzigen Betrag überschrieben

        }

        private void bAusgabe_Click(object sender, EventArgs e)
        {

            typ = 2;

            if (eingabe1.Text != null)
            {

                ausgabe = Convert.ToInt16(eingabe1.Text);

            }
            else
            {

                Console.Write("Error");

            }

            eingabe1.Text = null;
            betrag = betrag - ausgabe;
            lBetrag.Text = Convert.ToString(betrag);
            System.IO.File.WriteAllText(/*@"C:\Users\pasch\Desktop\SaveBuy\Settings.txt"*/Application.StartupPath + @"\Settings.txt", Convert.ToString(betrag));

        }

        private void eingabe1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

    }
}
