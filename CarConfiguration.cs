using System;
using Windows;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Dacia_Logan
{
    public partial class Forml: Form
    {
        private Car myCar

        public form1()
        {
            myCar = new Car;

            InitializeComponent();
        }

        private void GetCarData(Car car)
        {
            try
            {
                myCar.make = txtMake.text;

                myCar.year = int.Parse(txtModel.text);

                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Must enter a valid make and year model for the car. ", ex.Message, "/r/n", ex.StackTrace));
            }

            private void btnBrake_Click(object sender, EventArgs e)
            {
                GetCarData();
                myCar.DecSpreed(10);
                MessageBox.Show("Your car is a" + myCar.Year + myCar.Made + "and it is travelling" + myCar.Speed + "mph");
            }
        }
    }
}