
namespace BG_Task_7._1
{
    partial class NewVehicleForm
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
            this.VehicleNameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.VehicleTypeLabel = new System.Windows.Forms.Label();
            this.VehicleTypeBox = new System.Windows.Forms.ComboBox();
            this.VehicleWeightLabel = new System.Windows.Forms.Label();
            this.VehicleWeightTextBox = new System.Windows.Forms.TextBox();
            this.MaximumDistanceLabel = new System.Windows.Forms.Label();
            this.MaxDistanceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaximumPayloadLabel = new System.Windows.Forms.Label();
            this.MaxCargoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentPayloadLabel = new System.Windows.Forms.Label();
            this.CurrentPayloadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DriveTypeLabel = new System.Windows.Forms.Label();
            this.DriveTypeBox = new System.Windows.Forms.ComboBox();
            this.WheelsAmountLabel = new System.Windows.Forms.Label();
            this.WheelsAmountTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CarsAmountLabel = new System.Windows.Forms.Label();
            this.CarsAmountTextBox = new System.Windows.Forms.TextBox();
            this.PassengerAmountLabel = new System.Windows.Forms.Label();
            this.PassengersAmountTextBox = new System.Windows.Forms.TextBox();
            this.HasPassengerCheck = new System.Windows.Forms.CheckBox();
            this.TankAmountLabel = new System.Windows.Forms.Label();
            this.FuelTankAmountTextBox = new System.Windows.Forms.TextBox();
            this.TankSizeLabel = new System.Windows.Forms.Label();
            this.FuelTankSizeTextBox = new System.Windows.Forms.TextBox();
            this.HeavyCargoLiterLabel = new System.Windows.Forms.Label();
            this.DriversAmountLabel = new System.Windows.Forms.Label();
            this.DriversAmountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VehicleNameLabel
            // 
            this.VehicleNameLabel.AutoSize = true;
            this.VehicleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.VehicleNameLabel.Location = new System.Drawing.Point(12, 26);
            this.VehicleNameLabel.Name = "VehicleNameLabel";
            this.VehicleNameLabel.Size = new System.Drawing.Size(137, 24);
            this.VehicleNameLabel.TabIndex = 0;
            this.VehicleNameLabel.Text = "Vehicle name: ";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(155, 27);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(137, 23);
            this.NameTextBox.TabIndex = 1;
            // 
            // VehicleTypeLabel
            // 
            this.VehicleTypeLabel.AutoSize = true;
            this.VehicleTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.VehicleTypeLabel.Location = new System.Drawing.Point(12, 67);
            this.VehicleTypeLabel.Name = "VehicleTypeLabel";
            this.VehicleTypeLabel.Size = new System.Drawing.Size(124, 24);
            this.VehicleTypeLabel.TabIndex = 2;
            this.VehicleTypeLabel.Text = "Vehicle type: ";
            // 
            // VehicleTypeBox
            // 
            this.VehicleTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VehicleTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.VehicleTypeBox.FormattingEnabled = true;
            this.VehicleTypeBox.Items.AddRange(new object[] {
            "Cargo Train",
            "Pickup",
            "Cargo Truck"});
            this.VehicleTypeBox.Location = new System.Drawing.Point(142, 66);
            this.VehicleTypeBox.Name = "VehicleTypeBox";
            this.VehicleTypeBox.Size = new System.Drawing.Size(150, 24);
            this.VehicleTypeBox.TabIndex = 3;
            this.VehicleTypeBox.SelectedIndexChanged += new System.EventHandler(this.VehicleTypeBox_SelectedIndexChanged);
            // 
            // VehicleWeightLabel
            // 
            this.VehicleWeightLabel.AutoSize = true;
            this.VehicleWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.VehicleWeightLabel.Location = new System.Drawing.Point(12, 109);
            this.VehicleWeightLabel.Name = "VehicleWeightLabel";
            this.VehicleWeightLabel.Size = new System.Drawing.Size(144, 24);
            this.VehicleWeightLabel.TabIndex = 4;
            this.VehicleWeightLabel.Text = "Vehicle weight: ";
            // 
            // VehicleWeightTextBox
            // 
            this.VehicleWeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VehicleWeightTextBox.Location = new System.Drawing.Point(155, 112);
            this.VehicleWeightTextBox.Name = "VehicleWeightTextBox";
            this.VehicleWeightTextBox.Size = new System.Drawing.Size(111, 23);
            this.VehicleWeightTextBox.TabIndex = 5;
            // 
            // MaximumDistanceLabel
            // 
            this.MaximumDistanceLabel.AutoSize = true;
            this.MaximumDistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MaximumDistanceLabel.Location = new System.Drawing.Point(12, 150);
            this.MaximumDistanceLabel.Name = "MaximumDistanceLabel";
            this.MaximumDistanceLabel.Size = new System.Drawing.Size(178, 24);
            this.MaximumDistanceLabel.TabIndex = 6;
            this.MaximumDistanceLabel.Text = "Maximum distance: ";
            // 
            // MaxDistanceTextBox
            // 
            this.MaxDistanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxDistanceTextBox.Location = new System.Drawing.Point(198, 151);
            this.MaxDistanceTextBox.Name = "MaxDistanceTextBox";
            this.MaxDistanceTextBox.Size = new System.Drawing.Size(68, 23);
            this.MaxDistanceTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(263, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "km ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(263, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "kg";
            // 
            // MaximumPayloadLabel
            // 
            this.MaximumPayloadLabel.AutoSize = true;
            this.MaximumPayloadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MaximumPayloadLabel.Location = new System.Drawing.Point(12, 189);
            this.MaximumPayloadLabel.Name = "MaximumPayloadLabel";
            this.MaximumPayloadLabel.Size = new System.Drawing.Size(169, 24);
            this.MaximumPayloadLabel.TabIndex = 10;
            this.MaximumPayloadLabel.Text = "Maximum payload:";
            // 
            // MaxCargoTextBox
            // 
            this.MaxCargoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxCargoTextBox.Location = new System.Drawing.Point(187, 190);
            this.MaxCargoTextBox.Name = "MaxCargoTextBox";
            this.MaxCargoTextBox.Size = new System.Drawing.Size(78, 23);
            this.MaxCargoTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(263, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "kg";
            // 
            // CurrentPayloadLabel
            // 
            this.CurrentPayloadLabel.AutoSize = true;
            this.CurrentPayloadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CurrentPayloadLabel.Location = new System.Drawing.Point(12, 230);
            this.CurrentPayloadLabel.Name = "CurrentPayloadLabel";
            this.CurrentPayloadLabel.Size = new System.Drawing.Size(148, 24);
            this.CurrentPayloadLabel.TabIndex = 13;
            this.CurrentPayloadLabel.Text = "Current payload:";
            // 
            // CurrentPayloadTextBox
            // 
            this.CurrentPayloadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentPayloadTextBox.Location = new System.Drawing.Point(166, 231);
            this.CurrentPayloadTextBox.Name = "CurrentPayloadTextBox";
            this.CurrentPayloadTextBox.Size = new System.Drawing.Size(99, 23);
            this.CurrentPayloadTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(263, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "kg";
            // 
            // DriveTypeLabel
            // 
            this.DriveTypeLabel.AutoSize = true;
            this.DriveTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DriveTypeLabel.Location = new System.Drawing.Point(12, 273);
            this.DriveTypeLabel.Name = "DriveTypeLabel";
            this.DriveTypeLabel.Size = new System.Drawing.Size(103, 24);
            this.DriveTypeLabel.TabIndex = 16;
            this.DriveTypeLabel.Text = "Drive type: ";
            // 
            // DriveTypeBox
            // 
            this.DriveTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DriveTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DriveTypeBox.FormattingEnabled = true;
            this.DriveTypeBox.Items.AddRange(new object[] {
            "Rear-wheel",
            "Front-wheel",
            "All-wheel"});
            this.DriveTypeBox.Location = new System.Drawing.Point(115, 273);
            this.DriveTypeBox.Name = "DriveTypeBox";
            this.DriveTypeBox.Size = new System.Drawing.Size(177, 24);
            this.DriveTypeBox.TabIndex = 17;
            this.DriveTypeBox.SelectedIndexChanged += new System.EventHandler(this.DriveTypeBox_SelectedIndexChanged);
            // 
            // WheelsAmountLabel
            // 
            this.WheelsAmountLabel.AutoSize = true;
            this.WheelsAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.WheelsAmountLabel.Location = new System.Drawing.Point(12, 312);
            this.WheelsAmountLabel.Name = "WheelsAmountLabel";
            this.WheelsAmountLabel.Size = new System.Drawing.Size(147, 24);
            this.WheelsAmountLabel.TabIndex = 18;
            this.WheelsAmountLabel.Text = "Wheels amount:";
            // 
            // WheelsAmountTextBox
            // 
            this.WheelsAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WheelsAmountTextBox.Location = new System.Drawing.Point(167, 313);
            this.WheelsAmountTextBox.Name = "WheelsAmountTextBox";
            this.WheelsAmountTextBox.Size = new System.Drawing.Size(125, 23);
            this.WheelsAmountTextBox.TabIndex = 19;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Enabled = false;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.SubmitButton.Location = new System.Drawing.Point(453, 293);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(189, 48);
            this.SubmitButton.TabIndex = 20;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CarsAmountLabel
            // 
            this.CarsAmountLabel.AutoSize = true;
            this.CarsAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CarsAmountLabel.Location = new System.Drawing.Point(335, 27);
            this.CarsAmountLabel.Name = "CarsAmountLabel";
            this.CarsAmountLabel.Size = new System.Drawing.Size(112, 24);
            this.CarsAmountLabel.TabIndex = 21;
            this.CarsAmountLabel.Text = "Car amount:";
            this.CarsAmountLabel.Visible = false;
            // 
            // CarsAmountTextBox
            // 
            this.CarsAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarsAmountTextBox.Location = new System.Drawing.Point(453, 29);
            this.CarsAmountTextBox.Name = "CarsAmountTextBox";
            this.CarsAmountTextBox.Size = new System.Drawing.Size(137, 23);
            this.CarsAmountTextBox.TabIndex = 22;
            this.CarsAmountTextBox.Visible = false;
            // 
            // PassengerAmountLabel
            // 
            this.PassengerAmountLabel.AutoSize = true;
            this.PassengerAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PassengerAmountLabel.Location = new System.Drawing.Point(332, 67);
            this.PassengerAmountLabel.Name = "PassengerAmountLabel";
            this.PassengerAmountLabel.Size = new System.Drawing.Size(173, 24);
            this.PassengerAmountLabel.TabIndex = 23;
            this.PassengerAmountLabel.Text = "Passenger amount:";
            this.PassengerAmountLabel.Visible = false;
            // 
            // PassengersAmountTextBox
            // 
            this.PassengersAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassengersAmountTextBox.Location = new System.Drawing.Point(501, 68);
            this.PassengersAmountTextBox.Name = "PassengersAmountTextBox";
            this.PassengersAmountTextBox.Size = new System.Drawing.Size(137, 23);
            this.PassengersAmountTextBox.TabIndex = 24;
            this.PassengersAmountTextBox.Visible = false;
            // 
            // HasPassengerCheck
            // 
            this.HasPassengerCheck.AutoSize = true;
            this.HasPassengerCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.HasPassengerCheck.Location = new System.Drawing.Point(339, 111);
            this.HasPassengerCheck.Name = "HasPassengerCheck";
            this.HasPassengerCheck.Size = new System.Drawing.Size(166, 28);
            this.HasPassengerCheck.TabIndex = 26;
            this.HasPassengerCheck.Text = "Has passenger?";
            this.HasPassengerCheck.UseVisualStyleBackColor = true;
            this.HasPassengerCheck.Visible = false;
            // 
            // TankAmountLabel
            // 
            this.TankAmountLabel.AutoSize = true;
            this.TankAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TankAmountLabel.Location = new System.Drawing.Point(332, 68);
            this.TankAmountLabel.Name = "TankAmountLabel";
            this.TankAmountLabel.Size = new System.Drawing.Size(160, 24);
            this.TankAmountLabel.TabIndex = 27;
            this.TankAmountLabel.Text = "Fuel tank amount:";
            this.TankAmountLabel.Visible = false;
            // 
            // FuelTankAmountTextBox
            // 
            this.FuelTankAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FuelTankAmountTextBox.Location = new System.Drawing.Point(498, 71);
            this.FuelTankAmountTextBox.Name = "FuelTankAmountTextBox";
            this.FuelTankAmountTextBox.Size = new System.Drawing.Size(137, 23);
            this.FuelTankAmountTextBox.TabIndex = 28;
            this.FuelTankAmountTextBox.Visible = false;
            // 
            // TankSizeLabel
            // 
            this.TankSizeLabel.AutoSize = true;
            this.TankSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TankSizeLabel.Location = new System.Drawing.Point(335, 112);
            this.TankSizeLabel.Name = "TankSizeLabel";
            this.TankSizeLabel.Size = new System.Drawing.Size(130, 24);
            this.TankSizeLabel.TabIndex = 29;
            this.TankSizeLabel.Text = "Fuel tank size:";
            this.TankSizeLabel.Visible = false;
            // 
            // FuelTankSizeTextBox
            // 
            this.FuelTankSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FuelTankSizeTextBox.Location = new System.Drawing.Point(471, 110);
            this.FuelTankSizeTextBox.Name = "FuelTankSizeTextBox";
            this.FuelTankSizeTextBox.Size = new System.Drawing.Size(137, 23);
            this.FuelTankSizeTextBox.TabIndex = 30;
            this.FuelTankSizeTextBox.Visible = false;
            // 
            // HeavyCargoLiterLabel
            // 
            this.HeavyCargoLiterLabel.AutoSize = true;
            this.HeavyCargoLiterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.HeavyCargoLiterLabel.Location = new System.Drawing.Point(608, 110);
            this.HeavyCargoLiterLabel.Name = "HeavyCargoLiterLabel";
            this.HeavyCargoLiterLabel.Size = new System.Drawing.Size(48, 24);
            this.HeavyCargoLiterLabel.TabIndex = 31;
            this.HeavyCargoLiterLabel.Text = "litres";
            this.HeavyCargoLiterLabel.Visible = false;
            // 
            // DriversAmountLabel
            // 
            this.DriversAmountLabel.AutoSize = true;
            this.DriversAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DriversAmountLabel.Location = new System.Drawing.Point(335, 29);
            this.DriversAmountLabel.Name = "DriversAmountLabel";
            this.DriversAmountLabel.Size = new System.Drawing.Size(132, 24);
            this.DriversAmountLabel.TabIndex = 32;
            this.DriversAmountLabel.Text = "Driver amount:";
            this.DriversAmountLabel.Visible = false;
            // 
            // DriversAmountTextBox
            // 
            this.DriversAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DriversAmountTextBox.Location = new System.Drawing.Point(471, 28);
            this.DriversAmountTextBox.Name = "DriversAmountTextBox";
            this.DriversAmountTextBox.Size = new System.Drawing.Size(137, 23);
            this.DriversAmountTextBox.TabIndex = 33;
            this.DriversAmountTextBox.Visible = false;
            // 
            // NewVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 353);
            this.Controls.Add(this.DriversAmountTextBox);
            this.Controls.Add(this.DriversAmountLabel);
            this.Controls.Add(this.HeavyCargoLiterLabel);
            this.Controls.Add(this.FuelTankSizeTextBox);
            this.Controls.Add(this.TankSizeLabel);
            this.Controls.Add(this.FuelTankAmountTextBox);
            this.Controls.Add(this.TankAmountLabel);
            this.Controls.Add(this.HasPassengerCheck);
            this.Controls.Add(this.PassengersAmountTextBox);
            this.Controls.Add(this.PassengerAmountLabel);
            this.Controls.Add(this.CarsAmountTextBox);
            this.Controls.Add(this.CarsAmountLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.WheelsAmountTextBox);
            this.Controls.Add(this.WheelsAmountLabel);
            this.Controls.Add(this.DriveTypeBox);
            this.Controls.Add(this.DriveTypeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CurrentPayloadTextBox);
            this.Controls.Add(this.CurrentPayloadLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxCargoTextBox);
            this.Controls.Add(this.MaximumPayloadLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxDistanceTextBox);
            this.Controls.Add(this.MaximumDistanceLabel);
            this.Controls.Add(this.VehicleWeightTextBox);
            this.Controls.Add(this.VehicleWeightLabel);
            this.Controls.Add(this.VehicleTypeBox);
            this.Controls.Add(this.VehicleTypeLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.VehicleNameLabel);
            this.Name = "NewVehicleForm";
            this.Text = "New Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VehicleNameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label VehicleTypeLabel;
        private System.Windows.Forms.ComboBox VehicleTypeBox;
        private System.Windows.Forms.Label VehicleWeightLabel;
        private System.Windows.Forms.TextBox VehicleWeightTextBox;
        private System.Windows.Forms.Label MaximumDistanceLabel;
        private System.Windows.Forms.TextBox MaxDistanceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MaximumPayloadLabel;
        private System.Windows.Forms.TextBox MaxCargoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CurrentPayloadLabel;
        private System.Windows.Forms.TextBox CurrentPayloadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DriveTypeLabel;
        private System.Windows.Forms.ComboBox DriveTypeBox;
        private System.Windows.Forms.Label WheelsAmountLabel;
        private System.Windows.Forms.TextBox WheelsAmountTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label CarsAmountLabel;
        private System.Windows.Forms.TextBox CarsAmountTextBox;
        private System.Windows.Forms.Label PassengerAmountLabel;
        private System.Windows.Forms.TextBox PassengersAmountTextBox;
        private System.Windows.Forms.CheckBox HasPassengerCheck;
        private System.Windows.Forms.Label TankAmountLabel;
        private System.Windows.Forms.TextBox FuelTankAmountTextBox;
        private System.Windows.Forms.Label TankSizeLabel;
        private System.Windows.Forms.TextBox FuelTankSizeTextBox;
        private System.Windows.Forms.Label HeavyCargoLiterLabel;
        private System.Windows.Forms.Label DriversAmountLabel;
        private System.Windows.Forms.TextBox DriversAmountTextBox;
    }
}