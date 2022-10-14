namespace Phosotshop_AP
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Odczyt_obrazka = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.B_jasnosc = new System.Windows.Forms.Button();
            this.Jasnosc = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Negatyw = new System.Windows.Forms.Button();
            this.Transformacja_potegowa = new System.Windows.Forms.Button();
            this.Potegowa_numeric = new System.Windows.Forms.NumericUpDown();
            this.Odczytaj_img2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Suma = new System.Windows.Forms.Button();
            this.Odejmowanie = new System.Windows.Forms.Button();
            this.Roznica = new System.Windows.Forms.Button();
            this.Mnozenie = new System.Windows.Forms.Button();
            this.Odw_mnozenie = new System.Windows.Forms.Button();
            this.Negacja = new System.Windows.Forms.Button();
            this.Ciemniejsze = new System.Windows.Forms.Button();
            this.Jasniejsze = new System.Windows.Forms.Button();
            this.Wylaczenie = new System.Windows.Forms.Button();
            this.Ostre_swiatlo = new System.Windows.Forms.Button();
            this.Lagodne_swiatlo = new System.Windows.Forms.Button();
            this.Rozcienczanie = new System.Windows.Forms.Button();
            this.Wypalanie = new System.Windows.Forms.Button();
            this.Reflect_mode = new System.Windows.Forms.Button();
            this.Przezroczystosc_num = new System.Windows.Forms.NumericUpDown();
            this.Przezroczystosc = new System.Windows.Forms.Button();
            this.Kontrast_num = new System.Windows.Forms.NumericUpDown();
            this.Kontrast = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.Filtr = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Jasnosc)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Potegowa_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Przezroczystosc_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kontrast_num)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.Odczytaj_img2);
            this.panel1.Controls.Add(this.Odczyt_obrazka);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1480, 50);
            this.panel1.TabIndex = 0;
            // 
            // Odczyt_obrazka
            // 
            this.Odczyt_obrazka.Location = new System.Drawing.Point(626, 12);
            this.Odczyt_obrazka.Name = "Odczyt_obrazka";
            this.Odczyt_obrazka.Size = new System.Drawing.Size(75, 23);
            this.Odczyt_obrazka.TabIndex = 0;
            this.Odczyt_obrazka.Text = "Odczytaj img";
            this.Odczyt_obrazka.UseVisualStyleBackColor = true;
            this.Odczyt_obrazka.Click += new System.EventHandler(this.Odczyt_obrazka_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.Filtr);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.Kontrast);
            this.panel2.Controls.Add(this.Kontrast_num);
            this.panel2.Controls.Add(this.Przezroczystosc);
            this.panel2.Controls.Add(this.Przezroczystosc_num);
            this.panel2.Controls.Add(this.Reflect_mode);
            this.panel2.Controls.Add(this.Wypalanie);
            this.panel2.Controls.Add(this.Rozcienczanie);
            this.panel2.Controls.Add(this.Lagodne_swiatlo);
            this.panel2.Controls.Add(this.Ostre_swiatlo);
            this.panel2.Controls.Add(this.Wylaczenie);
            this.panel2.Controls.Add(this.Jasniejsze);
            this.panel2.Controls.Add(this.Ciemniejsze);
            this.panel2.Controls.Add(this.Negacja);
            this.panel2.Controls.Add(this.Odw_mnozenie);
            this.panel2.Controls.Add(this.Mnozenie);
            this.panel2.Controls.Add(this.Roznica);
            this.panel2.Controls.Add(this.Odejmowanie);
            this.panel2.Controls.Add(this.Suma);
            this.panel2.Controls.Add(this.Potegowa_numeric);
            this.panel2.Controls.Add(this.Transformacja_potegowa);
            this.panel2.Controls.Add(this.Negatyw);
            this.panel2.Controls.Add(this.B_jasnosc);
            this.panel2.Controls.Add(this.Jasnosc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 797);
            this.panel2.TabIndex = 1;
            // 
            // B_jasnosc
            // 
            this.B_jasnosc.Location = new System.Drawing.Point(99, 27);
            this.B_jasnosc.Name = "B_jasnosc";
            this.B_jasnosc.Size = new System.Drawing.Size(75, 20);
            this.B_jasnosc.TabIndex = 1;
            this.B_jasnosc.Text = "Jasnosc";
            this.B_jasnosc.UseVisualStyleBackColor = true;
            this.B_jasnosc.Click += new System.EventHandler(this.B_jasnosc_Click);
            // 
            // Jasnosc
            // 
            this.Jasnosc.Location = new System.Drawing.Point(12, 27);
            this.Jasnosc.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Jasnosc.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.Jasnosc.Name = "Jasnosc";
            this.Jasnosc.Size = new System.Drawing.Size(81, 20);
            this.Jasnosc.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(198, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 797);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(590, 660);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(843, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(637, 797);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(25, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(591, 660);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Negatyw
            // 
            this.Negatyw.Location = new System.Drawing.Point(99, 53);
            this.Negatyw.Name = "Negatyw";
            this.Negatyw.Size = new System.Drawing.Size(75, 25);
            this.Negatyw.TabIndex = 2;
            this.Negatyw.Text = "Negatyw";
            this.Negatyw.UseVisualStyleBackColor = true;
            this.Negatyw.Click += new System.EventHandler(this.Negatyw_Click);
            // 
            // Transformacja_potegowa
            // 
            this.Transformacja_potegowa.Location = new System.Drawing.Point(99, 84);
            this.Transformacja_potegowa.Name = "Transformacja_potegowa";
            this.Transformacja_potegowa.Size = new System.Drawing.Size(75, 25);
            this.Transformacja_potegowa.TabIndex = 3;
            this.Transformacja_potegowa.Text = "Potegowa";
            this.Transformacja_potegowa.UseVisualStyleBackColor = true;
            this.Transformacja_potegowa.Click += new System.EventHandler(this.Transformacja_potegowa_Click);
            // 
            // Potegowa_numeric
            // 
            this.Potegowa_numeric.DecimalPlaces = 2;
            this.Potegowa_numeric.Location = new System.Drawing.Point(12, 88);
            this.Potegowa_numeric.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Potegowa_numeric.Name = "Potegowa_numeric";
            this.Potegowa_numeric.Size = new System.Drawing.Size(81, 20);
            this.Potegowa_numeric.TabIndex = 4;
            // 
            // Odczytaj_img2
            // 
            this.Odczytaj_img2.Location = new System.Drawing.Point(707, 12);
            this.Odczytaj_img2.Name = "Odczytaj_img2";
            this.Odczytaj_img2.Size = new System.Drawing.Size(88, 23);
            this.Odczytaj_img2.TabIndex = 1;
            this.Odczytaj_img2.Text = "Odczytaj img2";
            this.Odczytaj_img2.UseVisualStyleBackColor = true;
            this.Odczytaj_img2.Click += new System.EventHandler(this.Odczytaj_img2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1447, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(12, 10);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(12, 114);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(75, 25);
            this.Suma.TabIndex = 5;
            this.Suma.Text = "Suma";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // Odejmowanie
            // 
            this.Odejmowanie.Location = new System.Drawing.Point(99, 114);
            this.Odejmowanie.Name = "Odejmowanie";
            this.Odejmowanie.Size = new System.Drawing.Size(83, 25);
            this.Odejmowanie.TabIndex = 6;
            this.Odejmowanie.Text = "Odejmowanie";
            this.Odejmowanie.UseVisualStyleBackColor = true;
            this.Odejmowanie.Click += new System.EventHandler(this.Odejmowanie_Click);
            // 
            // Roznica
            // 
            this.Roznica.Location = new System.Drawing.Point(12, 145);
            this.Roznica.Name = "Roznica";
            this.Roznica.Size = new System.Drawing.Size(75, 25);
            this.Roznica.TabIndex = 7;
            this.Roznica.Text = "Roznica";
            this.Roznica.UseVisualStyleBackColor = true;
            this.Roznica.Click += new System.EventHandler(this.Roznica_Click);
            // 
            // Mnozenie
            // 
            this.Mnozenie.Location = new System.Drawing.Point(99, 145);
            this.Mnozenie.Name = "Mnozenie";
            this.Mnozenie.Size = new System.Drawing.Size(75, 25);
            this.Mnozenie.TabIndex = 8;
            this.Mnozenie.Text = "Mnozenie";
            this.Mnozenie.UseVisualStyleBackColor = true;
            this.Mnozenie.Click += new System.EventHandler(this.Mnozenie_Click);
            // 
            // Odw_mnozenie
            // 
            this.Odw_mnozenie.Location = new System.Drawing.Point(12, 176);
            this.Odw_mnozenie.Name = "Odw_mnozenie";
            this.Odw_mnozenie.Size = new System.Drawing.Size(75, 25);
            this.Odw_mnozenie.TabIndex = 9;
            this.Odw_mnozenie.Text = "Odw_mnozenie";
            this.Odw_mnozenie.UseVisualStyleBackColor = true;
            this.Odw_mnozenie.Click += new System.EventHandler(this.Odw_mnozenie_Click);
            // 
            // Negacja
            // 
            this.Negacja.Location = new System.Drawing.Point(99, 176);
            this.Negacja.Name = "Negacja";
            this.Negacja.Size = new System.Drawing.Size(75, 25);
            this.Negacja.TabIndex = 10;
            this.Negacja.Text = "Negacja";
            this.Negacja.UseVisualStyleBackColor = true;
            this.Negacja.Click += new System.EventHandler(this.Negacja_Click);
            // 
            // Ciemniejsze
            // 
            this.Ciemniejsze.Location = new System.Drawing.Point(12, 207);
            this.Ciemniejsze.Name = "Ciemniejsze";
            this.Ciemniejsze.Size = new System.Drawing.Size(75, 25);
            this.Ciemniejsze.TabIndex = 11;
            this.Ciemniejsze.Text = "Ciemniejsze";
            this.Ciemniejsze.UseVisualStyleBackColor = true;
            this.Ciemniejsze.Click += new System.EventHandler(this.Ciemniejsze_Click);
            // 
            // Jasniejsze
            // 
            this.Jasniejsze.Location = new System.Drawing.Point(99, 207);
            this.Jasniejsze.Name = "Jasniejsze";
            this.Jasniejsze.Size = new System.Drawing.Size(75, 25);
            this.Jasniejsze.TabIndex = 12;
            this.Jasniejsze.Text = "Jasniejsze";
            this.Jasniejsze.UseVisualStyleBackColor = true;
            this.Jasniejsze.Click += new System.EventHandler(this.Jasniejsze_Click);
            // 
            // Wylaczenie
            // 
            this.Wylaczenie.Location = new System.Drawing.Point(12, 238);
            this.Wylaczenie.Name = "Wylaczenie";
            this.Wylaczenie.Size = new System.Drawing.Size(75, 25);
            this.Wylaczenie.TabIndex = 13;
            this.Wylaczenie.Text = "Wylaczenie";
            this.Wylaczenie.UseVisualStyleBackColor = true;
            this.Wylaczenie.Click += new System.EventHandler(this.Wylaczenie_Click);
            // 
            // Ostre_swiatlo
            // 
            this.Ostre_swiatlo.Location = new System.Drawing.Point(99, 238);
            this.Ostre_swiatlo.Name = "Ostre_swiatlo";
            this.Ostre_swiatlo.Size = new System.Drawing.Size(75, 25);
            this.Ostre_swiatlo.TabIndex = 14;
            this.Ostre_swiatlo.Text = "Ostre swiatlo";
            this.Ostre_swiatlo.UseVisualStyleBackColor = true;
            this.Ostre_swiatlo.Click += new System.EventHandler(this.Ostre_swiatlo_Click);
            // 
            // Lagodne_swiatlo
            // 
            this.Lagodne_swiatlo.Location = new System.Drawing.Point(0, 269);
            this.Lagodne_swiatlo.Name = "Lagodne_swiatlo";
            this.Lagodne_swiatlo.Size = new System.Drawing.Size(93, 25);
            this.Lagodne_swiatlo.TabIndex = 15;
            this.Lagodne_swiatlo.Text = "Lagodne swiatlo";
            this.Lagodne_swiatlo.UseVisualStyleBackColor = true;
            this.Lagodne_swiatlo.Click += new System.EventHandler(this.Lagodne_swiatlo_Click);
            // 
            // Rozcienczanie
            // 
            this.Rozcienczanie.Location = new System.Drawing.Point(99, 269);
            this.Rozcienczanie.Name = "Rozcienczanie";
            this.Rozcienczanie.Size = new System.Drawing.Size(93, 25);
            this.Rozcienczanie.TabIndex = 16;
            this.Rozcienczanie.Text = "Rozcienczanie";
            this.Rozcienczanie.UseVisualStyleBackColor = true;
            this.Rozcienczanie.Click += new System.EventHandler(this.button1_Click);
            // 
            // Wypalanie
            // 
            this.Wypalanie.Location = new System.Drawing.Point(12, 300);
            this.Wypalanie.Name = "Wypalanie";
            this.Wypalanie.Size = new System.Drawing.Size(75, 25);
            this.Wypalanie.TabIndex = 17;
            this.Wypalanie.Text = "Wypalanie";
            this.Wypalanie.UseVisualStyleBackColor = true;
            this.Wypalanie.Click += new System.EventHandler(this.Wypalanie_Click);
            // 
            // Reflect_mode
            // 
            this.Reflect_mode.Location = new System.Drawing.Point(99, 300);
            this.Reflect_mode.Name = "Reflect_mode";
            this.Reflect_mode.Size = new System.Drawing.Size(75, 25);
            this.Reflect_mode.TabIndex = 18;
            this.Reflect_mode.Text = "Reflect mode";
            this.Reflect_mode.UseVisualStyleBackColor = true;
            this.Reflect_mode.Click += new System.EventHandler(this.Reflect_mode_Click);
            // 
            // Przezroczystosc_num
            // 
            this.Przezroczystosc_num.DecimalPlaces = 2;
            this.Przezroczystosc_num.Location = new System.Drawing.Point(12, 336);
            this.Przezroczystosc_num.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Przezroczystosc_num.Name = "Przezroczystosc_num";
            this.Przezroczystosc_num.Size = new System.Drawing.Size(81, 20);
            this.Przezroczystosc_num.TabIndex = 19;
            // 
            // Przezroczystosc
            // 
            this.Przezroczystosc.Location = new System.Drawing.Point(99, 336);
            this.Przezroczystosc.Name = "Przezroczystosc";
            this.Przezroczystosc.Size = new System.Drawing.Size(93, 25);
            this.Przezroczystosc.TabIndex = 20;
            this.Przezroczystosc.Text = "Przezroczystosc";
            this.Przezroczystosc.UseVisualStyleBackColor = true;
            this.Przezroczystosc.Click += new System.EventHandler(this.Przezroczystosc_Click);
            // 
            // Kontrast_num
            // 
            this.Kontrast_num.Location = new System.Drawing.Point(12, 378);
            this.Kontrast_num.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.Kontrast_num.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.Kontrast_num.Name = "Kontrast_num";
            this.Kontrast_num.Size = new System.Drawing.Size(81, 20);
            this.Kontrast_num.TabIndex = 21;
            // 
            // Kontrast
            // 
            this.Kontrast.Location = new System.Drawing.Point(107, 378);
            this.Kontrast.Name = "Kontrast";
            this.Kontrast.Size = new System.Drawing.Size(75, 20);
            this.Kontrast.TabIndex = 22;
            this.Kontrast.Text = "Kontrast";
            this.Kontrast.UseVisualStyleBackColor = true;
            this.Kontrast.Click += new System.EventHandler(this.Kontrast_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 421);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(22, 20);
            this.textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 421);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(22, 20);
            this.textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(71, 421);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(22, 20);
            this.textBox3.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 447);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(22, 20);
            this.textBox4.TabIndex = 26;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(40, 447);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(22, 20);
            this.textBox5.TabIndex = 27;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(71, 447);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(22, 20);
            this.textBox6.TabIndex = 28;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(12, 473);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(22, 20);
            this.textBox7.TabIndex = 29;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(40, 473);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(22, 20);
            this.textBox8.TabIndex = 30;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(71, 473);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(22, 20);
            this.textBox9.TabIndex = 31;
            // 
            // Filtr
            // 
            this.Filtr.Location = new System.Drawing.Point(107, 446);
            this.Filtr.Name = "Filtr";
            this.Filtr.Size = new System.Drawing.Size(75, 20);
            this.Filtr.TabIndex = 32;
            this.Filtr.Text = "Filtr";
            this.Filtr.UseVisualStyleBackColor = true;
            this.Filtr.Click += new System.EventHandler(this.Filtr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 847);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Photoshop";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Jasnosc)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Potegowa_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Przezroczystosc_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kontrast_num)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Odczyt_obrazka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button B_jasnosc;
        private System.Windows.Forms.NumericUpDown Jasnosc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Negatyw;
        private System.Windows.Forms.Button Transformacja_potegowa;
        private System.Windows.Forms.NumericUpDown Potegowa_numeric;
        private System.Windows.Forms.Button Odczytaj_img2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Odejmowanie;
        private System.Windows.Forms.Button Roznica;
        private System.Windows.Forms.Button Mnozenie;
        private System.Windows.Forms.Button Odw_mnozenie;
        private System.Windows.Forms.Button Negacja;
        private System.Windows.Forms.Button Ciemniejsze;
        private System.Windows.Forms.Button Jasniejsze;
        private System.Windows.Forms.Button Wylaczenie;
        private System.Windows.Forms.Button Ostre_swiatlo;
        private System.Windows.Forms.Button Lagodne_swiatlo;
        private System.Windows.Forms.Button Rozcienczanie;
        private System.Windows.Forms.Button Wypalanie;
        private System.Windows.Forms.Button Reflect_mode;
        private System.Windows.Forms.Button Przezroczystosc;
        private System.Windows.Forms.NumericUpDown Przezroczystosc_num;
        private System.Windows.Forms.Button Kontrast;
        private System.Windows.Forms.NumericUpDown Kontrast_num;
        private System.Windows.Forms.Button Filtr;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

