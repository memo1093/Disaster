using System.Collections.Generic;
using disaster.entity;

namespace disaster.data.Abstract
{
    public interface ITownRepository:IRepository<Town>
    {
        List<Town> GetWithCityId(int id);
    }
}