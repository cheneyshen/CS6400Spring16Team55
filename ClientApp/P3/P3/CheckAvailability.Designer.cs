namespace P3
{
    partial class CheckAvailability
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
            this.label1 = new System.Windows.Forms.Label();
            this.optHandTools = new System.Windows.Forms.RadioButton();
            this.optConstruction = new System.Windows.Forms.RadioButton();
            this.optPowerTools = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtToolID = new System.Windows.Forms.TextBox();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listView2 = new System.Windows.Forms.ListView();
            this.toolID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deposit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dailyPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Tool Category";
            // 
            // optHandTools
            // 
            this.optHandTools.AutoSize = true;
            this.optHandTools.Checked = true;
            this.optHandTools.Location = new System.Drawing.Point(68, 75);
            this.optHandTools.Name = "optHandTools";
            this.optHandTools.Size = new System.Drawing.Size(80, 17);
            this.optHandTools.TabIndex = 1;
            this.optHandTools.TabStop = true;
            this.optHandTools.Text = "Hand Tools";
            this.optHandTools.UseVisualStyleBackColor = true;
            // 
            // optConstruction
            // 
            this.optConstruction.AutoSize = true;
            this.optConstruction.Location = new System.Drawing.Point(68, 98);
            this.optConstruction.Name = "optConstruction";
            this.optConstruction.Size = new System.Drawing.Size(137, 17);
            this.optConstruction.TabIndex = 2;
            this.optConstruction.TabStop = true;
            this.optConstruction.Text = "Construction Equipment";
            this.optConstruction.UseVisualStyleBackColor = true;
            // 
            // optPowerTools
            // 
            this.optPowerTools.AutoSize = true;
            this.optPowerTools.Location = new System.Drawing.Point(68, 121);
            this.optPowerTools.Name = "optPowerTools";
            this.optPowerTools.Size = new System.Drawing.Size(84, 17);
            this.optPowerTools.TabIndex = 3;
            this.optPowerTools.TabStop = true;
            this.optPowerTools.Text = "Power Tools";
            this.optPowerTools.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "End Date";
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.Location = new System.Drawing.Point(177, 147);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAvailability.TabIndex = 8;
            this.btnCheckAvailability.Text = "Submit";
            this.btnCheckAvailability.UseVisualStyleBackColor = true;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Tools Available";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Tool ID";
            // 
            // txtToolID
            // 
            this.txtToolID.Location = new System.Drawing.Point(132, 422);
            this.txtToolID.Name = "txtToolID";
            this.txtToolID.Size = new System.Drawing.Size(157, 20);
            this.txtToolID.TabIndex = 73;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(296, 422);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(75, 23);
            this.btnViewDetails.TabIndex = 74;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(17, 530);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(113, 23);
            this.btnMainMenu.TabIndex = 81;
            this.btnMainMenu.Text = "Back to Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(296, 75);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(110, 20);
            this.dateTimePickerStart.TabIndex = 83;
            this.dateTimePickerStart.Value = new System.DateTime(2016, 4, 6, 0, 0, 0, 0);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(296, 104);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(110, 20);
            this.dateTimePickerEnd.TabIndex = 84;
            this.dateTimePickerEnd.Value = new System.DateTime(2016, 4, 6, 0, 0, 0, 0);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.toolID,
            this.toolDesc,
            this.deposit,
            this.dailyPrice});
            this.listView2.Location = new System.Drawing.Point(17, 451);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(497, 49);
            this.listView2.TabIndex = 85;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // toolID
            // 
            this.toolID.Text = "Tool ID";
            // 
            // toolDesc
            // 
            this.toolDesc.Text = "Tool Description";
            this.toolDesc.Width = 219;
            // 
            // deposit
            // 
            this.deposit.Text = "Deposit";
            this.deposit.Width = 80;
            // 
            // dailyPrice
            // 
            this.dailyPrice.Text = "Price per Day";
            this.dailyPrice.Width = 82;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(17, 196);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(497, 207);
            this.listView1.TabIndex = 86;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tool ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tool Description";
            this.columnHeader2.Width = 219;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Deposit";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price per Day";
            this.columnHeader4.Width = 82;
            // 
            // CheckAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 610);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.txtToolID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheckAvailability);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.optPowerTools);
            this.Controls.Add(this.optConstruction);
            this.Controls.Add(this.optHandTools);
            this.Controls.Add(this.label1);
            this.Name = "CheckAvailability";
            this.Text = "Check Availability";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckAvailability_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optHandTools;
        private System.Windows.Forms.RadioButton optConstruction;
        private System.Windows.Forms.RadioButton optPowerTools;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckAvailability;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtToolID;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader toolID;
        private System.Windows.Forms.ColumnHeader toolDesc;
        private System.Windows.Forms.ColumnHeader deposit;
        private System.Windows.Forms.ColumnHeader dailyPrice;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}