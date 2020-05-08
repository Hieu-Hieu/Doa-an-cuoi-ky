using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaXe01
{
    public partial class staticsForm : Form
    {
        public staticsForm()
        {
            InitializeComponent();
        }

        Vehicle vehicle = new Vehicle();

        private void staticsForm_Load(object sender, EventArgs e)
        {

            double total = Convert.ToDouble(vehicle.totalVehicle());
            double car = Convert.ToDouble(vehicle.totalCar());
            double bike = Convert.ToDouble(vehicle.totalBicycle());
            double Moto = Convert.ToDouble(vehicle.totalMotorcycle());

            double CarPercent = car * (100 /( total));
            double BikePercent = bike * (100 /( total));
            double MotoPercent = Moto * (100 / (total));
            
            labelBike.Text = "Bike: " + BikePercent.ToString("0.00") + "%";
            labelCar.Text = "Car: " + CarPercent.ToString("0.00") + "%";
            labelMotorcycle.Text = "Motorcycle: " + MotoPercent.ToString("0.00") + "%";
            labelTotal.Text = " Total: " + vehicle.totalVehicle();
        }
    }
}
