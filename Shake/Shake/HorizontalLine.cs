using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shake
{
    class HorizontalLine : Figure // inheritance 
    {
        // Created in class Figure -->
        //List<point> plist;

        public HorizontalLine(int xLeft, int xReight, int y, char sym)
        {
            pList = new List<Point>();
            //point p1 = new point(4, 4, '*');
            //plist.Add(p1);
            for(int x = xLeft; x <= xReight; x++)
            {
                Point p= new Point(x, y, sym);
                pList.Add(p);
            }
        }
        // Created in class Figure -->
        //public override void Draw()
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    //foreach (Point p in plist)
        //    //{
        //    //    p.Draw();
        //    //}

        //    base.Draw();

        //    Console.ForegroundColor= ConsoleColor.White;
        //}
    }
}
