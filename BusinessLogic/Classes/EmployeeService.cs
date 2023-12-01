using MediaBazarCommon.DTOs;
using MediaBazarCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Classes
{
    public class EmployeeService : IEmployeeOperations
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

        public void AddEmployee(EmployeeDTO employeeDto)
        {
            // Convert DTO to Domain Object
            var employee = new Employee(
                employeeDto.ID,
                employeeDto.FirstName,
                employeeDto.LastName,
                employeeDto.JobPosition,
                employeeDto.Department
            );

            // Perform business logic on the Domain Object
            // ...

            // Convert back to DTO for repository interaction
            var dto = ConvertToDTO(employee);
            employeeRepository.AddEmployee(dto);
        }

        public void UpdateEmployee(EmployeeDTO employeeDto)
        {
            // Convert DTO to Domain Object
            var employee = DtoToDomain(employeeDto);

            // Any business logic here

            // Convert back to DTO for repository interaction
            employeeDto = ConvertToDTO(employee);
            employeeRepository.UpdateEmployee(employeeDto);
        }


        public void DeleteEmployee(string id)
        {
            // Business logic before deleting an employee, if any
            employeeRepository.DeleteEmployee(id);
        }

        public EmployeeDTO GetEmployeeById(string id)
        {
            var employeeDto = employeeRepository.GetEmployeeById(id);
            if (employeeDto != null)
            {
                // Convert DTO to Domain Object if needed for business logic
                var employee = DtoToDomain(employeeDto);

                // Any business logic here

                // Convert back to DTO for return
                return ConvertToDTO(employee);
            }
            return null;
        }


        public IEnumerable<EmployeeDTO> GetAllEmployees()
        {
            var employeeDtos = employeeRepository.GetAllEmployees();
            var employees = employeeDtos.Select(dto => DtoToDomain(dto)).ToList();

            // Any business logic here

            return employees.Select(emp => ConvertToDTO(emp));
        }
        private Employee DtoToDomain(EmployeeDTO dto)
        {
            return new Employee(dto.ID, dto.FirstName, dto.LastName, dto.JobPosition, dto.Department);
        }

        private EmployeeDTO ConvertToDTO(Employee employee)
        {
            return new EmployeeDTO
            {
                ID = employee.ID,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                JobPosition = employee.JobPosition,
                Department = employee.Department
            };
        }
        public string FormatEmployeeDataForDisplay(EmployeeDTO employee)
        {
            if (employee == null)
            {
                return "Invalid Employee";
            }

            return $"ID: {employee.ID}, Name: {employee.FirstName} {employee.LastName}, Position: {employee.JobPosition}, Department: {employee.Department}";
        }

    }
}
