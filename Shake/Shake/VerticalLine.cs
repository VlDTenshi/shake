﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shake
{
    class VerticalLine : Figure
    {
        //List<point> pList;

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        //public void Drow()
        //{
        //   foreach(point p in pList)
        //     {
        //        p.Draw();
        //     }

        //}
    }
}
