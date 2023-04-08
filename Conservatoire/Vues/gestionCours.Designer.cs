namespace Conservatoire.Vues
{
    partial class gestionCours
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
            this.label1 = new System.Windows.Forms.Label();
            this.numInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.capacite = new System.Windows.Forms.TextBox();
            this.trancheListe = new System.Windows.Forms.ComboBox();
            this.jourSeance = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.niveau = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "NumSeance";
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(72, 85);
            this.numInput.Name = "numInput";
            this.numInput.ReadOnly = true;
            this.numInput.Size = new System.Drawing.Size(242, 20);
            this.numInput.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Capacite";
            // 
            // capacite
            // 
            this.capacite.Location = new System.Drawing.Point(376, 197);
            this.capacite.Name = "capacite";
            this.capacite.Size = new System.Drawing.Size(242, 20);
            this.capacite.TabIndex = 15;
            // 
            // trancheListe
            // 
            this.trancheListe.FormattingEnabled = true;
            this.trancheListe.Location = new System.Drawing.Point(376, 135);
            this.trancheListe.Name = "trancheListe";
            this.trancheListe.Size = new System.Drawing.Size(242, 21);
            this.trancheListe.TabIndex = 19;
            // 
            // jourSeance
            // 
            this.jourSeance.FormattingEnabled = true;
            this.jourSeance.Items.AddRange(new object[] {
            "Lundi",
            "Mardi",
            "Mercredi",
            "Jeudi",
            "Vendredi",
            "Samedi"});
            this.jourSeance.Location = new System.Drawing.Point(72, 137);
            this.jourSeance.Name = "jourSeance";
            this.jourSeance.Size = new System.Drawing.Size(242, 21);
            this.jourSeance.TabIndex = 20;
            this.jourSeance.SelectedIndexChanged += new System.EventHandler(this.jourSeance_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Modifier ce cours";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Ajouter ce cours";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Gestion du cours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Jour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tranche";
            // 
            // niveau
            // 
            this.niveau.FormattingEnabled = true;
            this.niveau.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.niveau.Location = new System.Drawing.Point(72, 197);
            this.niveau.Name = "niveau";
            this.niveau.Size = new System.Drawing.Size(242, 21);
            this.niveau.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Niveau";
            // 
            // gestionCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.niveau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jourSeance);
            this.Controls.Add(this.trancheListe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.capacite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numInput);
            this.Name = "gestionCours";
            this.Text = "gestionCours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox capacite;
        private System.Windows.Forms.ComboBox trancheListe;
        private System.Windows.Forms.ComboBox jourSeance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox niveau;
        private System.Windows.Forms.Label label2;
    }
}