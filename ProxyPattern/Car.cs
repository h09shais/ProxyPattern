namespace ProxyPattern
{
    using System;

    public class Car : ICar 
    {
        public void Drive()
        {
            Console.WriteLine("Car has been driven!");
        }
    }
}
