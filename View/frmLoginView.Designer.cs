namespace T8_PraktijkProject.View
{
    partial class frmLoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginView));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            gebruikersnaamInput = new TextBox();
            label3 = new Label();
            label4 = new Label();
            wachtwoordInput = new TextBox();
            loginBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(562, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(633, 235);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 18;
            label1.Text = "BEHEERDER ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Heavy", 36F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(594, 272);
            label2.Name = "label2";
            label2.Size = new Size(205, 75);
            label2.TabIndex = 19;
            label2.Text = "LOGIN";
            // 
            // gebruikersnaamInput
            // 
            gebruikersnaamInput.Location = new Point(509, 425);
            gebruikersnaamInput.Name = "gebruikersnaamInput";
            gebruikersnaamInput.Size = new Size(384, 27);
            gebruikersnaamInput.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Heavy", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(509, 386);
            label3.Name = "label3";
            label3.Size = new Size(152, 23);
            label3.TabIndex = 21;
            label3.Text = "Gebruikersnaam";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Heavy", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(509, 486);
            label4.Name = "label4";
            label4.Size = new Size(115, 23);
            label4.TabIndex = 23;
            label4.Text = "Wachtwoord";
            // 
            // wachtwoordInput
            // 
            wachtwoordInput.Location = new Point(509, 525);
            wachtwoordInput.Name = "wachtwoordInput";
            wachtwoordInput.Size = new Size(384, 27);
            wachtwoordInput.TabIndex = 22;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(10, 10, 10);
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(509, 589);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(158, 55);
            loginBtn.TabIndex = 24;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // frmLoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1379, 806);
            Controls.Add(loginBtn);
            Controls.Add(label4);
            Controls.Add(wachtwoordInput);
            Controls.Add(label3);
            Controls.Add(gebruikersnaamInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLoginView";
            Text = "frmLoginView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox gebruikersnaamInput;
        private Label label3;
        private Label label4;
        private TextBox wachtwoordInput;
        private Button loginBtn;
    }
}