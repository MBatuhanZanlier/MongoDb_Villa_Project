using MongoDB.Bson;
using System.Linq.Expressions;
using Villa.BusinessLayer.Abstract;
using Villa.DataAccessLayer.Abstract;
using Villa.EntityLayer.Entities;

namespace Villa.BusinessLayer.Concrete
{
    public class BannerManager : GenericManager<Banner>, IBannerService
    {
        public BannerManager(IGenericDal<Banner> genericDAL) : base(genericDAL)
        {
        }
    }
}
