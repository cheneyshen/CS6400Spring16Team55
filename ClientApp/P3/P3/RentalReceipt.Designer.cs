namespace P3
{
    partial class RentalReceipt
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
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_ResNum = new System.Windows.Forms.Label();
            this.lbl_ClerkOnDuty = new System.Windows.Forms.Label();
            this.lbl_CustNum = new System.Windows.Forms.Label();
            this.lbl_CreditCard = new System.Windows.Forms.Label();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.lbl_RentalPrice = new System.Windows.Forms.Label();
            this.lbl_DepHeld = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_resNum = new System.Windows.Forms.TextBox();
            this.txt_Clerk = new System.Windows.Forms.TextBox();
            this.txt_custName = new System.Windows.Forms.TextBox();
            this.txt_ccNum = new System.Windows.Forms.TextBox();
            this.txt_startDate = new System.Windows.Forms.TextBox();
            this.txt_endDate = new System.Windows.Forms.TextBox();
            this.txt_rentalPrice = new System.Windows.Forms.TextBox();
            this.txt_deposit = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(150, 20);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(179, 13);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "HANDYMAN TOOLS RECEIPT";
            // 
            // lbl_ResNum
            // 
            this.lbl_ResNum.AutoSize = true;
            this.lbl_ResNum.Location = new System.Drawing.Point(7, 63);
            this.lbl_ResNum.Name = "lbl_ResNum";
            this.lbl_ResNum.Size = new System.Drawing.Size(107, 13);
            this.lbl_ResNum.TabIndex = 1;
            this.lbl_ResNum.Text = "Reservation Number:";
            // 
            // lbl_ClerkOnDuty
            // 
            this.lbl_ClerkOnDuty.AutoSize = true;
            this.lbl_ClerkOnDuty.Location = new System.Drawing.Point(276, 63);
            this.lbl_ClerkOnDuty.Name = "lbl_ClerkOnDuty";
            this.lbl_ClerkOnDuty.Size = new System.Drawing.Size(74, 13);
            this.lbl_ClerkOnDuty.TabIndex = 2;
            this.lbl_ClerkOnDuty.Text = "Clerk on Duty:";
            // 
            // lbl_CustNum
            // 
            this.lbl_CustNum.AutoSize = true;
            this.lbl_CustNum.Location = new System.Drawing.Point(20, 103);
            this.lbl_CustNum.Name = "lbl_CustNum";
            this.lbl_CustNum.Size = new System.Drawing.Size(85, 13);
            this.lbl_CustNum.TabIndex = 3;
            this.lbl_CustNum.Text = "Customer Name:";
            // 
            // lbl_CreditCard
            // 
            this.lbl_CreditCard.AutoSize = true;
            this.lbl_CreditCard.Location = new System.Drawing.Point(278, 103);
            this.lbl_CreditCard.Name = "lbl_CreditCard";
            this.lbl_CreditCard.Size = new System.Drawing.Size(72, 13);
            this.lbl_CreditCard.TabIndex = 4;
            this.lbl_CreditCard.Text = "Credit Card #:";
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Location = new System.Drawing.Point(56, 143);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(58, 13);
            this.lbl_StartDate.TabIndex = 5;
            this.lbl_StartDate.Text = "Start Date:";
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Location = new System.Drawing.Point(295, 143);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(55, 13);
            this.lbl_EndDate.TabIndex = 6;
            this.lbl_EndDate.Text = "End Date:";
            // 
            // lbl_RentalPrice
            // 
            this.lbl_RentalPrice.AutoSize = true;
            this.lbl_RentalPrice.Location = new System.Drawing.Point(43, 185);
            this.lbl_RentalPrice.Name = "lbl_RentalPrice";
            this.lbl_RentalPrice.Size = new System.Drawing.Size(71, 13);
            this.lbl_RentalPrice.TabIndex = 7;
            this.lbl_RentalPrice.Text = "Rental Price: ";
            // 
            // lbl_DepHeld
            // 
            this.lbl_DepHeld.AutoSize = true;
            this.lbl_DepHeld.Location = new System.Drawing.Point(43, 221);
            this.lbl_DepHeld.Name = "lbl_DepHeld";
            this.lbl_DepHeld.Size = new System.Drawing.Size(71, 13);
            this.lbl_DepHeld.TabIndex = 8;
            this.lbl_DepHeld.Text = "Deposit Held:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(86, 277);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(34, 13);
            this.lbl_Total.TabIndex = 9;
            this.lbl_Total.Text = "Total:";
            // 
            // txt_resNum
            // 
            this.txt_resNum.BackColor = System.Drawing.SystemColors.Control;
            this.txt_resNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_resNum.Enabled = false;
            this.txt_resNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resNum.Location = new System.Drawing.Point(126, 61);
            this.txt_resNum.Name = "txt_resNum";
            this.txt_resNum.ReadOnly = true;
            this.txt_resNum.Size = new System.Drawing.Size(100, 13);
            this.txt_resNum.TabIndex = 10;
            // 
            // txt_Clerk
            // 
            this.txt_Clerk.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Clerk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Clerk.Enabled = false;
            this.txt_Clerk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Clerk.Location = new System.Drawing.Point(362, 61);
            this.txt_Clerk.Name = "txt_Clerk";
            this.txt_Clerk.ReadOnly = true;
            this.txt_Clerk.Size = new System.Drawing.Size(121, 13);
            this.txt_Clerk.TabIndex = 11;
            // 
            // txt_custName
            // 
            this.txt_custName.BackColor = System.Drawing.SystemColors.Control;
            this.txt_custName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_custName.Enabled = false;
            this.txt_custName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_custName.Location = new System.Drawing.Point(126, 101);
            this.txt_custName.Name = "txt_custName";
            this.txt_custName.ReadOnly = true;
            this.txt_custName.Size = new System.Drawing.Size(100, 13);
            this.txt_custName.TabIndex = 12;
            // 
            // txt_ccNum
            // 
            this.txt_ccNum.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ccNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ccNum.Enabled = false;
            this.txt_ccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ccNum.Location = new System.Drawing.Point(362, 101);
            this.txt_ccNum.Name = "txt_ccNum";
            this.txt_ccNum.ReadOnly = true;
            this.txt_ccNum.Size = new System.Drawing.Size(121, 13);
            this.txt_ccNum.TabIndex = 13;
            // 
            // txt_startDate
            // 
            this.txt_startDate.BackColor = System.Drawing.SystemColors.Control;
            this.txt_startDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_startDate.Enabled = false;
            this.txt_startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_startDate.Location = new System.Drawing.Point(126, 141);
            this.txt_startDate.Name = "txt_startDate";
            this.txt_startDate.ReadOnly = true;
            this.txt_startDate.Size = new System.Drawing.Size(100, 13);
            this.txt_startDate.TabIndex = 14;
            // 
            // txt_endDate
            // 
            this.txt_endDate.BackColor = System.Drawing.SystemColors.Control;
            this.txt_endDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_endDate.Enabled = false;
            this.txt_endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_endDate.Location = new System.Drawing.Point(362, 141);
            this.txt_endDate.Name = "txt_endDate";
            this.txt_endDate.ReadOnly = true;
            this.txt_endDate.Size = new System.Drawing.Size(121, 13);
            this.txt_endDate.TabIndex = 15;
            // 
            // txt_rentalPrice
            // 
            this.txt_rentalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txt_rentalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_rentalPrice.Enabled = false;
            this.txt_rentalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rentalPrice.Location = new System.Drawing.Point(126, 183);
            this.txt_rentalPrice.Name = "txt_rentalPrice";
            this.txt_rentalPrice.ReadOnly = true;
            this.txt_rentalPrice.Size = new System.Drawing.Size(100, 13);
            this.txt_rentalPrice.TabIndex = 16;
            // 
            // txt_deposit
            // 
            this.txt_deposit.BackColor = System.Drawing.SystemColors.Control;
            this.txt_deposit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_deposit.Enabled = false;
            this.txt_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deposit.Location = new System.Drawing.Point(126, 219);
            this.txt_deposit.Name = "txt_deposit";
            this.txt_deposit.ReadOnly = true;
            this.txt_deposit.Size = new System.Drawing.Size(100, 13);
            this.txt_deposit.TabIndex = 17;
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.Control;
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(126, 275);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(100, 13);
            this.txt_total.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "________________";
            // 
            // RentalReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_deposit);
            this.Controls.Add(this.txt_rentalPrice);
            this.Controls.Add(this.txt_endDate);
            this.Controls.Add(this.txt_startDate);
            this.Controls.Add(this.txt_ccNum);
            this.Controls.Add(this.txt_custName);
            this.Controls.Add(this.txt_Clerk);
            this.Controls.Add(this.txt_resNum);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_DepHeld);
            this.Controls.Add(this.lbl_RentalPrice);
            this.Controls.Add(this.lbl_EndDate);
            this.Controls.Add(this.lbl_StartDate);
            this.Controls.Add(this.lbl_CreditCard);
            this.Controls.Add(this.lbl_CustNum);
            this.Controls.Add(this.lbl_ClerkOnDuty);
            this.Controls.Add(this.lbl_ResNum);
            this.Controls.Add(this.lbl_Header);
            this.Name = "RentalReceipt";
            this.Text = "RentalReceipt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentalReceipt_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_ResNum;
        private System.Windows.Forms.Label lbl_ClerkOnDuty;
        private System.Windows.Forms.Label lbl_CustNum;
        private System.Windows.Forms.Label lbl_CreditCard;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_RentalPrice;
        private System.Windows.Forms.Label lbl_DepHeld;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txt_resNum;
        private System.Windows.Forms.TextBox txt_Clerk;
        private System.Windows.Forms.TextBox txt_custName;
        private System.Windows.Forms.TextBox txt_ccNum;
        private System.Windows.Forms.TextBox txt_startDate;
        private System.Windows.Forms.TextBox txt_endDate;
        private System.Windows.Forms.TextBox txt_rentalPrice;
        private System.Windows.Forms.TextBox txt_deposit;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label1;
    }
}