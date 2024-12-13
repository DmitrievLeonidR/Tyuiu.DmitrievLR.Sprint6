using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DmitrievLR.Sprint6.Task0.V14.Lib;

namespace Tyuiu.DmitrievLR.Sprint6.Task0.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButnCLick_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                TextBoxResult.Text = ds.Calculate(Convert.ToInt32(InputTexBox.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные");   
            }
        }
    }
}