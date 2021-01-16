using disaster.data.Abstract;
using disaster.entity;

namespace disaster.data.Concrete
{
    public class EfCoreCityRepository : EfCoreGenericRepository<City, DisasterContext>, ICityRepository
    {
        
    }
}