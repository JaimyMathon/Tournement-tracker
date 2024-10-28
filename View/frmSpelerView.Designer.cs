namespace T8_PraktijkProject.View
{
    partial class frmSpelerView
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
            spelerFLP = new FlowLayoutPanel();
            toevoegenBtn = new Button();
            updateBtn = new Button();
            verwijderBtn = new Button();
            SuspendLayout();
            // 
            // spelerFLP
            // 
            spelerFLP.BackColor = Color.FromArgb(18, 18, 18);
            spelerFLP.Location = new Point(1, 1);
            spelerFLP.Name = "spelerFLP";
            spelerFLP.Size = new Size(1378, 742);
            spelerFLP.TabIndex = 0;
            // 
            // toevoegenBtn
            // 
            toevoegenBtn.FlatStyle = FlatStyle.Flat;
            toevoegenBtn.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            toevoegenBtn.ForeColor = Color.White;
            toevoegenBtn.Location = new Point(352, 749);
            toevoegenBtn.Name = "toevoegenBtn";
            toevoegenBtn.Size = new Size(185, 48);
            toevoegenBtn.TabIndex = 1;
            toevoegenBtn.Text = "Toevoegen";
            toevoegenBtn.UseVisualStyleBackColor = true;
            toevoegenBtn.Click += toevoegenBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(596, 749);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(185, 48);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Updaten";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // verwijderBtn
            // 
            verwijderBtn.FlatStyle = FlatStyle.Flat;
            verwijderBtn.Font = new Font("Franklin Gothic Heavy", 10.2F, FontStyle.Italic);
            verwijderBtn.ForeColor = Color.White;
            verwijderBtn.Location = new Point(840, 749);
            verwijderBtn.Name = "verwijderBtn";
            verwijderBtn.Size = new Size(185, 48);
            verwijderBtn.TabIndex = 3;
            verwijderBtn.Text = "Verwijderen";
            verwijderBtn.UseVisualStyleBackColor = true;
            verwijderBtn.Click += verwijderBtn_Click;
            // 
            // frmSpelerView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1379, 806);
            Controls.Add(verwijderBtn);
            Controls.Add(updateBtn);
            Controls.Add(toevoegenBtn);
            Controls.Add(spelerFLP);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSpelerView";
            Text = "frmSpelerView";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel spelerFLP;
        private Button toevoegenBtn;
        private Button updateBtn;
        private Button verwijderBtn;
    }
}