namespace AnastazjaZhdankina
{
    partial class Form3
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grafika = new System.Windows.Forms.ListBox();
            this.label = new System.Windows.Forms.ComboBox();
            this.kursor = new System.Windows.Forms.GroupBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.kolorTla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wlasciwosci = new System.Windows.Forms.ListBox();
            this.location = new System.Windows.Forms.ComboBox();
            this.grupa = new System.Windows.Forms.GroupBox();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wyrownanie = new System.Windows.Forms.GroupBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb7 = new System.Windows.Forms.CheckBox();
            this.cb6 = new System.Windows.Forms.CheckBox();
            this.cb8 = new System.Windows.Forms.CheckBox();
            this.tekst = new System.Windows.Forms.GroupBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sprawdz = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.Label();
            this.picOcena = new System.Windows.Forms.PictureBox();
            this.kursor.SuspendLayout();
            this.grupa.SuspendLayout();
            this.wyrownanie.SuspendLayout();
            this.tekst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOcena)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Thistle;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F);
            this.label5.Location = new System.Drawing.Point(42, 592);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(407, 109);
            this.label5.TabIndex = 25;
            this.label5.Text = "Jakiej kontrolki użyć, aby wyświetlić na formie krótki tekst, którego użytkownik " +
    "nie może edytować?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F);
            this.label2.Location = new System.Drawing.Point(42, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 134);
            this.label2.TabIndex = 24;
            this.label2.Text = "W jakim folderze wewnątrz projektu standardowo przechowywane są ikony i grafiki d" +
    "ostępne przez Properties.Resources?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grafika
            // 
            this.grafika.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grafika.FormattingEnabled = true;
            this.grafika.ItemHeight = 22;
            this.grafika.Items.AddRange(new object[] {
            "bin",
            "obj",
            "Resources",
            "Settings"});
            this.grafika.Location = new System.Drawing.Point(42, 467);
            this.grafika.Name = "grafika";
            this.grafika.Size = new System.Drawing.Size(407, 92);
            this.grafika.TabIndex = 23;
            // 
            // label
            // 
            this.label.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.FormattingEnabled = true;
            this.label.Items.AddRange(new object[] {
            "TextBox",
            "Button",
            "RichTextBox",
            "Label"});
            this.label.Location = new System.Drawing.Point(42, 730);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(407, 30);
            this.label.TabIndex = 21;
            // 
            // kursor
            // 
            this.kursor.Controls.Add(this.rb1);
            this.kursor.Controls.Add(this.rb4);
            this.kursor.Controls.Add(this.rb2);
            this.kursor.Controls.Add(this.rb3);
            this.kursor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kursor.Location = new System.Drawing.Point(42, 144);
            this.kursor.Name = "kursor";
            this.kursor.Size = new System.Drawing.Size(407, 141);
            this.kursor.TabIndex = 22;
            this.kursor.TabStop = false;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Verdana", 9F);
            this.rb1.Location = new System.Drawing.Point(53, 42);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(99, 26);
            this.rb1.TabIndex = 5;
            this.rb1.TabStop = true;
            this.rb1.Text = "Pointer";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Verdana", 9F);
            this.rb4.Location = new System.Drawing.Point(238, 87);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(81, 26);
            this.rb4.TabIndex = 8;
            this.rb4.TabStop = true;
            this.rb4.Text = "Style";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Verdana", 9F);
            this.rb2.Location = new System.Drawing.Point(53, 87);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(131, 26);
            this.rb2.TabIndex = 6;
            this.rb2.TabStop = true;
            this.rb2.Text = "MouseIcon";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Verdana", 9F);
            this.rb3.Location = new System.Drawing.Point(238, 42);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(95, 26);
            this.rb3.TabIndex = 7;
            this.rb3.TabStop = true;
            this.rb3.Text = "Cursor";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F);
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 98);
            this.label1.TabIndex = 20;
            this.label1.Text = "Jaką właściwość zmienić, aby po najechaniu myszką na przycisk, strzałka zmieniła " +
    "się w \"rączkę\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Thistle;
            this.label10.Font = new System.Drawing.Font("Verdana", 10F);
            this.label10.Location = new System.Drawing.Point(553, 791);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(450, 104);
            this.label10.TabIndex = 36;
            this.label10.Text = "Które zdarzenie wykonuje się jako pierwsze po uruchomieniu aplikacji, ale jeszcze" +
    " przed wyświetleniem okna?";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.load.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.load.Font = new System.Drawing.Font("Verdana", 10F);
            this.load.Location = new System.Drawing.Point(553, 931);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(450, 32);
            this.load.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Thistle;
            this.label9.Font = new System.Drawing.Font("Verdana", 10F);
            this.label9.Location = new System.Drawing.Point(42, 791);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(407, 104);
            this.label9.TabIndex = 34;
            this.label9.Text = "Która właściwość pozwala zmienić kolor tła kontrolki lub całego formularza?";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kolorTla
            // 
            this.kolorTla.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kolorTla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kolorTla.Font = new System.Drawing.Font("Verdana", 10F);
            this.kolorTla.Location = new System.Drawing.Point(47, 931);
            this.kolorTla.Name = "kolorTla";
            this.kolorTla.Size = new System.Drawing.Size(402, 32);
            this.kolorTla.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Thistle;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F);
            this.label4.Location = new System.Drawing.Point(569, 608);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 73);
            this.label4.TabIndex = 42;
            this.label4.Text = "Właściwość Location określa położenie kontrolki względem:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wlasciwosci
            // 
            this.wlasciwosci.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wlasciwosci.FormattingEnabled = true;
            this.wlasciwosci.ItemHeight = 22;
            this.wlasciwosci.Items.AddRange(new object[] {
            "Przybornik",
            "Właściwości",
            "Eksplorator rozwiązań",
            "Lista błędów"});
            this.wlasciwosci.Location = new System.Drawing.Point(569, 467);
            this.wlasciwosci.Name = "wlasciwosci";
            this.wlasciwosci.Size = new System.Drawing.Size(407, 92);
            this.wlasciwosci.TabIndex = 41;
            // 
            // location
            // 
            this.location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.location.FormattingEnabled = true;
            this.location.Items.AddRange(new object[] {
            "Środka ekranu",
            "Lewego górnego rogu formy",
            "Prawego dolnego rogu formy",
            "Kursora myszy"});
            this.location.Location = new System.Drawing.Point(569, 717);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(407, 30);
            this.location.TabIndex = 39;
            // 
            // grupa
            // 
            this.grupa.Controls.Add(this.rb5);
            this.grupa.Controls.Add(this.rb8);
            this.grupa.Controls.Add(this.rb6);
            this.grupa.Controls.Add(this.rb7);
            this.grupa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grupa.Location = new System.Drawing.Point(569, 144);
            this.grupa.Name = "grupa";
            this.grupa.Size = new System.Drawing.Size(407, 141);
            this.grupa.TabIndex = 40;
            this.grupa.TabStop = false;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("Verdana", 9F);
            this.rb5.Location = new System.Drawing.Point(28, 41);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(84, 26);
            this.rb5.TabIndex = 5;
            this.rb5.TabStop = true;
            this.rb5.Text = "Panel";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Font = new System.Drawing.Font("Verdana", 9F);
            this.rb8.Location = new System.Drawing.Point(246, 83);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(132, 26);
            this.rb8.TabIndex = 8;
            this.rb8.TabStop = true;
            this.rb8.Text = "TabControl";
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Font = new System.Drawing.Font("Verdana", 9F);
            this.rb6.Location = new System.Drawing.Point(28, 83);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(186, 26);
            this.rb6.TabIndex = 6;
            this.rb6.TabStop = true;
            this.rb6.Text = "FlowLayoutPanel";
            this.rb6.UseVisualStyleBackColor = true;
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Font = new System.Drawing.Font("Verdana", 9F);
            this.rb7.Location = new System.Drawing.Point(246, 41);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(124, 26);
            this.rb7.TabIndex = 7;
            this.rb7.TabStop = true;
            this.rb7.Text = "GroupBox";
            this.rb7.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Thistle;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F);
            this.label6.Location = new System.Drawing.Point(569, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(407, 112);
            this.label6.TabIndex = 38;
            this.label6.Text = "Która kontrolka służy do wizualnego grupowania innych kontrolek i posiada obramow" +
    "anie z opcjonalnym tytułem?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F);
            this.label3.Location = new System.Drawing.Point(569, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 108);
            this.label3.TabIndex = 37;
            this.label3.Text = "Jak nazywa się okno w Visual Studio, w którym zmieniamy kolory, czcionki i nazwy " +
    "kontrolek?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wyrownanie
            // 
            this.wyrownanie.Controls.Add(this.cb5);
            this.wyrownanie.Controls.Add(this.cb7);
            this.wyrownanie.Controls.Add(this.cb6);
            this.wyrownanie.Controls.Add(this.cb8);
            this.wyrownanie.Location = new System.Drawing.Point(1091, 448);
            this.wyrownanie.Name = "wyrownanie";
            this.wyrownanie.Size = new System.Drawing.Size(405, 167);
            this.wyrownanie.TabIndex = 46;
            this.wyrownanie.TabStop = false;
            // 
            // cb5
            // 
            this.cb5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb5.Location = new System.Drawing.Point(39, 26);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(142, 56);
            this.cb5.TabIndex = 25;
            this.cb5.Text = "TextAlign";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // cb7
            // 
            this.cb7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb7.Location = new System.Drawing.Point(239, 26);
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size(149, 56);
            this.cb7.TabIndex = 27;
            this.cb7.Text = "RightToLeft";
            this.cb7.UseVisualStyleBackColor = true;
            // 
            // cb6
            // 
            this.cb6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb6.Location = new System.Drawing.Point(39, 88);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(142, 56);
            this.cb6.TabIndex = 28;
            this.cb6.Text = "AutoSize";
            this.cb6.UseVisualStyleBackColor = true;
            // 
            // cb8
            // 
            this.cb8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb8.Location = new System.Drawing.Point(239, 88);
            this.cb8.Name = "cb8";
            this.cb8.Size = new System.Drawing.Size(122, 56);
            this.cb8.TabIndex = 29;
            this.cb8.Text = "Dock";
            this.cb8.UseVisualStyleBackColor = true;
            // 
            // tekst
            // 
            this.tekst.Controls.Add(this.cb3);
            this.tekst.Controls.Add(this.cb1);
            this.tekst.Controls.Add(this.cb2);
            this.tekst.Controls.Add(this.cb4);
            this.tekst.Location = new System.Drawing.Point(1101, 144);
            this.tekst.Name = "tekst";
            this.tekst.Size = new System.Drawing.Size(372, 147);
            this.tekst.TabIndex = 45;
            this.tekst.TabStop = false;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb3.Location = new System.Drawing.Point(234, 42);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(73, 26);
            this.cb3.TabIndex = 24;
            this.cb3.Text = "Size";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb1.Location = new System.Drawing.Point(56, 42);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(124, 26);
            this.cb1.TabIndex = 10;
            this.cb1.Text = "ForeColor";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb2.Location = new System.Drawing.Point(56, 94);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(75, 26);
            this.cb2.TabIndex = 22;
            this.cb2.Text = "Font";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb4.Location = new System.Drawing.Point(234, 94);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(89, 26);
            this.cb4.TabIndex = 23;
            this.cb4.Text = "Name";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Thistle;
            this.label8.Font = new System.Drawing.Font("Verdana", 10F);
            this.label8.Location = new System.Drawing.Point(1091, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(405, 132);
            this.label8.TabIndex = 44;
            this.label8.Text = "Które właściwości pozwalają wyrównać tekst do środka, do prawej lub do lewej stro" +
    "ny wewnątrz kontrolki?";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Thistle;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F);
            this.label7.Location = new System.Drawing.Point(1101, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(372, 98);
            this.label7.TabIndex = 43;
            this.label7.Text = "Które z poniższych właściwości pozwalają zmienić wygląd tekstu w kontrolce?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sprawdz
            // 
            this.sprawdz.BackColor = System.Drawing.Color.MediumPurple;
            this.sprawdz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sprawdz.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sprawdz.Location = new System.Drawing.Point(1111, 683);
            this.sprawdz.Name = "sprawdz";
            this.sprawdz.Size = new System.Drawing.Size(362, 50);
            this.sprawdz.TabIndex = 49;
            this.sprawdz.Text = "Sprawdź się";
            this.sprawdz.UseVisualStyleBackColor = false;
            this.sprawdz.Click += new System.EventHandler(this.sprawdz_Click);
            // 
            // wynik
            // 
            this.wynik.BackColor = System.Drawing.Color.Coral;
            this.wynik.Font = new System.Drawing.Font("Verdana", 10F);
            this.wynik.Location = new System.Drawing.Point(1069, 781);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(242, 137);
            this.wynik.TabIndex = 48;
            this.wynik.Text = "wynik";
            this.wynik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picOcena
            // 
            this.picOcena.Location = new System.Drawing.Point(1379, 781);
            this.picOcena.Name = "picOcena";
            this.picOcena.Size = new System.Drawing.Size(100, 100);
            this.picOcena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOcena.TabIndex = 47;
            this.picOcena.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 1044);
            this.Controls.Add(this.sprawdz);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.picOcena);
            this.Controls.Add(this.wyrownanie);
            this.Controls.Add(this.tekst);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wlasciwosci);
            this.Controls.Add(this.location);
            this.Controls.Add(this.grupa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.load);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.kolorTla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grafika);
            this.Controls.Add(this.label);
            this.Controls.Add(this.kursor);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1600, 1100);
            this.Name = "Form3";
            this.Text = "Anastazja Zhdankina";
            this.kursor.ResumeLayout(false);
            this.kursor.PerformLayout();
            this.grupa.ResumeLayout(false);
            this.grupa.PerformLayout();
            this.wyrownanie.ResumeLayout(false);
            this.tekst.ResumeLayout(false);
            this.tekst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOcena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox grafika;
        private System.Windows.Forms.ComboBox label;
        private System.Windows.Forms.GroupBox kursor;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox load;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox kolorTla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox wlasciwosci;
        private System.Windows.Forms.ComboBox location;
        private System.Windows.Forms.GroupBox grupa;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox wyrownanie;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox cb7;
        private System.Windows.Forms.CheckBox cb6;
        private System.Windows.Forms.CheckBox cb8;
        private System.Windows.Forms.GroupBox tekst;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button sprawdz;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.PictureBox picOcena;
    }
}