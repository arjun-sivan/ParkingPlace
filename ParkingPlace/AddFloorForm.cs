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
    public partial class AddFloorForm : Form
    {
        public AddFloorForm()
        {
            InitializeComponent();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Add", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                MessageBox.Show("Floors added succesfully");
                int multiplier = Int32.Parse(textBox3.Text);
                for (int i = 0; i < multiplier; i++)
                {
                    bool status = ParkingPlot.Instance.AddFloor(new Floor(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text)));
                }
                this.Close();
            }
            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("You canceled adding the floor");
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;   
                textBox3.Text = String.Empty;            
            }       
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
