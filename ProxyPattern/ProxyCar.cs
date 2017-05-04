namespace ProxyPattern
{
    using System;

    public class ProxyCar : ICar
    {
        private Driver driver;

        private Car car;

        public ProxyCar(Driver driver)
        {
            this.driver = driver;
            this.car = new Car();
        }
        public void Drive()
        {
            if (this.driver.Age <= 16)
            {
                Console.WriteLine("Sorry, the driver is too young to drive.");
            }
            else
            {
                this.car.Drive();
            }
        }
    }
}
