using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class TimeManager : ITimeService
    {
        private ITimeDal _timeDal;

        public TimeManager(ITimeDal timeDal)
        {
            _timeDal = timeDal;
        }

        public List<Time> GetAll()
        {
            return _timeDal.GetList();
        }
    }
}
