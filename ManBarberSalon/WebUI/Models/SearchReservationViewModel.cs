using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Entities.Concrete;

namespace WebUI.Models
{
    public class SearchReservationViewModel
    {
        public Employee Employee { get; set; }
        public string Date { get; set; }
        public List<Employee> Employees { get; set; }

    }
}
