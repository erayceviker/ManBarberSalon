using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities.Absract;

namespace Entities.Dtos
{
    public class ReservationDetail : IDto
    {
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string Menu { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public int StatusId { get; set; }
        public DateTime? CanceledDate { get; set; }
        public int ReservationId { get; set; }
    }
}
