using MediaBazarCommon.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic.Classes
{
    public class Shift
    {
        public int ShiftId { get; set; } 

        public DateTime Date { get; set; }
        public ShiftType Type { get; set; } // Using ShiftType from MediaBazarCommon.DTOs
        public string EmployeeID { get; set; }

        public Shift(DateTime date, ShiftType type, string employeeID)
        {
            this.Date = date;
            this.Type = type;
            this.EmployeeID = employeeID;
        }

        public override string ToString()
        {
            return $"Shift [Date: {Date.ToShortDateString()}, Type: {Type}, EmployeeID: {EmployeeID}]";
        }
    }
}