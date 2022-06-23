using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using Business.Abstract;
using DataAccess.Concrete.EntitiyFramework.Contexts;
using Entities.Concrete;
using Entities.Concrete.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {
        private IEmployeeService _employeeService;
        private IReservationSerivce _reservationSerivce;
        private IMenuService _menuService;
        private ITimeService _timeService;
        public ReservationController(IEmployeeService employeeService, IReservationSerivce reservationSerivce, IMenuService menuService, ITimeService timeService)
        {
            _employeeService = employeeService;
            _reservationSerivce = reservationSerivce;
            _menuService = menuService;
            _timeService = timeService;
        }


        public IActionResult MyReservations() 
        {
            int userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var model = new ReservationDetailListViewModel()
            {
                ReservationDetails = _reservationSerivce.GetReservationDetail(userId)
            };
            return View(model);
        }

        public IActionResult SearchReservation() 
        {
            var model = new SearchReservationViewModel
            {
                Employees = _employeeService.GetActiveEmployees()
            };
            return View(model);
        }


        [HttpPost]
        public IActionResult MakeReservations(SearchReservationViewModel model)
        {
            if (model == null)
            {
                return RedirectToAction("SearchReservation");
            }

            var disabledTimesList = _reservationSerivce.GetReservationTime(model.Employee.Id, model.Date);

            List<string> disabledTimesNameList = new List<string>();

            foreach(var time in disabledTimesList)
            {
                disabledTimesNameList.Add(time.Name);
            }

            var model2 = new MakeReservationViewModel
            {
                Times = _timeService.GetAll(),
                Menus = _menuService.GetAll(),
                DisabledTimes = disabledTimesNameList,
                Employee = _employeeService.GetById(model.Employee.Id), 
                Date = model.Date, 
            };
            return View(model2);
        }


        [HttpPost]
        public IActionResult Complete(CompleteViewModel model)
        {

            var dt = _reservationSerivce.ConvertToDateTime(model.Date);
            int userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            Reservation reservation = new Reservation()
            {
                AppUserId = userId,
                EmployeeId = model.Employee.Id,
                MenuId = model.Menu.Id,
                TimeId = model.TimeId,
                Date = dt,
                StatuId = 1,
                CanceledDate = null,
            };

            _reservationSerivce.AddReservation(reservation);
            return RedirectToAction("MyReservations");
        }

        [HttpPost]
        public IActionResult CancelReservation(int reservationId)
        {
            _reservationSerivce.CancelReservation(reservationId);
            return RedirectToAction("MyReservations");
        }

    }
}
