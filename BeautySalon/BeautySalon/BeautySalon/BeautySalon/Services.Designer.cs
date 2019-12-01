namespace BeautySalon
{
    partial class Services
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
            this.salonNameslistbx = new System.Windows.Forms.ListBox();
            this.nextbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 289);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(150, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salons";
            // 
            // salonNameslistbx
            // 
            this.salonNameslistbx.BackColor = System.Drawing.Color.Bisque;
            this.salonNameslistbx.FormattingEnabled = true;
            this.salonNameslistbx.ItemHeight = 25;
            this.salonNameslistbx.Items.AddRange(new object[] {
            "Maison de Joelle",
            "Nails Spa"});
            this.salonNameslistbx.Location = new System.Drawing.Point(299, 300);
            this.salonNameslistbx.Name = "salonNameslistbx";
            this.salonNameslistbx.Size = new System.Drawing.Size(366, 79);
            this.salonNameslistbx.TabIndex = 1;
            this.salonNameslistbx.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nextbtn
            // 
            this.nextbtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbtn.ForeColor = System.Drawing.Color.Tomato;
            this.nextbtn.Location = new System.Drawing.Point(329, 508);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(271, 90);
            this.nextbtn.TabIndex = 2;
            this.nextbtn.Text = "Next";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeautySalon.Properties.Resources.التقاطث;
            this.ClientSize = new System.Drawing.Size(962, 922);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.salonNameslistbx);
            this.Controls.Add(this.label1);
            this.Name = "Services";
            this.Text = "Services";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox salonNameslistbx;
        private System.Windows.Forms.Button nextbtn;
    }
}