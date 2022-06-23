using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfReservationDal : EfEntityRepositoryBase<Reservation, AppDbContext>, IReservationDal
    {
        public List<Time> GetReservationTimes(int employeeId, string date)
        {
            
            var dt = ConvertToDateTime(date);
            using (var _context = new AppDbContext())
            {
                var result = (from r in _context.Reservations
                    join t in _context.Times on r.TimeId equals t.Id
                    where r.EmployeeId == employeeId && r.Date == dt && r.StatuId == 1
                              select (new Time
                    {
                        Id = r.TimeId,
                        Name = t.Name
                    })).ToList();

                return result;

            }
        }

        public List<ReservationDetail> ReservationDetails(int userId)
        {
            using (var _context = new AppDbContext())
            {
                var result = (from r in _context.Reservations
                    join t in _context.Times on r.TimeId equals t.Id
                    join e in _context.Employees on r.EmployeeId equals e.Id
                    join m in _context.Menus on r.MenuId equals m.Id
                    join u in _context.Users on r.AppUserId equals u.Id
                    join s in _context.Status on r.StatuId equals  s.Id
                    where u.Id == userId
                    select new ReservationDetail()
                    {
                        EmployeeFirstName = e.FirstName,
                        EmployeeLastName = e.LastName,
                        Menu = m.Name,
                        Date = r.Date.ToString("d"),
                        Time = t.Name,
                        Status = s.Name,
                        StatusId = s.Id,
                        ReservationId = r.Id,
                        CanceledDate = r.CanceledDate
                    }).ToList();
                return result;
            }
        }

        public DateTime ConvertToDateTime(string date)
        {
            CultureInfo provider = CultureInfo.CurrentCulture;
            DateTime dt = DateTime.ParseExact(date, "dd.MM.yyyy", provider, DateTimeStyles.None);
            return dt;
        }

        public void ChangeReservationStatu(int reservationId)
        {
            using (var _context = new AppDbContext())
            {
                var reservation = _context.Reservations.FirstOrDefault(x => x.Id == reservationId);
                reservation.StatuId = 2;
                reservation.CanceledDate = DateTime.Now;
                _context.SaveChanges();
            }
        }
    }
}
