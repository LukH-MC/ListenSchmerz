namespace ListenSchmerz
{
    partial class Kontakte
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lName = new System.Windows.Forms.Label();
            this.lVorname = new System.Windows.Forms.Label();
            this.lAdresse = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Vorname = new System.Windows.Forms.TextBox();
            this.tb_Adresse = new System.Windows.Forms.TextBox();
            this.lTelefon = new System.Windows.Forms.Label();
            this.lMail = new System.Windows.Forms.Label();
            this.lBild = new System.Windows.Forms.Label();
            this.tb_Telefon = new System.Windows.Forms.TextBox();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.16F);
            this.lName.Location = new System.Drawing.Point(51, 42);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(68, 25);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name";
            this.lName.Click += new System.EventHandler(this.lName_Click);
            // 
            // lVorname
            // 
            this.lVorname.AutoSize = true;
            this.lVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.16F);
            this.lVorname.Location = new System.Drawing.Point(51, 134);
            this.lVorname.Name = "lVorname";
            this.lVorname.Size = new System.Drawing.Size(98, 25);
            this.lVorname.TabIndex = 1;
            this.lVorname.Text = "Vorname";
            this.lVorname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lAdresse
            // 
            this.lAdresse.AutoSize = true;
            this.lAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.16F);
            this.lAdresse.Location = new System.Drawing.Point(51, 236);
            this.lAdresse.Name = "lAdresse";
            this.lAdresse.Size = new System.Drawing.Size(91, 25);
            this.lAdresse.TabIndex = 2;
            this.lAdresse.Text = "Adresse";
            this.lAdresse.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(164, 46);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(207, 22);
            this.tb_Name.TabIndex = 3;
            // 
            // tb_Vorname
            // 
            this.tb_Vorname.Location = new System.Drawing.Point(164, 138);
            this.tb_Vorname.Name = "tb_Vorname";
            this.tb_Vorname.Size = new System.Drawing.Size(207, 22);
            this.tb_Vorname.TabIndex = 4;
            // 
            // tb_Adresse
            // 
            this.tb_Adresse.Location = new System.Drawing.Point(164, 240);
            this.tb_Adresse.Name = "tb_Adresse";
            this.tb_Adresse.Size = new System.Drawing.Size(207, 22);
            this.tb_Adresse.TabIndex = 5;
            // 
            // lTelefon
            // 
            this.lTelefon.AutoSize = true;
            this.lTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.16F);
            this.lTelefon.Location = new System.Drawing.Point(430, 43);
            this.lTelefon.Name = "lTelefon";
            this.lTelefon.Size = new System.Drawing.Size(84, 25);
            this.lTelefon.TabIndex = 6;
            this.lTelefon.Text = "Telefon";
            this.lTelefon.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.16F);
            this.lMail.Location = new System.Drawing.Point(430, 134);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(73, 25);
            this.lMail.TabIndex = 7;
            this.lMail.Text = "E-Mail";
            this.lMail.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lBild
            // 
            this.lBild.AutoSize = true;
            this.lBild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.16F);
            this.lBild.Location = new System.Drawing.Point(430, 242);
            this.lBild.Name = "lBild";
            this.lBild.Size = new System.Drawing.Size(48, 25);
            this.lBild.TabIndex = 8;
            this.lBild.Text = "Bild";
            // 
            // tb_Telefon
            // 
            this.tb_Telefon.Location = new System.Drawing.Point(536, 47);
            this.tb_Telefon.Name = "tb_Telefon";
            this.tb_Telefon.Size = new System.Drawing.Size(207, 22);
            this.tb_Telefon.TabIndex = 9;
            // 
            // tb_Mail
            // 
            this.tb_Mail.Location = new System.Drawing.Point(536, 137);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(207, 22);
            this.tb_Mail.TabIndex = 10;
            // 
            // Kontakte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 383);
            this.Controls.Add(this.tb_Mail);
            this.Controls.Add(this.tb_Telefon);
            this.Controls.Add(this.lBild);
            this.Controls.Add(this.lMail);
            this.Controls.Add(this.lTelefon);
            this.Controls.Add(this.tb_Adresse);
            this.Controls.Add(this.tb_Vorname);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lAdresse);
            this.Controls.Add(this.lVorname);
            this.Controls.Add(this.lName);
            this.Name = "Kontakte";
            this.Text = "Kontakte";
            this.Load += new System.EventHandler(this.Kontakte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lVorname;
        private System.Windows.Forms.Label lAdresse;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Vorname;
        private System.Windows.Forms.TextBox tb_Adresse;
        private System.Windows.Forms.Label lTelefon;
        private System.Windows.Forms.Label lMail;
        private System.Windows.Forms.Label lBild;
        private System.Windows.Forms.TextBox tb_Telefon;
        private System.Windows.Forms.TextBox tb_Mail;
    }
}

