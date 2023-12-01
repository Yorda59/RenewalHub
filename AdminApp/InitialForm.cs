using BusinessLogic.Classes;
using System;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class InitialForm : Form
    {
        private EmployeeService employeeService;
        private ShiftService shiftService;
        private void InitialForm_Load(object sender, EventArgs e)
        {
            // Your code here. For example:
            welcomeLabel.Text = "Welcome to the Initial Form!";
        }

        public InitialForm(EmployeeService employeeService, ShiftService shiftService)
        {
            this.employeeService = employeeService;
            this.shiftService = shiftService;
            InitializeComponent();
        }

        private void employeeManagementButton_Click(object sender, EventArgs e)
        {
            EmployeeManagement employeeManagement = new EmployeeManagement(employeeService, shiftService);
            this.Hide();
            employeeManagement.Show();
        }

        private void shiftManagementButton_Click(object sender, EventArgs e)
        {
            ShiftManagement shiftManagement = new ShiftManagement(employeeService, shiftService);
            this.Hide();
            shiftManagement.Show();
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
