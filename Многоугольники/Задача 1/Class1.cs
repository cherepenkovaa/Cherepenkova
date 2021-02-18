using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    public abstract class Figuri
    {
        protected int x;
        protected int y;
        protected static int R;
        protected static Color color;
        protected bool isDrugged;
        protected bool isIn;
        protected int deltaX;
        protected int deltaY;

        protected Figuri(int x, int y)
        {
            R = 100;
            color = Color.Violet;
            this.x = x;
            this.y = y;
        }
        
        public int SetX { set { x = value; } get { return x; } }
        public int SetY { set { y = value; } get { return y; } }
        public Color setColor{ set { color = value; } get { return color; } }

        public int SetDeltaX { set { deltaX = value; } get { return deltaX; } }
        public int SetDeltaY { set { deltaY = value; } get { return deltaY; } }
        public bool SetisDrugged { set { isDrugged = value; } get { return isDrugged; } }
        public bool SetisIn { set { isIn = value; } get { return isIn; } }

        public abstract void DrawFigure(Graphics graf);
        public abstract bool Check(int x, int y);
    }

    public class Triangle : Figuri
    {
        public Triangle(int x, int y) : base(x, y)
        {

        }

        public override void DrawFigure(Graphics graf)
        {
            Point point1 = new Point(x, y - R / 2);
            Point point2 = new Point(x - R / 2, y + R / 2);
            Point point3 = new Point(x + R / 2, y + R / 2);
            Point[] curvePoints = { point1, point2, point3 };
            SolidBrush brush = new SolidBrush(color);
            graf.FillPolygon(brush, curvePoints);
        }
        public override bool Check(int x, int y)
        {
            return true;
        }
    }

    public class Rectangle : Figuri
    {

        public Rectangle(int x, int y) : base(x, y)
        {

        }

        public override void DrawFigure(Graphics graf)
        {
            SolidBrush brush = new SolidBrush(color);
            graf.FillRectangle(brush, x - R / 2, y - R / 2, R, R);
        }
        public override bool Check(int a, int b)
        {
            if (this.x >= a - R / 2 && this.x <= a + R / 2 && this.y <= b + R / 2 && this.y >= b - R / 2)
            {
                return true;
            }
            else return false;
        }
    }

    public class Ellipse : Figuri
    {
        public Ellipse(int x, int y) : base(x, y)
        {

        }
        SolidBrush brush = new SolidBrush(color);
        public override void DrawFigure(Graphics graf)
        {
            SolidBrush brush = new SolidBrush(color);
            graf.FillEllipse(brush, x - R / 2, y - R / 2, R, R);
        }
        public override bool Check(int a, int b)
        {
            if (Math.Pow(R, 2) >= Math.Pow(this.x - a, 2) + Math.Pow(this.y - b, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }

}