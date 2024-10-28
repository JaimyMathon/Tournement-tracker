namespace T8_PraktijkProject.View
{
    partial class frmExitWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExitWindow));
            lblThanks = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblThanks
            // 
            lblThanks.AutoSize = true;
            lblThanks.Font = new Font("Franklin Gothic Heavy", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblThanks.ForeColor = Color.White;
            lblThanks.Location = new Point(87, 282);
            lblThanks.Name = "lblThanks";
            lblThanks.Size = new Size(585, 36);
            lblThanks.TabIndex = 25;
            lblThanks.Text = "Bedankt voor het kijken van de wedstrijden!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(211, 18, 18);
            panel1.Location = new Point(37, 195);
            panel1.Name = "panel1";
            panel1.Size = new Size(11, 443);
            panel1.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(567, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(87, 437);
            label1.Name = "label1";
            label1.Size = new Size(292, 34);
            label1.TabIndex = 29;
            label1.Text = "Tot de volgende keer!";
            // 
            // frmExitWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1379, 806);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(lblThanks);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmExitWindow";
            Text = "frmExitWindow";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThanks;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}