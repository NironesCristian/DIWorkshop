namespace DIWorkshop.Entities
{
    public interface ICar
    {
        int Id { get; set; }
        string Manufacturer { get; set; }
        string Model { get; set; }
        int Year { get; set; }
    }
}