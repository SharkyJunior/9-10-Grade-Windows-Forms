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
    public partial class Main : Form
    {
        public CargoVehicle vehicle;
        public NewVehicleForm newVehicleForm;
        public Main()
        {
            InitializeComponent();
        }

        private void newVehicleButton_Click(object sender, EventArgs e)
        {
            newVehicleForm = new NewVehicleForm();

            newVehicleForm.ShowDialog();

            if (newVehicleForm.currentVehicle != null)
            {
                vehicle = newVehicleForm.currentVehicle;
                EditVehicleButton.Visible = true;
            }
            InfoLabel.Text = vehicle.GetDescription();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void EditVehicleButton_Click(object sender, EventArgs e)
        {
            EditVehicleForm editVehicleForm = new EditVehicleForm(newVehicleForm.objectType, vehicle);

            editVehicleForm.ShowDialog();

            vehicle = editVehicleForm.EditedVehicle;
            InfoLabel.Text = vehicle.GetDescription();
        }
    }
}
