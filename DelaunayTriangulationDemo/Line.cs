using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelaunayTriangulationDemo
{
    class Line
    {
               /* 每条基线形成三角形都是从Begin出发，End结束*/
            public Point Begin;  // 基线起点
            public Point End;    // 基线终点
            public int ID;       // 画线ID
        
    }
}
