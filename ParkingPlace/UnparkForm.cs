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

namespace ParkingPlace
{
    public partial class UnparkForm : Form
    {
        public UnparkForm()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonUnPark_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Unpark", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                MessageBox.Show("You have clicked Ok Button");
                VehicleType type = new VehicleType();
                bool isChecked = radioButtonCAR.Checked;
                if (isChecked)
                    type = VehicleType.CAR;
                else
                    type = VehicleType.MOTOR;
                ParkingPlot.Instance.UnparkVehicle(Int32.Parse(textBox1.Text), type);

                textBox1.Text = String.Empty;
                radioButtonCAR.Checked = false;
                radioButtonMOTOR.Checked = false;
            }
            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("canceled Succesfully");
                textBox1.Text = String.Empty;
                radioButtonCAR.Checked = false;
                radioButtonMOTOR.Checked = false;
            }

            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
