using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities.Absract;

namespace Entities.Concrete
{
    public class Reservation : IEntity
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public int EmployeeId { get; set; }
        public int MenuId { get; set; }
        public int TimeId { get; set; }
        public int StatuId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? CanceledDate { get; set; }
        public Menu Menu { get; set; }
        public Employee Employee { get; set; }
        public Time Time { get; set; }
        public Statu Statu { get; set; }
    }
}
