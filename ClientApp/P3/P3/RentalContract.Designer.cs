namespace P3
{
    partial class RentalContract
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ResNum = new System.Windows.Forms.Label();
            this.lbl_ClerkOnDuty = new System.Windows.Forms.Label();
            this.lbl_CustNum = new System.Windows.Forms.Label();
            this.lbl_CCNum = new System.Windows.Forms.Label();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.lbl_ToolsRented = new System.Windows.Forms.Label();
            this.lbl_DepHeld = new System.Windows.Forms.Label();
            this.lbl_EstRental = new System.Windows.Forms.Label();
            this.lbl_Signature = new System.Windows.Forms.Label();
            this.txt_resNum = new System.Windows.Forms.TextBox();
            this.txt_clerk = new System.Windows.Forms.TextBox();
            this.txt_custNum = new System.Windows.Forms.TextBox();
            this.txt_ccNum = new System.Windows.Forms.TextBox();
            this.txt_startDate = new System.Windows.Forms.TextBox();
            this.txt_endDate = new System.Windows.Forms.TextBox();
            this.txt_deposit = new System.Windows.Forms.TextBox();
            this.txt_estRental = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.toolID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HANDYMAN TOOLS RENTAL CONTRACT";
            // 
            // lbl_ResNum
            // 
            this.lbl_ResNum.AutoSize = true;
            this.lbl_ResNum.Location = new System.Drawing.Point(7, 59);
            this.lbl_ResNum.Name = "lbl_ResNum";
            this.lbl_ResNum.Size = new System.Drawing.Size(107, 13);
            this.lbl_ResNum.TabIndex = 1;
            this.lbl_ResNum.Text = "Reservation Number:";
            // 
            // lbl_ClerkOnDuty
            // 
            this.lbl_ClerkOnDuty.AutoSize = true;
            this.lbl_ClerkOnDuty.Location = new System.Drawing.Point(272, 59);
            this.lbl_ClerkOnDuty.Name = "lbl_ClerkOnDuty";
            this.lbl_ClerkOnDuty.Size = new System.Drawing.Size(74, 13);
            this.lbl_ClerkOnDuty.TabIndex = 2;
            this.lbl_ClerkOnDuty.Text = "Clerk on Duty:";
            // 
            // lbl_CustNum
            // 
            this.lbl_CustNum.AutoSize = true;
            this.lbl_CustNum.Location = new System.Drawing.Point(29, 85);
            this.lbl_CustNum.Name = "lbl_CustNum";
            this.lbl_CustNum.Size = new System.Drawing.Size(85, 13);
            this.lbl_CustNum.TabIndex = 3;
            this.lbl_CustNum.Text = "Customer Name:";
            // 
            // lbl_CCNum
            // 
            this.lbl_CCNum.AutoSize = true;
            this.lbl_CCNum.Location = new System.Drawing.Point(274, 85);
            this.lbl_CCNum.Name = "lbl_CCNum";
            this.lbl_CCNum.Size = new System.Drawing.Size(72, 13);
            this.lbl_CCNum.TabIndex = 4;
            this.lbl_CCNum.Text = "Credit Card #:";
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Location = new System.Drawing.Point(56, 110);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(58, 13);
            this.lbl_StartDate.TabIndex = 5;
            this.lbl_StartDate.Text = "Start Date:";
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Location = new System.Drawing.Point(291, 110);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(55, 13);
            this.lbl_EndDate.TabIndex = 6;
            this.lbl_EndDate.Text = "End Date:";
            // 
            // lbl_ToolsRented
            // 
            this.lbl_ToolsRented.AutoSize = true;
            this.lbl_ToolsRented.Location = new System.Drawing.Point(40, 142);
            this.lbl_ToolsRented.Name = "lbl_ToolsRented";
            this.lbl_ToolsRented.Size = new System.Drawing.Size(74, 13);
            this.lbl_ToolsRented.TabIndex = 7;
            this.lbl_ToolsRented.Text = "Tools Rented:";
            // 
            // lbl_DepHeld
            // 
            this.lbl_DepHeld.AutoSize = true;
            this.lbl_DepHeld.Location = new System.Drawing.Point(43, 257);
            this.lbl_DepHeld.Name = "lbl_DepHeld";
            this.lbl_DepHeld.Size = new System.Drawing.Size(71, 13);
            this.lbl_DepHeld.TabIndex = 8;
            this.lbl_DepHeld.Text = "Deposit Held:";
            // 
            // lbl_EstRental
            // 
            this.lbl_EstRental.AutoSize = true;
            this.lbl_EstRental.Location = new System.Drawing.Point(232, 258);
            this.lbl_EstRental.Name = "lbl_EstRental";
            this.lbl_EstRental.Size = new System.Drawing.Size(90, 13);
            this.lbl_EstRental.TabIndex = 9;
            this.lbl_EstRental.Text = "Estimated Rental:";
            // 
            // lbl_Signature
            // 
            this.lbl_Signature.AutoSize = true;
            this.lbl_Signature.Location = new System.Drawing.Point(59, 313);
            this.lbl_Signature.Name = "lbl_Signature";
            this.lbl_Signature.Size = new System.Drawing.Size(55, 13);
            this.lbl_Signature.TabIndex = 10;
            this.lbl_Signature.Text = "Signature:";
            // 
            // txt_resNum
            // 
            this.txt_resNum.BackColor = System.Drawing.SystemColors.Control;
            this.txt_resNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_resNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resNum.Location = new System.Drawing.Point(120, 57);
            this.txt_resNum.Name = "txt_resNum";
            this.txt_resNum.ReadOnly = true;
            this.txt_resNum.Size = new System.Drawing.Size(148, 13);
            this.txt_resNum.TabIndex = 11;
            // 
            // txt_clerk
            // 
            this.txt_clerk.BackColor = System.Drawing.SystemColors.Control;
            this.txt_clerk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_clerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clerk.Location = new System.Drawing.Point(352, 56);
            this.txt_clerk.Name = "txt_clerk";
            this.txt_clerk.ReadOnly = true;
            this.txt_clerk.Size = new System.Drawing.Size(130, 13);
            this.txt_clerk.TabIndex = 12;
            // 
            // txt_custNum
            // 
            this.txt_custNum.BackColor = System.Drawing.SystemColors.Control;
            this.txt_custNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_custNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_custNum.Location = new System.Drawing.Point(120, 82);
            this.txt_custNum.Name = "txt_custNum";
            this.txt_custNum.ReadOnly = true;
            this.txt_custNum.Size = new System.Drawing.Size(148, 13);
            this.txt_custNum.TabIndex = 13;
            // 
            // txt_ccNum
            // 
            this.txt_ccNum.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ccNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ccNum.Location = new System.Drawing.Point(352, 82);
            this.txt_ccNum.Name = "txt_ccNum";
            this.txt_ccNum.ReadOnly = true;
            this.txt_ccNum.Size = new System.Drawing.Size(130, 13);
            this.txt_ccNum.TabIndex = 14;
            // 
            // txt_startDate
            // 
            this.txt_startDate.BackColor = System.Drawing.SystemColors.Control;
            this.txt_startDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_startDate.Location = new System.Drawing.Point(120, 108);
            this.txt_startDate.Name = "txt_startDate";
            this.txt_startDate.ReadOnly = true;
            this.txt_startDate.Size = new System.Drawing.Size(148, 13);
            this.txt_startDate.TabIndex = 15;
            // 
            // txt_endDate
            // 
            this.txt_endDate.BackColor = System.Drawing.SystemColors.Control;
            this.txt_endDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_endDate.Location = new System.Drawing.Point(352, 107);
            this.txt_endDate.Name = "txt_endDate";
            this.txt_endDate.ReadOnly = true;
            this.txt_endDate.Size = new System.Drawing.Size(130, 13);
            this.txt_endDate.TabIndex = 16;
            // 
            // txt_deposit
            // 
            this.txt_deposit.BackColor = System.Drawing.SystemColors.Control;
            this.txt_deposit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deposit.Location = new System.Drawing.Point(120, 254);
            this.txt_deposit.Name = "txt_deposit";
            this.txt_deposit.ReadOnly = true;
            this.txt_deposit.Size = new System.Drawing.Size(100, 13);
            this.txt_deposit.TabIndex = 17;
            // 
            // txt_estRental
            // 
            this.txt_estRental.BackColor = System.Drawing.SystemColors.Control;
            this.txt_estRental.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_estRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estRental.Location = new System.Drawing.Point(328, 255);
            this.txt_estRental.Name = "txt_estRental";
            this.txt_estRental.ReadOnly = true;
            this.txt_estRental.Size = new System.Drawing.Size(100, 13);
            this.txt_estRental.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "___________________________________________________";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.toolID,
            this.desc});
            this.listView1.Location = new System.Drawing.Point(120, 134);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(362, 101);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // toolID
            // 
            this.toolID.Text = "Tool ID";
            this.toolID.Width = 92;
            // 
            // desc
            // 
            this.desc.Text = "Abbr Description";
            this.desc.Width = 262;
            // 
            // RentalContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 356);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_estRental);
            this.Controls.Add(this.txt_deposit);
            this.Controls.Add(this.txt_endDate);
            this.Controls.Add(this.txt_startDate);
            this.Controls.Add(this.txt_ccNum);
            this.Controls.Add(this.txt_custNum);
            this.Controls.Add(this.txt_clerk);
            this.Controls.Add(this.txt_resNum);
            this.Controls.Add(this.lbl_Signature);
            this.Controls.Add(this.lbl_EstRental);
            this.Controls.Add(this.lbl_DepHeld);
            this.Controls.Add(this.lbl_ToolsRented);
            this.Controls.Add(this.lbl_EndDate);
            this.Controls.Add(this.lbl_StartDate);
            this.Controls.Add(this.lbl_CCNum);
            this.Controls.Add(this.lbl_CustNum);
            this.Controls.Add(this.lbl_ClerkOnDuty);
            this.Controls.Add(this.lbl_ResNum);
            this.Controls.Add(this.label1);
            this.Name = "RentalContract";
            this.Text = "RentalContract";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentalContract_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ResNum;
        private System.Windows.Forms.Label lbl_ClerkOnDuty;
        private System.Windows.Forms.Label lbl_CustNum;
        private System.Windows.Forms.Label lbl_CCNum;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_ToolsRented;
        private System.Windows.Forms.Label lbl_DepHeld;
        private System.Windows.Forms.Label lbl_EstRental;
        private System.Windows.Forms.Label lbl_Signature;
        private System.Windows.Forms.TextBox txt_resNum;
        private System.Windows.Forms.TextBox txt_clerk;
        private System.Windows.Forms.TextBox txt_custNum;
        private System.Windows.Forms.TextBox txt_ccNum;
        private System.Windows.Forms.TextBox txt_startDate;
        private System.Windows.Forms.TextBox txt_endDate;
        private System.Windows.Forms.TextBox txt_deposit;
        private System.Windows.Forms.TextBox txt_estRental;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader toolID;
        private System.Windows.Forms.ColumnHeader desc;
    }
}