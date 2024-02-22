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
            this.button_Speichern = new System.Windows.Forms.Button();
            this.button_suche = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_imageLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.16F);
            this.lName.Location = new System.Drawing.Point(38, 34);
            this.lName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(53, 20);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name";
            this.lName.Click += new System.EventHandler(this.lName_Click);
            // 
            // lVorname
            // 
            this.lVorname.AutoSize = true;
            this.lVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.16F);
            this.lVorname.Location = new System.Drawing.Point(38, 109);
            this.lVorname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lVorname.Name = "lVorname";
            this.lVorname.Size = new System.Drawing.Size(76, 20);
            this.lVorname.TabIndex = 1;
            this.lVorname.Text = "Vorname";
            this.lVorname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lAdresse
            // 
            this.lAdresse.AutoSize = true;
            this.lAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.16F);
            this.lAdresse.Location = new System.Drawing.Point(38, 192);
            this.lAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAdresse.Name = "lAdresse";
            this.lAdresse.Size = new System.Drawing.Size(71, 20);
            this.lAdresse.TabIndex = 2;
            this.lAdresse.Text = "Adresse";
            this.lAdresse.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(123, 37);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(156, 20);
            this.tb_Name.TabIndex = 3;
            // 
            // tb_Vorname
            // 
            this.tb_Vorname.Location = new System.Drawing.Point(123, 112);
            this.tb_Vorname.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Vorname.Name = "tb_Vorname";
            this.tb_Vorname.Size = new System.Drawing.Size(156, 20);
            this.tb_Vorname.TabIndex = 4;
            // 
            // tb_Adresse
            // 
            this.tb_Adresse.Location = new System.Drawing.Point(123, 195);
            this.tb_Adresse.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Adresse.Name = "tb_Adresse";
            this.tb_Adresse.Size = new System.Drawing.Size(156, 20);
            this.tb_Adresse.TabIndex = 5;
            // 
            // lTelefon
            // 
            this.lTelefon.AutoSize = true;
            this.lTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.16F);
            this.lTelefon.Location = new System.Drawing.Point(322, 35);
            this.lTelefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTelefon.Name = "lTelefon";
            this.lTelefon.Size = new System.Drawing.Size(64, 20);
            this.lTelefon.TabIndex = 6;
            this.lTelefon.Text = "Telefon";
            this.lTelefon.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.16F);
            this.lMail.Location = new System.Drawing.Point(322, 109);
            this.lMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(57, 20);
            this.lMail.TabIndex = 7;
            this.lMail.Text = "E-Mail";
            this.lMail.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lBild
            // 
            this.lBild.AutoSize = true;
            this.lBild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.16F);
            this.lBild.Location = new System.Drawing.Point(322, 197);
            this.lBild.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lBild.Name = "lBild";
            this.lBild.Size = new System.Drawing.Size(38, 20);
            this.lBild.TabIndex = 8;
            this.lBild.Text = "Bild";
            // 
            // tb_Telefon
            // 
            this.tb_Telefon.Location = new System.Drawing.Point(402, 38);
            this.tb_Telefon.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Telefon.Name = "tb_Telefon";
            this.tb_Telefon.Size = new System.Drawing.Size(156, 20);
            this.tb_Telefon.TabIndex = 9;
            // 
            // tb_Mail
            // 
            this.tb_Mail.Location = new System.Drawing.Point(402, 111);
            this.tb_Mail.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(156, 20);
            this.tb_Mail.TabIndex = 10;
            // 
            // button_Speichern
            // 
            this.button_Speichern.Location = new System.Drawing.Point(103, 346);
            this.button_Speichern.Margin = new System.Windows.Forms.Padding(2);
            this.button_Speichern.Name = "button_Speichern";
            this.button_Speichern.Size = new System.Drawing.Size(64, 24);
            this.button_Speichern.TabIndex = 11;
            this.button_Speichern.Text = "Speichern";
            this.button_Speichern.UseVisualStyleBackColor = true;
            this.button_Speichern.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_suche
            // 
            this.button_suche.Location = new System.Drawing.Point(180, 346);
            this.button_suche.Margin = new System.Windows.Forms.Padding(2);
            this.button_suche.Name = "button_suche";
            this.button_suche.Size = new System.Drawing.Size(99, 24);
            this.button_suche.TabIndex = 12;
            this.button_suche.Text = "Daten suchen";
            this.button_suche.UseVisualStyleBackColor = true;
            this.button_suche.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(402, 192);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(182, 182);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // button_imageLoad
            // 
            this.button_imageLoad.BackColor = System.Drawing.SystemColors.Control;
            this.button_imageLoad.Location = new System.Drawing.Point(300, 346);
            this.button_imageLoad.Margin = new System.Windows.Forms.Padding(2);
            this.button_imageLoad.Name = "button_imageLoad";
            this.button_imageLoad.Size = new System.Drawing.Size(79, 24);
            this.button_imageLoad.TabIndex = 14;
            this.button_imageLoad.Text = "Bild laden";
            this.button_imageLoad.UseVisualStyleBackColor = false;
            this.button_imageLoad.Click += new System.EventHandler(this.button2_Click);
            // 
            // Kontakte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 394);
            this.Controls.Add(this.button_imageLoad);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button_suche);
            this.Controls.Add(this.button_Speichern);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(716, 433);
            this.Name = "Kontakte";
            this.Text = "Kontakte";
            this.Load += new System.EventHandler(this.Kontakte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
        private System.Windows.Forms.Button button_Speichern;
        private System.Windows.Forms.Button button_suche;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_imageLoad;
    }
}

