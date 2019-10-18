using DIWorkshop.Entities;
using System.Linq;

namespace DIWorkshop.Persistence
{
    public class DriverRepository
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

        public Driver GetDriverWithCar(int driverID, int carID)
        {
            Driver newDriver = _dbContext.Drivers.Find(x => x.Id == driverID);
            newDriver.Car = _dbContext.Cars.Find(x => x.Id == carID);
            return newDriver;
        }

    }
}
