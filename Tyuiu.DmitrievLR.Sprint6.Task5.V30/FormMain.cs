﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DmitrievLR.Sprint6.Task5.V30.Lib;

namespace Tyuiu.DmitrievLR.Sprint6.Task5.V30
{
    public partial class FormMain : Form                 
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
    }
}