namespace P3
{
    partial class DropOff
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
            this.deposit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.dailyPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tool_Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tool_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbl_invalidRes = new System.Windows.Forms.Label();
            this.btn_retrieveRes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_EstCost_static = new System.Windows.Forms.TextBox();
            this.txt_DepReq_static = new System.Windows.Forms.TextBox();
            this.txt_ResNum = new System.Windows.Forms.TextBox();
            this.txt_ExpDate = new System.Windows.Forms.TextBox();
            this.txt_CCNum = new System.Windows.Forms.TextBox();
            this.txt_ToolId = new System.Windows.Forms.TextBox();
            this.btn_dropOff = new System.Windows.Forms.Button();
            this.btn_Details = new System.Windows.Forms.Button();
            this.lbl_ExpDate = new System.Windows.Forms.Label();
            this.lbl_CCNum = new System.Windows.Forms.Label();
            this.lbl_ToolID = new System.Windows.Forms.Label();
            this.lbl_EstCost = new System.Windows.Forms.Label();
            this.lbl_Deposit = new System.Windows.Forms.Label();
            this.lbl_ResNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deposit
            // 
            this.deposit.Text = "Deposit";
            this.deposit.Width = 80;
            // 
            // toolDesc
            // 
            this.toolDesc.Text = "Tool Description";
            this.toolDesc.Width = 219;
            // 
            // toolID
            // 
            this.toolID.Text = "Tool ID";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.toolID,
            this.toolDesc,
            this.deposit,
            this.dailyPrice});
            this.listView2.Location = new System.Drawing.Point(16, 361);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(446, 49);
            this.listView2.TabIndex = 44;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // dailyPrice
            // 
            this.dailyPrice.Text = "Price per Day";
            this.dailyPrice.Width = 82;
            // 
            // Tool_Description
            // 
            this.Tool_Description.Text = "Tool Description";
            this.Tool_Description.Width = 152;
            // 
            // Tool_ID
            // 
            this.Tool_ID.Text = "Tool ID";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tool_ID,
            this.Tool_Description});
            this.listView1.Location = new System.Drawing.Point(16, 94);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(217, 147);
            this.listView1.TabIndex = 43;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lbl_invalidRes
            // 
            this.lbl_invalidRes.AutoSize = true;
            this.lbl_invalidRes.ForeColor = System.Drawing.Color.Red;
            this.lbl_invalidRes.Location = new System.Drawing.Point(164, 67);
            this.lbl_invalidRes.Name = "lbl_invalidRes";
            this.lbl_invalidRes.Size = new System.Drawing.Size(144, 13);
            this.lbl_invalidRes.TabIndex = 42;
            this.lbl_invalidRes.Text = "Invalid Reservation# entered";
            this.lbl_invalidRes.Visible = false;
            // 
            // btn_retrieveRes
            // 
            this.btn_retrieveRes.Location = new System.Drawing.Point(182, 265);
            this.btn_retrieveRes.Name = "btn_retrieveRes";
            this.btn_retrieveRes.Size = new System.Drawing.Size(119, 23);
            this.btn_retrieveRes.TabIndex = 41;
            this.btn_retrieveRes.Text = "Retrieve Reservation";
            this.btn_retrieveRes.UseVisualStyleBackColor = true;
            this.btn_retrieveRes.Click += new System.EventHandler(this.btn_retrieveRes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "_____________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "RESERVATION DROP-UP";
            // 
            // txt_EstCost_static
            // 
            this.txt_EstCost_static.BackColor = System.Drawing.SystemColors.Control;
            this.txt_EstCost_static.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EstCost_static.Enabled = false;
            this.txt_EstCost_static.Location = new System.Drawing.Point(355, 144);
            this.txt_EstCost_static.Name = "txt_EstCost_static";
            this.txt_EstCost_static.Size = new System.Drawing.Size(100, 20);
            this.txt_EstCost_static.TabIndex = 38;
            // 
            // txt_DepReq_static
            // 
            this.txt_DepReq_static.BackColor = System.Drawing.SystemColors.Control;
            this.txt_DepReq_static.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DepReq_static.Enabled = false;
            this.txt_DepReq_static.Location = new System.Drawing.Point(355, 117);
            this.txt_DepReq_static.Name = "txt_DepReq_static";
            this.txt_DepReq_static.Size = new System.Drawing.Size(100, 20);
            this.txt_DepReq_static.TabIndex = 37;
            // 
            // txt_ResNum
            // 
            this.txt_ResNum.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ResNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ResNum.CausesValidation = false;
            this.txt_ResNum.Location = new System.Drawing.Point(280, 40);
            this.txt_ResNum.Name = "txt_ResNum";
            this.txt_ResNum.Size = new System.Drawing.Size(50, 20);
            this.txt_ResNum.TabIndex = 26;
            // 
            // txt_ExpDate
            // 
            this.txt_ExpDate.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ExpDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ExpDate.Location = new System.Drawing.Point(355, 206);
            this.txt_ExpDate.Name = "txt_ExpDate";
            this.txt_ExpDate.Size = new System.Drawing.Size(100, 20);
            this.txt_ExpDate.TabIndex = 36;
            // 
            // txt_CCNum
            // 
            this.txt_CCNum.BackColor = System.Drawing.SystemColors.Control;
            this.txt_CCNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CCNum.Location = new System.Drawing.Point(355, 177);
            this.txt_CCNum.Name = "txt_CCNum";
            this.txt_CCNum.Size = new System.Drawing.Size(100, 20);
            this.txt_CCNum.TabIndex = 35;
            // 
            // txt_ToolId
            // 
            this.txt_ToolId.Location = new System.Drawing.Point(186, 328);
            this.txt_ToolId.Name = "txt_ToolId";
            this.txt_ToolId.Size = new System.Drawing.Size(68, 20);
            this.txt_ToolId.TabIndex = 34;
            // 
            // btn_dropOff
            // 
            this.btn_dropOff.Location = new System.Drawing.Point(185, 265);
            this.btn_dropOff.Name = "btn_dropOff";
            this.btn_dropOff.Size = new System.Drawing.Size(102, 23);
            this.btn_dropOff.TabIndex = 33;
            this.btn_dropOff.Text = "Complete Drop-Up";
            this.btn_dropOff.UseVisualStyleBackColor = true;
            this.btn_dropOff.Click += new System.EventHandler(this.btn_dropOff_Click);
            // 
            // btn_Details
            // 
            this.btn_Details.Location = new System.Drawing.Point(270, 327);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(75, 23);
            this.btn_Details.TabIndex = 32;
            this.btn_Details.Text = "View Details";
            this.btn_Details.UseVisualStyleBackColor = true;
            // 
            // lbl_ExpDate
            // 
            this.lbl_ExpDate.AutoSize = true;
            this.lbl_ExpDate.Location = new System.Drawing.Point(267, 210);
            this.lbl_ExpDate.Name = "lbl_ExpDate";
            this.lbl_ExpDate.Size = new System.Drawing.Size(82, 13);
            this.lbl_ExpDate.TabIndex = 31;
            this.lbl_ExpDate.Text = "Expiration Date:";
            // 
            // lbl_CCNum
            // 
            this.lbl_CCNum.AutoSize = true;
            this.lbl_CCNum.Location = new System.Drawing.Point(247, 181);
            this.lbl_CCNum.Name = "lbl_CCNum";
            this.lbl_CCNum.Size = new System.Drawing.Size(102, 13);
            this.lbl_CCNum.TabIndex = 30;
            this.lbl_CCNum.Text = "Credit Card Number:";
            // 
            // lbl_ToolID
            // 
            this.lbl_ToolID.AutoSize = true;
            this.lbl_ToolID.Location = new System.Drawing.Point(135, 332);
            this.lbl_ToolID.Name = "lbl_ToolID";
            this.lbl_ToolID.Size = new System.Drawing.Size(45, 13);
            this.lbl_ToolID.TabIndex = 29;
            this.lbl_ToolID.Text = "Tool ID:";
            // 
            // lbl_EstCost
            // 
            this.lbl_EstCost.AutoSize = true;
            this.lbl_EstCost.Location = new System.Drawing.Point(269, 146);
            this.lbl_EstCost.Name = "lbl_EstCost";
            this.lbl_EstCost.Size = new System.Drawing.Size(80, 13);
            this.lbl_EstCost.TabIndex = 28;
            this.lbl_EstCost.Text = "Estimated Cost:";
            // 
            // lbl_Deposit
            // 
            this.lbl_Deposit.AutoSize = true;
            this.lbl_Deposit.Location = new System.Drawing.Point(257, 119);
            this.lbl_Deposit.Name = "lbl_Deposit";
            this.lbl_Deposit.Size = new System.Drawing.Size(92, 13);
            this.lbl_Deposit.TabIndex = 27;
            this.lbl_Deposit.Text = "Deposit Required:";
            // 
            // lbl_ResNum
            // 
            this.lbl_ResNum.AutoSize = true;
            this.lbl_ResNum.Location = new System.Drawing.Point(143, 43);
            this.lbl_ResNum.Name = "lbl_ResNum";
            this.lbl_ResNum.Size = new System.Drawing.Size(131, 13);
            this.lbl_ResNum.TabIndex = 25;
            this.lbl_ResNum.Text = "Please enter reservation#:";
            // 
            // DropOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 419);
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
            this.Controls.Add(this.btn_dropOff);
            this.Controls.Add(this.btn_Details);
            this.Controls.Add(this.lbl_ExpDate);
            this.Controls.Add(this.lbl_CCNum);
            this.Controls.Add(this.lbl_ToolID);
            this.Controls.Add(this.lbl_EstCost);
            this.Controls.Add(this.lbl_Deposit);
            this.Controls.Add(this.lbl_ResNum);
            this.Name = "DropOff";
            this.Text = "DropOff";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DropOff_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader deposit;
        private System.Windows.Forms.ColumnHeader toolDesc;
        private System.Windows.Forms.ColumnHeader toolID;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader dailyPrice;
        private System.Windows.Forms.ColumnHeader Tool_Description;
        private System.Windows.Forms.ColumnHeader Tool_ID;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbl_invalidRes;
        private System.Windows.Forms.Button btn_retrieveRes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_EstCost_static;
        private System.Windows.Forms.TextBox txt_DepReq_static;
        private System.Windows.Forms.TextBox txt_ResNum;
        private System.Windows.Forms.TextBox txt_ExpDate;
        private System.Windows.Forms.TextBox txt_CCNum;
        private System.Windows.Forms.TextBox txt_ToolId;
        private System.Windows.Forms.Button btn_dropOff;
        private System.Windows.Forms.Button btn_Details;
        private System.Windows.Forms.Label lbl_ExpDate;
        private System.Windows.Forms.Label lbl_CCNum;
        private System.Windows.Forms.Label lbl_ToolID;
        private System.Windows.Forms.Label lbl_EstCost;
        private System.Windows.Forms.Label lbl_Deposit;
        private System.Windows.Forms.Label lbl_ResNum;
    }
}