using ParkPlatz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ParkingPlace
{
    public partial class ParkVehicle : Form
    {
        public ParkVehicle()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonPARK_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Park", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
               
                VehicleType type = new VehicleType();
                bool isChecked = radioButtonCAR.Checked;
                if (isChecked)
                    type = VehicleType.CAR;
                else
                    type = VehicleType.MOTOR;

                Vehicle vehicle = new Vehicle(Int32.Parse(textBox1.Text), type);

                
                Tuple<int, int> parkingID = ParkingPlot.Instance.ParkVehicle(vehicle);
                string parkingIdString = parkingID.ToString();

                if (parkingID.Item1 == -1 && parkingID.Item2 == -1)
                {
                    MessageBox.Show("No free space in Floors");
                    return;
                }

                textBox1.Text = String.Empty;
                radioButtonCAR.Checked = false;
                radioButtonMOTOR.Checked = false;
                MessageBox.Show("The vehicle is succesfully parked at floor,Slot {0} ",parkingIdString);

            }
            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("Parking Canceled");
                textBox1.Text = String.Empty;
                radioButtonCAR.Checked = false;
                radioButtonMOTOR.Checked = false;

            }
            

        }
    }
}
