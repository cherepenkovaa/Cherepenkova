﻿using System;
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
    
    public partial class Form2 : Form
    {
        public int value
        {
            get; set;
        }
        public Form2()
        {
            value = 100;
            InitializeComponent();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            value = trackBar1.Value;
        }
    }
}
