using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задача_1
{
    public partial class Form1 : Form
    {
        int x, y;
        bool flag;
        bool stop;
        bool isBelow;
        bool isBottom;
        bool turn;
        bool perekluch;
        int t;
        int index = 0;
        
        Random random = new Random();
        Color color =  Color.Red;
        Figuri arr;
        List<Figuri> list = new List<Figuri>();

        static Form1()
        {

        }
        public Form1()
        {
            InitializeComponent();
            flag = false;
            //index = 0;
            t = 100;
            stop = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
                foreach (Figuri f in list)
                    {
                       f.SetisIn = false;
                       f.setColor = color;
                       f.DrawFigure(e.Graphics);
                    }
                if (turn)
                {
                    if (list.Count > 2)
                    {
                        for (int i = 0; i < list.Count; i++) //0 1 2 3 4  5-1=4 i< 4 => 3 хотя не
                        {
                            for (int j = i+1; j < list.Count; j++)//
                            {
                                isBelow = false;
                                isBottom = false;
                                for (int k = 0; k < list.Count; k++)
                                {
                                    if (k != j && k != i && i!= j)
                                    {
                                    //
                                        if (((list[k].SetY - list[i].SetY) * (list[j].SetX - list[i].SetX)) > ((list[k].SetX - list[i].SetX) * (list[j].SetY - list[i].SetY)))
                                            isBelow = true;
                                        else isBottom = true;
                                    }
                                }
                                    
                                if (isBelow == false || isBottom == false)
                                {
                                    list[i].SetisIn = true;
                                    list[j].SetisIn = true;
                                    e.Graphics.DrawLine(new Pen(Color.Violet), list[i].SetX, list[i].SetY, list[j].SetX, list[j].SetY);
                                }
                            }
                        }
                    }
                }
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //    flag = false;
            //    if (list.Count > 0)
            //    {
            //        //bool cringe = false;
            //        foreach (Figuri f in list)
            //        {
            //            if (f.Check(e.X, e.Y))
            //            {
            //                if (e.Button == MouseButtons.Left)
            //                {
            //                    f.SetDeltaX = e.X - f.SetX;
            //                    f.SetDeltaY = e.Y - f.SetY;
            //                    f.SetisDrugged = true;
            //                    flag = true;
            //                    //cringe = true;
            //                }
            //                if (e.Button == MouseButtons.Right)
            //                {
            //                    list.Remove(f);
            //                    Refresh();
            //                    //cringe = true;
            //                   // flag = true;
            //                    break;
            //                }
            //            }
            //            else if (e.Button == MouseButtons.Left)
            //            {

            //                if (Transfer(e.X, e.Y, list))
            //                {
            //                    flag = true; 
            //                    foreach (Figuri v in list)
            //                    {
            //                        v.SetDeltaX = e.X - v.SetX;
            //                        v.SetDeltaY = e.Y - v.SetY;
            //                        v.SetisDrugged = true;
            //                    }
            //                }
            //                 else flag = false;
            //            }
            //            Invalidate();                    
            //        }
            //    }
            //    if (flag == false && e.Button==MouseButtons.Left)
            //    {
            //        switch (index)
            //        {
            //            case 1: list.Add(new Ellipse(e.X, e.Y)); break;
            //            case 2: list.Add(new Rectangle(e.X, e.Y)); break;
            //            case 3: list.Add(new Triangle(e.X, e.Y)); break;
            //            default: list.Add(new Rectangle(e.X, e.Y)); break;
            //        }              
            //    }
            //    Invalidate();
            //}
            flag = false;
            if (list.Count > 0)
            {
                //bool cringe = false;
                foreach (Figuri f in list)
                {
                    if (f.Check(e.X, e.Y))
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            f.SetDeltaX = e.X - f.SetX;
                            f.SetDeltaY = e.Y - f.SetY;
                            f.SetisDrugged = true;
                            flag = true;
                            //cringe = true;
                        }
                        else if (e.Button == MouseButtons.Right)
                        {
                            list.Remove(f);
                            Refresh();
                            //cringe = true;
                            break;
                        }
                    }
                   /* else if (e.Button == MouseButtons.Left)
                    {
                        flag = false;
                    }*/
                }
            }
            if (flag == false && e.Button == MouseButtons.Left)
            {
                switch (index)
                {
                    case 1: list.Add(new Ellipse(e.X, e.Y)); break;
                    case 2: list.Add(new Rectangle(e.X, e.Y)); break;
                    case 3: list.Add(new Triangle(e.X, e.Y)); break;
                    default: list.Add(new Rectangle(e.X, e.Y)); break;
                }
            }
            Invalidate(); }

            private void КругToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void КвадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void ТреугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void КругToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (Figuri f in list)
            {
                if (f.SetisDrugged)
                {
                    f.SetX = e.X - f.SetDeltaX;
                    f.SetY = e.Y - f.SetDeltaY; 
                }
            }
            this.Invalidate();
        }
        public bool Transfer(double x, double y, List<Figuri> listCopy)
        {
            if (list.Count > 2)
            {
                bool isBelow;// над прямой
                bool isBottom;// под прямой
                Figuri TempObj = new Rectangle((int)x, (int)y);
                listCopy.Add(TempObj);
                List<Figuri> Figura = new List<Figuri>();

                for (int i = 0; i < listCopy.Count - 1; i++)
                {
                    for (int j = i + 1; j < listCopy.Count; j++)
                    {
                        isBelow = false;
                        isBottom = false;

                        for (int k = 0; k < listCopy.Count; k++)
                        {
                            if (k != i && k != j && i != j)
                            {
                                if (((listCopy[k].SetY - listCopy[i].SetY) * (listCopy[j].SetX - listCopy[i].SetX)) >=
                                    ((listCopy[k].SetX - listCopy[i].SetX) * (listCopy[j].SetY - listCopy[i].SetY))) isBottom= true;
                                else isBelow = true;
                            }

                            if (!(isBelow && !isBottom))
                            {
                                Figura.Add(listCopy[j]);
                                Figura.Add(listCopy[i]);
                            }

                        }
                    }
                    if (!Figura.Contains(TempObj)) return true;
                }
            }
            return false;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            stop = true;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].SetisDrugged)
                {
                    list[i].SetisDrugged = false;
                }
            }

            if (turn)//если вершин больше 2х count
            {
                for (int i = 0; i < list.Count; i++)
                {


                    if (!list[i].SetisIn)
                    {
                        list.Remove(list[i]);
                        
                    }
                }
              
            }

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int i = 0;
            foreach (Figuri f in list)
            {
                i++;
            }
            list.RemoveAt(i);
            flag = false;
            Invalidate();
        }

        private void Button2_Click(object sender, EventArgs e)//включить
        {
            turn = true;
            Invalidate();
        }

        private void Button1_Click(object sender, EventArgs e)//выключить
        {
            turn = false;
            Invalidate();

        }

        private void ПоменятьЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            int rnd = random.Next(-5, 5);
            if (perekluch)
            {
                foreach (Figuri f in list)
                {
                    f.SetX = f.SetX - rnd;
                    f.SetY = f.SetY - rnd;
                }
                perekluch = false;
            }
            else
            {
                foreach (Figuri f in list)
                {
                    f.SetX = f.SetX + rnd;
                    f.SetY = f.SetY + rnd;
                }
                perekluch = true;
            }
            Refresh();
        }

        private void ВключитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            
            
                t = f2.value;
                timer1.Interval = t;
                perekluch = true;
                timer1.Start();
            
            
        }

        private void ВыключитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        /*private void Form1_MouseLeave(object sender, EventArgs e)
        {
        flag = false;

        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }
    }
}

