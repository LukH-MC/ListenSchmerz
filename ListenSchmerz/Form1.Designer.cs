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
            this.SuspendLayout();
            // 
            // button_projects
            // 
            this.button_projects.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_projects.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_projects.Location = new System.Drawing.Point(29, 69);
            this.button_projects.Name = "button_projects";
            this.button_projects.Size = new System.Drawing.Size(188, 167);
            this.button_projects.TabIndex = 0;
            this.button_projects.Text = "Projekte verwalten";
            this.button_projects.UseVisualStyleBackColor = true;
            this.button_projects.Click += new System.EventHandler(this.button_projects_Click);
            // 
            // button_employee
            // 
            this.button_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_employee.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_employee.Location = new System.Drawing.Point(296, 69);
            this.button_employee.Name = "button_employee";
            this.button_employee.Size = new System.Drawing.Size(188, 167);
            this.button_employee.TabIndex = 1;
            this.button_employee.Text = "Mitarbeiter/-innen";
            this.button_employee.UseVisualStyleBackColor = true;
            this.button_employee.Click += new System.EventHandler(this.button_employee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 306);
            this.Controls.Add(this.button_employee);
            this.Controls.Add(this.button_projects);
            this.Name = "Form1";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_projects;
        private System.Windows.Forms.Button button_employee;
    }
}

