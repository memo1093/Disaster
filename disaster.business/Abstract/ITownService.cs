using System.Collections.Generic;
using disaster.entity;

namespace disaster.business.Abstract
{
    public interface ITownService:IService<Town>
    {
        List<Town> GetByCityId(int cityId);
        Town GetByTownId(int cityId);
    }
}