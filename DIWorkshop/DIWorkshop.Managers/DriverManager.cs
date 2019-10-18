using DIWorkshop.Entities;
using DIWorkshop.Interfaces;
using DIWorkshop.Persistence;

namespace DIWorkshop.Managers
{
    public class DriverManager : IDriverManager
    {
        private readonly DriverRepository _driverRepository;
        private readonly CarRepository _carRepository;

        public DriverManager()
        {
            var dbContext = new DbContext();
            _driverRepository = new DriverRepository(dbContext);
            _carRepository = new CarRepository(dbContext);
        }

        public Driver GetDriver(int id)
        {
            return _driverRepository.GetDriver(id);
        }

        public Driver GetDriverWithCar(int driverID, int carID)
        {
            var driver = _driverRepository.GetDriver(driverID);
            driver.Car = _carRepository.GetCar(carID);
            return driver;
        }
    }
}
