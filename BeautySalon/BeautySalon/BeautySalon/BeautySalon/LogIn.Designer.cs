namespace BeautySalon
{
    partial class LogIn
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
            this.userName = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.logIn_btn = new System.Windows.Forms.Button();
            this.userlogingtxb = new System.Windows.Forms.TextBox();
            this.passlogingtxb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.SeaShell;
            this.userName.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(99, 252);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(218, 53);
            this.userName.TabIndex = 0;
            this.userName.Text = "Uername : ";
            this.userName.Click += new System.EventHandler(this.userName_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.SeaShell;
            this.password.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(95, 355);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(222, 53);
            this.password.TabIndex = 1;
            this.password.Text = "Password : ";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // logIn_btn
            // 
            this.logIn_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.logIn_btn.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn_btn.ForeColor = System.Drawing.Color.Tomato;
            this.logIn_btn.Location = new System.Drawing.Point(302, 533);
            this.logIn_btn.Name = "logIn_btn";
            this.logIn_btn.Size = new System.Drawing.Size(254, 92);
            this.logIn_btn.TabIndex = 4;
            this.logIn_btn.Text = "Log in";
            this.logIn_btn.UseVisualStyleBackColor = false;
            this.logIn_btn.Click += new System.EventHandler(this.logInbtn_Click);
            // 
            // userlogingtxb
            // 
            this.userlogingtxb.Location = new System.Drawing.Point(341, 239);
            this.userlogingtxb.Multiline = true;
            this.userlogingtxb.Name = "userlogingtxb";
            this.userlogingtxb.Size = new System.Drawing.Size(314, 66);
            this.userlogingtxb.TabIndex = 5;
            this.userlogingtxb.TextChanged += new System.EventHandler(this.usernamelogingtxb_TextChanged);
            // 
            // passlogingtxb
            // 
            this.passlogingtxb.Location = new System.Drawing.Point(341, 344);
            this.passlogingtxb.Multiline = true;
            this.passlogingtxb.Name = "passlogingtxb";
            this.passlogingtxb.Size = new System.Drawing.Size(314, 64);
            this.passlogingtxb.TabIndex = 6;
            this.passlogingtxb.TextChanged += new System.EventHandler(this.passlogingtxb_TextChanged);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::BeautySalon.Properties.Resources.التقاطث;
            this.ClientSize = new System.Drawing.Size(856, 827);
            this.Controls.Add(this.passlogingtxb);
            this.Controls.Add(this.userlogingtxb);
            this.Controls.Add(this.logIn_btn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button logIn_btn;
        private System.Windows.Forms.TextBox userlogingtxb;
        private System.Windows.Forms.TextBox passlogingtxb;
    }
}