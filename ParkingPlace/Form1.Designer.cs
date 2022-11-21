namespace ParkingPlace
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonPark = new System.Windows.Forms.Button();
            this.buttonUnPark = new System.Windows.Forms.Button();
            this.buttonAdminLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(45, 236);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(153, 29);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search vehicle";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonPark
            // 
            this.buttonPark.Location = new System.Drawing.Point(271, 236);
            this.buttonPark.Name = "buttonPark";
            this.buttonPark.Size = new System.Drawing.Size(152, 29);
            this.buttonPark.TabIndex = 1;
            this.buttonPark.Text = "Park Vehicle";
            this.buttonPark.UseVisualStyleBackColor = true;
            this.buttonPark.Click += new System.EventHandler(this.buttonPark_Click);
            // 
            // buttonUnPark
            // 
            this.buttonUnPark.Location = new System.Drawing.Point(514, 236);
            this.buttonUnPark.Name = "buttonUnPark";
            this.buttonUnPark.Size = new System.Drawing.Size(153, 29);
            this.buttonUnPark.TabIndex = 2;
            this.buttonUnPark.Text = "Unpark Vehicle";
            this.buttonUnPark.UseVisualStyleBackColor = true;
            this.buttonUnPark.Click += new System.EventHandler(this.buttonUnPark_Click);
            // 
            // buttonAdminLogin
            // 
            this.buttonAdminLogin.Location = new System.Drawing.Point(533, 392);
            this.buttonAdminLogin.Name = "buttonAdminLogin";
            this.buttonAdminLogin.Size = new System.Drawing.Size(153, 29);
            this.buttonAdminLogin.TabIndex = 3;
            this.buttonAdminLogin.Text = "Admin Login";
            this.buttonAdminLogin.UseVisualStyleBackColor = true;
            this.buttonAdminLogin.Click += new System.EventHandler(this.buttonAdminLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdminLogin);
            this.Controls.Add(this.buttonUnPark);
            this.Controls.Add(this.buttonPark);
            this.Controls.Add(this.buttonSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonSearch;
        private Button buttonPark;
        private Button buttonUnPark;
        private Button buttonAdminLogin;
    }
}