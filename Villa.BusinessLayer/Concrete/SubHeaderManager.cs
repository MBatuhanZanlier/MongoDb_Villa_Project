using Villa.BusinessLayer.Abstract;
using Villa.DataAccessLayer.Abstract;
using Villa.EntityLayer.Entities;

namespace Villa.BusinessLayer.Concrete
{
    public class SubHeaderManager : GenericManager<SubHeader>, ISubHeaderService
    {
        public SubHeaderManager(IGenericDal<SubHeader> genericDAL) : base(genericDAL)
        {
        }
    }
}
