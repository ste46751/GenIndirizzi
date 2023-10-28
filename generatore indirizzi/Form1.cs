using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generatore_indirizzi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Subnet(double bit_sotto)
        {
            double n = bit_sotto;
            string indirizzo = "";
            
            for (int i = 0; i < n; i++)
            {
                indirizzo += "1";
            }

            for (double i = n; i < 8; i++)
            {
                indirizzo += "0";
            }

            double valore = 0;
            double elevazione = 7;

            for (int i = 0; i < indirizzo.Length; i++)
            {
                double bit = Convert.ToInt32(indirizzo[i]);

                if (indirizzo[i] == '1')
                {
                    valore += Math.Pow(2, elevazione);
                }

                elevazione--;
            }

            return valore;
           
        }
        private void bttn_crea_Click(object sender, EventArgs e)
        {
            //CALCOLO CLASSE SOTTORETI
            int host = int.Parse(InputHost.Text);
            int sottoreti = int.Parse(InputSottoreti.Text);

            double CDIR;

            double bitRiservatiHost = Math.Ceiling(Math.Log(host, 2)); //BIT PARTE HOST
            double bitRiservatiSottoreti = Math.Ceiling(Math.Log(sottoreti, 2)); //BIT PARTE SOTTORETE

            double somma = bitRiservatiHost + bitRiservatiSottoreti;

            if (somma <= 8) //CLASSE C
            {

               lst_tabella.Items.Add("Classe C");
               lst_tabella.Items.Add("192.168.0.0");
               lst_tabella.Items.Add($"255.255.255.{ Subnet(bitRiservatiSottoreti)}");
                CDIR = 24 + bitRiservatiSottoreti;
                lst_tabella.Items.Add($"/{CDIR}");
            }
            else if (somma <= 16 && somma>8) //CLASSE B
            {
                lst_tabella.Items.Add("Classe B");
                lst_tabella.Items.Add("172.16.0.0");
                lst_tabella.Items.Add($"255.255.{Subnet(bitRiservatiSottoreti)}.0");
                CDIR = 16 + bitRiservatiSottoreti;
                lst_tabella.Items.Add($"/{CDIR}");
            }
            else if(somma>16)//CLASSE A
            {
                lst_tabella.Items.Add("Classe A");
                lst_tabella.Items.Add("10.0.0.0");
                lst_tabella.Items.Add($"255.{Subnet(bitRiservatiSottoreti)}.0.0");
                CDIR = 8 + bitRiservatiSottoreti;
                lst_tabella.Items.Add($"/{CDIR}");
            }
         }
    }
}

















































//Verso maggio con un paggio vo in viaggio. Non vaneggio, nè motteggio; forse è peggio! Se mi seggo, più non reggo: mangio o leggo. Se non fuggo qui mi struggo, ma se fuggo vado al poggio e un alloggio là mi foggio, sotto un faggio, con coraggio.