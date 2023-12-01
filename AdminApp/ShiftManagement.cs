using BusinessLogic.Classes;
using MediaBazarCommon.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class ShiftManagement : Form
    {
        ShiftService shiftService;
        EmployeeService employeeService;
        public ShiftManagement(EmployeeService employeeService, ShiftService shiftService)
        {
            this.employeeService = employeeService;
            this.shiftService = shiftService;
            InitializeComponent();
            PopulateShiftTypeComboBox(cBoxShiftTypes);
            LoadInitialData();
        }

        private void LoadInitialData()
        {
            List<Shift> shifts = shiftService.GetAllShifts().Select(dto => new Shift(dto.Date, dto.Type, dto.EmployeeID)).ToList();
            lBoxDataShow.Items.Clear();

            if (shifts != null)
            {
                foreach (Shift shift in shifts)
                {
                    lBoxDataShow.Items.Add(shift.ToString());
                }
            }
            else
            {
                MessageBox.Show("No shifts found.");
            }
        }

        private void PopulateShiftTypeComboBox(ComboBox comboBox)
        {
            foreach (string sType in Enum.GetNames(typeof(ShiftType)))
            {
                comboBox.Items.Add(sType);
            }
        }

        private void btnShowExistingShifts_Click(object sender, EventArgs e)
        {
            List<Shift> shifts = shiftService.GetAllShifts().Select(dto => new Shift(dto.Date, dto.Type, dto.EmployeeID)).ToList();

            lBoxDataShow.Items.Clear();

            if (shifts != null)
            {
                foreach (Shift shift in shifts)
                {
                    lBoxDataShow.Items.Add(shift.ToString());
                }
            }
            else
            {
                MessageBox.Show("No shifts found.");
            }
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            string empId = nudEmpIDForShiftAdding.Value.ToString();
            DateTime shiftDate = dtpShiftDate.Value;
            ShiftType shiftType = (ShiftType)Enum.Parse(typeof(ShiftType), cBoxShiftTypes.SelectedItem.ToString());

            // Create a ShiftDTO from Shift object
            ShiftDTO newShiftDto = new ShiftDTO
            {
                Date = shiftDate,
                Type = shiftType,
                EmployeeID = empId
            };

            shiftService.ScheduleShift(newShiftDto); // Pass the ShiftDTO to the ScheduleShift method

            MessageBox.Show("Shift added successfully!");
        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            InitialForm initialForm = new InitialForm(employeeService, shiftService);
            this.Hide();
            initialForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
