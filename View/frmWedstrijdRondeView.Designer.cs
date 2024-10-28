namespace T8_PraktijkProject.View
{
    partial class frmWedstrijdRondeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWedstrijdRondeView));
            wedstrijdFLP = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // wedstrijdFLP
            // 
            wedstrijdFLP.Location = new Point(0, 3);
            wedstrijdFLP.Name = "wedstrijdFLP";
            wedstrijdFLP.Size = new Size(1379, 805);
            wedstrijdFLP.TabIndex = 0;
            // 
            // frmWedstrijdRondeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 805);
            Controls.Add(wedstrijdFLP);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmWedstrijdRondeView";
            Text = "Wedstrijd Ronde Overzicht";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel wedstrijdFLP;
    }
}