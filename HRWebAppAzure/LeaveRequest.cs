using System;
namespace HRWebAppAzure
{
    public class LeaveRequest
    {
        public LeaveRequest()
        {
        }

        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}

