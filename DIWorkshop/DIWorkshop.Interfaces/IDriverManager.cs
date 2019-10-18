using DIWorkshop.Entities;

namespace DIWorkshop.Interfaces
{
    public interface IDriverManager
    {
        Driver GetDriver(int id);

        Driver GetDriverWithCar(int driverID, int carID);
    }
}