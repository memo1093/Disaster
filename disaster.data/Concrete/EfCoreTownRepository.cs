using System.Collections.Generic;
using System.Linq;
using disaster.data.Abstract;
using disaster.entity;

namespace disaster.data.Concrete
{
    public class EfCoreTownRepository : EfCoreGenericRepository<Town, DisasterContext>, ITownRepository
    {
        public List<Town> GetWithCityId(int cityId)
        {
            using (var context = new DisasterContext())
            {
                if (cityId==null)
                {
                    return new List<Town>(){new Town(){TownId=0,TownName="Şehir Seçiniz"}};
                }
                return context.Towns.Where(i=>i.CityId==cityId).ToList();
            }
        }
    }
}