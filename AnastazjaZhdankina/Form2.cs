using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AnastazjaZhdankina
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        bool ValidujQuiz()
        {
            bool radioZaznaczone = false;
            if ((rb1.Checked || rb2.Checked || rb3.Checked || rb4.Checked) && (rb5.Checked || rb6.Checked || rb7.Checked || rb8.Checked)) radioZaznaczone = true;

            bool listZaznaczone = false;
            if (herm.SelectedIndex != -1 && nieZwraca.SelectedIndex != -1) listZaznaczone = true;

            bool comboZaznaczone = false;
            if (nowyObiekt.SelectedIndex != -1 && refer.SelectedIndex != -1) comboZaznaczone = true;

            bool tekstWpisany = false;
            if (pochodna.Text != "" && przeciaz.Text != "") tekstWpisany = true;

            bool checkboxZaznaczone = false;
            if ((cb1.Checked || cb2.Checked || cb3.Checked || cb4.Checked) && (cb5.Checked || cb6.Checked || cb7.Checked || cb8.Checked)) checkboxZaznaczone = true;

            if (!radioZaznaczone || !listZaznaczone || !comboZaznaczone || !tekstWpisany || !checkboxZaznaczone)
            {
                MessageBox.Show("Proszę odpowiedzieć na wszystkie pytania przed sprawdzeniem!", "Błąd walidacji");
                return false;
            }
            return true;
        }

        void WyswietlWynik(int pkt, int max)
        {
            double procent = (double)pkt / max * 100;
            string ocena = "";

            if (procent == 100)
            {
                ocena = "Celujący";
                picOcena.Image = Properties.Resources.szesc;
            }
            else if (procent >= 90) 
            {
                ocena = "Bardzo dobry";
                picOcena.Image = Properties.Resources.piec;
            }
            else if (procent >= 75)
            {
                ocena = "Dobry";
                picOcena.Image = Properties.Resources.cztery;
            }
            else if (procent >= 55)
            {
                ocena = "Dostateczny";
                picOcena.Image = Properties.Resources.trzy;
            }
            else if (procent >= 40)
            {
                ocena = "Dopuszczający";
                picOcena.Image = Properties.Resources.dwa;
            }
            else
            {
                ocena = "Niedostateczny";
                picOcena.Image = Properties.Resources.jeden;
            }

            wynik.Text = $"Wynik: {pkt}/{max}, {procent:F2}%\nOcena: {ocena}";
        }

        private void sprawdz_Click(object sender, EventArgs e)
        {
            if (ValidujQuiz())
            {
                int punkty = 0, maxpunkty = 14;

                if (rb3.Checked) punkty++;
                foreach (System.Windows.Forms.RadioButton rb in slowoKlucz.Controls.OfType<System.Windows.Forms.RadioButton>())
                {
                    if (rb == rb3) rb.ForeColor = Color.Green;
                    else if (rb.Checked) rb.ForeColor = Color.Red;
                    else rb.ForeColor = Color.Black;
                }


                if (rb6.Checked) punkty++;
                foreach (System.Windows.Forms.RadioButton rb in dostep.Controls.OfType<System.Windows.Forms.RadioButton>())
                {
                    if (rb == rb6) rb.ForeColor = Color.Green;
                    else if (rb.Checked) rb.ForeColor = Color.Red;
                    else rb.ForeColor = Color.Black;
                }
                


                if (herm.SelectedIndex == 0)
                {
                    punkty++;
                    herm.BackColor = Color.LightGreen;
                }
                else herm.BackColor = Color.LightPink;

                if (nieZwraca.SelectedIndex == 2)
                {
                    punkty++;
                    nieZwraca.BackColor = Color.LightGreen;
                }
                else nieZwraca.BackColor = Color.LightPink;



                if (nowyObiekt.SelectedIndex == 1)
                {
                    punkty++;
                    nowyObiekt.BackColor = Color.LightGreen;
                }
                else nowyObiekt.BackColor = Color.LightPink;

                if (refer.SelectedIndex == 3)
                {
                    punkty++;
                    refer.BackColor = Color.LightGreen;
                }
                else refer.BackColor = Color.LightPink;



                if (pochodna.Text.Trim().ToLower() == "pochodna")
                {
                    punkty += 2;
                    pochodna.BackColor = Color.LightGreen;
                }
                else pochodna.BackColor = Color.LightPink;

                if (przeciaz.Text.Trim().ToLower() == "przeciążanie")
                {
                    punkty += 2;
                    przeciaz.BackColor = Color.LightGreen;
                }
                else przeciaz.BackColor = Color.LightPink;



                if (cb2.Checked && cb3.Checked && !cb1.Checked && !cb4.Checked) punkty += 2;
                foreach (System.Windows.Forms.CheckBox cb in typyDanych.Controls.OfType<System.Windows.Forms.CheckBox>())
                {
                    if (cb == cb2 || cb == cb3) cb.ForeColor = Color.Green;
                    else if (cb.Checked) cb.ForeColor = Color.Red;
                    else cb.ForeColor = Color.Black;
                }

                if (cb5.Checked && cb6.Checked && !cb7.Checked && cb8.Checked) punkty += 2;
                foreach (System.Windows.Forms.CheckBox cb in cechyKonstr.Controls.OfType<System.Windows.Forms.CheckBox>())
                {
                    if (cb == cb5 || cb == cb6 || cb == cb8) cb.ForeColor = Color.Green;
                    else if (cb.Checked) cb.ForeColor = Color.Red;
                    else cb.ForeColor = Color.Black;
                }


                WyswietlWynik(punkty, maxpunkty);
            }
        }
    }
}
