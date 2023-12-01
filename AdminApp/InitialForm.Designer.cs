namespace AdminApp
{
    partial class InitialForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.employeeManagementButton = new System.Windows.Forms.Button();
            this.shiftManagementButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(343, 183);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(52, 13);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome";
            // 
            // employeeManagementButton
            // 
            this.employeeManagementButton.Location = new System.Drawing.Point(85, 344);
            this.employeeManagementButton.Name = "employeeManagementButton";
            this.employeeManagementButton.Size = new System.Drawing.Size(191, 81);
            this.employeeManagementButton.TabIndex = 2;
            this.employeeManagementButton.Text = "Open Employee Management Window";
            this.employeeManagementButton.UseVisualStyleBackColor = true;
            this.employeeManagementButton.Click += new System.EventHandler(this.employeeManagementButton_Click);
            // 
            // shiftManagementButton
            // 
            this.shiftManagementButton.Location = new System.Drawing.Point(479, 344);
            this.shiftManagementButton.Name = "shiftManagementButton";
            this.shiftManagementButton.Size = new System.Drawing.Size(191, 81);
            this.shiftManagementButton.TabIndex = 3;
            this.shiftManagementButton.Text = "Open Shift Management Window";
            this.shiftManagementButton.UseVisualStyleBackColor = true;
            this.shiftManagementButton.Click += new System.EventHandler(this.shiftManagementButton_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shiftManagementButton);
            this.Controls.Add(this.employeeManagementButton);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "InitialForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.InitialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button employeeManagementButton;
        private System.Windows.Forms.Button shiftManagementButton;
    }
}