using System.Collections.Generic;
using disaster.business.Abstract;
using disaster.data.Abstract;
using disaster.entity;

namespace disaster.business.Concrete
{
    public class DisasterManager : IDisasterService
    {
        public string ErrorMessage { get; set; }
        private IDisasterRepository _disasterRepository;

        public DisasterManager(IDisasterRepository disasterRepository)
        {
            _disasterRepository = disasterRepository;
        }

        public bool Create(Disaster entity)
        {
            _disasterRepository.Create(entity);
            return true;
        }

        public bool Delete(Disaster entity)
        {
            _disasterRepository.Delete(entity);
            return true;
        }

        public List<Disaster> GetAll()
        {
            return _disasterRepository.GetAll();

        }

        public Disaster GetById(int id)
        {
            return _disasterRepository.GetById(id);
        }

        public bool Update(Disaster entity)
        {
            _disasterRepository.Update(entity);
            return true;
        }

        public bool Validation(Disaster entity)
        {
            if(entity.GlideNo==null || entity.SerialNo==null)
            {
                ErrorMessage += $"Bu bölüm boş bırakılamaz.";
                return false;
            }
            if (entity.StartDate==null)
            {
                ErrorMessage += $"Bu bölüm boş bırakılamaz.";
                return false;
            }
            if (entity.FinishDate==null)
            {
                ErrorMessage += $"Bu bölüm boş bırakılamaz.";
                return false;
            }
            if (entity.DisasterType==null || entity.DisasterType=="")
            {
                ErrorMessage += $"Afet türü seçilmelidir.";
                return false;
            }
            if (entity.DisasterType==null || entity.DisasterType=="")
            {
                ErrorMessage += $"Afet türü seçilmelidir.";
                return false;
            }
            if (entity.CityId==0)
            {
                ErrorMessage += $"İl seçilmelidir.";
                return false;
            }
            if (entity.TownId==0)
            {
                ErrorMessage += $"İlçe seçilmelidir.";
                return false;
            }
            
            
            if (entity.Why=="")
            {
                ErrorMessage += $"Neden girilmelidir.";
                return false;
            }
            if (entity.Description=="")
            {
                ErrorMessage += $"Açıklama girilmelidir.";
                return false;
            }
            if (entity.AffectedAreas=="")
            {
                ErrorMessage += $"Etkilenen alanlar girilmelidir.";
                return false;
            }
            
            
            return true;
        }
    }
}