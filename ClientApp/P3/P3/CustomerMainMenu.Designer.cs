namespace P3
{
    partial class CustomerMainMenu
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
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Location = new System.Drawing.Point(60, 34);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(132, 23);
            this.btnViewProfile.TabIndex = 0;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.Location = new System.Drawing.Point(60, 63);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(132, 23);
            this.btnCheckAvailability.TabIndex = 1;
            this.btnCheckAvailability.Text = "Check Tool Availability";
            this.btnCheckAvailability.UseVisualStyleBackColor = true;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.Location = new System.Drawing.Point(60, 92);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(132, 23);
            this.btnMakeReservation.TabIndex = 2;
            this.btnMakeReservation.Text = "Make Reservation";
            this.btnMakeReservation.UseVisualStyleBackColor = true;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(60, 121);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Sign Out";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CustomerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 169);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMakeReservation);
            this.Controls.Add(this.btnCheckAvailability);
            this.Controls.Add(this.btnViewProfile);
            this.Name = "CustomerMainMenu";
            this.Text = "Customer Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerMainMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnCheckAvailability;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Button btnExit;
    }
}