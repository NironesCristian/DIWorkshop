using DIWorkshop.Entities;
using System.Linq;

namespace DIWorkshop.Persistence
{
    public class DriverRepository : IDriverRepository
    {
        private readonly DbContext _dbContext;

        public DriverRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Driver GetDriver(int id)
        {
            if (_dbContext.Drivers.FirstOrDefault(x => x.Id == id) == null)
                return null;

            return _dbContext.Drivers.FirstOrDefault(x => x.Id == id);
        }
    }
}
