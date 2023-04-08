namespace Conservatoire.Vues
{
    partial class gestionProf
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
            this.prenomInput = new System.Windows.Forms.TextBox();
            this.nomInput = new System.Windows.Forms.TextBox();
            this.mailInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adresseInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.InstrumentListe = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.salaireInput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.telephoneInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salaireInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneInput)).BeginInit();
            this.SuspendLayout();
            // 
            // prenomInput
            // 
            this.prenomInput.Location = new System.Drawing.Point(48, 89);
            this.prenomInput.Name = "prenomInput";
            this.prenomInput.Size = new System.Drawing.Size(242, 20);
            this.prenomInput.TabIndex = 0;
            // 
            // nomInput
            // 
            this.nomInput.Location = new System.Drawing.Point(411, 88);
            this.nomInput.Name = "nomInput";
            this.nomInput.Size = new System.Drawing.Size(242, 20);
            this.nomInput.TabIndex = 1;
            // 
            // mailInput
            // 
            this.mailInput.Location = new System.Drawing.Point(48, 148);
            this.mailInput.Name = "mailInput";
            this.mailInput.Size = new System.Drawing.Size(242, 20);
            this.mailInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mail";
            // 
            // adresseInput
            // 
            this.adresseInput.Location = new System.Drawing.Point(48, 212);
            this.adresseInput.Name = "adresseInput";
            this.adresseInput.Size = new System.Drawing.Size(242, 20);
            this.adresseInput.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ajouter un professeur";
            // 
            // InstrumentListe
            // 
            this.InstrumentListe.DropDownWidth = 242;
            this.InstrumentListe.FormattingEnabled = true;
            this.InstrumentListe.IntegralHeight = false;
            this.InstrumentListe.Location = new System.Drawing.Point(48, 274);
            this.InstrumentListe.Name = "InstrumentListe";
            this.InstrumentListe.Size = new System.Drawing.Size(242, 21);
            this.InstrumentListe.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ajouter ce professeur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Adresse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Instrument";
            // 
            // salaireInput
            // 
            this.salaireInput.Location = new System.Drawing.Point(411, 212);
            this.salaireInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.salaireInput.Name = "salaireInput";
            this.salaireInput.Size = new System.Drawing.Size(242, 20);
            this.salaireInput.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Salaire";
            // 
            // telephoneInput
            // 
            this.telephoneInput.Location = new System.Drawing.Point(411, 148);
            this.telephoneInput.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.telephoneInput.Name = "telephoneInput";
            this.telephoneInput.Size = new System.Drawing.Size(242, 20);
            this.telephoneInput.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Téléphone";
            // 
            // gestionProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(757, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.telephoneInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salaireInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InstrumentListe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adresseInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mailInput);
            this.Controls.Add(this.nomInput);
            this.Controls.Add(this.prenomInput);
            this.Name = "gestionProf";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.salaireInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prenomInput;
        private System.Windows.Forms.TextBox nomInput;
        private System.Windows.Forms.TextBox mailInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adresseInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox InstrumentListe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown salaireInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown telephoneInput;
        private System.Windows.Forms.Label label3;
    }
}