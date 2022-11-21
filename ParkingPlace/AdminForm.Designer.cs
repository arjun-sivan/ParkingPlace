namespace ParkingPlace
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.buttonRemoveFloor = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FloorNumber = new System.Windows.Forms.ColumnHeader();
            this.AvailableParkingCars = new System.Windows.Forms.ColumnHeader();
            this.AvailableParkingMotors = new System.Windows.Forms.ColumnHeader();
            this.buttonAddFloor = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRemoveFloor
            // 
            this.buttonRemoveFloor.Location = new System.Drawing.Point(222, 30);
            this.buttonRemoveFloor.Name = "buttonRemoveFloor";
            this.buttonRemoveFloor.Size = new System.Drawing.Size(106, 29);
            this.buttonRemoveFloor.TabIndex = 1;
            this.buttonRemoveFloor.Text = "Delete Floor";
            this.buttonRemoveFloor.UseVisualStyleBackColor = true;
            this.buttonRemoveFloor.Click += new System.EventHandler(this.buttonRemoveFloor_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FloorNumber,
            this.AvailableParkingCars,
            this.AvailableParkingMotors});
            this.listView1.HoverSelection = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(62, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(689, 298);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // FloorNumber
            // 
            this.FloorNumber.Text = "Floor Number";
            this.FloorNumber.Width = 120;
            // 
            // AvailableParkingCars
            // 
            this.AvailableParkingCars.Text = "Available Parking Cars";
            this.AvailableParkingCars.Width = 180;
            // 
            // AvailableParkingMotors
            // 
            this.AvailableParkingMotors.Text = "Available Parking Motors";
            this.AvailableParkingMotors.Width = 180;
            // 
            // buttonAddFloor
            // 
            this.buttonAddFloor.Location = new System.Drawing.Point(62, 30);
            this.buttonAddFloor.Name = "buttonAddFloor";
            this.buttonAddFloor.Size = new System.Drawing.Size(94, 29);
            this.buttonAddFloor.TabIndex = 3;
            this.buttonAddFloor.Text = "Add Floor";
            this.buttonAddFloor.UseVisualStyleBackColor = true;
            this.buttonAddFloor.Click += new System.EventHandler(this.buttonAddFloor_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(657, 409);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(94, 29);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddFloor);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonRemoveFloor);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonRemoveFloor;
        private ListView listView1;
        private ColumnHeader FloorNumber;
        private ColumnHeader AvailableParkingCars;
        private ColumnHeader AvailableParkingMotors;
        private Button buttonAddFloor;
        private Button buttonBack;
    }
}