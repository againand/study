using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1;
            p1 = new Point();
            //p1.x = 7;
           // p1.y = 86;
            string b=p1.GetPointString();
            Console.WriteLine(b);
           
                    }
    }

    class Point
    {
        public int x=6;
        public int y=7;

        public string GetPointString()
        {
            return string.Format("({0},{1})", x, y);
        }
    }
}
