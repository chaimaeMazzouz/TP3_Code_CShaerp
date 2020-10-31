namespace Atelier3_TP
{
    partial class Pilote
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
            this.textPil = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textCdPostal = new System.Windows.Forms.TextBox();
            this.textVille = new System.Windows.Forms.TextBox();
            this.textSalaireBrut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dTP_DateNaissance = new System.Windows.Forms.DateTimePicker();
            this.dTP_DateDbActivite = new System.Windows.Forms.DateTimePicker();
            this.dTP_DateFinActivite = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInserer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textPil
            // 
            this.textPil.Location = new System.Drawing.Point(102, 48);
            this.textPil.Name = "textPil";
            this.textPil.Size = new System.Drawing.Size(100, 20);
            this.textPil.TabIndex = 0;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(102, 98);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(100, 20);
            this.textNom.TabIndex = 1;
            // 
            // textCdPostal
            // 
            this.textCdPostal.Location = new System.Drawing.Point(102, 151);
            this.textCdPostal.Name = "textCdPostal";
            this.textCdPostal.Size = new System.Drawing.Size(100, 20);
            this.textCdPostal.TabIndex = 2;
            // 
            // textVille
            // 
            this.textVille.Location = new System.Drawing.Point(102, 205);
            this.textVille.Name = "textVille";
            this.textVille.Size = new System.Drawing.Size(100, 20);
            this.textVille.TabIndex = 3;
            // 
            // textSalaireBrut
            // 
            this.textSalaireBrut.Location = new System.Drawing.Point(380, 209);
            this.textSalaireBrut.Name = "textSalaireBrut";
            this.textSalaireBrut.Size = new System.Drawing.Size(100, 20);
            this.textSalaireBrut.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "CodePostal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "SalaireBrut";
            // 
            // dTP_DateNaissance
            // 
            this.dTP_DateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_DateNaissance.Location = new System.Drawing.Point(379, 48);
            this.dTP_DateNaissance.Name = "dTP_DateNaissance";
            this.dTP_DateNaissance.Size = new System.Drawing.Size(101, 20);
            this.dTP_DateNaissance.TabIndex = 10;
            // 
            // dTP_DateDbActivite
            // 
            this.dTP_DateDbActivite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_DateDbActivite.Location = new System.Drawing.Point(379, 102);
            this.dTP_DateDbActivite.Name = "dTP_DateDbActivite";
            this.dTP_DateDbActivite.Size = new System.Drawing.Size(101, 20);
            this.dTP_DateDbActivite.TabIndex = 11;
            // 
            // dTP_DateFinActivite
            // 
            this.dTP_DateFinActivite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_DateFinActivite.Location = new System.Drawing.Point(379, 152);
            this.dTP_DateFinActivite.Name = "dTP_DateFinActivite";
            this.dTP_DateFinActivite.Size = new System.Drawing.Size(101, 20);
            this.dTP_DateFinActivite.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "DateNaissance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(230, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "DateDebutActivite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(230, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "DateFinActivite";
            // 
            // btnInserer
            // 
            this.btnInserer.Location = new System.Drawing.Point(233, 261);
            this.btnInserer.Name = "btnInserer";
            this.btnInserer.Size = new System.Drawing.Size(75, 23);
            this.btnInserer.TabIndex = 16;
            this.btnInserer.Text = "Inserer";
            this.btnInserer.UseVisualStyleBackColor = true;
            this.btnInserer.Click += new System.EventHandler(this.btnInserer_Click);
            // 
            // Pilote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 302);
            this.Controls.Add(this.btnInserer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dTP_DateFinActivite);
            this.Controls.Add(this.dTP_DateDbActivite);
            this.Controls.Add(this.dTP_DateNaissance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSalaireBrut);
            this.Controls.Add(this.textVille);
            this.Controls.Add(this.textCdPostal);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.textPil);
            this.Name = "Pilote";
            this.Text = "Pilote";
            this.Load += new System.EventHandler(this.Pilote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPil;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textCdPostal;
        private System.Windows.Forms.TextBox textVille;
        private System.Windows.Forms.TextBox textSalaireBrut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTP_DateNaissance;
        private System.Windows.Forms.DateTimePicker dTP_DateDbActivite;
        private System.Windows.Forms.DateTimePicker dTP_DateFinActivite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInserer;
    }
}