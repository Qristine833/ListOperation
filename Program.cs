using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutGeneric
{
    public class MyClass<T> where T: struct
    {
        public MyClass(T x, T y)
        {
            X = x;
            Y = y;
        }

        public T X { get; set; }
        public T Y { get; set; }

        public override string ToString()
        {
            return typeof(T).Name + X + " " + Y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Methods m = new Methods();
            List<Car> car = new List<Car>();
            m.Init(car);
            int x;
            for(; ; )
            {
                Console.WriteLine("1-Show  2-Add  3-Sort  4-Search  5-Delete");
                x = int.Parse(Console.ReadLine());
                if(x==1)
                {
                    m.Show(car);
                }
                if(x==2)
                {
                    m.Add(car);
                }
                if(x==3)
                {
                    m.Sort(car);
                }
                if(x==4)
                {
                    m.Search(car);
                }
                if(x==5)
                {
                    m.Delete(car);
                }
            }


        }
    }
}
