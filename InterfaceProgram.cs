using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{

    public interface IFlyable
    {
        void Fly();
    }

    public interface ISwimmable
    {
        void Swim();
    }

    public class Duck : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("The duck is flying.");
        }

        public void Swim()
        {
            Console.WriteLine("The duck is swimming.");
        }
    }

    public class Airplane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("The airplane is flying.");
        }
    }

    class InterfaceProgram
    {
        static void Main()
        {
            Duck duck = new Duck();
            duck.Fly();   
            duck.Swim();  

            
            Airplane airplane = new Airplane();
            airplane.Fly(); 
            Console.ReadLine();
        }
    }

}
