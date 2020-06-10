using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutGeneric
{
    public class Car:IComparable<Car>
    {
        private string model;
        private int year;
        private int price;
        private string color;

        public string Model { get => model; private set => model = value; }
        public int Year { get => year; set => year = value; }
        public int Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }

        public Car(string model, int year, int price, string color)
        {
            this.Model = model;
            this.Year = year;
            this.Price = price;
            this.Color = color;
        }
        public Car()
        {

        }
        public override string ToString()
        {
            return Model + " " + Year + " " + Price + " " + Color;
                
        }
        public void AddData()
        {
            Console.Write("Enter the model - ");
            model = Console.ReadLine();
            Console.Write("Enter the year - ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Enter the price - ");
            price = int.Parse(Console.ReadLine());
            Console.Write("Enter the color - ");
            color = Console.ReadLine();
        }

      

        public int CompareTo(Car other)
        {
            if (Year > other.Year) return 1;
            else if (Year < other.Year) return -1;
            else return 0;

        }
    }
}
