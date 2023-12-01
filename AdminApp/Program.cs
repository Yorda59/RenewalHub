using AdminApp;
using BusinessLogic.Classes;
using MediaBazarCommon.Interfaces;
using MediaBazarDataAccess; // Import the necessary namespace for your data access classes
using System;
using System.Windows.Forms;

namespace BusinessLogic
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Retrieve the connection string from your application configuration
               string connStr = "Server=mssqlstud.fhict.local;Database=dbi501637;User Id=dbi501637;Password=darSlovo;TrustServerCertificate=true";

        // Create instances of the data access classes with the connection string
            var employeeRepository = new DBOpsEmployee(connStr);
            var shiftRepository = new DBOpsShift(connStr);

            // Create instances of the business logic services
            var employeeService = new EmployeeService(employeeRepository);
            var shiftService = new ShiftService(shiftRepository);

            Application.Run(new InitialForm(employeeService, shiftService));
        }
    }
}
