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

            Point point = new Point(4, 3);
            var isOnMap = map.OnMap(point);
            Console.WriteLine("Is the Point in Map:{0}", isOnMap);

            Point point1 = new Point(8,5);
            var isOnMap1 = map.OnMap(point1);
            Console.WriteLine("Is the Point in Map:{0}", isOnMap1);

            int distance = point.DistanceTo(6, 4);
            Console.WriteLine("Distance : {0}", distance);

            Console.ReadLine();
        }
    }
}
