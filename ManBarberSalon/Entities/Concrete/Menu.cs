using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Absract;

namespace Entities.Concrete
{
    public class Menu : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
