using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface IReservationDal: IEntitiyRepository<Reservation>
    {
        public List<Time> GetReservationTimes(int employeeId, string date);

        public List<ReservationDetail> ReservationDetails(int userId);

        public DateTime ConvertToDateTime(string date);

        public void ChangeReservationStatu(int reservationId);
    }
}
