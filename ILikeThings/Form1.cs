using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ILikeThings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMakeCar_Click(object sender, EventArgs e)
        {
            //int a = 5;
            //int[] scores = new int[5];

            //Car c = new Car();
            //c.NumberOfDoors = 5;
            //c.Color = "red";

            //MessageBox.Show(c.NumberOfDoors.ToString());

            int[] scores = new int[5];
            Car[] lot = new Car[100];

            for (int i = 0; i < 100; i++) {
                lot[i] = new Car();
            }

            int b = 5;

        }
    }
}
