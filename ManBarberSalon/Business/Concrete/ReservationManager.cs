using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class ReservationManager: IReservationSerivce
    {
        private IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Time> GetReservationTime(int employeeId, string date)
        {
            return _reservationDal.GetReservationTimes(employeeId, date);
        }

        public void AddReservation(Reservation reservation)
        {
            _reservationDal.Add(reservation);
        }

        public DateTime ConvertToDateTime(string date)
        {
            return _reservationDal.ConvertToDateTime(date);
        }

        public List<ReservationDetail> GetReservationDetail(int userId)
        {
            return _reservationDal.ReservationDetails(userId);
        }

        public void CancelReservation(int reservationId)
        {
            _reservationDal.ChangeReservationStatu(reservationId);
        }
    }
}
