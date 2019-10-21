using DIWorkshop.Entities;

namespace DIWorkshop.Managers
{
    public interface IDriverManager
    {
        Driver AssignCarToDriver(int driverId, int carId);
        Driver GetDriver(int id);
        Driver GetDriverByCarId(int carId);
    }
}