using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Creates a Structure called Cars and defines its attributes
        private struct Cars
        {
            public string make;
            public int year;
            public double mileage;
        }

        private Cars[] myCars = new Cars[2];

        private void Form1_Load(object sender, EventArgs e)
        {
            AddCarList();
        }

        //Adds hard coded list of cars to myCars
        private void AddCarList()
        {

            myCars[0].make = "Ford";
            myCars[0].year = 2019;
            myCars[0].mileage = 52.0;

            myCars[1].make = "Chevrolet";
            myCars[1].year = 2020;
            myCars[1].mileage = 193.5;

            //Resize the array
            Array.Resize(ref myCars, 3);

            myCars[2].make = "GMC";
            myCars[2].year = 2018;
            myCars[2].mileage = 15254.8;
        }

        private void btnLoadList_Click(object sender, EventArgs e)
        {
            lstCars.Items.Clear();

            for (int Loop = 0; Loop < myCars.Length; Loop++)
            {
                lstCars.Items.Add(
                    "Make: " + myCars[Loop].make +
                    "\tYear: " + myCars[Loop].year +
                    "\tMileage: " + myCars[Loop].mileage);
            }
        }

        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMake.Text = myCars[lstCars.SelectedIndex].make;
            txtYear.Text = myCars[lstCars.SelectedIndex].year.ToString();
            txtMileage.Text = myCars[lstCars.SelectedIndex].mileage.ToString();
        }
    }
}
