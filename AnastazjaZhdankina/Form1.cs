using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnastazjaZhdankina
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anastazja Zhdankina. Aplikacja do sprawdzenia wiedzy z zakresu progrowamowania", "Info");
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var odp = MessageBox.Show("Czy na pewno chcesz zamknąć aplikację?", "Potwierdzenie zamknięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (odp == DialogResult.Yes)
            {
                MessageBox.Show("Wybrałeś zamknięcie aplikacji.");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Dobra decyzja. Jeszcze możesz się nacieszyć tą aplikacją");
            }
        }

        bool Validuj(string im, string nazw)
        {
            if (im == "" || nazw == "")
            {
                MessageBox.Show("Pola imię i nazwisko nie mogą być puste!", "Błąd");
                return false;
            }

            bool tylkoLiteryI = true;
            bool tylkoLiteryN = true;
            foreach (char litera in im)
            {
                if (!((litera >= 'A' && litera <= 'Z') || (litera >= 'a' && litera <= 'z')))
                {
                    tylkoLiteryI = false;
                    break;
                }
            }
            foreach (char litera in nazw)
            {
                if (!((litera >= 'A' && litera <= 'Z') || (litera >= 'a' && litera <= 'z')))
                {
                    tylkoLiteryN = false;
                    break;
                }
            }

            if (!tylkoLiteryI || !tylkoLiteryN)
            {
                MessageBox.Show("Pola imię i nazwisko mogą zawierać tylko litery!", "Błąd");
                return false;
            }

            if (im.Length < 3 || nazw.Length < 3)
            {
                MessageBox.Show("Pola imię i nazwisko muszą zawierać przynajmniej 3 znaki!", "Błąd");
                return false;
            }

            return true;
        }

        private void obiektoweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Validuj(imie.Text, nazw.Text))
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void desktopoweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Validuj(imie.Text, nazw.Text))
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
        }
    }
}
