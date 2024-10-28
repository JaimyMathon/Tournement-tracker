namespace T8_PraktijkProject.View
{
    partial class singlePlayerFrame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ageLbl = new Label();
            disciplinesLbl = new Label();
            winLbl = new Label();
            nameLbl = new Label();
            lossLbl = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            SpelerPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)SpelerPicture).BeginInit();
            SuspendLayout();
            // 
            // ageLbl
            // 
            ageLbl.AutoSize = true;
            ageLbl.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            ageLbl.ForeColor = Color.White;
            ageLbl.Location = new Point(28, 84);
            ageLbl.Name = "ageLbl";
            ageLbl.Size = new Size(57, 18);
            ageLbl.TabIndex = 21;
            ageLbl.Text = "Leeftijd";
            // 
            // disciplinesLbl
            // 
            disciplinesLbl.AutoSize = true;
            disciplinesLbl.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            disciplinesLbl.ForeColor = Color.Silver;
            disciplinesLbl.Location = new Point(28, 28);
            disciplinesLbl.Name = "disciplinesLbl";
            disciplinesLbl.Size = new Size(92, 21);
            disciplinesLbl.TabIndex = 22;
            disciplinesLbl.Text = "Disciplines";
            // 
            // winLbl
            // 
            winLbl.AutoSize = true;
            winLbl.Font = new Font("Franklin Gothic Heavy", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            winLbl.ForeColor = Color.White;
            winLbl.Location = new Point(24, 124);
            winLbl.Name = "winLbl";
            winLbl.Size = new Size(47, 34);
            winLbl.TabIndex = 23;
            winLbl.Text = "10";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Franklin Gothic Heavy", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            nameLbl.ForeColor = Color.White;
            nameLbl.Location = new Point(28, 56);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(72, 28);
            nameLbl.TabIndex = 24;
            nameLbl.Text = "Naam";
            // 
            // lossLbl
            // 
            lossLbl.AutoSize = true;
            lossLbl.Font = new Font("Franklin Gothic Heavy", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lossLbl.ForeColor = Color.White;
            lossLbl.Location = new Point(114, 124);
            lossLbl.Name = "lossLbl";
            lossLbl.Size = new Size(47, 34);
            lossLbl.TabIndex = 25;
            lossLbl.Text = "20";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(211, 18, 18);
            panel1.Location = new Point(88, 116);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(9, 49);
            panel1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Demi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 161);
            label1.Name = "label1";
            label1.Size = new Size(39, 18);
            label1.TabIndex = 27;
            label1.Text = "Wins";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Demi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(112, 161);
            label2.Name = "label2";
            label2.Size = new Size(51, 18);
            label2.TabIndex = 28;
            label2.Text = "Losses";
            // 
            // SpelerPicture
            // 
            SpelerPicture.Location = new Point(233, 12);
            SpelerPicture.Margin = new Padding(3, 2, 3, 2);
            SpelerPicture.Name = "SpelerPicture";
            SpelerPicture.Size = new Size(313, 178);
            SpelerPicture.SizeMode = PictureBoxSizeMode.Zoom;
            SpelerPicture.TabIndex = 30;
            SpelerPicture.TabStop = false;
            // 
            // singlePlayerFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            Controls.Add(SpelerPicture);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(lossLbl);
            Controls.Add(nameLbl);
            Controls.Add(winLbl);
            Controls.Add(disciplinesLbl);
            Controls.Add(ageLbl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "singlePlayerFrame";
            Size = new Size(582, 206);
            ((System.ComponentModel.ISupportInitialize)SpelerPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ageLbl;
        private Label disciplinesLbl;
        private Label winLbl;
        private Label nameLbl;
        private Label lossLbl;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox SpelerPicture;
    }
}
