using DIWorkshop.Entities;
using DIWorkshop.Persistence;

namespace DIWorkshop.Managers
{
    public class DriverManager : IDriverManager
    {
        private readonly IDriverRepository _driverRepository;
        private readonly ICarRepository _carRepository;

        public DriverManager(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }
        public DriverManager(IDriverRepository driverRepository, ICarRepository carRepository)
        {
            _driverRepository = driverRepository;
            _carRepository = carRepository;
        }

        public Driver GetDriver(int driverId)
        {
            return _driverRepository.GetDriver(driverId);
        }
        public Car GetCar(int carId)
        {
            return _carRepository.GetCar(carId);
        }

        public Driver GetDriverByCarId(int carId)
        {
            return _driverRepository.GetDriverByCarId(carId);
        }
        public Driver AssignCarToDriver(int driverId, int carId)
        {
            Driver driver = GetDriver(driverId);
            if (driver == null) return null;
            driver.Car = GetCar(carId);
            return driver;
        }
    }
}
