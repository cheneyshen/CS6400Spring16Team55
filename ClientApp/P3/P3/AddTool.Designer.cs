namespace P3
{
    partial class AddTool
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbToolType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAccessories = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.txtAbbrDescription = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtRentPrice = new System.Windows.Forms.TextBox();
            this.txtDepositPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Tool";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Abbreviated Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Purchase Price: $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rental Price (per day): $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Deposit Amount: $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Full Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(55, 194);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(337, 76);
            this.txtDescription.TabIndex = 7;
            // 
            // cbToolType
            // 
            this.cbToolType.FormattingEnabled = true;
            this.cbToolType.Location = new System.Drawing.Point(140, 276);
            this.cbToolType.Name = "cbToolType";
            this.cbToolType.Size = new System.Drawing.Size(159, 21);
            this.cbToolType.TabIndex = 8;
            this.cbToolType.SelectionChangeCommitted += new System.EventHandler(this.cbToolType_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tool Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Accessories:";
            // 
            // txtAccessories
            // 
            this.txtAccessories.Enabled = false;
            this.txtAccessories.Location = new System.Drawing.Point(55, 323);
            this.txtAccessories.MaxLength = 100;
            this.txtAccessories.Multiline = true;
            this.txtAccessories.Name = "txtAccessories";
            this.txtAccessories.Size = new System.Drawing.Size(337, 75);
            this.txtAccessories.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(58, 404);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 23);
            this.btnSubmit.TabIndex = 72;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(167, 404);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(113, 23);
            this.btnMainMenu.TabIndex = 82;
            this.btnMainMenu.Text = "Back to Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // txtAbbrDescription
            // 
            this.txtAbbrDescription.Location = new System.Drawing.Point(152, 58);
            this.txtAbbrDescription.Name = "txtAbbrDescription";
            this.txtAbbrDescription.Size = new System.Drawing.Size(238, 20);
            this.txtAbbrDescription.TabIndex = 83;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(152, 89);
            this.txtPurchasePrice.MaxLength = 10;
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(238, 20);
            this.txtPurchasePrice.TabIndex = 84;
            // 
            // txtRentPrice
            // 
            this.txtRentPrice.Location = new System.Drawing.Point(152, 116);
            this.txtRentPrice.MaxLength = 10;
            this.txtRentPrice.Name = "txtRentPrice";
            this.txtRentPrice.Size = new System.Drawing.Size(238, 20);
            this.txtRentPrice.TabIndex = 85;
            // 
            // txtDepositPrice
            // 
            this.txtDepositPrice.Location = new System.Drawing.Point(152, 142);
            this.txtDepositPrice.MaxLength = 10;
            this.txtDepositPrice.Name = "txtDepositPrice";
            this.txtDepositPrice.Size = new System.Drawing.Size(238, 20);
            this.txtDepositPrice.TabIndex = 86;
            // 
            // AddTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 439);
            this.Controls.Add(this.txtDepositPrice);
            this.Controls.Add(this.txtRentPrice);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.txtAbbrDescription);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAccessories);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbToolType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTool";
            this.Text = "AddTool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTool_FormClosed);
            this.Load += new System.EventHandler(this.AddTool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cbToolType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAccessories;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.TextBox txtAbbrDescription;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtRentPrice;
        private System.Windows.Forms.TextBox txtDepositPrice;
    }
}