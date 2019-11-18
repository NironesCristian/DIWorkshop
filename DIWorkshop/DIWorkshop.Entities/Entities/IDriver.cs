namespace DIWorkshop.Entities
{
    public interface IDriver
    {
        Car Car { get; set; }
        string Firstname { get; set; }
        int Id { get; set; }
        string Lastname { get; set; }
    }
}