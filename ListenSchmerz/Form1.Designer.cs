namespace ListenSchmerz
{
    partial class Form1
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
            this.button_projects = new System.Windows.Forms.Button();
            this.button_employee = new System.Windows.Forms.Button();
            this.button_togleDarkMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_projects
            // 
            this.button_projects.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_projects.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_projects.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_projects.Location = new System.Drawing.Point(14, 70);
            this.button_projects.Margin = new System.Windows.Forms.Padding(2);
            this.button_projects.Name = "button_projects";
            this.button_projects.Size = new System.Drawing.Size(176, 170);
            this.button_projects.TabIndex = 0;
            this.button_projects.Text = "Projekte verwalten";
            this.button_projects.UseVisualStyleBackColor = false;
            this.button_projects.Click += new System.EventHandler(this.button_projects_Click);
            // 
            // button_employee
            // 
            this.button_employee.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_employee.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_employee.Location = new System.Drawing.Point(278, 70);
            this.button_employee.Margin = new System.Windows.Forms.Padding(2);
            this.button_employee.Name = "button_employee";
            this.button_employee.Size = new System.Drawing.Size(176, 170);
            this.button_employee.TabIndex = 1;
            this.button_employee.Text = "Mitarbeiter/-innen";
            this.button_employee.UseVisualStyleBackColor = false;
            this.button_employee.Click += new System.EventHandler(this.button_employee_Click);
            // 
            // button_togleDarkMode
            // 
            this.button_togleDarkMode.BackColor = System.Drawing.Color.Transparent;
            this.button_togleDarkMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_togleDarkMode.ForeColor = System.Drawing.Color.Black;
            this.button_togleDarkMode.Location = new System.Drawing.Point(451, 0);
            this.button_togleDarkMode.Margin = new System.Windows.Forms.Padding(4);
            this.button_togleDarkMode.Name = "button_togleDarkMode";
            this.button_togleDarkMode.Size = new System.Drawing.Size(32, 38);
            this.button_togleDarkMode.TabIndex = 2;
            this.button_togleDarkMode.Text = "🌙";
            this.button_togleDarkMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_togleDarkMode.UseVisualStyleBackColor = false;
            this.button_togleDarkMode.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.button_togleDarkMode);
            this.Controls.Add(this.button_employee);
            this.Controls.Add(this.button_projects);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(502, 358);
            this.MinimumSize = new System.Drawing.Size(502, 358);
            this.Name = "Form1";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_projects;
        private System.Windows.Forms.Button button_employee;
        private System.Windows.Forms.Button button_togleDarkMode;
    }
}

