namespace VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("/");
            Catalog catalogs = new Catalog();
            while (input[0] != "end")
            {
                string type = input[0];
                string brand = input[1];
                string model = input[2];
                int weightOrHp = int.Parse(input[3]);
                if (type == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weightOrHp;
                    catalogs.Trucks.Add(truck);
                    catalogs.Trucks.OrderByDescending(t => t.Brand);
                }
                else if (type == "Car")
                {
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = weightOrHp;
                    catalogs.Cars.Add(car);
                    catalogs.Cars.OrderByDescending(b => b.Brand);
                }
                input = Console.ReadLine().Split("/");
            }
            Console.WriteLine($"Cars:");
            foreach (var car in catalogs.Cars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            foreach (var truck in catalogs.Trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }


        }
    }
    internal class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    internal class Catalog
    {
        public Catalog()
        {
            this.Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
