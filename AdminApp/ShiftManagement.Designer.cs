namespace AdminApp
{
    partial class ShiftManagement
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
            this.lBoxDataShow = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.btnShowExistingShifts = new System.Windows.Forms.Button();
            this.nudEmpIDForShiftAdding = new System.Windows.Forms.NumericUpDown();
            this.dtpShiftDate = new System.Windows.Forms.DateTimePicker();
            this.cBoxShiftTypes = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backToLoginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpIDForShiftAdding)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxDataShow
            // 
            this.lBoxDataShow.BackColor = System.Drawing.Color.HotPink;
            this.lBoxDataShow.FormattingEnabled = true;
            this.lBoxDataShow.Location = new System.Drawing.Point(-4, 224);
            this.lBoxDataShow.Name = "lBoxDataShow";
            this.lBoxDataShow.Size = new System.Drawing.Size(865, 212);
            this.lBoxDataShow.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(13, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 24);
            this.label13.TabIndex = 6;
            this.label13.Text = " Shift Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(17, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 24);
            this.label12.TabIndex = 5;
            this.label12.Text = "Shift Date ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(17, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 24);
            this.label11.TabIndex = 4;
            this.label11.Text = "Employee ID";
            // 
            // btnAddShift
            // 
            this.btnAddShift.Location = new System.Drawing.Point(297, 91);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(124, 26);
            this.btnAddShift.TabIndex = 11;
            this.btnAddShift.Text = "Add Shift";
            this.btnAddShift.UseVisualStyleBackColor = true;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // btnShowExistingShifts
            // 
            this.btnShowExistingShifts.Location = new System.Drawing.Point(16, 180);
            this.btnShowExistingShifts.Name = "btnShowExistingShifts";
            this.btnShowExistingShifts.Size = new System.Drawing.Size(124, 34);
            this.btnShowExistingShifts.TabIndex = 14;
            this.btnShowExistingShifts.Text = "Show All Shifts";
            this.btnShowExistingShifts.UseVisualStyleBackColor = true;
            this.btnShowExistingShifts.Click += new System.EventHandler(this.btnShowExistingShifts_Click);
            // 
            // nudEmpIDForShiftAdding
            // 
            this.nudEmpIDForShiftAdding.Location = new System.Drawing.Point(165, 19);
            this.nudEmpIDForShiftAdding.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudEmpIDForShiftAdding.Name = "nudEmpIDForShiftAdding";
            this.nudEmpIDForShiftAdding.Size = new System.Drawing.Size(100, 20);
            this.nudEmpIDForShiftAdding.TabIndex = 15;
            // 
            // dtpShiftDate
            // 
            this.dtpShiftDate.Location = new System.Drawing.Point(165, 56);
            this.dtpShiftDate.Name = "dtpShiftDate";
            this.dtpShiftDate.Size = new System.Drawing.Size(200, 20);
            this.dtpShiftDate.TabIndex = 17;
            // 
            // cBoxShiftTypes
            // 
            this.cBoxShiftTypes.FormattingEnabled = true;
            this.cBoxShiftTypes.Location = new System.Drawing.Point(170, 95);
            this.cBoxShiftTypes.Name = "cBoxShiftTypes";
            this.cBoxShiftTypes.Size = new System.Drawing.Size(121, 21);
            this.cBoxShiftTypes.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox3.Controls.Add(this.backToLoginButton);
            this.groupBox3.Controls.Add(this.cBoxShiftTypes);
            this.groupBox3.Controls.Add(this.dtpShiftDate);
            this.groupBox3.Controls.Add(this.nudEmpIDForShiftAdding);
            this.groupBox3.Controls.Add(this.btnShowExistingShifts);
            this.groupBox3.Controls.Add(this.btnAddShift);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(-4, -1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(862, 227);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shift Form";
            // 
            // backToLoginButton
            // 
            this.backToLoginButton.Location = new System.Drawing.Point(721, 180);
            this.backToLoginButton.Name = "backToLoginButton";
            this.backToLoginButton.Size = new System.Drawing.Size(127, 39);
            this.backToLoginButton.TabIndex = 30;
            this.backToLoginButton.Text = "Back To Login";
            this.backToLoginButton.UseVisualStyleBackColor = true;
            this.backToLoginButton.Click += new System.EventHandler(this.backToLoginButton_Click);
            // 
            // ShiftManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 434);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lBoxDataShow);
            this.Name = "ShiftManagement";
            this.Text = "ShiftManagement";
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpIDForShiftAdding)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxDataShow;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.Button btnShowExistingShifts;
        private System.Windows.Forms.NumericUpDown nudEmpIDForShiftAdding;
        private System.Windows.Forms.DateTimePicker dtpShiftDate;
        private System.Windows.Forms.ComboBox cBoxShiftTypes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button backToLoginButton;
    }
}