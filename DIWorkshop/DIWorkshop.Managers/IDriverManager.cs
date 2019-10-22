using DIWorkshop.Entities;

namespace DIWorkshop.Managers
{
    public interface IDriverManager
    {
        void AssignCarToADriver(int carID, int driverID);
        Driver GetDriver(int id);
    }
}