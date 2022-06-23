using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public List<Employee> GetActiveEmployees()
        {
            return _employeeDal.GetList(x=>x.IsActive == true);
        }

        public Employee GetById(int id)
        {
            return _employeeDal.Get(x=>x.Id == id);
        }
    }
}
