using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG_Task_7._1
{
    public enum DriveTypes { Rear, Front, All }

    public abstract class CargoVehicle
    {
        protected string name;
        protected int vehicleWeight, maxDistance, maxCargo, currentCargoWeight;

        protected CargoVehicle()
        {
            name = "CargoVehicle";
            vehicleWeight = 10000;
            maxDistance = 10000;
            maxCargo = 100000;
            currentCargoWeight = 10000;
        }

        protected CargoVehicle(string name, int vehicleWeight, int maxDistance, int maxCargo, int currentCargoWeight)
        {
            this.name = name;
            this.vehicleWeight = vehicleWeight;
            this.maxDistance = maxDistance;
            this.maxCargo = maxCargo;
            this.currentCargoWeight = currentCargoWeight;
            if (currentCargoWeight > maxCargo)
                maxCargo = currentCargoWeight;
        }

        public int VehicleWeight
        { 
            get { return vehicleWeight; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                vehicleWeight = value;
            }    
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual int WeightWithCargo
        {
            get { return vehicleWeight + currentCargoWeight; }
        }

        public virtual int CargoWeight
        {
            get { return currentCargoWeight; }
            set
            {
                if (value < 0 || value > maxCargo)
                    throw new ArgumentOutOfRangeException();
                currentCargoWeight = value;
            }
        }

        public int MaximumDistance
        {
            get { return maxDistance; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                maxDistance = value;
            }
        }

        public int MaximumPayload
        {
            get { return maxCargo; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                maxCargo = value;
            }
        }

        public abstract double MaximumDistanceWithCargoLoad();
        public abstract string GetDescription();
        public abstract DriveTypes DriveType { get; set; }
        public abstract int WheelAmount { get; set; }
        public virtual int CarsAmount { get; set; }
        public virtual int PassengerAmount { get; set; }
        public virtual bool HasPassenger { get; set; }
        public virtual int FuelTankAmount { get; set; }
        public virtual int FuelTankSize { get; set; }
        public virtual int DriverAmount { get; set; }
    }

    public abstract class WheeledVehicle : CargoVehicle
    {
        protected DriveTypes driveType;
        protected int wheelsAmount;

        protected WheeledVehicle() : base()
        {
            driveType = DriveTypes.All;
            wheelsAmount = 4;
        }

        protected WheeledVehicle(string name, int vehicleWeight, int maxDistance, int maxCargo, int currentCargoWeight,
            DriveTypes driveType, int wheelsAmount) : base(name, vehicleWeight, maxDistance, maxCargo, currentCargoWeight)
        {
            this.driveType = driveType;
            this.wheelsAmount = wheelsAmount;
        }

        public override DriveTypes DriveType
        {
            get { return driveType; }
            set
            {
                driveType = value;
            }
        }

        public override int WheelAmount
        {
            get { return wheelsAmount; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                wheelsAmount = value;
            }
        }
    }

    public class CargoTrain : WheeledVehicle
    {
        private int carAmount;

        public CargoTrain() : base()
        {
            carAmount = 10;
        }

        public CargoTrain(string name, int vehicleWeight, int maxDistance, int maxCargo, int currentCargoWeight,
            DriveTypes driveType, int wheelsAmount, int carAmount)
            : base(name, vehicleWeight, maxDistance, maxCargo, currentCargoWeight, driveType, wheelsAmount)
        {
            this.carAmount = carAmount;
        }
        public override int CargoWeight
        {
            get
            {
                return currentCargoWeight / carAmount;
            }
            set
            {
                if (value < 0 || value * carAmount > maxCargo)
                    throw new ArgumentOutOfRangeException();
                currentCargoWeight = value * carAmount;
            }
        }

        public override int WeightWithCargo
        {
            get { return vehicleWeight + currentCargoWeight * carAmount; }
        }

        public override double MaximumDistanceWithCargoLoad()
        {
            return Math.Abs(maxDistance * (1 - 0.0001 * currentCargoWeight + 0.01 * wheelsAmount * 0.1 * carAmount));
        }

        public override string GetDescription()
        {
            return $"Cargo Train:\n" +
                              $"\tName: {name}\n" +
                              $"\tVehicle Weight: {vehicleWeight}kg\n" +
                              $"\tMaximum Distance: {maxDistance}km\n" +
                              $"\tMaximum Cargo Weight: {maxCargo}kg\n" +
                              $"\tCurrent Cargo Weight: {currentCargoWeight}kg\n" +
                              $"\tWeight With Cargo: {WeightWithCargo}kg\n" +
                              $"\tCargo per Car: {CargoWeight}kg\n" +
                              $"\tDrive Type: {driveType}\n" +
                              $"\tWheels Amount: {wheelsAmount}\n" +
                              $"\tCar Amount: {carAmount}\n" +
                              $"\tMaximum Distance With Cargo Load: {MaximumDistanceWithCargoLoad():f2}km";
        }

        public override int CarsAmount
        {
            get { return carAmount; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                carAmount = value;
            }
        }
    }

    public abstract class CargoAutomobile : WheeledVehicle
    {
        protected int driversAmount;

        protected CargoAutomobile() : base()
        {
            driversAmount = 2;
        }

        protected CargoAutomobile(string name, int vehicleWeight, int maxDistance, int maxCargo, int currentCargoWeight,
            DriveTypes driveType, int wheelsAmount, int driversAmount)
            : base(name, vehicleWeight, maxDistance, maxCargo, currentCargoWeight, driveType, wheelsAmount)
        {
            this.driversAmount = driversAmount;
        }
        public override int WeightWithCargo
        {
            get
            {
                return vehicleWeight + currentCargoWeight + driversAmount * 80;
            }
        }

        public override int DriverAmount
        {
            get { return driversAmount; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                driversAmount = value;
            }
        }

        public virtual void PrintDescription()
        {
            Console.WriteLine($"Cargo Automobile:\n" +
                              $"\tName: {name}\n" +
                              $"\tVehicle Weight: {vehicleWeight}kg\n" +
                              $"\tMaximum Distance: {maxDistance}km\n" +
                              $"\tMaximum Cargo Weight: {maxCargo}kg\n" +
                              $"\tCurrent Cargo Weight: {currentCargoWeight}kg\n" +
                              $"\tWeight With Cargo: {WeightWithCargo}kg\n" +
                              $"\tCargo per Car: {CargoWeight}kg\n" +
                              $"\tDrive Type: {driveType}\n" +
                              $"\tWheels Amount: {wheelsAmount}\n" +
                              $"\tDriver Amount: {driversAmount}\n" +
                              $"\tMaximum Distance With Cargo Load: {MaximumDistanceWithCargoLoad():f2}km");
        }
    }

    public class Pickup : CargoAutomobile
    {
        private bool _hasPassenger;
        private int _passengersAmount;

        public Pickup() : base()
        {
            _hasPassenger = true;
        }

        public Pickup(string name, int vehicleWeight, int maxDistance, int maxCargo, int currentCargoWeight,
            DriveTypes driveType, int wheelsAmount, int driversAmount, bool hasPassenger, int passengersAmount)
            : base(name, vehicleWeight, maxDistance, maxCargo, currentCargoWeight,
                driveType, wheelsAmount, driversAmount)
        {
            _hasPassenger = hasPassenger;
            _passengersAmount = passengersAmount;
        }

        public override int WeightWithCargo
        {
            get
            {
                return vehicleWeight + currentCargoWeight + (_passengersAmount + driversAmount) * 80;
            }
        }

        public override bool HasPassenger
        {
            get
            {
                return _hasPassenger;
            }
            set
            {
                _hasPassenger = value;
            }
        }

        public override int PassengerAmount
        {
            get
            {
                return _passengersAmount;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                _passengersAmount = value;
            }
        }
        public override string GetDescription()
        {
            return $"Pickup:\n" +
                              $"\tName: {name}\n" +
                              $"\tVehicle Weight: {vehicleWeight}kg\n" +
                              $"\tMaximum Distance: {maxDistance}km\n" +
                              $"\tMaximum Cargo Weight: {maxCargo}kg\n" +
                              $"\tCurrent Cargo Weight: {currentCargoWeight}kg\n" +
                              $"\tWeight With Cargo: {WeightWithCargo}kg\n" +
                              $"\tDrive Type: {driveType}\n" +
                              $"\tWheels Amount: {wheelsAmount}\n" +
                              $"\tDriver Amount: {driversAmount}\n" +
                              $"\tMaximum Distance With Cargo Load: {MaximumDistanceWithCargoLoad():f2}km\n" +
                              $"\tHas Passenger?: {_hasPassenger}";
        }

        public override double MaximumDistanceWithCargoLoad()
        {
            double finalDistance = maxDistance * (1 - 0.0001 * currentCargoWeight + 0.01 * wheelsAmount);
            if (_hasPassenger)
                finalDistance -= 0.005 * _passengersAmount;

            return Math.Abs(finalDistance);
        }
    }

    public class HeavyCargoAutomobile : CargoAutomobile
    {
        private int _tankAmount;
        private int _tankSize;

        public HeavyCargoAutomobile() : base()
        {
            _tankAmount = 2;
        }

        public HeavyCargoAutomobile(string name, int vehicleWeight, int maxDistance, int maxCargo, int currentCargoWeight,
            DriveTypes driveType, int wheelsAmount, int driversAmount, int tankAmount, int tankSize)
            : base(name, vehicleWeight, maxDistance, maxCargo, currentCargoWeight,
                driveType, wheelsAmount, driversAmount)
        {
            _tankAmount = tankAmount;
            _tankSize = tankSize;
        }

        public override int WeightWithCargo
        {
            get
            {
                return vehicleWeight + currentCargoWeight + driversAmount * 80 + _tankAmount * _tankSize;
            }
        }

        public override int FuelTankAmount 
        {
            get
            {
                return _tankAmount;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                _tankAmount = value;
            }
        }

        public override int FuelTankSize
        {
            get
            {
                return _tankSize;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                _tankSize = value;
            }
        }

        public override double MaximumDistanceWithCargoLoad()
        {
            return Math.Abs(maxDistance * (1 - 0.0001 * currentCargoWeight + 0.01 * wheelsAmount + _tankAmount * _tankSize * 0.0001));
        }

        public override string GetDescription()
        {
            return $"Heavy truck:\n" +
                              $"\tName: {name}\n" +
                              $"\tVehicle Weight: {vehicleWeight}kg\n" +
                              $"\tMaximum Distance: {maxDistance}km\n" +
                              $"\tMaximum Cargo Weight: {maxCargo}kg\n" +
                              $"\tCurrent Cargo Weight: {currentCargoWeight}kg\n" +
                              $"\tWeight With Cargo: {WeightWithCargo}kg\n" +
                              $"\tDrive Type: {driveType}\n" +
                              $"\tWheels Amount: {wheelsAmount}\n" +
                              $"\tDriver Amount: {driversAmount}\n" +
                              $"\tMaximum Distance With Cargo Load: {MaximumDistanceWithCargoLoad():f2}km\n" +
                              $"\tTank Amount: {_tankAmount}\n" +
                              $"\tTank Size: {_tankSize}\n";
        }

    }
}
