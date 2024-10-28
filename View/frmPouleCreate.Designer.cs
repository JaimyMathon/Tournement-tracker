namespace T8_PraktijkProject.View
{
    partial class frmPouleCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPouleCreate));
            spelerFLP = new FlowLayoutPanel();
            btnCreatePoule = new Button();
            btnSelecteer = new Button();
            lblPlayerCount = new Label();
            btnCloseWindow = new Button();
            SuspendLayout();
            // 
            // spelerFLP
            // 
            resources.ApplyResources(spelerFLP, "spelerFLP");
            spelerFLP.Name = "spelerFLP";
            // 
            // btnCreatePoule
            // 
            resources.ApplyResources(btnCreatePoule, "btnCreatePoule");
            btnCreatePoule.ForeColor = Color.White;
            btnCreatePoule.Name = "btnCreatePoule";
            btnCreatePoule.UseVisualStyleBackColor = true;
            btnCreatePoule.Click += btnCreatePoule_Click;
            // 
            // btnSelecteer
            // 
            resources.ApplyResources(btnSelecteer, "btnSelecteer");
            btnSelecteer.ForeColor = Color.White;
            btnSelecteer.Name = "btnSelecteer";
            btnSelecteer.UseVisualStyleBackColor = true;
            btnSelecteer.Click += btnSelecteer_Click;
            // 
            // lblPlayerCount
            // 
            resources.ApplyResources(lblPlayerCount, "lblPlayerCount");
            lblPlayerCount.ForeColor = Color.White;
            lblPlayerCount.Name = "lblPlayerCount";
            // 
            // btnCloseWindow
            // 
            resources.ApplyResources(btnCloseWindow, "btnCloseWindow");
            btnCloseWindow.ForeColor = Color.White;
            btnCloseWindow.Name = "btnCloseWindow";
            btnCloseWindow.UseVisualStyleBackColor = true;
            btnCloseWindow.Click += btnCloseWindow_Click;
            // 
            // frmPouleCreate
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            Controls.Add(btnCloseWindow);
            Controls.Add(lblPlayerCount);
            Controls.Add(btnSelecteer);
            Controls.Add(btnCreatePoule);
            Controls.Add(spelerFLP);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmPouleCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel spelerFLP;
        private Button btnCreatePoule;
        private Button btnSelecteer;
        private Label lblPlayerCount;
        private Button btnCloseWindow;
    }
}