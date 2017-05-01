using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelaunayTriangulationDemo
{
    public partial class Form1 : Form
    {
        private static List<Point> PL = null;
        private static int nums = 0;
        //基本画图
        private static Graphics graphics;
        private static Bitmap bitmap;
        private static Pen pen;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 画点
        /// </summary>
        /// <param name="p0">PointClass类的点</param>
        /// <param name="i">计数用的</param>
        private void DrawPoint(Point p0, string str)
        {
            pen = new Pen(Color.Red, 3);
            graphics.DrawEllipse(pen, p0.X, p0.Y, 1.5f, 1.5f);
            graphics.DrawString(str, new Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular), new SolidBrush(Color.Blue), p0.X, p0.Y);
            this.pictureBox1.Image = bitmap;
        }

        //初始画板
        private void initPic()
        {
            bitmap = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
        }

        /// <summary>
        /// 依次传入 两个点 来画线
        /// 用来画裁剪后的线段
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        private void DrawLine(Point p1, Point p2)
        {
            
            pen = new Pen(Color.Red, 1);
            //PolylineClass plc = new PolylineClass(pointList.ToArray());
            //p1 = plc.m_p[plc.m_pointCounts - 1];
            graphics.DrawLine(pen, p1.X, p1.Y, p2.X, p2.Y);
             this.pictureBox1.Image = bitmap;
        }


        /// <summary>
        /// 生成随机数，返回一个点
        /// </summary>
        /// <returns></returns>
        private Point Random_Point(int width, int height)
        {
            //暂时将宽度定义为 600  高度 500
            Random random = new Random();
            //int x = random.Next(this.panel_Tools.Width, this.pictureBox1.Width);
            //int y = random.Next(this.panel_Openfile.Height, this.pictureBox1.Height);
            int x = random.Next(0, width);
            int y = random.Next(0, height);
            return new Point(x, y);
        }
        private void RandomPoint_Btu_Click(object sender, EventArgs e)
        {
            
            initPic();
            PointCountsForm pf = new PointCountsForm();
            pf.ShowDialog();
            if (pf.DialogResult == DialogResult.OK)
            {
                nums = pf.Nums;
                PL=new List<Point>();
            }
            for (int i = 0; i < nums; i++)
            {
              AddPoint();
            }
        }

        private void AddPoint()
        {
            while (PL.Count < nums)
            {
                Point p = Random_Point(this.pictureBox1.Width, this.pictureBox1.Height);
                if (!PL.Contains(p))
                {
                    PL.Add(p);
                    DrawPoint(p, "V" + PL.Count);
                }
            }
        }

            public double Distance(Point first, Point second)//两点距离
            {
                double dis;
                dis = Math.Sqrt((second.Y - first.Y) * (second.Y - first.Y) + (second.X - first.X) * (second.X - first.X));
                return dis;
            }
        
        //第三点是否与前两点共线
        public int You(Point cen, Point first, Point second)
        {
            double s;
            s = (first.X - cen.X) * (second.Y - cen.Y) - (first.Y - cen.Y) * (second.X - cen.X);
            if (s > 0)
            {
                return 1;
            }
            else
                return 2;
        }

        public float Angle(Point cen, Point first, Point second)//三个点形成的三角形，CEN为顶点对应的夹角
        {
            float dx1, dx2, dy1, dy2;
            float angle;
            dx1 = first.X - cen.X;
            dy1 = first.Y - cen.Y;
            dx2 = second.X - cen.X;
            dy2 = second.Y - cen.Y;
            float c = (float)Math.Sqrt(dx1 * dx1 + dy1 * dy1) * (float)Math.Sqrt(dx2 * dx2 + dy2 * dy2);
            if (c == 0) return -1;
            angle = (float)Math.Acos((dx1 * dx2 + dy1 * dy2) / c);
            return angle;
        }

        private void Net_Btu_Click(object sender, EventArgs e)
        {
            //graphics.Clear(this.pictureBox1.BackColor);
          //  initPic();
            try
            {
                double angle1;//角度
                this.Refresh();
                ArrayList tinline = new ArrayList();
                //定义与第一点最近的点
                double mindis = Distance((Point)PL[0], (Point)PL[1]);
                double dis;
                int count = 0;
                int count1 = 0;
                int count2 = 0;
                Line tl = new Line();
                //以第一个点为基准 找到最近的点
                for (int j = 0; j < PL.Count - 1; j++)
                {
                    for (int i = j + 1; i < PL.Count; i++)
                    {
                        dis = Distance((Point)PL[0], (Point)PL[i]);
                        if (dis < mindis)
                        {
                            mindis = dis;
                            count1 = j;
                            count2 = i;
                        }
                    }
                }
                //将第一条边反向以进行三角形扩展
                tl.Begin = (Point)PL[count1];
                tl.End = (Point)PL[count2];
                tinline.Add(tl);
                Line line = new Line();
                Point a = ((Line)tinline[0]).Begin;
                Point b = ((Line)tinline[0]).End;
                line.Begin = b;
                line.End = a;
                tinline.Add(line);

                //对每一条边进行扩展

                for (int j = 0; j < tinline.Count; j++)
                {
                    double t = -1;
                    bool flag;
                    flag = false;
                    Line tling1 = new Line();
                    Line tling2 = new Line();
                    for (int i = 0; i < PL.Count; i++)
                    {
                        int you;
                        //判断第三点与前两点位置关系
                        you = You((Point)PL[i], ((Line)tinline[j]).Begin, ((Line)tinline[j]).End);
                        if (you == 1)
                        {
                            //获取角度最大点
                            angle1 = Angle((Point)PL[i], ((Line)tinline[j]).Begin, ((Line)tinline[j]).End);
                            if (angle1 > t)
                            {
                                t = angle1;
                                count = i;
                            }
                            flag = true;
                        }
                    }
                    if (flag == true)
                    {
                        //将新生成两条边添加入集合中
                        int t1 = 0;
                        int t2 = 0;
                        tling1.Begin = ((Line)tinline[j]).Begin;
                        tling1.End = (Point)PL[count];
                        tling2.Begin = (Point)PL[count];
                        tling2.End = ((Line)tinline[j]).End;
                        tinline.Add(tling1);
                        tinline.Add(tling2);
                        for (int i = 0; i < tinline.Count - 2; i++)
                        {
                            //判断新生成的两边是否与已生成边重合
                            if ((tling2.Begin == ((Line)tinline[i]).Begin && tling2.End == ((Line)tinline[i]).End) || (tling2.Begin == ((Line)tinline[i]).End && tling2.End == ((Line)tinline[i]).Begin))
                            {
                                t2 = 1;
                            }
                            if ((tling1.Begin == ((Line)tinline[i]).Begin && tling1.End == ((Line)tinline[i]).End) || (tling1.Begin == ((Line)tinline[i]).End && tling1.End == ((Line)tinline[i]).Begin))
                            {
                                t1 = 1;
                            }
                        }
                        //两条边都重合
                        if (t2 == 1 && t1 == 1)
                        {
                            for (int i = 0; i < 2; i++)
                            {
                                tinline.Remove(tinline[tinline.Count - 1]);
                            }
                        }
                        //第二条边重合
                        else if (t2 == 1)
                        {
                            tinline.Remove(tinline[tinline.Count - 1]);
                        }
                        //第一条边重合
                        else if (t1 == 1)
                        {
                            tinline.Remove(tinline[tinline.Count - 2]);
                        }
                    }
                }
                tinline.Remove(tinline[0]);//将集合中第一条边删除
                for (int i = 0; i <= tinline.Count - 1; i++)
                {
                    DrawLine(((Line)tinline[i]).Begin, ((Line)tinline[i]).End);
                   // graphics.DrawLine(pen, ((Line)tinline[i]).Begin, ((Line)tinline[i]).End);
                }
                // this.Text = "TIN边数： " + tinline.Count.ToString() + " 条";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //清空画板
        private void Clear_Btu_Click(object sender, EventArgs e)
        {
            PL.Clear();
            initPic();
            this.pictureBox1.Image = bitmap;
            
        }
    }
}
