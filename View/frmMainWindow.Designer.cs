namespace T8_PraktijkProject
{
    partial class frmMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            viewPanel = new Panel();
            panel2 = new Panel();
            dashboardBtn = new Button();
            loginBtn = new Button();
            pictureBox1 = new PictureBox();
            afsluitenBtn = new Button();
            deelnemerBtn = new Button();
            wedstrijdenBtn = new Button();
            poulesBtn = new Button();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // viewPanel
            // 
            viewPanel.BackColor = Color.Gray;
            viewPanel.Location = new Point(222, 1);
            viewPanel.Name = "viewPanel";
            viewPanel.Size = new Size(1379, 806);
            viewPanel.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 20, 20);
            panel2.Controls.Add(dashboardBtn);
            panel2.Controls.Add(loginBtn);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(afsluitenBtn);
            panel2.Controls.Add(deelnemerBtn);
            panel2.Controls.Add(wedstrijdenBtn);
            panel2.Controls.Add(poulesBtn);
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 809);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // dashboardBtn
            // 
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Franklin Gothic Heavy", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dashboardBtn.ForeColor = Color.White;
            dashboardBtn.ImageAlign = ContentAlignment.MiddleRight;
            dashboardBtn.Location = new Point(21, 297);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(181, 39);
            dashboardBtn.TabIndex = 9;
            dashboardBtn.Text = "DASHBOARD";
            dashboardBtn.UseVisualStyleBackColor = true;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Franklin Gothic Heavy", 13.8F, FontStyle.Italic);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(21, 532);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(181, 39);
            loginBtn.TabIndex = 8;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // afsluitenBtn
            // 
            afsluitenBtn.FlatStyle = FlatStyle.Flat;
            afsluitenBtn.Font = new Font("Franklin Gothic Heavy", 13.8F, FontStyle.Italic);
            afsluitenBtn.ForeColor = Color.White;
            afsluitenBtn.Location = new Point(21, 736);
            afsluitenBtn.Name = "afsluitenBtn";
            afsluitenBtn.Size = new Size(181, 39);
            afsluitenBtn.TabIndex = 6;
            afsluitenBtn.Text = "AFSLUITEN";
            afsluitenBtn.UseVisualStyleBackColor = true;
            afsluitenBtn.Click += afsluitenBtn_Click;
            // 
            // deelnemerBtn
            // 
            deelnemerBtn.FlatStyle = FlatStyle.Flat;
            deelnemerBtn.Font = new Font("Franklin Gothic Heavy", 13.8F, FontStyle.Italic);
            deelnemerBtn.ForeColor = Color.White;
            deelnemerBtn.Location = new Point(21, 473);
            deelnemerBtn.Name = "deelnemerBtn";
            deelnemerBtn.Size = new Size(181, 39);
            deelnemerBtn.TabIndex = 4;
            deelnemerBtn.Text = "DEELNEMERS";
            deelnemerBtn.UseVisualStyleBackColor = true;
            deelnemerBtn.Click += deelnemerBtn_Click;
            // 
            // wedstrijdenBtn
            // 
            wedstrijdenBtn.FlatStyle = FlatStyle.Flat;
            wedstrijdenBtn.Font = new Font("Franklin Gothic Heavy", 13.8F, FontStyle.Italic);
            wedstrijdenBtn.ForeColor = Color.White;
            wedstrijdenBtn.Location = new Point(21, 415);
            wedstrijdenBtn.Name = "wedstrijdenBtn";
            wedstrijdenBtn.Size = new Size(181, 39);
            wedstrijdenBtn.TabIndex = 2;
            wedstrijdenBtn.Text = "WEDSTRIJDEN";
            wedstrijdenBtn.UseVisualStyleBackColor = true;
            wedstrijdenBtn.Click += wedstrijdenBtn_Click;
            // 
            // poulesBtn
            // 
            poulesBtn.FlatStyle = FlatStyle.Flat;
            poulesBtn.Font = new Font("Franklin Gothic Heavy", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            poulesBtn.ForeColor = Color.White;
            poulesBtn.ImageAlign = ContentAlignment.MiddleRight;
            poulesBtn.Location = new Point(21, 356);
            poulesBtn.Name = "poulesBtn";
            poulesBtn.Size = new Size(181, 39);
            poulesBtn.TabIndex = 1;
            poulesBtn.Text = "POULES";
            poulesBtn.UseVisualStyleBackColor = true;
            poulesBtn.Click += poulesBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(508, 388);
            panel1.Name = "panel1";
            panel1.Size = new Size(1413, 812);
            panel1.TabIndex = 0;
            // 
            // frmMainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1601, 806);
            Controls.Add(panel2);
            Controls.Add(viewPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMainWindow";
            Text = "UFC Fight Night                                               ";
            Load += frmMainWindow_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel viewPanel;
        private Panel panel2;
        private Button deelnemerBtn;
        private Button wedstrijdenBtn;
        private Button poulesBtn;
        private Panel panel1;
        private Button afsluitenBtn;
        private PictureBox pictureBox1;
        private Button loginBtn;
        private Button dashboardBtn;
    }
}
