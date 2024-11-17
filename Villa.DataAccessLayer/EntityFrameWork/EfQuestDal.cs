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
    public class EfQuestDal : GenericRepository<Quest>, IQuestDal
    {
        public EfQuestDal(VillaContext context) : base(context)
        {
        }
    }
}
