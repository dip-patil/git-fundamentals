using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
   

    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public Vehicle(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }

        public void Start()
        {
            Console.WriteLine($"{Make} {Model} is starting...");
        }

        public void Stop()
        {
            Console.WriteLine($"{Make} {Model} is stopping...");
        }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string make, string model, int numberOfDoors) : base(make, model)
        {
            this.NumberOfDoors = numberOfDoors;
        }

        public void OpenDoors()
        {
            Console.WriteLine("Doors are open.");
        }
    }

    public class Bike : Vehicle
    {
        public bool HasCarrier { get; set; }

        public Bike(string make, string model, bool hasCarrier) : base(make, model)
        {
            this.HasCarrier = hasCarrier;
        }

        public void RingBell()
        {
            Console.WriteLine("Ring Ring!");
        }
    }

    class Inheritance
    {
        static void Main()
        {
            Car car = new Car("Swift", "Dezire", 4);
            car.Start();
            car.OpenDoors();
            car.Stop();

            Console.WriteLine(new string('-', 30));

            Bike bike = new Bike("Yamaha", "FZ", true);
            bike.Start();
            bike.RingBell();
            bike.Stop();
            Console.ReadLine();
        }
    }


}
