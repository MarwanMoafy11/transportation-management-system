namespace Transportation_System_C_
{
    partial class Form3
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
            this.where_to_textBox = new System.Windows.Forms.TextBox();
            this.from_where_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.car_radioButton = new System.Windows.Forms.RadioButton();
            this.scooter_radioButton = new System.Windows.Forms.RadioButton();
            this.bus_radioButton = new System.Windows.Forms.RadioButton();
            this.search_button = new System.Windows.Forms.Button();
            this.profile_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Where To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(580, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ride Details";
            // 
            // where_to_textBox
            // 
            this.where_to_textBox.Location = new System.Drawing.Point(621, 288);
            this.where_to_textBox.Name = "where_to_textBox";
            this.where_to_textBox.Size = new System.Drawing.Size(100, 22);
            this.where_to_textBox.TabIndex = 2;
            // 
            // from_where_textBox
            // 
            this.from_where_textBox.Location = new System.Drawing.Point(621, 203);
            this.from_where_textBox.Name = "from_where_textBox";
            this.from_where_textBox.Size = new System.Drawing.Size(100, 22);
            this.from_where_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "From Where ";
            // 
            // car_radioButton
            // 
            this.car_radioButton.AutoSize = true;
            this.car_radioButton.Location = new System.Drawing.Point(341, 393);
            this.car_radioButton.Name = "car_radioButton";
            this.car_radioButton.Size = new System.Drawing.Size(49, 20);
            this.car_radioButton.TabIndex = 7;
            this.car_radioButton.TabStop = true;
            this.car_radioButton.Text = "Car";
            this.car_radioButton.UseVisualStyleBackColor = true;
            // 
            // scooter_radioButton
            // 
            this.scooter_radioButton.AutoSize = true;
            this.scooter_radioButton.Location = new System.Drawing.Point(621, 393);
            this.scooter_radioButton.Name = "scooter_radioButton";
            this.scooter_radioButton.Size = new System.Drawing.Size(75, 20);
            this.scooter_radioButton.TabIndex = 8;
            this.scooter_radioButton.TabStop = true;
            this.scooter_radioButton.Text = "Scooter";
            this.scooter_radioButton.UseVisualStyleBackColor = true;
            // 
            // bus_radioButton
            // 
            this.bus_radioButton.AutoSize = true;
            this.bus_radioButton.Location = new System.Drawing.Point(893, 393);
            this.bus_radioButton.Name = "bus_radioButton";
            this.bus_radioButton.Size = new System.Drawing.Size(51, 20);
            this.bus_radioButton.TabIndex = 9;
            this.bus_radioButton.TabStop = true;
            this.bus_radioButton.Text = "Bus";
            this.bus_radioButton.UseVisualStyleBackColor = true;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(607, 566);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(114, 48);
            this.search_button.TabIndex = 11;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // profile_button
            // 
            this.profile_button.Location = new System.Drawing.Point(1190, 71);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(114, 48);
            this.profile_button.TabIndex = 12;
            this.profile_button.Text = "Profile";
            this.profile_button.UseVisualStyleBackColor = true;
            this.profile_button.Click += new System.EventHandler(this.profile_button_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 728);
            this.Controls.Add(this.profile_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.bus_radioButton);
            this.Controls.Add(this.scooter_radioButton);
            this.Controls.Add(this.car_radioButton);
            this.Controls.Add(this.from_where_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.where_to_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Main Ride";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox where_to_textBox;
        private System.Windows.Forms.TextBox from_where_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton car_radioButton;
        private System.Windows.Forms.RadioButton scooter_radioButton;
        private System.Windows.Forms.RadioButton bus_radioButton;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button profile_button;
    }
}