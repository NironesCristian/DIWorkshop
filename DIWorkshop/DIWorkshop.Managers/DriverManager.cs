using DIWorkshop.Entities;
using DIWorkshop.Interfaces;

namespace DIWorkshop.Managers
{
    public class DriverManager : IDriverManager
    {
        private readonly IDriverRepository _driverRepository;
        private readonly ICarRepository _carRepository;

        public DriverManager(IDriverRepository driverRepository, ICarRepository carRepository)
        {
            _driverRepository = driverRepository;
            _carRepository = carRepository;
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