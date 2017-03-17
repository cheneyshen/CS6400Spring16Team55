namespace P3
{
    partial class ClerkMainMenu
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
            this.btnPickUpReservation = new System.Windows.Forms.Button();
            this.btnDropOffReservation = new System.Windows.Forms.Button();
            this.btnServiceOrder = new System.Windows.Forms.Button();
            this.btnAddNewTool = new System.Windows.Forms.Button();
            this.btnSellTool = new System.Windows.Forms.Button();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPickUpReservation
            // 
            this.btnPickUpReservation.Location = new System.Drawing.Point(13, 13);
            this.btnPickUpReservation.Name = "btnPickUpReservation";
            this.btnPickUpReservation.Size = new System.Drawing.Size(203, 23);
            this.btnPickUpReservation.TabIndex = 0;
            this.btnPickUpReservation.Text = "Pick-Up Reservation";
            this.btnPickUpReservation.UseVisualStyleBackColor = true;
            this.btnPickUpReservation.Click += new System.EventHandler(this.btnPickUpReservation_Click);
            // 
            // btnDropOffReservation
            // 
            this.btnDropOffReservation.Location = new System.Drawing.Point(13, 42);
            this.btnDropOffReservation.Name = "btnDropOffReservation";
            this.btnDropOffReservation.Size = new System.Drawing.Size(203, 23);
            this.btnDropOffReservation.TabIndex = 1;
            this.btnDropOffReservation.Text = "Drop-Off Reservation";
            this.btnDropOffReservation.UseVisualStyleBackColor = true;
            this.btnDropOffReservation.Click += new System.EventHandler(this.btnDropOffReservation_Click);
            // 
            // btnServiceOrder
            // 
            this.btnServiceOrder.Location = new System.Drawing.Point(13, 71);
            this.btnServiceOrder.Name = "btnServiceOrder";
            this.btnServiceOrder.Size = new System.Drawing.Size(203, 23);
            this.btnServiceOrder.TabIndex = 2;
            this.btnServiceOrder.Text = "Service Order";
            this.btnServiceOrder.UseVisualStyleBackColor = true;
            this.btnServiceOrder.Click += new System.EventHandler(this.btnServiceOrder_Click);
            // 
            // btnAddNewTool
            // 
            this.btnAddNewTool.Location = new System.Drawing.Point(13, 100);
            this.btnAddNewTool.Name = "btnAddNewTool";
            this.btnAddNewTool.Size = new System.Drawing.Size(203, 23);
            this.btnAddNewTool.TabIndex = 3;
            this.btnAddNewTool.Text = "Add New Tool";
            this.btnAddNewTool.UseVisualStyleBackColor = true;
            this.btnAddNewTool.Click += new System.EventHandler(this.btnAddNewTool_Click);
            // 
            // btnSellTool
            // 
            this.btnSellTool.Location = new System.Drawing.Point(13, 129);
            this.btnSellTool.Name = "btnSellTool";
            this.btnSellTool.Size = new System.Drawing.Size(203, 23);
            this.btnSellTool.TabIndex = 4;
            this.btnSellTool.Text = "Sell Tool";
            this.btnSellTool.UseVisualStyleBackColor = true;
            this.btnSellTool.Click += new System.EventHandler(this.btnSellTool_Click);
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.Location = new System.Drawing.Point(13, 158);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(203, 23);
            this.btnGenerateReports.TabIndex = 5;
            this.btnGenerateReports.Text = "Generate Reports";
            this.btnGenerateReports.UseVisualStyleBackColor = true;
            this.btnGenerateReports.Click += new System.EventHandler(this.btnGenerateReports_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 187);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(203, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Sign Out";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ClerkMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 229);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerateReports);
            this.Controls.Add(this.btnSellTool);
            this.Controls.Add(this.btnAddNewTool);
            this.Controls.Add(this.btnServiceOrder);
            this.Controls.Add(this.btnDropOffReservation);
            this.Controls.Add(this.btnPickUpReservation);
            this.Name = "ClerkMainMenu";
            this.Text = "Clerk Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClerkMainMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPickUpReservation;
        private System.Windows.Forms.Button btnDropOffReservation;
        private System.Windows.Forms.Button btnServiceOrder;
        private System.Windows.Forms.Button btnAddNewTool;
        private System.Windows.Forms.Button btnSellTool;
        private System.Windows.Forms.Button btnGenerateReports;
        private System.Windows.Forms.Button btnExit;
    }
}