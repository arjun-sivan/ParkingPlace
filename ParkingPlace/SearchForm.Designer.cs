namespace ParkingPlace
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonMOTOR = new System.Windows.Forms.RadioButton();
            this.radioButtonCAR = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelResultSlot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle Type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 27);
            this.textBox1.TabIndex = 2;
            // 
            // radioButtonMOTOR
            // 
            this.radioButtonMOTOR.AutoSize = true;
            this.radioButtonMOTOR.Location = new System.Drawing.Point(310, 122);
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
            this.radioButtonCAR.Location = new System.Drawing.Point(449, 122);
            this.radioButtonCAR.Name = "radioButtonCAR";
            this.radioButtonCAR.Size = new System.Drawing.Size(58, 24);
            this.radioButtonCAR.TabIndex = 4;
            this.radioButtonCAR.TabStop = true;
            this.radioButtonCAR.Text = "CAR";
            this.radioButtonCAR.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(310, 170);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(206, 29);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(593, 381);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(113, 29);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(320, 249);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 20);
            this.labelResult.TabIndex = 7;
            // 
            // labelResultSlot
            // 
            this.labelResultSlot.AutoSize = true;
            this.labelResultSlot.Location = new System.Drawing.Point(310, 293);
            this.labelResultSlot.Name = "labelResultSlot";
            this.labelResultSlot.Size = new System.Drawing.Size(0, 20);
            this.labelResultSlot.TabIndex = 8;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResultSlot);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.radioButtonCAR);
            this.Controls.Add(this.radioButtonMOTOR);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private RadioButton radioButtonMOTOR;
        private RadioButton radioButtonCAR;
        private Button buttonSearch;
        private Button buttonBack;
        private Label labelResult;
        private Label labelResultSlot;
    }
}