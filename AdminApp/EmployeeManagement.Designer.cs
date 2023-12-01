namespace AdminApp
{
    partial class EmployeeManagement
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
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backToLoginButton = new System.Windows.Forms.Button();
            this.comboBoxNewEmployeePosition = new System.Windows.Forms.ComboBox();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.txtBoxNewEmployeeSecondName = new System.Windows.Forms.GroupBox();
            this.nudNewEmployeeID = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxNewEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowInfoByID = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxShowEmployeeByID = new System.Windows.Forms.TextBox();
            this.lBoxDataShow = new System.Windows.Forms.ListBox();
            this.groupBoxAddForm = new System.Windows.Forms.GroupBox();
            this.comboBoxEmployeePosition = new System.Windows.Forms.ComboBox();
            this.nudEmployeeID = new System.Windows.Forms.NumericUpDown();
            this.btnShowEmployees = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.txtBoxEmployeeSecondName = new System.Windows.Forms.TextBox();
            this.txtBoxEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.lblPCN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxDepAddEmployee = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxDepUpdate = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.txtBoxNewEmployeeSecondName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewEmployeeID)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxAddForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmployeeID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(96, 81);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(100, 25);
            this.btnDeleteEmployee.TabIndex = 7;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(61, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox2.Controls.Add(this.backToLoginButton);
            this.groupBox2.Controls.Add(this.btnDeleteEmployee);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(405, 412);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 190);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Box";
            // 
            // backToLoginButton
            // 
            this.backToLoginButton.Location = new System.Drawing.Point(291, 148);
            this.backToLoginButton.Name = "backToLoginButton";
            this.backToLoginButton.Size = new System.Drawing.Size(156, 36);
            this.backToLoginButton.TabIndex = 28;
            this.backToLoginButton.Text = "Back To Login";
            this.backToLoginButton.UseVisualStyleBackColor = true;
            this.backToLoginButton.Click += new System.EventHandler(this.backToLoginButton_Click);
            // 
            // comboBoxNewEmployeePosition
            // 
            this.comboBoxNewEmployeePosition.FormattingEnabled = true;
            this.comboBoxNewEmployeePosition.Location = new System.Drawing.Point(123, 126);
            this.comboBoxNewEmployeePosition.Name = "comboBoxNewEmployeePosition";
            this.comboBoxNewEmployeePosition.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNewEmployeePosition.TabIndex = 16;
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(107, 215);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(89, 25);
            this.btnUpdateEmployee.TabIndex = 7;
            this.btnUpdateEmployee.Text = "Submit Updates";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click_1);
            // 
            // txtBoxNewEmployeeSecondName
            // 
            this.txtBoxNewEmployeeSecondName.BackColor = System.Drawing.Color.MediumPurple;
            this.txtBoxNewEmployeeSecondName.Controls.Add(this.comboBoxDepUpdate);
            this.txtBoxNewEmployeeSecondName.Controls.Add(this.label11);
            this.txtBoxNewEmployeeSecondName.Controls.Add(this.comboBoxNewEmployeePosition);
            this.txtBoxNewEmployeeSecondName.Controls.Add(this.btnUpdateEmployee);
            this.txtBoxNewEmployeeSecondName.Controls.Add(this.nudNewEmployeeID);
            this.txtBoxNewEmployeeSecondName.Controls.Add(this.label7);
            this.txtBoxNewEmployeeSecondName.Controls.Add(this.label4);
            this.txtBoxNewEmployeeSecondName.Controls.Add(this.label8);
            this.txtBoxNewEmployeeSecondName.Controls.Add(this.label5);
            this.txtBoxNewEmployeeSecondName.Controls.Add(this.txtBoxNewEmployeeFirstName);
            this.txtBoxNewEmployeeSecondName.Controls.Add(this.textBox2);
            this.txtBoxNewEmployeeSecondName.Location = new System.Drawing.Point(412, 0);
            this.txtBoxNewEmployeeSecondName.Name = "txtBoxNewEmployeeSecondName";
            this.txtBoxNewEmployeeSecondName.Size = new System.Drawing.Size(453, 255);
            this.txtBoxNewEmployeeSecondName.TabIndex = 27;
            this.txtBoxNewEmployeeSecondName.TabStop = false;
            this.txtBoxNewEmployeeSecondName.Text = "Update Data";
            // 
            // nudNewEmployeeID
            // 
            this.nudNewEmployeeID.Location = new System.Drawing.Point(123, 93);
            this.nudNewEmployeeID.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudNewEmployeeID.Name = "nudNewEmployeeID";
            this.nudNewEmployeeID.Size = new System.Drawing.Size(100, 20);
            this.nudNewEmployeeID.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(6, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Working as";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last Name";
            // 
            // txtBoxNewEmployeeFirstName
            // 
            this.txtBoxNewEmployeeFirstName.Location = new System.Drawing.Point(123, 16);
            this.txtBoxNewEmployeeFirstName.Name = "txtBoxNewEmployeeFirstName";
            this.txtBoxNewEmployeeFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNewEmployeeFirstName.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Controls.Add(this.btnShowInfoByID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tboxShowEmployeeByID);
            this.groupBox1.Location = new System.Drawing.Point(-7, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 190);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Box";
            // 
            // btnShowInfoByID
            // 
            this.btnShowInfoByID.Location = new System.Drawing.Point(99, 81);
            this.btnShowInfoByID.Name = "btnShowInfoByID";
            this.btnShowInfoByID.Size = new System.Drawing.Size(100, 25);
            this.btnShowInfoByID.TabIndex = 7;
            this.btnShowInfoByID.Text = "Show Info";
            this.btnShowInfoByID.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(64, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID";
            // 
            // tboxShowEmployeeByID
            // 
            this.tboxShowEmployeeByID.Location = new System.Drawing.Point(99, 38);
            this.tboxShowEmployeeByID.Name = "tboxShowEmployeeByID";
            this.tboxShowEmployeeByID.Size = new System.Drawing.Size(100, 20);
            this.tboxShowEmployeeByID.TabIndex = 5;
            // 
            // lBoxDataShow
            // 
            this.lBoxDataShow.BackColor = System.Drawing.Color.HotPink;
            this.lBoxDataShow.FormattingEnabled = true;
            this.lBoxDataShow.Location = new System.Drawing.Point(-7, 254);
            this.lBoxDataShow.Name = "lBoxDataShow";
            this.lBoxDataShow.Size = new System.Drawing.Size(865, 160);
            this.lBoxDataShow.TabIndex = 25;
            // 
            // groupBoxAddForm
            // 
            this.groupBoxAddForm.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBoxAddForm.Controls.Add(this.comboBoxDepAddEmployee);
            this.groupBoxAddForm.Controls.Add(this.label10);
            this.groupBoxAddForm.Controls.Add(this.comboBoxEmployeePosition);
            this.groupBoxAddForm.Controls.Add(this.txtBoxNewEmployeeSecondName);
            this.groupBoxAddForm.Controls.Add(this.nudEmployeeID);
            this.groupBoxAddForm.Controls.Add(this.btnShowEmployees);
            this.groupBoxAddForm.Controls.Add(this.label3);
            this.groupBoxAddForm.Controls.Add(this.btnAddEmployee);
            this.groupBoxAddForm.Controls.Add(this.txtBoxEmployeeSecondName);
            this.groupBoxAddForm.Controls.Add(this.txtBoxEmployeeFirstName);
            this.groupBoxAddForm.Controls.Add(this.lblPCN);
            this.groupBoxAddForm.Controls.Add(this.label1);
            this.groupBoxAddForm.Controls.Add(this.label2);
            this.groupBoxAddForm.Location = new System.Drawing.Point(-7, -1);
            this.groupBoxAddForm.Name = "groupBoxAddForm";
            this.groupBoxAddForm.Size = new System.Drawing.Size(865, 255);
            this.groupBoxAddForm.TabIndex = 24;
            this.groupBoxAddForm.TabStop = false;
            this.groupBoxAddForm.Text = "Add Form";
            // 
            // comboBoxEmployeePosition
            // 
            this.comboBoxEmployeePosition.FormattingEnabled = true;
            this.comboBoxEmployeePosition.Location = new System.Drawing.Point(181, 126);
            this.comboBoxEmployeePosition.Name = "comboBoxEmployeePosition";
            this.comboBoxEmployeePosition.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmployeePosition.TabIndex = 16;
            this.comboBoxEmployeePosition.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployeePosition_SelectedIndexChanged);
            // 
            // nudEmployeeID
            // 
            this.nudEmployeeID.Location = new System.Drawing.Point(181, 93);
            this.nudEmployeeID.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudEmployeeID.Name = "nudEmployeeID";
            this.nudEmployeeID.Size = new System.Drawing.Size(100, 20);
            this.nudEmployeeID.TabIndex = 15;
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.Location = new System.Drawing.Point(12, 215);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.Size = new System.Drawing.Size(124, 34);
            this.btnShowEmployees.TabIndex = 14;
            this.btnShowEmployees.Text = "Show All";
            this.btnShowEmployees.UseVisualStyleBackColor = true;
            this.btnShowEmployees.Click += new System.EventHandler(this.btnShowEmployees_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(17, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Working as";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(12, 183);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(124, 26);
            this.btnAddEmployee.TabIndex = 11;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // txtBoxEmployeeSecondName
            // 
            this.txtBoxEmployeeSecondName.Location = new System.Drawing.Point(181, 52);
            this.txtBoxEmployeeSecondName.Name = "txtBoxEmployeeSecondName";
            this.txtBoxEmployeeSecondName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEmployeeSecondName.TabIndex = 0;
            // 
            // txtBoxEmployeeFirstName
            // 
            this.txtBoxEmployeeFirstName.Location = new System.Drawing.Point(181, 16);
            this.txtBoxEmployeeFirstName.Name = "txtBoxEmployeeFirstName";
            this.txtBoxEmployeeFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEmployeeFirstName.TabIndex = 1;
            // 
            // lblPCN
            // 
            this.lblPCN.AutoSize = true;
            this.lblPCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPCN.Location = new System.Drawing.Point(17, 16);
            this.lblPCN.Name = "lblPCN";
            this.lblPCN.Size = new System.Drawing.Size(111, 24);
            this.lblPCN.TabIndex = 4;
            this.lblPCN.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(19, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 24);
            this.label10.TabIndex = 28;
            this.label10.Text = "Department";
            // 
            // comboBoxDepAddEmployee
            // 
            this.comboBoxDepAddEmployee.FormattingEnabled = true;
            this.comboBoxDepAddEmployee.Location = new System.Drawing.Point(181, 160);
            this.comboBoxDepAddEmployee.Name = "comboBoxDepAddEmployee";
            this.comboBoxDepAddEmployee.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDepAddEmployee.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Snow;
            this.label11.Location = new System.Drawing.Point(6, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 24);
            this.label11.TabIndex = 30;
            this.label11.Text = "Department";
            // 
            // comboBoxDepUpdate
            // 
            this.comboBoxDepUpdate.FormattingEnabled = true;
            this.comboBoxDepUpdate.Location = new System.Drawing.Point(123, 160);
            this.comboBoxDepUpdate.Name = "comboBoxDepUpdate";
            this.comboBoxDepUpdate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDepUpdate.TabIndex = 30;
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lBoxDataShow);
            this.Controls.Add(this.groupBoxAddForm);
            this.Name = "EmployeeManagement";
            this.Text = "Form2";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.txtBoxNewEmployeeSecondName.ResumeLayout(false);
            this.txtBoxNewEmployeeSecondName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewEmployeeID)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxAddForm.ResumeLayout(false);
            this.groupBoxAddForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmployeeID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxNewEmployeePosition;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.GroupBox txtBoxNewEmployeeSecondName;
        private System.Windows.Forms.NumericUpDown nudNewEmployeeID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxNewEmployeeFirstName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowInfoByID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxShowEmployeeByID;
        private System.Windows.Forms.ListBox lBoxDataShow;
        private System.Windows.Forms.GroupBox groupBoxAddForm;
        private System.Windows.Forms.ComboBox comboBoxEmployeePosition;
        private System.Windows.Forms.NumericUpDown nudEmployeeID;
        private System.Windows.Forms.Button btnShowEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox txtBoxEmployeeSecondName;
        private System.Windows.Forms.TextBox txtBoxEmployeeFirstName;
        private System.Windows.Forms.Label lblPCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backToLoginButton;
        private System.Windows.Forms.ComboBox comboBoxDepAddEmployee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxDepUpdate;
        private System.Windows.Forms.Label label11;
    }
}