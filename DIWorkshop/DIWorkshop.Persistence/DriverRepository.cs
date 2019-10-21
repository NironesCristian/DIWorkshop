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
            return _dbContext.Drivers.FirstOrDefault(x => x.Id == id);
        }
        public Driver GetDriverByCarId(int carId)
        {
            return _dbContext.Drivers.FirstOrDefault(x => x.Car.Id == carId);
        }
        public void AssignCarToDriver(int driverId, int carId)
        {
            _dbContext.Drivers.FirstOrDefault(x => x.Id == driverId).Car = _dbContext.Cars.FirstOrDefault(c => c.Id == carId);
        }
    }
}
