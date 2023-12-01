using MediaBazarCommon.DTOs;
using System.Collections.Generic;

namespace BusinessLogic.Classes
{
    public class Employee
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Position JobPosition { get; set; } // Using Position from MediaBazarCommon.DTOs
        public List<Shift> Shifts { get; set; } // Assuming Shift is defined in your BusinessLogic.Classes
        public Department Department { get; set; } // Using Department from MediaBazarCommon.DTOs

        public Employee(string id, string firstName, string lastName, Position jobPosition, Department department)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.JobPosition = jobPosition;
            this.Shifts = new List<Shift>();  // Initialize the shifts list
            this.Department = department;
        }

        public void AddShift(Shift shift)
        {
            if (shift != null)
            {
                this.Shifts.Add(shift);
            }
        }

        public List<Shift> GetShifts()
        {
            return Shifts;
        }

        public override string ToString()
        {
            return $"Employee [ID: {ID}, First Name: {FirstName}, Last Name: {LastName}, Position: {JobPosition}, Department: {Department}]";
        }
    }
}
