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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        bool ValidujQuiz()
        {
            bool radioZaznaczone = false;
            if ((rb1.Checked || rb2.Checked || rb3.Checked || rb4.Checked) && (rb5.Checked || rb6.Checked || rb7.Checked || rb8.Checked)) radioZaznaczone = true;

            bool listZaznaczone = false;
            if (grafika.SelectedIndex != -1 && wlasciwosci.SelectedIndex != -1) listZaznaczone = true;

            bool comboZaznaczone = false;
            if (label.SelectedIndex != -1 && location.SelectedIndex != -1) comboZaznaczone = true;

            bool tekstWpisany = false;
            if (kolorTla.Text != "" && load.Text != "") tekstWpisany = true;

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
                foreach (System.Windows.Forms.RadioButton rb in kursor.Controls.OfType<System.Windows.Forms.RadioButton>())
                {
                    if (rb == rb3) rb.ForeColor = Color.Green;
                    else if (rb.Checked) rb.ForeColor = Color.Red;
                    else rb.ForeColor = Color.Black;
                }


                if (rb7.Checked) punkty++;
                foreach (System.Windows.Forms.RadioButton rb in grupa.Controls.OfType<System.Windows.Forms.RadioButton>())
                {
                    if (rb == rb7) rb.ForeColor = Color.Green;
                    else if (rb.Checked) rb.ForeColor = Color.Red;
                    else rb.ForeColor = Color.Black;
                }



                if (grafika.SelectedIndex == 2)
                {
                    punkty++;
                    grafika.BackColor = Color.LightGreen;
                }
                else grafika.BackColor = Color.LightPink;

                if (wlasciwosci.SelectedIndex == 1)
                {
                    punkty++;
                    wlasciwosci.BackColor = Color.LightGreen;
                }
                else wlasciwosci.BackColor = Color.LightPink;



                if (label.SelectedIndex == 3)
                {
                    punkty++;
                    label.BackColor = Color.LightGreen;
                }
                else label.BackColor = Color.LightPink;

                if (location.SelectedIndex == 1)
                {
                    punkty++;
                    location.BackColor = Color.LightGreen;
                }
                else location.BackColor = Color.LightPink;



                if (kolorTla.Text.Trim() == "BackColor")
                {
                    punkty += 2;
                    kolorTla.BackColor = Color.LightGreen;
                }
                else kolorTla.BackColor = Color.LightPink;

                if (load.Text.Trim() == "Load")
                {
                    punkty += 2;
                    load.BackColor = Color.LightGreen;
                }
                else load.BackColor = Color.LightPink;



                if (cb1.Checked && cb2.Checked && !cb3.Checked && !cb4.Checked) punkty += 2;
                foreach (System.Windows.Forms.CheckBox cb in tekst.Controls.OfType<System.Windows.Forms.CheckBox>())
                {
                    if (cb == cb1 || cb == cb2) cb.ForeColor = Color.Green;
                    else if (cb.Checked) cb.ForeColor = Color.Red;
                    else cb.ForeColor = Color.Black;
                }

                if (cb5.Checked && !cb6.Checked && cb7.Checked && !cb8.Checked) punkty += 2;
                foreach (System.Windows.Forms.CheckBox cb in wyrownanie.Controls.OfType<System.Windows.Forms.CheckBox>())
                {
                    if (cb == cb5 || cb == cb7) cb.ForeColor = Color.Green;
                    else if (cb.Checked) cb.ForeColor = Color.Red;
                    else cb.ForeColor = Color.Black;
                }


                WyswietlWynik(punkty, maxpunkty);
            }
        }
    }
}
