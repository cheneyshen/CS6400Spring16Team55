namespace P3
{
    partial class Login
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.optClerk = new System.Windows.Forms.RadioButton();
            this.optCustomer = new System.Windows.Forms.RadioButton();
            this.linkCreateProfile = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(102, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(154, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(102, 74);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(154, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(117, 144);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Enter";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // optClerk
            // 
            this.optClerk.AutoSize = true;
            this.optClerk.Checked = true;
            this.optClerk.Location = new System.Drawing.Point(102, 116);
            this.optClerk.Name = "optClerk";
            this.optClerk.Size = new System.Drawing.Size(49, 17);
            this.optClerk.TabIndex = 5;
            this.optClerk.TabStop = true;
            this.optClerk.Text = "Clerk";
            this.optClerk.UseVisualStyleBackColor = true;
            // 
            // optCustomer
            // 
            this.optCustomer.AutoSize = true;
            this.optCustomer.Location = new System.Drawing.Point(170, 116);
            this.optCustomer.Name = "optCustomer";
            this.optCustomer.Size = new System.Drawing.Size(69, 17);
            this.optCustomer.TabIndex = 6;
            this.optCustomer.Text = "Customer";
            this.optCustomer.UseVisualStyleBackColor = true;
            // 
            // linkCreateProfile
            // 
            this.linkCreateProfile.AutoSize = true;
            this.linkCreateProfile.Location = new System.Drawing.Point(96, 191);
            this.linkCreateProfile.Name = "linkCreateProfile";
            this.linkCreateProfile.Size = new System.Drawing.Size(160, 13);
            this.linkCreateProfile.TabIndex = 7;
            this.linkCreateProfile.TabStop = true;
            this.linkCreateProfile.Text = "Click Here to Create an Account";
            this.linkCreateProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreateProfile_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 226);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkCreateProfile);
            this.Controls.Add(this.optCustomer);
            this.Controls.Add(this.optClerk);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.Name = "Login";
            this.Text = "Handyman Tools";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton optClerk;
        private System.Windows.Forms.RadioButton optCustomer;
        private System.Windows.Forms.LinkLabel linkCreateProfile;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
    }
}

