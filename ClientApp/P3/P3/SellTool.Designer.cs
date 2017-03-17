namespace P3
{
    partial class SellTool
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
            this.btnMarkForSale = new System.Windows.Forms.Button();
            this.txtToolID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMarkForSale
            // 
            this.btnMarkForSale.Location = new System.Drawing.Point(94, 113);
            this.btnMarkForSale.Name = "btnMarkForSale";
            this.btnMarkForSale.Size = new System.Drawing.Size(106, 23);
            this.btnMarkForSale.TabIndex = 77;
            this.btnMarkForSale.Text = "Mark For Sale";
            this.btnMarkForSale.UseVisualStyleBackColor = true;
            this.btnMarkForSale.Click += new System.EventHandler(this.btnMarkForSale_Click);
            // 
            // txtToolID
            // 
            this.txtToolID.Location = new System.Drawing.Point(85, 87);
            this.txtToolID.Name = "txtToolID";
            this.txtToolID.Size = new System.Drawing.Size(157, 20);
            this.txtToolID.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Tool ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 78;
            this.label1.Text = "Sell Tool";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(82, 159);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 79;
            this.lblMessage.Text = "Message";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(87, 202);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(113, 23);
            this.btnMainMenu.TabIndex = 83;
            this.btnMainMenu.Text = "Back to Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // SellTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 287);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMarkForSale);
            this.Controls.Add(this.txtToolID);
            this.Controls.Add(this.label5);
            this.Name = "SellTool";
            this.Text = "SellTool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SellTool_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMarkForSale;
        private System.Windows.Forms.TextBox txtToolID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnMainMenu;
    }
}