using DIWorkshop.Entities;

namespace DIWorkshop.Managers
{
    public interface IDriverManager
    {
        Driver GetDriver(int id);
        Driver GetDriverAndHisCar(int driverId, int carId);
    }
}