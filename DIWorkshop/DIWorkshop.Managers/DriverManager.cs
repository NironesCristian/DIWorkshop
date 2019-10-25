using DIWorkshop.Entities;
using DIWorkshop.Persistence;
using System.Linq;

namespace DIWorkshop.Managers
{
    public class DriverManager : IDriverManager
    {
        private readonly IDriverRepository _driverRepository;
        private readonly ICarRepository _carRepository;

        public DriverManager(IDriverRepository driverRepository,ICarRepository carRepository)
        {
            _driverRepository = driverRepository;
            _carRepository = carRepository;
        }

        public Driver GetDriver(int id)
        {
            return _driverRepository.GetDriver(id);
        }

        public Driver GetDriverByCarId(int carId,int driverId)
        {
            Driver driver = _driverRepository.GetDriver(driverId);
            if (driver == null)
                return null;
            driver.Car = _carRepository.GetCar(carId);
            return driver;
        }
    }
}
