namespace Conservatoire.Vues
{
    partial class listeEleve
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.listeElev = new System.Windows.Forms.ComboBox();
            this.confirmationAjout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(29, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(732, 264);
            this.listBox1.TabIndex = 0;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(29, 349);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(192, 23);
            this.Ajouter.TabIndex = 1;
            this.Ajouter.Text = "Ajouter un élève à ce cours";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(558, 349);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(203, 23);
            this.Supprimer.TabIndex = 2;
            this.Supprimer.Text = "Supprimer l\'élève de ce cours";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // listeElev
            // 
            this.listeElev.FormattingEnabled = true;
            this.listeElev.Location = new System.Drawing.Point(29, 380);
            this.listeElev.Name = "listeElev";
            this.listeElev.Size = new System.Drawing.Size(322, 21);
            this.listeElev.TabIndex = 3;
            this.listeElev.Visible = false;
            // 
            // confirmationAjout
            // 
            this.confirmationAjout.Location = new System.Drawing.Point(370, 378);
            this.confirmationAjout.Name = "confirmationAjout";
            this.confirmationAjout.Size = new System.Drawing.Size(172, 22);
            this.confirmationAjout.TabIndex = 4;
            this.confirmationAjout.Text = "Ajouter cet élève";
            this.confirmationAjout.UseVisualStyleBackColor = true;
            this.confirmationAjout.Visible = false;
            this.confirmationAjout.Click += new System.EventHandler(this.confirmationAjout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Liste des élèves";
            // 
            // listeEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmationAjout);
            this.Controls.Add(this.listeElev);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.listBox1);
            this.Name = "listeEleve";
            this.Text = "listeEleve";
            this.Load += new System.EventHandler(this.listeEleve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.ComboBox listeElev;
        private System.Windows.Forms.Button confirmationAjout;
        private System.Windows.Forms.Label label1;
    }
}