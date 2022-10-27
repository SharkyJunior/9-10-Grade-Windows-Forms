
namespace BG_Task_7._1
{
    partial class Main
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
            this.newVehicleButton = new System.Windows.Forms.Button();
            this.EditVehicleButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newVehicleButton
            // 
            this.newVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newVehicleButton.Location = new System.Drawing.Point(12, 12);
            this.newVehicleButton.Name = "newVehicleButton";
            this.newVehicleButton.Size = new System.Drawing.Size(136, 60);
            this.newVehicleButton.TabIndex = 0;
            this.newVehicleButton.Text = "Create new vehicle";
            this.newVehicleButton.UseVisualStyleBackColor = true;
            this.newVehicleButton.Click += new System.EventHandler(this.newVehicleButton_Click);
            // 
            // EditVehicleButton
            // 
            this.EditVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EditVehicleButton.Location = new System.Drawing.Point(154, 12);
            this.EditVehicleButton.Name = "EditVehicleButton";
            this.EditVehicleButton.Size = new System.Drawing.Size(136, 60);
            this.EditVehicleButton.TabIndex = 1;
            this.EditVehicleButton.Text = "Edit vehicle";
            this.EditVehicleButton.UseVisualStyleBackColor = true;
            this.EditVehicleButton.Visible = false;
            this.EditVehicleButton.Click += new System.EventHandler(this.EditVehicleButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InfoLabel.Location = new System.Drawing.Point(12, 93);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 20);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.EditVehicleButton);
            this.Controls.Add(this.newVehicleButton);
            this.Name = "Main";
            this.Text = "Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newVehicleButton;
        private System.Windows.Forms.Button EditVehicleButton;
        private System.Windows.Forms.Label InfoLabel;
    }
}

