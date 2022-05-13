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
    public partial class EditVehicleForm : Form
    {
        private ObjectType _objectType;
        private CargoVehicle _vehicle;
        public CargoVehicle EditedVehicle
        {
            get { return _vehicle; }
        }
        public EditVehicleForm(ObjectType objectType, CargoVehicle vehicle)
        {
            InitializeComponent();
            _objectType = objectType;
            _vehicle = vehicle;
        }

        private void EditVehicleForm_Load(object sender, EventArgs e)
        {
            CarsAmountLabel.Visible = false; CarsAmountTextBox.Visible = false; PassengerAmountLabel.Visible = false; PassengersAmountTextBox.Visible = false; HasPassengerCheck.Visible = false; FuelTankAmountTextBox.Visible = false;
            FuelTankSizeTextBox.Visible = false; TankAmountLabel.Visible = false; TankSizeLabel.Visible = false; DriversAmountLabel.Visible = false; DriversAmountTextBox.Visible = false;

            if (_objectType == ObjectType.CargoTrain)
            {
                CarsAmountLabel.Visible = true; CarsAmountTextBox.Visible = true;
                CarsAmountTextBox.Text = Convert.ToString(_vehicle.CarsAmount);
            }
            if (_objectType == ObjectType.Pickup)
            {
                PassengerAmountLabel.Visible = true; PassengersAmountTextBox.Visible = true; HasPassengerCheck.Visible = true; DriversAmountLabel.Visible = true; DriversAmountTextBox.Visible = true;
                DriversAmountTextBox.Text = Convert.ToString(_vehicle.DriverAmount);
                PassengersAmountTextBox.Text = Convert.ToString(_vehicle.PassengerAmount);
                HasPassengerCheck.Checked = _vehicle.HasPassenger;
            }
            if (_objectType == ObjectType.CargoTruck)
            {
                FuelTankAmountTextBox.Visible = true; FuelTankSizeTextBox.Visible = true; TankAmountLabel.Visible = true; TankSizeLabel.Visible = true; DriversAmountLabel.Visible = true; DriversAmountTextBox.Visible = true; HeavyCargoLiterLabel.Visible = true;
                DriversAmountTextBox.Text = Convert.ToString(_vehicle.DriverAmount);
                FuelTankAmountTextBox.Text = Convert.ToString(_vehicle.FuelTankAmount);
                FuelTankSizeTextBox.Text = Convert.ToString(_vehicle.FuelTankSize);
            }

            NameTextBox.Text = _vehicle.Name;
            VehicleWeightTextBox.Text = Convert.ToString(_vehicle.VehicleWeight);
            CurrentPayloadTextBox.Text = Convert.ToString(_vehicle.CargoWeight);
            MaximumDistanceTextBox.Text = Convert.ToString(_vehicle.MaximumDistance);
            MaxCargoTextBox.Text = Convert.ToString(_vehicle.MaximumPayload);
            DriveTypeBox.SelectedIndex = (int)_vehicle.DriveType;
            WheelsAmountTextBox.Text = Convert.ToString(_vehicle.WheelAmount);

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

            if (_objectType == ObjectType.CargoTrain)
            {
                int carsAmount;
                if (NameTextBox.Text == "" || VehicleWeightTextBox.Text == "" || MaximumDistanceTextBox.Text == "" || MaxCargoTextBox.Text == "" || CurrentPayloadTextBox.Text == "" || DriveTypeBox.SelectedItem == null || WheelsAmountTextBox.Text == "" || CarsAmountTextBox.Text == "")
                {
                    MessageBox.Show("Please make sure that all fields are not empty.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool exp1 = int.TryParse(VehicleWeightTextBox.Text, out vehicleWeight);
                    bool exp2 = int.TryParse(MaximumDistanceTextBox.Text, out maxDistance);
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
                        _vehicle.Name = NameTextBox.Text;
                        _vehicle.VehicleWeight = vehicleWeight;
                        _vehicle.MaximumDistance = maxDistance;
                        _vehicle.MaximumPayload = maxCargo;
                        _vehicle.CargoWeight = currentCargo;
                        _vehicle.WheelAmount = wheelsAmount;
                        _vehicle.CarsAmount = carsAmount;
                        _vehicle.DriveType = driveType;
                        this.Close();
                    }

                }

            }
            else if (_objectType == ObjectType.Pickup)
            {
                int passengerAmount, driversAmount;
                if (NameTextBox.Text == "" || VehicleWeightTextBox.Text == "" || MaximumDistanceTextBox.Text == "" || MaxCargoTextBox.Text == "" || CurrentPayloadTextBox.Text == "" || DriveTypeBox.SelectedItem == null || WheelsAmountTextBox.Text == "" || DriversAmountTextBox.Text == "" || PassengersAmountTextBox.Text == "")
                {
                    MessageBox.Show("Please make sure that all fields are not empty.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool exp1 = int.TryParse(VehicleWeightTextBox.Text, out vehicleWeight);
                    bool exp2 = int.TryParse(MaximumDistanceTextBox.Text, out maxDistance);
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
                        _vehicle.Name = NameTextBox.Text;
                        _vehicle.VehicleWeight = vehicleWeight;
                        _vehicle.MaximumDistance = maxDistance;
                        _vehicle.MaximumPayload = maxCargo;
                        _vehicle.CargoWeight = currentCargo;
                        _vehicle.WheelAmount = wheelsAmount;
                        _vehicle.DriverAmount = driversAmount;
                        _vehicle.PassengerAmount = passengerAmount;
                        _vehicle.HasPassenger = HasPassengerCheck.Checked;
                        _vehicle.DriveType = driveType;
                        this.Close();
                    }
                }
            }
            else if (_objectType == ObjectType.CargoTruck)
            {
                int driverAmount, tankAmount, tankSize;
                if (NameTextBox.Text == "" || VehicleWeightTextBox.Text == "" || MaximumDistanceTextBox.Text == "" || MaxCargoTextBox.Text == "" || CurrentPayloadTextBox.Text == "" || DriveTypeBox.SelectedItem == null || WheelsAmountTextBox.Text == "" || DriversAmountTextBox.Text == "" || FuelTankAmountTextBox.Text == "" || FuelTankSizeTextBox.Text == "")
                {
                    MessageBox.Show("Please make sure that all fields are not empty.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool exp1 = int.TryParse(VehicleWeightTextBox.Text, out vehicleWeight);
                    bool exp2 = int.TryParse(MaximumDistanceTextBox.Text, out maxDistance);
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
                        _vehicle.Name = NameTextBox.Text;
                        _vehicle.VehicleWeight = vehicleWeight;
                        _vehicle.MaximumDistance = maxDistance;
                        _vehicle.MaximumPayload = maxCargo;
                        _vehicle.CargoWeight = currentCargo;
                        _vehicle.WheelAmount = wheelsAmount;
                        _vehicle.DriverAmount = driverAmount;
                        _vehicle.FuelTankAmount = tankAmount;
                        _vehicle.FuelTankSize = tankSize;
                        _vehicle.DriveType = driveType;
                        this.Close();
                    }
                }
            }
        }
    }
}
