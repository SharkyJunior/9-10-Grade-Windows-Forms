using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BG_Task_7._1
{
    public enum ObjectType
    {
        CargoTrain,
        Pickup,
        CargoTruck
    }
    public partial class NewVehicleForm : Form
    {
        public CargoVehicle currentVehicle;
        public ObjectType objectType;
        public NewVehicleForm()
        {
            InitializeComponent();
        }

        private void VehicleTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarsAmountLabel.Visible = false; CarsAmountTextBox.Visible = false; PassengerAmountLabel.Visible = false; PassengersAmountTextBox.Visible = false; HasPassengerCheck.Visible = false; FuelTankAmountTextBox.Visible = false;
            FuelTankSizeTextBox.Visible = false; TankAmountLabel.Visible = false; TankSizeLabel.Visible = false; DriversAmountLabel.Visible = false; DriversAmountTextBox.Visible = false;
            if (VehicleTypeBox.SelectedIndex == 0)
            {
                CarsAmountLabel.Visible = true; CarsAmountTextBox.Visible = true;
            }
            if (VehicleTypeBox.SelectedIndex == 1)
            {
                PassengerAmountLabel.Visible = true; PassengersAmountTextBox.Visible = true; HasPassengerCheck.Visible = true; DriversAmountLabel.Visible = true; DriversAmountTextBox.Visible = true;
            }
            if (VehicleTypeBox.SelectedIndex == 2)
            {
                FuelTankAmountTextBox.Visible = true; FuelTankSizeTextBox.Visible = true; TankAmountLabel.Visible = true; TankSizeLabel.Visible = true; DriversAmountLabel.Visible = true; DriversAmountTextBox.Visible = true;
            }
            if (!(VehicleTypeBox.SelectedItem == null) && !(DriveTypeBox.SelectedItem == null))
                SubmitButton.Enabled = true;
            else
                SubmitButton.Enabled = false;

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int vehicleWeight, maxDistance, maxCargo, currentCargo, wheelsAmount;
            DriveTypes driveType;
            if (DriveTypeBox.SelectedIndex == 0)
                driveType = DriveTypes.Rear;
            else if (DriveTypeBox.SelectedIndex == 1)
                driveType = DriveTypes.Front;
            else
                driveType = DriveTypes.All;

            if (VehicleTypeBox.SelectedIndex == 0)
            {
                int carsAmount;
                if (NameTextBox.Text == "" || VehicleWeightTextBox.Text == "" || MaxDistanceTextBox.Text == "" || MaxCargoTextBox.Text == "" || CurrentPayloadTextBox.Text == "" || DriveTypeBox.SelectedItem == null || WheelsAmountTextBox.Text == "" || CarsAmountTextBox.Text == "")
                {
                    MessageBox.Show("Please make sure that all fields are not empty.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool exp1 = int.TryParse(VehicleWeightTextBox.Text, out vehicleWeight);
                    bool exp2 = int.TryParse(MaxDistanceTextBox.Text, out maxDistance);
                    bool exp3 = int.TryParse(MaxCargoTextBox.Text, out maxCargo);
                    bool exp4 = int.TryParse(CurrentPayloadTextBox.Text, out currentCargo);
                    bool exp5 = int.TryParse(WheelsAmountTextBox.Text, out wheelsAmount);
                    bool exp6 = int.TryParse(CarsAmountTextBox.Text, out carsAmount);
                    if (!exp1 || !exp2 || !exp3 || !exp4 || !exp5 || !exp6)
                    {
                        MessageBox.Show("Could not recognize number in one or more fields.", "Value error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (currentCargo > maxCargo)
                        MessageBox.Show("Current payload cannot be greater than maximum payload.", "Value error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        currentVehicle = new CargoTrain(NameTextBox.Text, vehicleWeight, maxDistance, maxCargo, currentCargo, driveType, wheelsAmount, carsAmount);
                        objectType = ObjectType.CargoTrain;
                        this.Close();
                    }

                }
            }
            else if (VehicleTypeBox.SelectedIndex == 1)
            {
                int passengerAmount, driversAmount;
                if (NameTextBox.Text == "" || VehicleWeightTextBox.Text == "" || MaxDistanceTextBox.Text == "" || MaxCargoTextBox.Text == "" || CurrentPayloadTextBox.Text == "" || DriveTypeBox.SelectedItem == null || WheelsAmountTextBox.Text == "" || DriversAmountTextBox.Text == "" || PassengersAmountTextBox.Text == "")
                {
                    MessageBox.Show("Please make sure that all fields are not empty.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool exp1 = int.TryParse(VehicleWeightTextBox.Text, out vehicleWeight);
                    bool exp2 = int.TryParse(MaxDistanceTextBox.Text, out maxDistance);
                    bool exp3 = int.TryParse(MaxCargoTextBox.Text, out maxCargo);
                    bool exp4 = int.TryParse(CurrentPayloadTextBox.Text, out currentCargo);
                    bool exp5 = int.TryParse(WheelsAmountTextBox.Text, out wheelsAmount);
                    bool exp6 = int.TryParse(PassengersAmountTextBox.Text, out passengerAmount);
                    bool exp7 = int.TryParse(DriversAmountTextBox.Text, out driversAmount);
                    if (!exp1 || !exp2 || !exp3 || !exp4 || !exp5 || !exp6 || !exp7)
                    {
                        MessageBox.Show("Could not recognize number in one or more fields.", "Value error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (currentCargo > maxCargo)
                        MessageBox.Show("Current payload cannot be greater than maximum payload.", "Value error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        currentVehicle = new Pickup(NameTextBox.Text, vehicleWeight, maxDistance, maxCargo, currentCargo, driveType, wheelsAmount, driversAmount, HasPassengerCheck.Checked, passengerAmount);
                        objectType = ObjectType.Pickup;
                        this.Close();
                    }
                }
            }
            else if (VehicleTypeBox.SelectedIndex == 2)
            {
                int driverAmount, tankAmount, tankSize;
                if (NameTextBox.Text == "" || VehicleWeightTextBox.Text == "" || MaxDistanceTextBox.Text == "" || MaxCargoTextBox.Text == "" || CurrentPayloadTextBox.Text == "" || DriveTypeBox.SelectedItem == null || WheelsAmountTextBox.Text == "" || DriversAmountTextBox.Text == "" || FuelTankAmountTextBox.Text == "" || FuelTankSizeTextBox.Text == "")
                {
                    MessageBox.Show("Please make sure that all fields are not empty.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool exp1 = int.TryParse(VehicleWeightTextBox.Text, out vehicleWeight);
                    bool exp2 = int.TryParse(MaxDistanceTextBox.Text, out maxDistance);
                    bool exp3 = int.TryParse(MaxCargoTextBox.Text, out maxCargo);
                    bool exp4 = int.TryParse(CurrentPayloadTextBox.Text, out currentCargo);
                    bool exp5 = int.TryParse(WheelsAmountTextBox.Text, out wheelsAmount);
                    bool exp6 = int.TryParse(FuelTankAmountTextBox.Text, out tankAmount);
                    bool exp7 = int.TryParse(DriversAmountTextBox.Text, out driverAmount);
                    bool exp8 = int.TryParse(FuelTankSizeTextBox.Text, out tankSize);
                    if (!exp1 || !exp2 || !exp3 || !exp4 || !exp5 || !exp6 || !exp7 || !exp8)
                    {
                        MessageBox.Show("Could not recognize number in one or more fields.", "Value error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (currentCargo > maxCargo)
                        MessageBox.Show("Current payload cannot be greater than maximum payload.", "Value error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    { 
                        currentVehicle = new HeavyCargoAutomobile(NameTextBox.Text, vehicleWeight, maxDistance, maxCargo, currentCargo, driveType, wheelsAmount, driverAmount, tankAmount, tankSize);
                        objectType = ObjectType.CargoTruck;
                        this.Close();
                    }
                }
            }
        }

        private void DriveTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(VehicleTypeBox.SelectedItem == null) && !(DriveTypeBox.SelectedItem == null))
                SubmitButton.Enabled = true;
            else
                SubmitButton.Enabled = false;
        }
    }
}
