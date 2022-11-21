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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ParkingPlace
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            VehicleType type = new VehicleType();
            bool isChecked = radioButtonCAR.Checked;
            if (isChecked)
                type = VehicleType.CAR;
            else
                type = VehicleType.MOTOR;

           Tuple<int,int> location = ParkingPlot.Instance.FindVehicle(Int32.Parse( textBox1.Text), type);
            if (location.Item1 == -1 && location.Item2 == -1)
            {
                MessageBox.Show( " Vehicle Not Found");
                textBox1.Text = String.Empty;
                radioButtonCAR.Checked = false;
                radioButtonMOTOR.Checked = false;
            }
            else
            {
                labelResult.Text = location.Item1.ToString();
                labelResultSlot.Text = location.Item2.ToString();

            }
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();            
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            radioButtonCAR.Checked = false;
            radioButtonMOTOR.Checked= false;
            labelResult.Text = String.Empty;
            labelResultSlot.Text = String.Empty;
            
        }
    }
}
