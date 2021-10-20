using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad
{
    public partial class Form1 : Form
    {///
        public struct osoba
        {
            public string imie_wartosc;
            public string nazwisko_wartosc;
            public DateTime data_i_czas;
        }
       
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            wybrany.Text = DateTime.Now.ToString("hh:mm");
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void kolejka_Click(object sender, EventArgs e)
        {
            kolejka.Text = "kolejka";
        }

        private void data_badania_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void wybrany_Click(object sender, EventArgs e)
        {
            osoba osoba1;
            osoba1.imie_wartosc = imie.Text;
            osoba1.nazwisko_wartosc = nazwisko.Text;
            osoba1.data_i_czas = daty.Value;
            

        }
    }
}
