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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParkingPlace
{
    public partial class RemoveFloorForm : Form
    {
        public RemoveFloorForm()
        {
            InitializeComponent();
            int Count = ParkingPlot.Instance.floors.Count();
            //string[] floorList = new string[10];
            List<string> floorList = Enumerable.Range(0, Count).Select(x => x.ToString()).ToList();
            comboBox1.DataSource = floorList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                MessageBox.Show("Floor Deleted Succesfully");
                int floorNumber = comboBox1.SelectedIndex;
                ParkingPlot.Instance.DeleteFloor(floorNumber);

                this.Close();
                this.Dispose();
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
                   
            }
            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("Succesfully Canceled");
               
            }          
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
