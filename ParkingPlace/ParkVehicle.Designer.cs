namespace ParkingPlace
{
    partial class ParkVehicle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonMOTOR = new System.Windows.Forms.RadioButton();
            this.radioButtonCAR = new System.Windows.Forms.RadioButton();
            this.buttonPARK = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(365, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 27);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Vehicle ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vehicle Type";
            // 
            // radioButtonMOTOR
            // 
            this.radioButtonMOTOR.AutoSize = true;
            this.radioButtonMOTOR.Location = new System.Drawing.Point(375, 220);
            this.radioButtonMOTOR.Name = "radioButtonMOTOR";
            this.radioButtonMOTOR.Size = new System.Drawing.Size(80, 24);
            this.radioButtonMOTOR.TabIndex = 3;
            this.radioButtonMOTOR.TabStop = true;
            this.radioButtonMOTOR.Text = "MOTOR";
            this.radioButtonMOTOR.UseVisualStyleBackColor = true;
            // 
            // radioButtonCAR
            // 
            this.radioButtonCAR.AutoSize = true;
            this.radioButtonCAR.Location = new System.Drawing.Point(493, 222);
            this.radioButtonCAR.Name = "radioButtonCAR";
            this.radioButtonCAR.Size = new System.Drawing.Size(58, 24);
            this.radioButtonCAR.TabIndex = 4;
            this.radioButtonCAR.TabStop = true;
            this.radioButtonCAR.Text = "CAR";
            this.radioButtonCAR.UseVisualStyleBackColor = true;
            // 
            // buttonPARK
            // 
            this.buttonPARK.Location = new System.Drawing.Point(375, 278);
            this.buttonPARK.Name = "buttonPARK";
            this.buttonPARK.Size = new System.Drawing.Size(176, 29);
            this.buttonPARK.TabIndex = 5;
            this.buttonPARK.Text = "PARK";
            this.buttonPARK.UseVisualStyleBackColor = true;
            this.buttonPARK.Click += new System.EventHandler(this.buttonPARK_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(595, 374);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(102, 29);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ParkVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonPARK);
            this.Controls.Add(this.radioButtonCAR);
            this.Controls.Add(this.radioButtonMOTOR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "ParkVehicle";
            this.Text = "ParkVehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private RadioButton radioButtonMOTOR;
        private RadioButton radioButtonCAR;
        private Button buttonPARK;
        private Button buttonBack;
    }
}