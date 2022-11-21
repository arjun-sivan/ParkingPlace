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
               
                VehicleType type = new VehicleType();
                bool isChecked = radioButtonCAR.Checked;
                if (isChecked)
                    type = VehicleType.CAR;
                else
                    type = VehicleType.MOTOR;

                bool UnparkStatus = ParkingPlot.Instance.UnparkVehicle(Int32.Parse(textBox1.Text), type);

               if (UnparkStatus == false)
                {
                    MessageBox.Show("Vehicle Not Found");
                    this.Reset();
                }
                if(UnparkStatus)
                { 
                    MessageBox.Show("Vehicle unparked succesfully");
                    this.Reset();
                }

               
            }
            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("canceled Succesfully");
                this.Reset();
            }

            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void UnparkForm_Load(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            textBox1.Text = String.Empty;
            radioButtonCAR.Checked = false;
            radioButtonMOTOR.Checked = false;
        }

    }
}
