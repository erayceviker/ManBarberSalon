using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IReservationSerivce
    {
        public List<Time> GetReservationTime(int employeeId, string date);

        public void AddReservation(Reservation reservation);

        public DateTime ConvertToDateTime(string date);

        public List<ReservationDetail> GetReservationDetail(int userId);

        public void CancelReservation(int reservationId);
    }
}
