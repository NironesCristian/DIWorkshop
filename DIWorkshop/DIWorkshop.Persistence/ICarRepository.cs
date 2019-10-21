using DIWorkshop.Entities;

namespace DIWorkshop.Persistence
{
    public interface ICarRepository
    {
        Car GetCar(int id);
    }
}