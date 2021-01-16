using disaster.entity;

namespace disaster.business.Abstract
{
    public interface IDisasterService:IService<Disaster>,IValidator<Disaster>
    {
         
    }
}