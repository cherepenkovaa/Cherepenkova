using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica5
{
    public partial class Form1 : Form
    {
        Color brush;
        int R;
        bool flag;
        bool flag2;
        int x;
        int y;
        public Form1()
        {
            InitializeComponent();
            brush = Color.Olive;
            flag2 = false;
            R = 30;
            x = 35;
            y = 35;
        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (flag)
            {
                e.Graphics.FillEllipse(new SolidBrush(brush), x, y, R, R);
                //flag = false;
            }
            
        }

        private void НАРИСОВАТЬ_Click(object sender, EventArgs e)
        {
            flag = true;
            splitContainer1.Panel1.Invalidate();
        }

        private void СТЕРЕТЬ_Click(object sender, EventArgs e)
        {
            flag = false;
            splitContainer1.Panel1.Invalidate();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
          



            if (flag2 != true)
            {
                x += 5;
                y += 5;
            
                if (splitContainer1.Panel1.ClientSize.Height - R <= y || splitContainer1.Panel1.ClientSize.Height - R <= x) flag2 = true;
            }
            else
            {

                x -= 5;
                y -= 5;
                
                if (x == 0 || y == 0) flag2 = false;
            }
            splitContainer1.Panel1.Invalidate();
        

        }

        private void ОЖИВИТЬ_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
                x = 35;
                y = 35;
            }
            else timer1.Start();
        }
    }
}
