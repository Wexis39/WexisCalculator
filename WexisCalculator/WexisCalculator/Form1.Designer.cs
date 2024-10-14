namespace WexisCalculator
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
            panel1 = new Panel();
            lblCal = new Label();
            pictureBox1 = new PictureBox();
            lblError = new Label();
            lblHesaplama = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnTopla = new Button();
            btnClear = new Button();
            btn0 = new Button();
            btnNokta = new Button();
            btnEsittir = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnCikar = new Button();
            btnKaresi = new Button();
            btn7 = new Button();
            btnKareKok = new Button();
            btnBolme = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnCarp = new Button();
            btnSilme = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 240, 210);
            panel1.Controls.Add(lblCal);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(lblHesaplama);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 154);
            panel1.TabIndex = 3;
            // 
            // lblCal
            // 
            lblCal.AutoSize = true;
            lblCal.Font = new Font("Bahnschrift Condensed", 23.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCal.Location = new Point(46, 0);
            lblCal.Name = "lblCal";
            lblCal.Size = new Size(125, 37);
            lblCal.TabIndex = 5;
            lblCal.Text = "Calculator";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Calculator_512;
            pictureBox1.Location = new Point(-22, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(0, 49);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 40);
            lblError.TabIndex = 6;
            // 
            // lblHesaplama
            // 
            lblHesaplama.AutoSize = true;
            lblHesaplama.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHesaplama.ForeColor = Color.Black;
            lblHesaplama.Location = new Point(0, 82);
            lblHesaplama.Name = "lblHesaplama";
            lblHesaplama.Size = new Size(0, 54);
            lblHesaplama.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Location = new Point(0, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(364, 5);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 227, 170);
            panel3.Controls.Add(btn1);
            panel3.Controls.Add(btn2);
            panel3.Controls.Add(btn3);
            panel3.Controls.Add(btnTopla);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btn0);
            panel3.Controls.Add(btnNokta);
            panel3.Controls.Add(btnEsittir);
            panel3.Controls.Add(btn4);
            panel3.Controls.Add(btn5);
            panel3.Controls.Add(btn6);
            panel3.Controls.Add(btnCikar);
            panel3.Controls.Add(btnKaresi);
            panel3.Controls.Add(btn7);
            panel3.Controls.Add(btnKareKok);
            panel3.Controls.Add(btnBolme);
            panel3.Controls.Add(btn8);
            panel3.Controls.Add(btn9);
            panel3.Controls.Add(btnCarp);
            panel3.Controls.Add(btnSilme);
            panel3.Location = new Point(0, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 438);
            panel3.TabIndex = 4;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(255, 224, 192);
            btn1.BackgroundImageLayout = ImageLayout.None;
            btn1.Cursor = Cursors.Hand;
            btn1.FlatAppearance.BorderColor = Color.Tomato;
            btn1.FlatAppearance.BorderSize = 3;
            btn1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn1.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(3, 240);
            btn1.Name = "btn1";
            btn1.Size = new Size(70, 70);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseCompatibleTextRendering = true;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(255, 224, 192);
            btn2.BackgroundImageLayout = ImageLayout.None;
            btn2.Cursor = Cursors.Hand;
            btn2.FlatAppearance.BorderColor = Color.Tomato;
            btn2.FlatAppearance.BorderSize = 3;
            btn2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn2.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(88, 240);
            btn2.Name = "btn2";
            btn2.Size = new Size(70, 70);
            btn2.TabIndex = 0;
            btn2.Text = "2";
            btn2.UseCompatibleTextRendering = true;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(255, 224, 192);
            btn3.BackgroundImageLayout = ImageLayout.None;
            btn3.Cursor = Cursors.Hand;
            btn3.FlatAppearance.BorderColor = Color.Tomato;
            btn3.FlatAppearance.BorderSize = 3;
            btn3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn3.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = Color.Black;
            btn3.Location = new Point(176, 240);
            btn3.Name = "btn3";
            btn3.Size = new Size(70, 70);
            btn3.TabIndex = 0;
            btn3.Text = "3";
            btn3.UseCompatibleTextRendering = true;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btnTopla
            // 
            btnTopla.BackColor = Color.FromArgb(255, 192, 128);
            btnTopla.BackgroundImageLayout = ImageLayout.None;
            btnTopla.Cursor = Cursors.Hand;
            btnTopla.FlatAppearance.BorderColor = Color.Tomato;
            btnTopla.FlatAppearance.BorderSize = 3;
            btnTopla.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTopla.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnTopla.FlatStyle = FlatStyle.Flat;
            btnTopla.Font = new Font("Segoe UI", 47.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTopla.ForeColor = Color.Black;
            btnTopla.Location = new Point(261, 240);
            btnTopla.Name = "btnTopla";
            btnTopla.Size = new Size(70, 70);
            btnTopla.TabIndex = 0;
            btnTopla.Text = "+";
            btnTopla.UseCompatibleTextRendering = true;
            btnTopla.UseVisualStyleBackColor = false;
            btnTopla.Click += btnTopla_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Linen;
            btnClear.BackgroundImageLayout = ImageLayout.None;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.Tomato;
            btnClear.FlatAppearance.BorderSize = 3;
            btnClear.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClear.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Red;
            btnClear.Location = new Point(3, 318);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(70, 70);
            btnClear.TabIndex = 0;
            btnClear.Text = "C";
            btnClear.UseCompatibleTextRendering = true;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(255, 224, 192);
            btn0.BackgroundImageLayout = ImageLayout.None;
            btn0.Cursor = Cursors.Hand;
            btn0.FlatAppearance.BorderColor = Color.Tomato;
            btn0.FlatAppearance.BorderSize = 3;
            btn0.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn0.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.ForeColor = Color.Black;
            btn0.Location = new Point(88, 318);
            btn0.Name = "btn0";
            btn0.Size = new Size(70, 70);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseCompatibleTextRendering = true;
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnNokta
            // 
            btnNokta.BackColor = Color.FromArgb(255, 224, 192);
            btnNokta.BackgroundImageLayout = ImageLayout.None;
            btnNokta.Cursor = Cursors.Hand;
            btnNokta.FlatAppearance.BorderColor = Color.Tomato;
            btnNokta.FlatAppearance.BorderSize = 3;
            btnNokta.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNokta.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnNokta.FlatStyle = FlatStyle.Flat;
            btnNokta.Font = new Font("Segoe UI", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNokta.ForeColor = Color.Black;
            btnNokta.Location = new Point(176, 318);
            btnNokta.Name = "btnNokta";
            btnNokta.Size = new Size(70, 70);
            btnNokta.TabIndex = 0;
            btnNokta.Text = ".";
            btnNokta.UseCompatibleTextRendering = true;
            btnNokta.UseVisualStyleBackColor = false;
            btnNokta.Click += btnNokta_Click;
            // 
            // btnEsittir
            // 
            btnEsittir.BackColor = Color.Coral;
            btnEsittir.BackgroundImageLayout = ImageLayout.None;
            btnEsittir.Cursor = Cursors.Hand;
            btnEsittir.FlatAppearance.BorderColor = Color.Black;
            btnEsittir.FlatAppearance.BorderSize = 3;
            btnEsittir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEsittir.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnEsittir.FlatStyle = FlatStyle.Flat;
            btnEsittir.Font = new Font("Segoe UI", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEsittir.ForeColor = Color.Azure;
            btnEsittir.Location = new Point(261, 318);
            btnEsittir.Name = "btnEsittir";
            btnEsittir.Size = new Size(70, 70);
            btnEsittir.TabIndex = 0;
            btnEsittir.Text = "=";
            btnEsittir.UseCompatibleTextRendering = true;
            btnEsittir.UseVisualStyleBackColor = false;
            btnEsittir.Click += btnEsittir_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(255, 224, 192);
            btn4.BackgroundImageLayout = ImageLayout.None;
            btn4.Cursor = Cursors.Hand;
            btn4.FlatAppearance.BorderColor = Color.Tomato;
            btn4.FlatAppearance.BorderSize = 3;
            btn4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn4.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.ForeColor = Color.Black;
            btn4.Location = new Point(3, 162);
            btn4.Name = "btn4";
            btn4.Size = new Size(70, 70);
            btn4.TabIndex = 0;
            btn4.Text = "4";
            btn4.UseCompatibleTextRendering = true;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(255, 224, 192);
            btn5.BackgroundImageLayout = ImageLayout.None;
            btn5.Cursor = Cursors.Hand;
            btn5.FlatAppearance.BorderColor = Color.Tomato;
            btn5.FlatAppearance.BorderSize = 3;
            btn5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn5.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.ForeColor = Color.Black;
            btn5.Location = new Point(88, 162);
            btn5.Name = "btn5";
            btn5.Size = new Size(70, 70);
            btn5.TabIndex = 0;
            btn5.Text = "5";
            btn5.UseCompatibleTextRendering = true;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(255, 224, 192);
            btn6.BackgroundImageLayout = ImageLayout.None;
            btn6.Cursor = Cursors.Hand;
            btn6.FlatAppearance.BorderColor = Color.Tomato;
            btn6.FlatAppearance.BorderSize = 3;
            btn6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn6.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.ForeColor = Color.Black;
            btn6.Location = new Point(176, 162);
            btn6.Name = "btn6";
            btn6.Size = new Size(70, 70);
            btn6.TabIndex = 0;
            btn6.Text = "6";
            btn6.UseCompatibleTextRendering = true;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btnCikar
            // 
            btnCikar.BackColor = Color.FromArgb(255, 192, 128);
            btnCikar.BackgroundImageLayout = ImageLayout.None;
            btnCikar.Cursor = Cursors.Hand;
            btnCikar.FlatAppearance.BorderColor = Color.Tomato;
            btnCikar.FlatAppearance.BorderSize = 3;
            btnCikar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCikar.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnCikar.FlatStyle = FlatStyle.Flat;
            btnCikar.Font = new Font("Microsoft JhengHei", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCikar.ForeColor = Color.Black;
            btnCikar.Location = new Point(261, 162);
            btnCikar.Name = "btnCikar";
            btnCikar.Size = new Size(70, 70);
            btnCikar.TabIndex = 0;
            btnCikar.Text = "-";
            btnCikar.UseCompatibleTextRendering = true;
            btnCikar.UseVisualStyleBackColor = false;
            btnCikar.Click += btnCikar_Click;
            // 
            // btnKaresi
            // 
            btnKaresi.BackColor = Color.FromArgb(255, 224, 140);
            btnKaresi.BackgroundImage = Properties.Resources.output_onlinepngtools;
            btnKaresi.BackgroundImageLayout = ImageLayout.Zoom;
            btnKaresi.Cursor = Cursors.Hand;
            btnKaresi.FlatAppearance.BorderColor = Color.Tomato;
            btnKaresi.FlatAppearance.BorderSize = 3;
            btnKaresi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKaresi.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnKaresi.FlatStyle = FlatStyle.Flat;
            btnKaresi.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKaresi.ForeColor = Color.Black;
            btnKaresi.Location = new Point(3, 6);
            btnKaresi.Name = "btnKaresi";
            btnKaresi.Size = new Size(70, 70);
            btnKaresi.TabIndex = 0;
            btnKaresi.UseCompatibleTextRendering = true;
            btnKaresi.UseVisualStyleBackColor = false;
            btnKaresi.Click += btnKaresi_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(255, 224, 192);
            btn7.BackgroundImageLayout = ImageLayout.None;
            btn7.Cursor = Cursors.Hand;
            btn7.FlatAppearance.BorderColor = Color.Tomato;
            btn7.FlatAppearance.BorderSize = 3;
            btn7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn7.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.ForeColor = Color.Black;
            btn7.Location = new Point(3, 84);
            btn7.Name = "btn7";
            btn7.Size = new Size(70, 70);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseCompatibleTextRendering = true;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btnKareKok
            // 
            btnKareKok.BackColor = Color.FromArgb(255, 224, 140);
            btnKareKok.BackgroundImage = Properties.Resources.square_root_x_an2ob7xcrp4a257xsi1grg;
            btnKareKok.BackgroundImageLayout = ImageLayout.Zoom;
            btnKareKok.Cursor = Cursors.Hand;
            btnKareKok.FlatAppearance.BorderColor = Color.Tomato;
            btnKareKok.FlatAppearance.BorderSize = 3;
            btnKareKok.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKareKok.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnKareKok.FlatStyle = FlatStyle.Flat;
            btnKareKok.Font = new Font("Segoe UI", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKareKok.ForeColor = Color.Black;
            btnKareKok.Location = new Point(88, 6);
            btnKareKok.Name = "btnKareKok";
            btnKareKok.Size = new Size(70, 70);
            btnKareKok.TabIndex = 0;
            btnKareKok.UseCompatibleTextRendering = true;
            btnKareKok.UseVisualStyleBackColor = false;
            btnKareKok.Click += btnKareKok_Click;
            // 
            // btnBolme
            // 
            btnBolme.BackColor = Color.FromArgb(255, 224, 140);
            btnBolme.BackgroundImageLayout = ImageLayout.None;
            btnBolme.Cursor = Cursors.Hand;
            btnBolme.FlatAppearance.BorderColor = Color.Tomato;
            btnBolme.FlatAppearance.BorderSize = 3;
            btnBolme.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBolme.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnBolme.FlatStyle = FlatStyle.Flat;
            btnBolme.Font = new Font("Segoe UI", 33.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBolme.ForeColor = Color.Black;
            btnBolme.Location = new Point(176, 6);
            btnBolme.Name = "btnBolme";
            btnBolme.Size = new Size(70, 70);
            btnBolme.TabIndex = 0;
            btnBolme.Text = "/";
            btnBolme.UseCompatibleTextRendering = true;
            btnBolme.UseVisualStyleBackColor = false;
            btnBolme.Click += btnBolme_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(255, 224, 192);
            btn8.BackgroundImageLayout = ImageLayout.None;
            btn8.Cursor = Cursors.Hand;
            btn8.FlatAppearance.BorderColor = Color.Tomato;
            btn8.FlatAppearance.BorderSize = 3;
            btn8.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn8.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.ForeColor = Color.Black;
            btn8.Location = new Point(88, 84);
            btn8.Name = "btn8";
            btn8.Size = new Size(70, 70);
            btn8.TabIndex = 0;
            btn8.Text = "8";
            btn8.UseCompatibleTextRendering = true;
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(255, 224, 192);
            btn9.BackgroundImageLayout = ImageLayout.None;
            btn9.Cursor = Cursors.Hand;
            btn9.FlatAppearance.BorderColor = Color.Tomato;
            btn9.FlatAppearance.BorderSize = 3;
            btn9.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn9.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.ForeColor = Color.Black;
            btn9.Location = new Point(176, 84);
            btn9.Name = "btn9";
            btn9.Size = new Size(70, 70);
            btn9.TabIndex = 0;
            btn9.Text = "9";
            btn9.UseCompatibleTextRendering = true;
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btnCarp
            // 
            btnCarp.BackColor = Color.FromArgb(255, 192, 128);
            btnCarp.BackgroundImageLayout = ImageLayout.None;
            btnCarp.Cursor = Cursors.Hand;
            btnCarp.FlatAppearance.BorderColor = Color.Tomato;
            btnCarp.FlatAppearance.BorderSize = 3;
            btnCarp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCarp.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnCarp.FlatStyle = FlatStyle.Flat;
            btnCarp.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarp.ForeColor = Color.Black;
            btnCarp.Location = new Point(261, 84);
            btnCarp.Name = "btnCarp";
            btnCarp.Size = new Size(70, 70);
            btnCarp.TabIndex = 0;
            btnCarp.Text = "x";
            btnCarp.UseCompatibleTextRendering = true;
            btnCarp.UseVisualStyleBackColor = false;
            btnCarp.Click += btnCarp_Click;
            // 
            // btnSilme
            // 
            btnSilme.BackColor = Color.FromArgb(255, 192, 128);
            btnSilme.BackgroundImage = Properties.Resources._6830095;
            btnSilme.BackgroundImageLayout = ImageLayout.Stretch;
            btnSilme.Cursor = Cursors.Hand;
            btnSilme.FlatAppearance.BorderColor = Color.Tomato;
            btnSilme.FlatAppearance.BorderSize = 3;
            btnSilme.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSilme.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnSilme.FlatStyle = FlatStyle.Flat;
            btnSilme.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSilme.ForeColor = Color.Black;
            btnSilme.Location = new Point(261, 6);
            btnSilme.Name = "btnSilme";
            btnSilme.Size = new Size(70, 70);
            btnSilme.TabIndex = 0;
            btnSilme.UseVisualStyleBackColor = false;
            btnSilme.Click += btnSilme_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 549);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Wexis Calculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnCarp;
        private Button btnSilme;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnTopla;
        private Button btnClear;
        private Button btn0;
        private Button btnNokta;
        private Button btnEsittir;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnCikar;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnKaresi;
        private Button btnKareKok;
        private Button btnBolme;
        private Label lblCal;
        private PictureBox pictureBox1;
        private Label lblHesaplama;
        private Label lblError;
    }
}
