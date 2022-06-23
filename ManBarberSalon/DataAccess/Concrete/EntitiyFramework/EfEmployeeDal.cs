using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfEmployeeDal: EfEntityRepositoryBase<Employee, AppDbContext>, IEmployeeDal
    {
    }
}
