using System.Collections.Generic;
using Entities.Concrete;

namespace WebUI.Models
{
    public class CompleteViewModel
    {
        public Menu Menu { get; set; }
        public Employee Employee { get; set; }
        public int TimeId { get; set; }
        public string Date { get; set; }
    }
}
