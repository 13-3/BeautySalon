namespace BeautySalon
{
    partial class Nails_spa
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
            this.components = new System.ComponentModel.Container();
            this.NailaData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Nailsspaapptlistbx = new System.Windows.Forms.ListBox();
            this.nailsSpaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beautySalonDataSet = new BeautySalon.BeautySalonDataSet();
            this.nails_SpaTableAdapter = new BeautySalon.BeautySalonDataSetTableAdapters.Nails_SpaTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.nailspabookbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NailaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nailsSpaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautySalonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // NailaData
            // 
            this.NailaData.BackgroundColor = System.Drawing.Color.SeaShell;
            this.NailaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NailaData.Location = new System.Drawing.Point(52, 154);
            this.NailaData.Name = "NailaData";
            this.NailaData.RowHeadersWidth = 82;
            this.NailaData.RowTemplate.Height = 33;
            this.NailaData.Size = new System.Drawing.Size(902, 415);
            this.NailaData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1040, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointments";
            // 
            // Nailsspaapptlistbx
            // 
            this.Nailsspaapptlistbx.DataSource = this.nailsSpaBindingSource;
            this.Nailsspaapptlistbx.DisplayMember = "appointment";
            this.Nailsspaapptlistbx.FormattingEnabled = true;
            this.Nailsspaapptlistbx.ItemHeight = 25;
            this.Nailsspaapptlistbx.Location = new System.Drawing.Point(1026, 345);
            this.Nailsspaapptlistbx.Name = "Nailsspaapptlistbx";
            this.Nailsspaapptlistbx.Size = new System.Drawing.Size(392, 204);
            this.Nailsspaapptlistbx.TabIndex = 2;
            this.Nailsspaapptlistbx.SelectedIndexChanged += new System.EventHandler(this.Nailsspaapptlistbx_SelectedIndexChanged);
            // 
            // nailsSpaBindingSource
            // 
            this.nailsSpaBindingSource.DataMember = "Nails_Spa";
            this.nailsSpaBindingSource.DataSource = this.beautySalonDataSet;
            // 
            // beautySalonDataSet
            // 
            this.beautySalonDataSet.DataSetName = "BeautySalonDataSet";
            this.beautySalonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nails_SpaTableAdapter
            // 
            this.nails_SpaTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1510, 25);
            this.fillByToolStrip.TabIndex = 3;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // nailspabookbtn
            // 
            this.nailspabookbtn.Location = new System.Drawing.Point(1045, 638);
            this.nailspabookbtn.Name = "nailspabookbtn";
            this.nailspabookbtn.Size = new System.Drawing.Size(219, 70);
            this.nailspabookbtn.TabIndex = 4;
            this.nailspabookbtn.Text = "Book";
            this.nailspabookbtn.UseVisualStyleBackColor = true;
            this.nailspabookbtn.Click += new System.EventHandler(this.nailspabookbtn_Click);
            // 
            // Nails_spa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeautySalon.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(1510, 1017);
            this.Controls.Add(this.nailspabookbtn);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.Nailsspaapptlistbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NailaData);
            this.Name = "Nails_spa";
            this.Text = "Nails_spa";
            this.Load += new System.EventHandler(this.Nails_spa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NailaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nailsSpaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautySalonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NailaData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Nailsspaapptlistbx;
        private BeautySalonDataSet beautySalonDataSet;
        private System.Windows.Forms.BindingSource nailsSpaBindingSource;
        private BeautySalonDataSetTableAdapters.Nails_SpaTableAdapter nails_SpaTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.Button nailspabookbtn;
    }
}