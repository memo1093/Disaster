using System.Collections.Generic;
using disaster.business.Abstract;
using disaster.data.Abstract;
using disaster.entity;

namespace disaster.business.Concrete
{
    public class CityManager : ICityService
    {
        private ICityRepository _cityRepository;

        public CityManager(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public bool Create(City entity)
        {
            if (entity != null)
            {
                _cityRepository.Create(entity);
                return true;
            }
            return false;

        }

        public bool Delete(City entity)
        {
            if (entity != null)
            {
                _cityRepository.Create(entity);
                return true;
            }
            return false;
        }

        public List<City> GetAll()
        {
            return _cityRepository.GetAll();
        }

        public City GetById(int id)
        {
            return _cityRepository.GetById(id);
        }

        

        public bool Update(City entity)
        {
            if (entity != null)
            {
                _cityRepository.Create(entity);
                return true;
            }
            return false;
        }
    }
}