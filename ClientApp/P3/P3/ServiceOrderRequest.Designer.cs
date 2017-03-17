namespace P3
{
    partial class ServiceOrderRequest
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
            this.lbl_ToolID = new System.Windows.Forms.Label();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.lbl_EstRepairCost = new System.Windows.Forms.Label();
            this.btn_serviceOrder = new System.Windows.Forms.Button();
            this.txt_toolID = new System.Windows.Forms.TextBox();
            this.txt_startDate = new System.Windows.Forms.TextBox();
            this.txt_endDate = new System.Windows.Forms.TextBox();
            this.txt_estimate = new System.Windows.Forms.TextBox();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ToolID
            // 
            this.lbl_ToolID.AutoSize = true;
            this.lbl_ToolID.Location = new System.Drawing.Point(97, 60);
            this.lbl_ToolID.Name = "lbl_ToolID";
            this.lbl_ToolID.Size = new System.Drawing.Size(45, 13);
            this.lbl_ToolID.TabIndex = 0;
            this.lbl_ToolID.Text = "Tool ID:";
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Location = new System.Drawing.Point(4, 100);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(138, 13);
            this.lbl_StartDate.TabIndex = 1;
            this.lbl_StartDate.Text = "Starting Date (yyyy-mm-dd) :";
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Location = new System.Drawing.Point(8, 142);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(135, 13);
            this.lbl_EndDate.TabIndex = 2;
            this.lbl_EndDate.Text = "Ending Date (yyyy-mm-dd) :";
            // 
            // lbl_EstRepairCost
            // 
            this.lbl_EstRepairCost.AutoSize = true;
            this.lbl_EstRepairCost.Location = new System.Drawing.Point(13, 183);
            this.lbl_EstRepairCost.Name = "lbl_EstRepairCost";
            this.lbl_EstRepairCost.Size = new System.Drawing.Size(126, 13);
            this.lbl_EstRepairCost.TabIndex = 3;
            this.lbl_EstRepairCost.Text = "Estimated cost of repair $";
            // 
            // btn_serviceOrder
            // 
            this.btn_serviceOrder.Location = new System.Drawing.Point(103, 235);
            this.btn_serviceOrder.Name = "btn_serviceOrder";
            this.btn_serviceOrder.Size = new System.Drawing.Size(79, 24);
            this.btn_serviceOrder.TabIndex = 4;
            this.btn_serviceOrder.Text = "Submit";
            this.btn_serviceOrder.UseVisualStyleBackColor = true;
            this.btn_serviceOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_toolID
            // 
            this.txt_toolID.Location = new System.Drawing.Point(149, 56);
            this.txt_toolID.Name = "txt_toolID";
            this.txt_toolID.Size = new System.Drawing.Size(100, 20);
            this.txt_toolID.TabIndex = 5;
            // 
            // txt_startDate
            // 
            this.txt_startDate.Location = new System.Drawing.Point(149, 96);
            this.txt_startDate.Name = "txt_startDate";
            this.txt_startDate.Size = new System.Drawing.Size(100, 20);
            this.txt_startDate.TabIndex = 6;
            // 
            // txt_endDate
            // 
            this.txt_endDate.Location = new System.Drawing.Point(149, 138);
            this.txt_endDate.Name = "txt_endDate";
            this.txt_endDate.Size = new System.Drawing.Size(100, 20);
            this.txt_endDate.TabIndex = 7;
            // 
            // txt_estimate
            // 
            this.txt_estimate.Location = new System.Drawing.Point(149, 179);
            this.txt_estimate.Name = "txt_estimate";
            this.txt_estimate.Size = new System.Drawing.Size(100, 20);
            this.txt_estimate.TabIndex = 8;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(57, 20);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(171, 13);
            this.lbl_Header.TabIndex = 9;
            this.lbl_Header.Text = "SERVICE ORDER REQUEST";
            // 
            // ServiceOrderRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 277);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.txt_estimate);
            this.Controls.Add(this.txt_endDate);
            this.Controls.Add(this.txt_startDate);
            this.Controls.Add(this.txt_toolID);
            this.Controls.Add(this.btn_serviceOrder);
            this.Controls.Add(this.lbl_EstRepairCost);
            this.Controls.Add(this.lbl_EndDate);
            this.Controls.Add(this.lbl_StartDate);
            this.Controls.Add(this.lbl_ToolID);
            this.Name = "ServiceOrderRequest";
            this.Text = "ServiceOrderRequest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServiceOrderRequest_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ToolID;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_EstRepairCost;
        private System.Windows.Forms.Button btn_serviceOrder;
        private System.Windows.Forms.TextBox txt_toolID;
        private System.Windows.Forms.TextBox txt_startDate;
        private System.Windows.Forms.TextBox txt_endDate;
        private System.Windows.Forms.TextBox txt_estimate;
        private System.Windows.Forms.Label lbl_Header;
    }
}