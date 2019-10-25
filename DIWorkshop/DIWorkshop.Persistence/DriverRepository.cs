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
        public Driver GetDriver(int driverId)
        {
            return _dbContext.Drivers.FirstOrDefault(x => x.Id == driverId);
        }
        public Driver GetDriverByCarId(int carId)
        {
            return _dbContext.Drivers.FirstOrDefault(x => x.Car.Id == carId);
        }
    }
}
