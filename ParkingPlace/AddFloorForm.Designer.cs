namespace ParkingPlace
{
    partial class AddFloorForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AvailableCarParking = new System.Windows.Forms.Label();
            this.AvailableMotorParking = new System.Windows.Forms.Label();
            this.buttonADD = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(402, 213);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 1;
            // 
            // AvailableCarParking
            // 
            this.AvailableCarParking.AutoSize = true;
            this.AvailableCarParking.Location = new System.Drawing.Point(214, 150);
            this.AvailableCarParking.Name = "AvailableCarParking";
            this.AvailableCarParking.Size = new System.Drawing.Size(149, 20);
            this.AvailableCarParking.TabIndex = 2;
            this.AvailableCarParking.Text = "Available Car Parking";
            // 
            // AvailableMotorParking
            // 
            this.AvailableMotorParking.AutoSize = true;
            this.AvailableMotorParking.Location = new System.Drawing.Point(195, 220);
            this.AvailableMotorParking.Name = "AvailableMotorParking";
            this.AvailableMotorParking.Size = new System.Drawing.Size(168, 20);
            this.AvailableMotorParking.TabIndex = 3;
            this.AvailableMotorParking.Text = "Available Motor Parking";
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(414, 325);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(98, 29);
            this.buttonADD.TabIndex = 4;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(402, 268);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Multiplier";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(664, 393);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(94, 29);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // AddFloorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.AvailableMotorParking);
            this.Controls.Add(this.AvailableCarParking);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "AddFloorForm";
            this.Text = "AddFloorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label AvailableCarParking;
        private Label AvailableMotorParking;
        private Button buttonADD;
        private TextBox textBox3;
        private Label label1;
        private Button buttonBack;
    }
}