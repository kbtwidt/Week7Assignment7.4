namespace Week7Assignment7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingSystem parkingLot = new ParkingSystem(2, 3, 1);
            Console.WriteLine("Can the lot accomodate:");
            Console.WriteLine("Big: " + parkingLot.AddCar(1));
            Console.WriteLine("Medium: " + parkingLot.AddCar(2));
            Console.WriteLine("Small: " + parkingLot.AddCar(3));
            Console.WriteLine("Small: " + parkingLot.AddCar(3));
            Console.WriteLine("Big: " + parkingLot.AddCar(1));
        }
    }
}
