
namespace zad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imie = new System.Windows.Forms.TextBox();
            this.nazwa_badania = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dodawanie = new System.Windows.Forms.Button();
            this.usuwanie = new System.Windows.Forms.Button();
            this.wprowadz = new System.Windows.Forms.Button();
            this.dane = new System.Windows.Forms.TextBox();
            this.kolejka = new System.Windows.Forms.Label();
            this.poprzedni = new System.Windows.Forms.Label();
            this.wybrany = new System.Windows.Forms.Label();
            this.nastepny = new System.Windows.Forms.Label();
            this.dane_przed = new System.Windows.Forms.TextBox();
            this.dane_po = new System.Windows.Forms.TextBox();
            this.dane_wybrana = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.za_ile = new System.Windows.Forms.Label();
            this.jak_dawno = new System.Windows.Forms.Label();
            this.czas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imie
            // 
            this.imie.Location = new System.Drawing.Point(12, 12);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(100, 23);
            this.imie.TabIndex = 3;
            this.imie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nazwa_badania
            // 
            this.nazwa_badania.Location = new System.Drawing.Point(12, 41);
            this.nazwa_badania.Name = "nazwa_badania";
            this.nazwa_badania.Size = new System.Drawing.Size(100, 23);
            this.nazwa_badania.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dodawanie
            // 
            this.dodawanie.Location = new System.Drawing.Point(354, 12);
            this.dodawanie.Name = "dodawanie";
            this.dodawanie.Size = new System.Drawing.Size(75, 23);
            this.dodawanie.TabIndex = 7;
            this.dodawanie.Text = "Dodaj";
            this.dodawanie.UseVisualStyleBackColor = true;
            // 
            // usuwanie
            // 
            this.usuwanie.Location = new System.Drawing.Point(354, 40);
            this.usuwanie.Name = "usuwanie";
            this.usuwanie.Size = new System.Drawing.Size(75, 23);
            this.usuwanie.TabIndex = 8;
            this.usuwanie.Text = "Usuń";
            this.usuwanie.UseVisualStyleBackColor = true;
            // 
            // wprowadz
            // 
            this.wprowadz.Location = new System.Drawing.Point(354, 72);
            this.wprowadz.Name = "wprowadz";
            this.wprowadz.Size = new System.Drawing.Size(75, 23);
            this.wprowadz.TabIndex = 9;
            this.wprowadz.Text = "Wprowadź";
            this.wprowadz.UseVisualStyleBackColor = true;
            // 
            // dane
            // 
            this.dane.Location = new System.Drawing.Point(248, 27);
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(100, 23);
            this.dane.TabIndex = 10;
            this.dane.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // kolejka
            // 
            this.kolejka.AutoSize = true;
            this.kolejka.Location = new System.Drawing.Point(271, 9);
            this.kolejka.Name = "kolejka";
            this.kolejka.Size = new System.Drawing.Size(45, 15);
            this.kolejka.TabIndex = 11;
            this.kolejka.Text = "Kolejka";
            this.kolejka.Click += new System.EventHandler(this.kolejka_Click);
            // 
            // poprzedni
            // 
            this.poprzedni.AutoSize = true;
            this.poprzedni.Location = new System.Drawing.Point(13, 129);
            this.poprzedni.Name = "poprzedni";
            this.poprzedni.Size = new System.Drawing.Size(71, 15);
            this.poprzedni.TabIndex = 12;
            this.poprzedni.Text = "osoba przed";
            // 
            // wybrany
            // 
            this.wybrany.AutoSize = true;
            this.wybrany.Location = new System.Drawing.Point(13, 86);
            this.wybrany.Name = "wybrany";
            this.wybrany.Size = new System.Drawing.Size(29, 15);
            this.wybrany.TabIndex = 13;
            this.wybrany.Text = "czas";
            this.wybrany.Click += new System.EventHandler(this.wybrany_Click);
            // 
            // nastepny
            // 
            this.nastepny.AutoSize = true;
            this.nastepny.Location = new System.Drawing.Point(13, 217);
            this.nastepny.Name = "nastepny";
            this.nastepny.Size = new System.Drawing.Size(56, 15);
            this.nastepny.TabIndex = 14;
            this.nastepny.Text = "osoba po";
            // 
            // dane_przed
            // 
            this.dane_przed.Location = new System.Drawing.Point(12, 147);
            this.dane_przed.Name = "dane_przed";
            this.dane_przed.Size = new System.Drawing.Size(100, 23);
            this.dane_przed.TabIndex = 15;
            // 
            // dane_po
            // 
            this.dane_po.Location = new System.Drawing.Point(12, 235);
            this.dane_po.Name = "dane_po";
            this.dane_po.Size = new System.Drawing.Size(100, 23);
            this.dane_po.TabIndex = 16;
            // 
            // dane_wybrana
            // 
            this.dane_wybrana.Location = new System.Drawing.Point(13, 191);
            this.dane_wybrana.Name = "dane_wybrana";
            this.dane_wybrana.Size = new System.Drawing.Size(100, 23);
            this.dane_wybrana.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(12, 323);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 19;
            // 
            // za_ile
            // 
            this.za_ile.AutoSize = true;
            this.za_ile.Location = new System.Drawing.Point(12, 261);
            this.za_ile.Name = "za_ile";
            this.za_ile.Size = new System.Drawing.Size(66, 15);
            this.za_ile.TabIndex = 20;
            this.za_ile.Text = "Badanie za:";
            // 
            // jak_dawno
            // 
            this.jak_dawno.AutoSize = true;
            this.jak_dawno.Location = new System.Drawing.Point(13, 305);
            this.jak_dawno.Name = "jak_dawno";
            this.jak_dawno.Size = new System.Drawing.Size(73, 15);
            this.jak_dawno.TabIndex = 21;
            this.jak_dawno.Text = "Ile dni temu:";
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Location = new System.Drawing.Point(13, 71);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(50, 15);
            this.czas.TabIndex = 22;
            this.czas.Text = "Godzina";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 368);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.jak_dawno);
            this.Controls.Add(this.za_ile);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dane_wybrana);
            this.Controls.Add(this.dane_po);
            this.Controls.Add(this.dane_przed);
            this.Controls.Add(this.nastepny);
            this.Controls.Add(this.wybrany);
            this.Controls.Add(this.poprzedni);
            this.Controls.Add(this.kolejka);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.wprowadz);
            this.Controls.Add(this.usuwanie);
            this.Controls.Add(this.dodawanie);
            this.Controls.Add(this.nazwa_badania);
            this.Controls.Add(this.imie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.TextBox nazwa_badania;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button dodawanie;
        private System.Windows.Forms.Button usuwanie;
        private System.Windows.Forms.Button wprowadz;
        private System.Windows.Forms.TextBox dane;
        private System.Windows.Forms.Label kolejka;
        private System.Windows.Forms.Label poprzedni;
        private System.Windows.Forms.Label wybrany;
        private System.Windows.Forms.Label nastepny;
        private System.Windows.Forms.TextBox dane_przed;
        private System.Windows.Forms.TextBox dane_po;
        private System.Windows.Forms.TextBox dane_wybrana;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label za_ile;
        private System.Windows.Forms.Label jak_dawno;
        private System.Windows.Forms.Label czas;
    }
}

