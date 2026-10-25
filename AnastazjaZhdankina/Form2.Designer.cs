namespace AnastazjaZhdankina
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pochodna = new System.Windows.Forms.TextBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.slowoKlucz = new System.Windows.Forms.GroupBox();
            this.nowyObiekt = new System.Windows.Forms.ComboBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.picOcena = new System.Windows.Forms.PictureBox();
            this.herm = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nieZwraca = new System.Windows.Forms.ListBox();
            this.refer = new System.Windows.Forms.ComboBox();
            this.dostep = new System.Windows.Forms.GroupBox();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb6 = new System.Windows.Forms.CheckBox();
            this.cb7 = new System.Windows.Forms.CheckBox();
            this.cb8 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.przeciaz = new System.Windows.Forms.TextBox();
            this.wynik = new System.Windows.Forms.Label();
            this.sprawdz = new System.Windows.Forms.Button();
            this.typyDanych = new System.Windows.Forms.GroupBox();
            this.cechyKonstr = new System.Windows.Forms.GroupBox();
            this.slowoKlucz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOcena)).BeginInit();
            this.dostep.SuspendLayout();
            this.typyDanych.SuspendLayout();
            this.cechyKonstr.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F);
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 71);
            this.label1.TabIndex = 3;
            this.label1.Text = "Które słowo czy znak kluczowe służy do dziedziczenia klasy w C#?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pochodna
            // 
            this.pochodna.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pochodna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pochodna.Font = new System.Drawing.Font("Verdana", 10F);
            this.pochodna.Location = new System.Drawing.Point(49, 933);
            this.pochodna.Name = "pochodna";
            this.pochodna.Size = new System.Drawing.Size(402, 32);
            this.pochodna.TabIndex = 4;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Verdana", 9F);
            this.rb1.Location = new System.Drawing.Point(51, 49);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(82, 26);
            this.rb1.TabIndex = 5;
            this.rb1.TabStop = true;
            this.rb1.Text = "using";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Verdana", 9F);
            this.rb2.Location = new System.Drawing.Point(51, 94);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(65, 26);
            this.rb2.TabIndex = 6;
            this.rb2.TabStop = true;
            this.rb2.Text = "=>";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Verdana", 9F);
            this.rb3.Location = new System.Drawing.Point(236, 49);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(43, 26);
            this.rb3.TabIndex = 7;
            this.rb3.TabStop = true;
            this.rb3.Text = ":";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Verdana", 9F);
            this.rb4.Location = new System.Drawing.Point(236, 94);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(106, 26);
            this.rb4.TabIndex = 8;
            this.rb4.TabStop = true;
            this.rb4.Text = "extends";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // slowoKlucz
            // 
            this.slowoKlucz.Controls.Add(this.rb1);
            this.slowoKlucz.Controls.Add(this.rb4);
            this.slowoKlucz.Controls.Add(this.rb2);
            this.slowoKlucz.Controls.Add(this.rb3);
            this.slowoKlucz.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.slowoKlucz.Location = new System.Drawing.Point(44, 123);
            this.slowoKlucz.Name = "slowoKlucz";
            this.slowoKlucz.Size = new System.Drawing.Size(407, 155);
            this.slowoKlucz.TabIndex = 9;
            this.slowoKlucz.TabStop = false;
            // 
            // nowyObiekt
            // 
            this.nowyObiekt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nowyObiekt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nowyObiekt.FormattingEnabled = true;
            this.nowyObiekt.Items.AddRange(new object[] {
            "create",
            "new",
            "make",
            "static"});
            this.nowyObiekt.Location = new System.Drawing.Point(44, 710);
            this.nowyObiekt.Name = "nowyObiekt";
            this.nowyObiekt.Size = new System.Drawing.Size(407, 30);
            this.nowyObiekt.TabIndex = 9;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb1.Location = new System.Drawing.Point(56, 42);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(87, 26);
            this.cb1.TabIndex = 10;
            this.cb1.Text = "string";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // picOcena
            // 
            this.picOcena.Location = new System.Drawing.Point(1394, 868);
            this.picOcena.Name = "picOcena";
            this.picOcena.Size = new System.Drawing.Size(100, 100);
            this.picOcena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOcena.TabIndex = 11;
            this.picOcena.TabStop = false;
            // 
            // herm
            // 
            this.herm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.herm.FormattingEnabled = true;
            this.herm.ItemHeight = 22;
            this.herm.Items.AddRange(new object[] {
            "Hermetyzacja (Enkapsulacja)",
            "Polimorfizm",
            "Abstrakcja",
            "Delegowanie"});
            this.herm.Location = new System.Drawing.Point(44, 460);
            this.herm.Name = "herm";
            this.herm.Size = new System.Drawing.Size(407, 92);
            this.herm.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F);
            this.label2.Location = new System.Drawing.Point(44, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 99);
            this.label2.TabIndex = 13;
            this.label2.Text = "Jak nazywa się ukrywanie pól danej klasy dla innych klas, elementów (w programie " +
    "głównym)?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F);
            this.label3.Location = new System.Drawing.Point(575, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 73);
            this.label3.TabIndex = 14;
            this.label3.Text = "Metoda, która nic nie zwraca, ma w sygnaturze słowo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F);
            this.label4.Location = new System.Drawing.Point(575, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 73);
            this.label4.TabIndex = 20;
            this.label4.Text = "Który typ danych jest typem referencyjnym?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F);
            this.label5.Location = new System.Drawing.Point(44, 603);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(407, 71);
            this.label5.TabIndex = 19;
            this.label5.Text = "Jakim słowem kluczowym tworzymy nowy obiekt klasy?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nieZwraca
            // 
            this.nieZwraca.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nieZwraca.FormattingEnabled = true;
            this.nieZwraca.ItemHeight = 22;
            this.nieZwraca.Items.AddRange(new object[] {
            "empty",
            "null",
            "void",
            "none"});
            this.nieZwraca.Location = new System.Drawing.Point(575, 460);
            this.nieZwraca.Name = "nieZwraca";
            this.nieZwraca.Size = new System.Drawing.Size(407, 92);
            this.nieZwraca.TabIndex = 18;
            // 
            // refer
            // 
            this.refer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.refer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refer.FormattingEnabled = true;
            this.refer.Items.AddRange(new object[] {
            "int",
            "bool",
            "double",
            "string"});
            this.refer.Location = new System.Drawing.Point(575, 710);
            this.refer.Name = "refer";
            this.refer.Size = new System.Drawing.Size(407, 30);
            this.refer.TabIndex = 16;
            // 
            // dostep
            // 
            this.dostep.Controls.Add(this.rb5);
            this.dostep.Controls.Add(this.rb8);
            this.dostep.Controls.Add(this.rb6);
            this.dostep.Controls.Add(this.rb7);
            this.dostep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dostep.Location = new System.Drawing.Point(575, 137);
            this.dostep.Name = "dostep";
            this.dostep.Size = new System.Drawing.Size(407, 141);
            this.dostep.TabIndex = 17;
            this.dostep.TabStop = false;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("Verdana", 9F);
            this.rb5.Location = new System.Drawing.Point(57, 48);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(87, 26);
            this.rb5.TabIndex = 5;
            this.rb5.TabStop = true;
            this.rb5.Text = "public";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Font = new System.Drawing.Font("Verdana", 9F);
            this.rb8.Location = new System.Drawing.Point(234, 90);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(83, 26);
            this.rb8.TabIndex = 8;
            this.rb8.TabStop = true;
            this.rb8.Text = "static";
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Font = new System.Drawing.Font("Verdana", 9F);
            this.rb6.Location = new System.Drawing.Point(57, 90);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(99, 26);
            this.rb6.TabIndex = 6;
            this.rb6.TabStop = true;
            this.rb6.Text = "private";
            this.rb6.UseVisualStyleBackColor = true;
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Font = new System.Drawing.Font("Verdana", 9F);
            this.rb7.Location = new System.Drawing.Point(234, 48);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(121, 26);
            this.rb7.TabIndex = 7;
            this.rb7.TabStop = true;
            this.rb7.Text = "protected";
            this.rb7.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F);
            this.label6.Location = new System.Drawing.Point(575, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(407, 112);
            this.label6.TabIndex = 15;
            this.label6.Text = "Który modyfikator dostępu sprawia, że zmienną można użyć tylko przy pozwoleniu kl" +
    "asy, w której się znajduje?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F);
            this.label7.Location = new System.Drawing.Point(1128, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(367, 98);
            this.label7.TabIndex = 21;
            this.label7.Text = "Które typy danych najlepiej nadają się do przechowywania wieku?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb2.Location = new System.Drawing.Point(56, 94);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(70, 26);
            this.cb2.TabIndex = 22;
            this.cb2.Text = "uint";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb4.Location = new System.Drawing.Point(234, 94);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(96, 26);
            this.cb4.TabIndex = 23;
            this.cb4.Text = "double";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb3.Location = new System.Drawing.Point(234, 42);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(59, 26);
            this.cb3.TabIndex = 24;
            this.cb3.Text = "int";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Verdana", 10F);
            this.label8.Location = new System.Drawing.Point(1128, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(367, 73);
            this.label8.TabIndex = 26;
            this.label8.Text = "Wskaż poprawne cechy konstruktora:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb5
            // 
            this.cb5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb5.Location = new System.Drawing.Point(19, 26);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(362, 56);
            this.cb5.TabIndex = 25;
            this.cb5.Text = "Może być wiele konstruktorów w jednej klasie";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // cb6
            // 
            this.cb6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb6.Location = new System.Drawing.Point(19, 106);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(372, 56);
            this.cb6.TabIndex = 27;
            this.cb6.Text = "Nie posiada zwracanego typu danych";
            this.cb6.UseVisualStyleBackColor = true;
            // 
            // cb7
            // 
            this.cb7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb7.Location = new System.Drawing.Point(19, 187);
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size(362, 56);
            this.cb7.TabIndex = 28;
            this.cb7.Text = "Nie musi mieć taką samą nazwę jak klasa";
            this.cb7.UseVisualStyleBackColor = true;
            // 
            // cb8
            // 
            this.cb8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb8.Location = new System.Drawing.Point(19, 249);
            this.cb8.Name = "cb8";
            this.cb8.Size = new System.Drawing.Size(362, 93);
            this.cb8.TabIndex = 29;
            this.cb8.Text = "Jest wywoływany automatycznie podczas tworzenia nowego obiektu";
            this.cb8.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Verdana", 10F);
            this.label9.Location = new System.Drawing.Point(44, 793);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(407, 104);
            this.label9.TabIndex = 30;
            this.label9.Text = "Klasa, z której dziedziczymy, to klasa bazowa, a klasa, która dziedziczy, to klas" +
    "a:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Verdana", 10F);
            this.label10.Location = new System.Drawing.Point(555, 787);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(450, 147);
            this.label10.TabIndex = 32;
            this.label10.Text = "Jak nazywa się mechanizm, który pozwala na zdefiniowanie w tej samej klasie wielu" +
    " metod o tej samej nazwie, ale z różną liczbą lub rodzajem parametrów?";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // przeciaz
            // 
            this.przeciaz.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.przeciaz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.przeciaz.Font = new System.Drawing.Font("Verdana", 10F);
            this.przeciaz.Location = new System.Drawing.Point(555, 960);
            this.przeciaz.Name = "przeciaz";
            this.przeciaz.Size = new System.Drawing.Size(450, 32);
            this.przeciaz.TabIndex = 31;
            // 
            // wynik
            // 
            this.wynik.BackColor = System.Drawing.Color.Coral;
            this.wynik.Font = new System.Drawing.Font("Verdana", 10F);
            this.wynik.Location = new System.Drawing.Point(1084, 868);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(242, 137);
            this.wynik.TabIndex = 33;
            this.wynik.Text = "wynik";
            this.wynik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sprawdz
            // 
            this.sprawdz.BackColor = System.Drawing.Color.Plum;
            this.sprawdz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sprawdz.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sprawdz.Location = new System.Drawing.Point(1133, 787);
            this.sprawdz.Name = "sprawdz";
            this.sprawdz.Size = new System.Drawing.Size(362, 50);
            this.sprawdz.TabIndex = 34;
            this.sprawdz.Text = "Sprawdź się";
            this.sprawdz.UseVisualStyleBackColor = false;
            this.sprawdz.Click += new System.EventHandler(this.sprawdz_Click);
            // 
            // typyDanych
            // 
            this.typyDanych.Controls.Add(this.cb3);
            this.typyDanych.Controls.Add(this.cb1);
            this.typyDanych.Controls.Add(this.cb2);
            this.typyDanych.Controls.Add(this.cb4);
            this.typyDanych.Location = new System.Drawing.Point(1123, 123);
            this.typyDanych.Name = "typyDanych";
            this.typyDanych.Size = new System.Drawing.Size(372, 147);
            this.typyDanych.TabIndex = 35;
            this.typyDanych.TabStop = false;
            // 
            // cechyKonstr
            // 
            this.cechyKonstr.Controls.Add(this.cb5);
            this.cechyKonstr.Controls.Add(this.cb6);
            this.cechyKonstr.Controls.Add(this.cb7);
            this.cechyKonstr.Controls.Add(this.cb8);
            this.cechyKonstr.Location = new System.Drawing.Point(1113, 398);
            this.cechyKonstr.Name = "cechyKonstr";
            this.cechyKonstr.Size = new System.Drawing.Size(405, 353);
            this.cechyKonstr.TabIndex = 36;
            this.cechyKonstr.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1578, 1044);
            this.Controls.Add(this.cechyKonstr);
            this.Controls.Add(this.typyDanych);
            this.Controls.Add(this.sprawdz);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.przeciaz);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nieZwraca);
            this.Controls.Add(this.refer);
            this.Controls.Add(this.dostep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.herm);
            this.Controls.Add(this.nowyObiekt);
            this.Controls.Add(this.picOcena);
            this.Controls.Add(this.slowoKlucz);
            this.Controls.Add(this.pochodna);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1600, 1100);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anastazja Zhdankina";
            this.slowoKlucz.ResumeLayout(false);
            this.slowoKlucz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOcena)).EndInit();
            this.dostep.ResumeLayout(false);
            this.dostep.PerformLayout();
            this.typyDanych.ResumeLayout(false);
            this.typyDanych.PerformLayout();
            this.cechyKonstr.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pochodna;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.GroupBox slowoKlucz;
        private System.Windows.Forms.ComboBox nowyObiekt;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.PictureBox picOcena;
        private System.Windows.Forms.ListBox herm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox nieZwraca;
        private System.Windows.Forms.ComboBox refer;
        private System.Windows.Forms.GroupBox dostep;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox cb6;
        private System.Windows.Forms.CheckBox cb7;
        private System.Windows.Forms.CheckBox cb8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox przeciaz;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.Button sprawdz;
        private System.Windows.Forms.GroupBox typyDanych;
        private System.Windows.Forms.GroupBox cechyKonstr;
    }
}