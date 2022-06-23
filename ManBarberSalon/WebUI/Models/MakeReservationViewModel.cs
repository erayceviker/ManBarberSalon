using System;
using System.Collections.Generic;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebUI.Models
{
    public class MakeReservationViewModel
    {
        public List<Menu> Menus { get; set; } 
        public List<Time> Times { get; set; } 
        public List<string> DisabledTimes { get; set; } 
        public Menu Menu { get; set; }
        public Employee Employee { get; set; }

        public int TimeId { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
    }
}
