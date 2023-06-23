using System.Data.Common;

namespace POS.Model
{
    public class Employee
    {
        public int Id;
        public string? Name { get; set; }
        public string? EmployeeId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Location { get; set; }

    }
}