namespace BeautySalon
{
    partial class SignUp
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
            this.firstnmlbl = new System.Windows.Forms.Label();
            this.firstNametbx = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNametbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernametbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneNumbertxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailtxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordtxb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstnmlbl
            // 
            this.firstnmlbl.AutoSize = true;
            this.firstnmlbl.BackColor = System.Drawing.Color.SeaShell;
            this.firstnmlbl.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnmlbl.Location = new System.Drawing.Point(28, 72);
            this.firstnmlbl.Name = "firstnmlbl";
            this.firstnmlbl.Size = new System.Drawing.Size(207, 45);
            this.firstnmlbl.TabIndex = 0;
            this.firstnmlbl.Text = "First Name : ";
            this.firstnmlbl.Click += new System.EventHandler(this.firstnmlbl_Click);
            // 
            // firstNametbx
            // 
            this.firstNametbx.Location = new System.Drawing.Point(241, 75);
            this.firstNametbx.Multiline = true;
            this.firstNametbx.Name = "firstNametbx";
            this.firstNametbx.Size = new System.Drawing.Size(248, 42);
            this.firstNametbx.TabIndex = 2;
            this.firstNametbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.Tomato;
            this.save_btn.Location = new System.Drawing.Point(453, 433);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(257, 77);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Last Name : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lastNametbx
            // 
            this.lastNametbx.Location = new System.Drawing.Point(241, 168);
            this.lastNametbx.Multiline = true;
            this.lastNametbx.Name = "lastNametbx";
            this.lastNametbx.Size = new System.Drawing.Size(248, 42);
            this.lastNametbx.TabIndex = 6;
            this.lastNametbx.TextChanged += new System.EventHandler(this.lastNametbx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaShell;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(580, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username : ";
            // 
            // usernametbx
            // 
            this.usernametbx.Location = new System.Drawing.Point(822, 86);
            this.usernametbx.Multiline = true;
            this.usernametbx.Name = "usernametbx";
            this.usernametbx.Size = new System.Drawing.Size(251, 42);
            this.usernametbx.TabIndex = 8;
            this.usernametbx.TextChanged += new System.EventHandler(this.usernametbx_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaShell;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 45);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone number : ";
            // 
            // phoneNumbertxb
            // 
            this.phoneNumbertxb.Location = new System.Drawing.Point(822, 165);
            this.phoneNumbertxb.Multiline = true;
            this.phoneNumbertxb.Name = "phoneNumbertxb";
            this.phoneNumbertxb.Size = new System.Drawing.Size(251, 45);
            this.phoneNumbertxb.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SeaShell;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email : ";
            // 
            // emailtxb
            // 
            this.emailtxb.Location = new System.Drawing.Point(241, 248);
            this.emailtxb.Multiline = true;
            this.emailtxb.Name = "emailtxb";
            this.emailtxb.Size = new System.Drawing.Size(248, 45);
            this.emailtxb.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SeaShell;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(593, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 45);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password : ";
            // 
            // passwordtxb
            // 
            this.passwordtxb.Location = new System.Drawing.Point(822, 251);
            this.passwordtxb.Multiline = true;
            this.passwordtxb.Name = "passwordtxb";
            this.passwordtxb.Size = new System.Drawing.Size(251, 42);
            this.passwordtxb.TabIndex = 14;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeautySalon.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(1174, 593);
            this.Controls.Add(this.passwordtxb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailtxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneNumbertxb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernametbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNametbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.firstNametbx);
            this.Controls.Add(this.firstnmlbl);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstnmlbl;
        private System.Windows.Forms.TextBox firstNametbx;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNametbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernametbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneNumbertxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailtxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordtxb;
    }
}