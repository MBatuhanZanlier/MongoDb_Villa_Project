using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.DataAccessLayer.Abstract;
using Villa.DataAccessLayer.Context;
using Villa.DataAccessLayer.Repositories;
using Villa.EntityLayer.Entities;

namespace Villa.DataAccessLayer.EntityFrameWork
{
    public class EfSubHeaderDal : GenericRepository<SubHeader>, ISubHeaderDal
    {
        public EfSubHeaderDal(VillaContext context) : base(context)
        {
        }
    }
}
