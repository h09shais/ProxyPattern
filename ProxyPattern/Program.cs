namespace ProxyPattern
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new ProxyCar(new Driver(16));
            car.Drive();

            car = new ProxyCar(new Driver(25));
            car.Drive();

            Console.ReadLine();
        }
    }
}
