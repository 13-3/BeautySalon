namespace BeautySalon
{
    partial class MaisonDeJoelle
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
            this.MaisonData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Maisondeapptslisbx = new System.Windows.Forms.ListBox();
            this.maisondejoelleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beautySalonDataSet1 = new BeautySalon.BeautySalonDataSet1();
            this.maison_de_joelleTableAdapter = new BeautySalon.BeautySalonDataSet1TableAdapters.Maison_de_joelleTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.maisonBookbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MaisonData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maisondejoelleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautySalonDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // MaisonData
            // 
            this.MaisonData.BackgroundColor = System.Drawing.Color.SeaShell;
            this.MaisonData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaisonData.Location = new System.Drawing.Point(61, 163);
            this.MaisonData.Name = "MaisonData";
            this.MaisonData.RowHeadersWidth = 82;
            this.MaisonData.RowTemplate.Height = 33;
            this.MaisonData.Size = new System.Drawing.Size(956, 416);
            this.MaisonData.TabIndex = 0;
            this.MaisonData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MaisonData_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1201, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointments";
            // 
            // Maisondeapptslisbx
            // 
            this.Maisondeapptslisbx.DataSource = this.maisondejoelleBindingSource;
            this.Maisondeapptslisbx.DisplayMember = "appointment";
            this.Maisondeapptslisbx.FormattingEnabled = true;
            this.Maisondeapptslisbx.ItemHeight = 25;
            this.Maisondeapptslisbx.Location = new System.Drawing.Point(1079, 375);
            this.Maisondeapptslisbx.Name = "Maisondeapptslisbx";
            this.Maisondeapptslisbx.Size = new System.Drawing.Size(419, 204);
            this.Maisondeapptslisbx.TabIndex = 2;
            this.Maisondeapptslisbx.SelectedIndexChanged += new System.EventHandler(this.Maisondeapptslisbx_SelectedIndexChanged);
            // 
            // maisondejoelleBindingSource
            // 
            this.maisondejoelleBindingSource.DataMember = "Maison_de_joelle";
            this.maisondejoelleBindingSource.DataSource = this.beautySalonDataSet1;
            // 
            // beautySalonDataSet1
            // 
            this.beautySalonDataSet1.DataSetName = "BeautySalonDataSet1";
            this.beautySalonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maison_de_joelleTableAdapter
            // 
            this.maison_de_joelleTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1745, 25);
            this.fillByToolStrip.TabIndex = 3;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // maisonBookbtn
            // 
            this.maisonBookbtn.Location = new System.Drawing.Point(1206, 719);
            this.maisonBookbtn.Name = "maisonBookbtn";
            this.maisonBookbtn.Size = new System.Drawing.Size(221, 76);
            this.maisonBookbtn.TabIndex = 4;
            this.maisonBookbtn.Text = "Book";
            this.maisonBookbtn.UseVisualStyleBackColor = true;
            this.maisonBookbtn.Click += new System.EventHandler(this.maisonBookbtn_Click);
            // 
            // MaisonDeJoelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeautySalon.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(1745, 1033);
            this.Controls.Add(this.maisonBookbtn);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.Maisondeapptslisbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaisonData);
            this.Name = "MaisonDeJoelle";
            this.Text = "MaisonDeJoelle";
            this.Load += new System.EventHandler(this.MaisonDeJoelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaisonData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maisondejoelleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautySalonDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MaisonData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Maisondeapptslisbx;
        private BeautySalonDataSet1 beautySalonDataSet1;
        private System.Windows.Forms.BindingSource maisondejoelleBindingSource;
        private BeautySalonDataSet1TableAdapters.Maison_de_joelleTableAdapter maison_de_joelleTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.Button maisonBookbtn;
    }
}