using ParkPlatz;

namespace ParkingPlace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
            this.Hide();

        }

        private void buttonAdminLogin_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();  
            adminForm.Show();
            this.Hide();
        }

        private void buttonPark_Click(object sender, EventArgs e)
        {
            ParkVehicle parkVehicle = new ParkVehicle();
            parkVehicle.Show();
            this.Hide();
        }

        private void buttonUnPark_Click(object sender, EventArgs e)
        {
            UnparkForm unparkForm = new UnparkForm();
            unparkForm.Show();
            this.Hide();
        }
    }
}