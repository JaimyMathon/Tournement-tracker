namespace T8_PraktijkProject.View
{
    partial class frmWedstrijdView
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
            wedstrijdFLP = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // wedstrijdFLP
            // 
            wedstrijdFLP.BackColor = Color.FromArgb(18, 18, 18);
            wedstrijdFLP.Location = new Point(0, -2);
            wedstrijdFLP.Name = "wedstrijdFLP";
            wedstrijdFLP.Size = new Size(1379, 809);
            wedstrijdFLP.TabIndex = 0;
            // 
            // frmWedstrijdView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 806);
            Controls.Add(wedstrijdFLP);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmWedstrijdView";
            Text = "frmWedstrijdView";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel wedstrijdFLP;
    }
}