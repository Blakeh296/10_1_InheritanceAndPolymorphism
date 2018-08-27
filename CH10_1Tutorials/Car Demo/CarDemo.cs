using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Demo
{
    public partial class CarDemo : Form
    {
        public CarDemo()
        {
            InitializeComponent();
        }
        Automobile automobile = new Automobile();
        private void btnCreateObject_Click(object sender, EventArgs e)
        {

            
            // Get the car data
            GetCarData(automobile);

            // Display the  car data

            lblCarMake.Text = automobile.Make;
            lblCarModel.Text = automobile.Model;
            lblCarMileage.Text = automobile.Mileage.ToString();
            lblCarPrice.Text = automobile.Price.ToString("c");
            lblCarDoors.Text = automobile.Doors.ToString();
        }
        // The GetCarData method accepts a car object as an argument
        // It assigns the data entered by the user to the object properties
        private void GetCarData(Automobile car)
        {
            // Temp veriables to hold mileage, price, and number of doors

            int mileage;
            decimal price;
            int doors;

            // Get the cars make
            automobile.Make = textbox1.Text;

            // Get the cars model
            automobile.Model = tbCarModel.Text;

            // Get the car's Mileage
            if (int.TryParse(tbCarMileage.Text, out mileage))
            {
                automobile.Mileage = mileage;

                // Ge tthe cars price
                if (decimal.TryParse(tbCarPrice.Text, out price))
                {
                    automobile.Price = price;

                    // Get the number of doors
                    if (int.TryParse(tbCarDoors.Text, out doors))
                    {
                        automobile.Doors = doors;
                    }
                    else
                    {
                        // Display an error message
                        MessageBox.Show("Invalid number of doors");
                    }
                }
                else
                {
                    // Display error message
                    MessageBox.Show("Invalid price");
                }
            }
            else
            {
                // Display an error message
                MessageBox.Show("Invalid Mileage");
            }
        }

        private void nextTutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CD_AccountTest nextForm = new CD_AccountTest();
            nextForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    

    
}
