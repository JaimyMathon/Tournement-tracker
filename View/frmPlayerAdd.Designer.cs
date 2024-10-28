namespace T8_PraktijkProject.View
{
    partial class frmPlayerAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayerAdd));
            losses = new TextBox();
            wins = new TextBox();
            disciplines = new TextBox();
            achternaam = new TextBox();
            tussenvoegsel = new TextBox();
            voornaam = new TextBox();
            toevoegenBtn = new Button();
            geboortedatum = new TextBox();
            playerImage = new PictureBox();
            previewBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)playerImage).BeginInit();
            SuspendLayout();
            // 
            // losses
            // 
            losses.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            losses.Location = new Point(260, 367);
            losses.Margin = new Padding(2);
            losses.Name = "losses";
            losses.PlaceholderText = "Losses";
            losses.Size = new Size(191, 27);
            losses.TabIndex = 14;
            // 
            // wins
            // 
            wins.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            wins.Location = new Point(260, 326);
            wins.Margin = new Padding(2);
            wins.Name = "wins";
            wins.PlaceholderText = "Wins";
            wins.Size = new Size(191, 27);
            wins.TabIndex = 13;
            // 
            // disciplines
            // 
            disciplines.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            disciplines.Location = new Point(260, 244);
            disciplines.Margin = new Padding(2);
            disciplines.Name = "disciplines";
            disciplines.PlaceholderText = "Disciplines";
            disciplines.Size = new Size(191, 27);
            disciplines.TabIndex = 12;
            // 
            // achternaam
            // 
            achternaam.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            achternaam.Location = new Point(260, 162);
            achternaam.Margin = new Padding(2);
            achternaam.Name = "achternaam";
            achternaam.PlaceholderText = "Achternaam";
            achternaam.Size = new Size(191, 27);
            achternaam.TabIndex = 10;
            // 
            // tussenvoegsel
            // 
            tussenvoegsel.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            tussenvoegsel.Location = new Point(260, 122);
            tussenvoegsel.Margin = new Padding(2);
            tussenvoegsel.Name = "tussenvoegsel";
            tussenvoegsel.PlaceholderText = "Tussenvoegsel";
            tussenvoegsel.Size = new Size(191, 27);
            tussenvoegsel.TabIndex = 9;
            // 
            // voornaam
            // 
            voornaam.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            voornaam.Location = new Point(260, 82);
            voornaam.Margin = new Padding(2);
            voornaam.Name = "voornaam";
            voornaam.PlaceholderText = "Voornaam";
            voornaam.Size = new Size(191, 27);
            voornaam.TabIndex = 8;
            // 
            // toevoegenBtn
            // 
            toevoegenBtn.BackColor = Color.FromArgb(20, 20, 20);
            toevoegenBtn.FlatStyle = FlatStyle.Flat;
            toevoegenBtn.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            toevoegenBtn.ForeColor = Color.White;
            toevoegenBtn.Location = new Point(388, 460);
            toevoegenBtn.Margin = new Padding(2);
            toevoegenBtn.Name = "toevoegenBtn";
            toevoegenBtn.Size = new Size(155, 55);
            toevoegenBtn.TabIndex = 16;
            toevoegenBtn.Text = "Toevoegen";
            toevoegenBtn.UseVisualStyleBackColor = false;
            toevoegenBtn.Click += toevoegenBtn_Click;
            // 
            // geboortedatum
            // 
            geboortedatum.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            geboortedatum.Location = new Point(260, 203);
            geboortedatum.Margin = new Padding(2);
            geboortedatum.Name = "geboortedatum";
            geboortedatum.PlaceholderText = "Geboortedatum";
            geboortedatum.Size = new Size(191, 27);
            geboortedatum.TabIndex = 17;
            // 
            // playerImage
            // 
            playerImage.Location = new Point(535, 82);
            playerImage.Name = "playerImage";
            playerImage.Size = new Size(364, 344);
            playerImage.SizeMode = PictureBoxSizeMode.Zoom;
            playerImage.TabIndex = 18;
            playerImage.TabStop = false;
            // 
            // previewBtn
            // 
            previewBtn.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            previewBtn.ForeColor = Color.FromArgb(211, 18, 18);
            previewBtn.Location = new Point(260, 284);
            previewBtn.Margin = new Padding(2);
            previewBtn.Name = "previewBtn";
            previewBtn.Size = new Size(191, 29);
            previewBtn.TabIndex = 19;
            previewBtn.Text = "Selecteer foto";
            previewBtn.UseVisualStyleBackColor = true;
            previewBtn.Click += previewBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(149, 85);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 20;
            label1.Text = "Voornaam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(112, 125);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 21;
            label2.Text = "Tussenvoegsel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(133, 165);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 22;
            label3.Text = "Achternaam";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            label4.ForeColor = Color.White;
            label4.Location = new Point(105, 206);
            label4.Name = "label4";
            label4.Size = new Size(135, 21);
            label4.TabIndex = 23;
            label4.Text = "Geboortedatum";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            label5.ForeColor = Color.White;
            label5.Location = new Point(141, 247);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 24;
            label5.Text = "Disciplines";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            label6.ForeColor = Color.White;
            label6.Location = new Point(131, 288);
            label6.Name = "label6";
            label6.Size = new Size(109, 21);
            label6.TabIndex = 25;
            label6.Text = "Vechter foto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            label7.ForeColor = Color.White;
            label7.Location = new Point(146, 329);
            label7.Name = "label7";
            label7.Size = new Size(94, 21);
            label7.TabIndex = 26;
            label7.Text = "Gewonnen";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            label8.ForeColor = Color.White;
            label8.Location = new Point(161, 370);
            label8.Name = "label8";
            label8.Size = new Size(79, 21);
            label8.TabIndex = 27;
            label8.Text = "Verloren";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(211, 18, 18);
            panel1.Location = new Point(46, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 316);
            panel1.TabIndex = 47;
            // 
            // frmPlayerAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(949, 543);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(previewBtn);
            Controls.Add(playerImage);
            Controls.Add(geboortedatum);
            Controls.Add(toevoegenBtn);
            Controls.Add(losses);
            Controls.Add(wins);
            Controls.Add(disciplines);
            Controls.Add(achternaam);
            Controls.Add(tussenvoegsel);
            Controls.Add(voornaam);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmPlayerAdd";
            Text = "Deelnemer Toevoegen";
            ((System.ComponentModel.ISupportInitialize)playerImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox losses;
        private TextBox wins;
        private TextBox disciplines;
        private TextBox achternaam;
        private TextBox tussenvoegsel;
        private TextBox voornaam;
        private Button toevoegenBtn;
        private TextBox geboortedatum;
        private PictureBox playerImage;
        private Button previewBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel1;
    }
}