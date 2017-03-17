namespace P3
{
    partial class PickUp
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
            this.lbl_ResNum = new System.Windows.Forms.Label();
            this.lbl_Deposit = new System.Windows.Forms.Label();
            this.lbl_EstCost = new System.Windows.Forms.Label();
            this.lbl_ToolID = new System.Windows.Forms.Label();
            this.lbl_CCNum = new System.Windows.Forms.Label();
            this.lbl_ExpDate = new System.Windows.Forms.Label();
            this.btn_Details = new System.Windows.Forms.Button();
            this.btn_PickUp = new System.Windows.Forms.Button();
            this.txt_ToolId = new System.Windows.Forms.TextBox();
            this.txt_CCNum = new System.Windows.Forms.TextBox();
            this.txt_ExpDate = new System.Windows.Forms.TextBox();
            this.txt_ResNum = new System.Windows.Forms.TextBox();
            this.txt_DepReq_static = new System.Windows.Forms.TextBox();
            this.txt_EstCost_static = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_retrieveRes = new System.Windows.Forms.Button();
            this.lbl_invalidRes = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Tool_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tool_Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.toolID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deposit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dailyPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_ccMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ResNum
            // 
            this.lbl_ResNum.AutoSize = true;
            this.lbl_ResNum.Location = new System.Drawing.Point(144, 54);
            this.lbl_ResNum.Name = "lbl_ResNum";
            this.lbl_ResNum.Size = new System.Drawing.Size(131, 13);
            this.lbl_ResNum.TabIndex = 0;
            this.lbl_ResNum.Text = "Please enter reservation#:";
            // 
            // lbl_Deposit
            // 
            this.lbl_Deposit.AutoSize = true;
            this.lbl_Deposit.Location = new System.Drawing.Point(258, 130);
            this.lbl_Deposit.Name = "lbl_Deposit";
            this.lbl_Deposit.Size = new System.Drawing.Size(92, 13);
            this.lbl_Deposit.TabIndex = 2;
            this.lbl_Deposit.Text = "Deposit Required:";
            // 
            // lbl_EstCost
            // 
            this.lbl_EstCost.AutoSize = true;
            this.lbl_EstCost.Location = new System.Drawing.Point(270, 157);
            this.lbl_EstCost.Name = "lbl_EstCost";
            this.lbl_EstCost.Size = new System.Drawing.Size(80, 13);
            this.lbl_EstCost.TabIndex = 3;
            this.lbl_EstCost.Text = "Estimated Cost:";
            // 
            // lbl_ToolID
            // 
            this.lbl_ToolID.AutoSize = true;
            this.lbl_ToolID.Location = new System.Drawing.Point(136, 343);
            this.lbl_ToolID.Name = "lbl_ToolID";
            this.lbl_ToolID.Size = new System.Drawing.Size(45, 13);
            this.lbl_ToolID.TabIndex = 4;
            this.lbl_ToolID.Text = "Tool ID:";
            // 
            // lbl_CCNum
            // 
            this.lbl_CCNum.AutoSize = true;
            this.lbl_CCNum.Location = new System.Drawing.Point(248, 192);
            this.lbl_CCNum.Name = "lbl_CCNum";
            this.lbl_CCNum.Size = new System.Drawing.Size(102, 13);
            this.lbl_CCNum.TabIndex = 5;
            this.lbl_CCNum.Text = "Credit Card Number:";
            // 
            // lbl_ExpDate
            // 
            this.lbl_ExpDate.AutoSize = true;
            this.lbl_ExpDate.Location = new System.Drawing.Point(268, 221);
            this.lbl_ExpDate.Name = "lbl_ExpDate";
            this.lbl_ExpDate.Size = new System.Drawing.Size(82, 13);
            this.lbl_ExpDate.TabIndex = 6;
            this.lbl_ExpDate.Text = "Expiration Date:";
            // 
            // btn_Details
            // 
            this.btn_Details.Location = new System.Drawing.Point(271, 338);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(75, 23);
            this.btn_Details.TabIndex = 7;
            this.btn_Details.Text = "View Details";
            this.btn_Details.UseVisualStyleBackColor = true;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // btn_PickUp
            // 
            this.btn_PickUp.Enabled = false;
            this.btn_PickUp.Location = new System.Drawing.Point(186, 276);
            this.btn_PickUp.Name = "btn_PickUp";
            this.btn_PickUp.Size = new System.Drawing.Size(102, 23);
            this.btn_PickUp.TabIndex = 8;
            this.btn_PickUp.Text = "Complete Pick-Up";
            this.btn_PickUp.UseVisualStyleBackColor = true;
            this.btn_PickUp.Click += new System.EventHandler(this.btn_PickUp_Click);
            // 
            // txt_ToolId
            // 
            this.txt_ToolId.Location = new System.Drawing.Point(187, 339);
            this.txt_ToolId.Name = "txt_ToolId";
            this.txt_ToolId.Size = new System.Drawing.Size(68, 20);
            this.txt_ToolId.TabIndex = 9;
            // 
            // txt_CCNum
            // 
            this.txt_CCNum.Location = new System.Drawing.Point(356, 188);
            this.txt_CCNum.Name = "txt_CCNum";
            this.txt_CCNum.Size = new System.Drawing.Size(100, 20);
            this.txt_CCNum.TabIndex = 10;
            // 
            // txt_ExpDate
            // 
            this.txt_ExpDate.Location = new System.Drawing.Point(356, 217);
            this.txt_ExpDate.Name = "txt_ExpDate";
            this.txt_ExpDate.Size = new System.Drawing.Size(100, 20);
            this.txt_ExpDate.TabIndex = 11;
            // 
            // txt_ResNum
            // 
            this.txt_ResNum.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ResNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ResNum.CausesValidation = false;
            this.txt_ResNum.Location = new System.Drawing.Point(281, 51);
            this.txt_ResNum.Name = "txt_ResNum";
            this.txt_ResNum.Size = new System.Drawing.Size(50, 20);
            this.txt_ResNum.TabIndex = 1;
            // 
            // txt_DepReq_static
            // 
            this.txt_DepReq_static.BackColor = System.Drawing.SystemColors.Control;
            this.txt_DepReq_static.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DepReq_static.Enabled = false;
            this.txt_DepReq_static.Location = new System.Drawing.Point(356, 128);
            this.txt_DepReq_static.Name = "txt_DepReq_static";
            this.txt_DepReq_static.Size = new System.Drawing.Size(100, 20);
            this.txt_DepReq_static.TabIndex = 13;
            // 
            // txt_EstCost_static
            // 
            this.txt_EstCost_static.BackColor = System.Drawing.SystemColors.Control;
            this.txt_EstCost_static.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EstCost_static.Enabled = false;
            this.txt_EstCost_static.Location = new System.Drawing.Point(356, 155);
            this.txt_EstCost_static.Name = "txt_EstCost_static";
            this.txt_EstCost_static.Size = new System.Drawing.Size(100, 20);
            this.txt_EstCost_static.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "RESERVATION PICK-UP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "_____________________________________________";
            // 
            // btn_retrieveRes
            // 
            this.btn_retrieveRes.Location = new System.Drawing.Point(178, 276);
            this.btn_retrieveRes.Name = "btn_retrieveRes";
            this.btn_retrieveRes.Size = new System.Drawing.Size(119, 23);
            this.btn_retrieveRes.TabIndex = 19;
            this.btn_retrieveRes.Text = "Retrieve Reservation";
            this.btn_retrieveRes.UseVisualStyleBackColor = true;
            this.btn_retrieveRes.Click += new System.EventHandler(this.btn_retrieveRes_Click);
            // 
            // lbl_invalidRes
            // 
            this.lbl_invalidRes.AutoSize = true;
            this.lbl_invalidRes.ForeColor = System.Drawing.Color.Red;
            this.lbl_invalidRes.Location = new System.Drawing.Point(165, 78);
            this.lbl_invalidRes.Name = "lbl_invalidRes";
            this.lbl_invalidRes.Size = new System.Drawing.Size(144, 13);
            this.lbl_invalidRes.TabIndex = 20;
            this.lbl_invalidRes.Text = "Invalid Reservation# entered";
            this.lbl_invalidRes.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tool_ID,
            this.Tool_Description});
            this.listView1.Location = new System.Drawing.Point(17, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(217, 147);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Tool_ID
            // 
            this.Tool_ID.Text = "Tool ID";
            // 
            // Tool_Description
            // 
            this.Tool_Description.Text = "Tool Description";
            this.Tool_Description.Width = 152;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.toolID,
            this.toolDesc,
            this.deposit,
            this.dailyPrice});
            this.listView2.Location = new System.Drawing.Point(17, 372);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(446, 49);
            this.listView2.TabIndex = 23;
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
            // lbl_ccMessage
            // 
            this.lbl_ccMessage.AutoSize = true;
            this.lbl_ccMessage.ForeColor = System.Drawing.Color.Red;
            this.lbl_ccMessage.Location = new System.Drawing.Point(168, 78);
            this.lbl_ccMessage.Name = "lbl_ccMessage";
            this.lbl_ccMessage.Size = new System.Drawing.Size(141, 13);
            this.lbl_ccMessage.TabIndex = 24;
            this.lbl_ccMessage.Text = "Enter Credit Card information";
            this.lbl_ccMessage.Visible = false;
            // 
            // PickUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 433);
            this.Controls.Add(this.lbl_ccMessage);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbl_invalidRes);
            this.Controls.Add(this.btn_retrieveRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_EstCost_static);
            this.Controls.Add(this.txt_DepReq_static);
            this.Controls.Add(this.txt_ResNum);
            this.Controls.Add(this.txt_ExpDate);
            this.Controls.Add(this.txt_CCNum);
            this.Controls.Add(this.txt_ToolId);
            this.Controls.Add(this.btn_PickUp);
            this.Controls.Add(this.btn_Details);
            this.Controls.Add(this.lbl_ExpDate);
            this.Controls.Add(this.lbl_CCNum);
            this.Controls.Add(this.lbl_ToolID);
            this.Controls.Add(this.lbl_EstCost);
            this.Controls.Add(this.lbl_Deposit);
            this.Controls.Add(this.lbl_ResNum);
            this.Name = "PickUp";
            this.Text = "PickUp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PickUp_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ResNum;
        private System.Windows.Forms.Label lbl_Deposit;
        private System.Windows.Forms.Label lbl_EstCost;
        private System.Windows.Forms.Label lbl_ToolID;
        private System.Windows.Forms.Label lbl_CCNum;
        private System.Windows.Forms.Label lbl_ExpDate;
        private System.Windows.Forms.Button btn_Details;
        private System.Windows.Forms.Button btn_PickUp;
        private System.Windows.Forms.TextBox txt_ToolId;
        private System.Windows.Forms.TextBox txt_CCNum;
        private System.Windows.Forms.TextBox txt_ExpDate;
        private System.Windows.Forms.TextBox txt_ResNum;
        private System.Windows.Forms.TextBox txt_DepReq_static;
        private System.Windows.Forms.TextBox txt_EstCost_static;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_retrieveRes;
        private System.Windows.Forms.Label lbl_invalidRes;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Tool_ID;
        private System.Windows.Forms.ColumnHeader Tool_Description;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader toolID;
        private System.Windows.Forms.ColumnHeader toolDesc;
        private System.Windows.Forms.ColumnHeader deposit;
        private System.Windows.Forms.ColumnHeader dailyPrice;
        private System.Windows.Forms.Label lbl_ccMessage;
    }
}