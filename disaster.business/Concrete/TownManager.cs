using System.Collections.Generic;
using disaster.business.Abstract;
using disaster.data.Abstract;
using disaster.entity;

namespace disaster.business.Concrete
{
    public class TownManager : ITownService
    {
        private ITownRepository _townRepository;

        public TownManager(ITownRepository townRepository)
        {
            _townRepository = townRepository;
        }

        public bool Create(Town entity)
        {
            if (entity!=null)
            {
                _townRepository.Create(entity);
                return true;
            }
            return false;
        }

        public bool Delete(Town entity)
        {
            if (entity!=null)
            {
                _townRepository.Delete(entity);
                return true;
            }
            return false;
        }

        public List<Town> GetAll()
        {
            return _townRepository.GetAll();
        }

        public List<Town> GetByCityId(int cityId)
        {
            return _townRepository.GetWithCityId(cityId);
        }

        public Town GetById(int id)
        {
            return _townRepository.GetById(id);
        }

        public Town GetByTownId(int townId)
        {
            return _townRepository.GetById(townId);
        }

        public bool Update(Town entity)
        {
            if (entity!=null)
            {
                _townRepository.Update(entity);
                return true;
            }
            return false;
        }
    }
}