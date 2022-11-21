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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            this.GenerateList();
        }

       

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GenerateList()
        {
            listView1.Items.Clear();
            foreach (var floor in ParkingPlot.Instance.floors.Select((value, i) => new { i, value }))
            {

                string[] row = { floor.i.ToString(), floor.value.availParkingCars.ToString(), floor.value.availParkingMotors.ToString() };


                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);

            }
        }

        private void buttonAddFloor_Click(object sender, EventArgs e)
        {
           AddFloorForm addFloorForm = new AddFloorForm();
            addFloorForm.ShowDialog();
            this.GenerateList();

        }

        private void buttonRemoveFloor_Click(object sender, EventArgs e)
        {
            RemoveFloorForm removeFloorForm = new RemoveFloorForm();
            removeFloorForm.ShowDialog();
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.ShowDialog();

        }
    }
}
