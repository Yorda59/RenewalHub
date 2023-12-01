using BusinessLogic.Classes;
using MediaBazarCommon.DTOs;
using MediaBazarCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class EmployeeManagement : Form
    {
        private EmployeeService employeeService;
        private ShiftService shiftService;
        public EmployeeManagement(EmployeeService employeeService, ShiftService shiftService)
        {
            this.employeeService = employeeService;
            this.shiftService = shiftService;
            InitializeComponent();
            PopulateComboBoxes();
            // ...
        }

        private void PopulateComboBoxes()
        {
            comboBoxEmployeePosition.DataSource = Enum.GetValues(typeof(MediaBazarCommon.DTOs.Position));
            comboBoxDepAddEmployee.DataSource = Enum.GetValues(typeof(MediaBazarCommon.DTOs.Department));
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string id = nudEmployeeID.Value.ToString();  // Assuming nudEmployeeID is a control like a numeric up-down or text box
            string firstName = txtBoxEmployeeFirstName.Text;
            string lastName = txtBoxEmployeeSecondName.Text;
            var selectedPosition = (MediaBazarCommon.DTOs.Position)Enum.Parse(typeof(MediaBazarCommon.DTOs.Position), comboBoxEmployeePosition.SelectedItem.ToString());
            var selectedDepartment = (MediaBazarCommon.DTOs.Department)Enum.Parse(typeof(MediaBazarCommon.DTOs.Department), comboBoxDepAddEmployee.SelectedItem.ToString());

            EmployeeDTO newEmployeeDto = new EmployeeDTO
            {
                ID = id,
                FirstName = firstName,
                LastName = lastName,
                JobPosition = selectedPosition,
                Department = selectedDepartment
            };
                
            try
            {
                employeeService.AddEmployee(newEmployeeDto);
                MessageBox.Show("Employee added successfully!");
                UpdateEmployeeList(); // Refresh the list to show the newly added employee
            }
            catch (Exception ex)    
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            lBoxDataShow.Items.Clear();
            foreach (EmployeeDTO employeeDto in employeeService.GetAllEmployees())
            {
                lBoxDataShow.Items.Add(employeeService.FormatEmployeeDataForDisplay(employeeDto));
            }
        }

        private void btnShowInfoByID_Click(object sender, EventArgs e)
        {
            lBoxDataShow.Items.Clear();
            EmployeeDTO foundEmployeeDto = employeeService.GetEmployeeById(tboxShowEmployeeByID.Text);
            if (foundEmployeeDto != null)
            {
                lBoxDataShow.Items.Add(foundEmployeeDto.ToString());
            }
            else
            {
                lBoxDataShow.Items.Add("Employee not found.");
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            string id = nudEmployeeID.Value.ToString();
            try
            {
                employeeService.DeleteEmployee(id);
                MessageBox.Show("Employee deleted successfully!");
                UpdateEmployeeList();  // Refresh the list
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateEmployeeList()
        {
            lBoxDataShow.Items.Clear();
            foreach (var employeeDto in employeeService.GetAllEmployees())
            {
                lBoxDataShow.Items.Add(employeeDto.ToString());
            }
        }
        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            InitialForm initialForm = new InitialForm(employeeService, shiftService);
            initialForm.Show();
            this.Close();
        }


        private void comboBoxEmployeePosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Your code here
        }
        private void btnUpdateEmployee_Click_1(object sender, EventArgs e)
        {

        }
        private void EmployeeManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

    }
}
