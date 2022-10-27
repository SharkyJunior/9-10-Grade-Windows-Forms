namespace SolarSystem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cosmicBodiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cosmicBodiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1303, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cosmicBodiesToolStripMenuItem
            // 
            this.cosmicBodiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sunToolStripMenuItem,
            this.saturnToolStripMenuItem,
            this.marsToolStripMenuItem});
            this.cosmicBodiesToolStripMenuItem.Name = "cosmicBodiesToolStripMenuItem";
            this.cosmicBodiesToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.cosmicBodiesToolStripMenuItem.Text = "Celestial Bodies On The Sky";
            // 
            // sunToolStripMenuItem
            // 
            this.sunToolStripMenuItem.Name = "sunToolStripMenuItem";
            this.sunToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sunToolStripMenuItem.Text = "Sun";
            this.sunToolStripMenuItem.Click += new System.EventHandler(this.sunToolStripMenuItem_Click);
            // 
            // saturnToolStripMenuItem
            // 
            this.saturnToolStripMenuItem.Name = "saturnToolStripMenuItem";
            this.saturnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saturnToolStripMenuItem.Text = "Saturn";
            this.saturnToolStripMenuItem.Click += new System.EventHandler(this.saturnToolStripMenuItem_Click);
            // 
            // marsToolStripMenuItem
            // 
            this.marsToolStripMenuItem.Name = "marsToolStripMenuItem";
            this.marsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marsToolStripMenuItem.Text = "Mars";
            this.marsToolStripMenuItem.Click += new System.EventHandler(this.marsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 548);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cosmicBodiesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marsToolStripMenuItem;
    }
}

