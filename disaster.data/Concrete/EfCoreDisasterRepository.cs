using System.Collections.Generic;
using System.Linq;
using disaster.data.Abstract;
using disaster.entity;
using Microsoft.EntityFrameworkCore;

namespace disaster.data.Concrete
{
    public class EfCoreDisasterRepository:EfCoreGenericRepository<Disaster,DisasterContext>,IDisasterRepository
    {
        public override List<Disaster> GetAll()
        {
            using (var context = new DisasterContext())
            {
                return context.Disasters.Include(i=>i.Sources).ToList();
            }
        }
        public override Disaster GetById(int id)
        {
            using (var context = new DisasterContext())
            {
                return context.Disasters.Where(i=>i.DisasterId==id).Include(i=>i.Sources).FirstOrDefault();
            }
        }
    }
}