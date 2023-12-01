using MediaBazarCommon.DTOs;
using MediaBazarCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Classes
{
    public class ShiftService : IShiftOperations
    {
        private readonly IShiftRepository shiftRepository;

        public ShiftService(IShiftRepository shiftRepository)
        {
            this.shiftRepository = shiftRepository ?? throw new ArgumentNullException(nameof(shiftRepository));
        }

        public void ScheduleShift(ShiftDTO shiftDto)
        {
            var shift = ConvertToDomain(shiftDto);
            // Perform business logic
            var dto = ConvertToDTO(shift);
            shiftRepository.AddShift(dto);
        }

        public void CancelShift(int shiftId)
        {
            // Fetch ShiftDTO (if needed for business logic)
            var shiftDto = shiftRepository.GetShiftById(shiftId);
            if (shiftDto == null) return;

            var shift = new Shift(shiftDto.Date, shiftDto.Type, shiftDto.EmployeeID);

            // Apply business logic if needed
            // ...

            shiftRepository.DeleteShift(shiftId);
        }

        public void ChangeShift(ShiftDTO shiftDto)
        {
            var shift = new Shift(shiftDto.Date, shiftDto.Type, shiftDto.EmployeeID);

            // Logic before updating a shift
            // ...

            var dto = ConvertToDTO(shift);
            shiftRepository.UpdateShift(dto);
        }

        public ShiftDTO GetShiftDetails(int shiftId)
        {
            var shiftDto = shiftRepository.GetShiftById(shiftId);
            if (shiftDto == null) return null;

            var shift = new Shift(shiftDto.Date, shiftDto.Type, shiftDto.EmployeeID);

            // Apply any additional logic needed
            // ...

            return ConvertToDTO(shift);
        }



        public IEnumerable<ShiftDTO> GetAllShifts()
        {
            var shiftDtos = shiftRepository.GetAllShifts();
            var shifts = shiftDtos.Select(dto => new Shift(dto.Date, dto.Type, dto.EmployeeID));

            // Logic for modifying the retrieved shifts, if needed
            // ...

            return shifts.Select(shift => ConvertToDTO(shift));
        }
        private ShiftDTO ConvertToDTO(Shift shift)
        {
            return new ShiftDTO
            {
                Date = shift.Date,
                Type = shift.Type,
                EmployeeID = shift.EmployeeID
            };
        }
        private Shift ConvertToDomain(ShiftDTO dto)
        {
            // Convert DTO to Shift domain object
            return new Shift(dto.Date, dto.Type, dto.EmployeeID);
        }

        public IEnumerable<ShiftDTO> GetShiftsForEmployee(string employeeId)
        {
            var allShifts = shiftRepository.GetAllShifts();
            return allShifts.Where(shift => shift.EmployeeID == employeeId).ToList();
        }

    }
}
