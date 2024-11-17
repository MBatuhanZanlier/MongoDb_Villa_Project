using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.DataAccessLayer.Abstract;
using Villa.DataAccessLayer.Context;
using Villa.EntityLayer.Entities;
using Villa.DataAccessLayer.Repositories;

namespace Villa.DataAccessLayer.EntityFrameWork
{
    public class EfBannerDal : GenericRepository<Banner>, IBannerDal
    {
        public EfBannerDal(VillaContext context) : base(context)
        {
        }
    }
}
