using Villa.DataAccessLayer.Abstract;
using Villa.DataAccessLayer.Context;
using Villa.EntityLayer.Entities;
using Villa.DataAccessLayer.Repositories;

namespace Villa.DataAccessLayer.EntityFrameWork
{
    public class EfVideoDal : GenericRepository<Video>,IVideoDal
    {
        public EfVideoDal(VillaContext context) : base(context)
        {
        }
    }
}
