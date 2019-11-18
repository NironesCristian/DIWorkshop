namespace DIWorkshop.Entities
{
    public class Car : ICar
    {
        public int Id { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }
    }
}
