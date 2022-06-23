using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccess.Abstract
{
    public interface ITimeDal: IEntitiyRepository<Time>
    {
    }
}
