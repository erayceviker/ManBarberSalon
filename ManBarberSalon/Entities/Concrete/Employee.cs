using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Absract;

namespace Entities.Concrete
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }

        public List<Reservation> Reservations { get; set; }
    }
}
