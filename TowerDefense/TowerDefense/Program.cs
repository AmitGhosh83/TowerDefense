using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);
            int area = map.Width * map.Height;
            Console.WriteLine("Area is :{0}", area);
            Console.ReadLine();
        }
    }
}
