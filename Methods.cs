using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AboutGeneric
{
    class Methods
    {
        public void Init(List<Car> car)
        {
            Car c1 = new Car("BMW", 2000, 10000, "red");
            Car c2 = new Car("MSR", 2005, 6000, "blue");
            Car c3 = new Car("Opel", 2002, 9000, "green");
            Car c4 = new Car("Lada", 1900, 1100, "white");
            Car c5 = new Car("Ford", 1996, 8000, "black");

            car.Add(c1);
            car.Add(c2);
            car.Add(c3);
            car.Add(c4);
            car.Add(c5);

        }
        public void Show(List<Car> car)
        {
            foreach (Car c in car)
            {
                Console.WriteLine(c);
            }
        }
        public void Add(List<Car> car)
        {
            Car c = new Car();
            c.AddData();
            car.Add(c);
        }
        public void Sort(List<Car> car)
        {
            car.Sort();
        }
        public int Search(List<Car> car)
        {
            Car c = new Car();
            Console.Write("Enter the year ");
            c.Year = int.Parse(Console.ReadLine());
            car.Sort();
            int y = car.BinarySearch(c);
            if (y >= 0)
            {
                Console.WriteLine(car[y]);
            }
            else
            {
                Console.WriteLine("There isn't car");
            }
            return y;

        }
        public void Delete(List<Car> car)
        {
            int x = Search(car);
            if (x < 0) return;
            else car.RemoveAt(x);

        }
    }
}
