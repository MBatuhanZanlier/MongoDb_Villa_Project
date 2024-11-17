using Villa.BusinessLayer.Abstract;
using Villa.BusinessLayer.Concrete;
using Villa.DataAccessLayer.Abstract;
using Villa.DataAccessLayer.EntityFrameWork;
using Villa.DataAccessLayer.Repositories;

namespace MongoDb_Villa_Project.Extensions
{
    public static class ServiceExtensions
    {
        
        
            public static void AddServiceExtensions(this IServiceCollection Services)
            {
             Services.AddScoped<IBannerDal, EfBannerDal>();
             Services.AddScoped<IBannerService, BannerManager>();

             Services.AddScoped<IContactDal, EfContactDal>();
             Services.AddScoped<IContactService, ContactManager>();

             Services.AddScoped<ICounterDal, EfCounterDal>();
             Services.AddScoped<ICounterService, CounterManager>();

             Services.AddScoped<IDealDal, EfDealDal>();
             Services.AddScoped<IDealService, DealManager>();

             Services.AddScoped<IFeatureDal, EfFeatureDal>();
             Services.AddScoped<IFeatureService, FeatureManager>();

             Services.AddScoped<IMessageDal, EfMessageDal>();
             Services.AddScoped<IMessageService, MessageManager>();

             Services.AddScoped<IProductDal, EfProductDal>();
             Services.AddScoped<IProductService, ProductManager>();

             Services.AddScoped<IQuestDal, EfQuestDal>();
             Services.AddScoped<IQuestService, QuestManager>();

             Services.AddScoped<IVideoDal, EfVideoDal>();
             Services.AddScoped<IVideoService, VideoManager>();

             Services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
             Services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>)); 
           
            }
        
       
    }
}
