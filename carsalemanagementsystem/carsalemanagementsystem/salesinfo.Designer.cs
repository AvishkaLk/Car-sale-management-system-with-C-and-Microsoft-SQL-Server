namespace carsalemanagementsystem
{
    partial class salesinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salesinfo));
            this.labelsalesinfo = new System.Windows.Forms.Label();
            this.labelsaleid = new System.Windows.Forms.Label();
            this.textboxsaleid = new System.Windows.Forms.TextBox();
            this.labelcustomerid = new System.Windows.Forms.Label();
            this.textboxcustomerid = new System.Windows.Forms.TextBox();
            this.labelcarid = new System.Windows.Forms.Label();
            this.textboxcarid = new System.Windows.Forms.TextBox();
            this.labelsaledate = new System.Windows.Forms.Label();
            this.textboxsaledate = new System.Windows.Forms.TextBox();
            this.labelsaleprice = new System.Windows.Forms.Label();
            this.textboxsaleprice = new System.Windows.Forms.TextBox();
            this.buttonback = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttoninsert = new System.Windows.Forms.Button();
            this.datagridviewsalesinfo = new System.Windows.Forms.DataGridView();
            this.saleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesinfotableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csmsDataSet2 = new carsalemanagementsystem.csmsDataSet2();
            this.buttonshowall = new System.Windows.Forms.Button();
            this.salesinfotableTableAdapter = new carsalemanagementsystem.csmsDataSet2TableAdapters.salesinfotableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewsalesinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesinfotableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csmsDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelsalesinfo
            // 
            this.labelsalesinfo.AutoSize = true;
            this.labelsalesinfo.BackColor = System.Drawing.Color.Transparent;
            this.labelsalesinfo.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsalesinfo.Location = new System.Drawing.Point(441, 9);
            this.labelsalesinfo.Name = "labelsalesinfo";
            this.labelsalesinfo.Size = new System.Drawing.Size(120, 33);
            this.labelsalesinfo.TabIndex = 1;
            this.labelsalesinfo.Text = "Sales Info";
            // 
            // labelsaleid
            // 
            this.labelsaleid.AutoSize = true;
            this.labelsaleid.BackColor = System.Drawing.Color.Transparent;
            this.labelsaleid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsaleid.Location = new System.Drawing.Point(12, 50);
            this.labelsaleid.Name = "labelsaleid";
            this.labelsaleid.Size = new System.Drawing.Size(55, 16);
            this.labelsaleid.TabIndex = 2;
            this.labelsaleid.Text = "SaleID";
            // 
            // textboxsaleid
            // 
            this.textboxsaleid.Location = new System.Drawing.Point(15, 69);
            this.textboxsaleid.Name = "textboxsaleid";
            this.textboxsaleid.Size = new System.Drawing.Size(201, 20);
            this.textboxsaleid.TabIndex = 7;
            // 
            // labelcustomerid
            // 
            this.labelcustomerid.AutoSize = true;
            this.labelcustomerid.BackColor = System.Drawing.Color.Transparent;
            this.labelcustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcustomerid.Location = new System.Drawing.Point(12, 106);
            this.labelcustomerid.Name = "labelcustomerid";
            this.labelcustomerid.Size = new System.Drawing.Size(88, 16);
            this.labelcustomerid.TabIndex = 8;
            this.labelcustomerid.Text = "CustomerID";
            // 
            // textboxcustomerid
            // 
            this.textboxcustomerid.Location = new System.Drawing.Point(15, 125);
            this.textboxcustomerid.Name = "textboxcustomerid";
            this.textboxcustomerid.Size = new System.Drawing.Size(201, 20);
            this.textboxcustomerid.TabIndex = 9;
            // 
            // labelcarid
            // 
            this.labelcarid.AutoSize = true;
            this.labelcarid.BackColor = System.Drawing.Color.Transparent;
            this.labelcarid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcarid.Location = new System.Drawing.Point(12, 158);
            this.labelcarid.Name = "labelcarid";
            this.labelcarid.Size = new System.Drawing.Size(47, 16);
            this.labelcarid.TabIndex = 10;
            this.labelcarid.Text = "CarID";
            // 
            // textboxcarid
            // 
            this.textboxcarid.Location = new System.Drawing.Point(15, 177);
            this.textboxcarid.Name = "textboxcarid";
            this.textboxcarid.Size = new System.Drawing.Size(201, 20);
            this.textboxcarid.TabIndex = 11;
            // 
            // labelsaledate
            // 
            this.labelsaledate.AutoSize = true;
            this.labelsaledate.BackColor = System.Drawing.Color.Transparent;
            this.labelsaledate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsaledate.Location = new System.Drawing.Point(12, 211);
            this.labelsaledate.Name = "labelsaledate";
            this.labelsaledate.Size = new System.Drawing.Size(73, 16);
            this.labelsaledate.TabIndex = 12;
            this.labelsaledate.Text = "SaleDate";
            // 
            // textboxsaledate
            // 
            this.textboxsaledate.Location = new System.Drawing.Point(15, 230);
            this.textboxsaledate.Name = "textboxsaledate";
            this.textboxsaledate.Size = new System.Drawing.Size(201, 20);
            this.textboxsaledate.TabIndex = 13;
            // 
            // labelsaleprice
            // 
            this.labelsaleprice.AutoSize = true;
            this.labelsaleprice.BackColor = System.Drawing.Color.Transparent;
            this.labelsaleprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsaleprice.Location = new System.Drawing.Point(12, 262);
            this.labelsaleprice.Name = "labelsaleprice";
            this.labelsaleprice.Size = new System.Drawing.Size(76, 16);
            this.labelsaleprice.TabIndex = 14;
            this.labelsaleprice.Text = "SalePrice";
            // 
            // textboxsaleprice
            // 
            this.textboxsaleprice.Location = new System.Drawing.Point(15, 281);
            this.textboxsaleprice.Name = "textboxsaleprice";
            this.textboxsaleprice.Size = new System.Drawing.Size(201, 20);
            this.textboxsaleprice.TabIndex = 15;
            // 
            // buttonback
            // 
            this.buttonback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonback.Location = new System.Drawing.Point(15, 307);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(99, 23);
            this.buttonback.TabIndex = 16;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclear.Location = new System.Drawing.Point(120, 307);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(99, 23);
            this.buttonclear.TabIndex = 17;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttonsearch
            // 
            this.buttonsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsearch.Location = new System.Drawing.Point(15, 336);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(99, 23);
            this.buttonsearch.TabIndex = 18;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(120, 336);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(99, 23);
            this.buttonexit.TabIndex = 19;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.Location = new System.Drawing.Point(15, 365);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(99, 23);
            this.buttondelete.TabIndex = 20;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdate.Location = new System.Drawing.Point(120, 365);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(99, 23);
            this.buttonupdate.TabIndex = 21;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttoninsert
            // 
            this.buttoninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoninsert.Location = new System.Drawing.Point(15, 394);
            this.buttoninsert.Name = "buttoninsert";
            this.buttoninsert.Size = new System.Drawing.Size(204, 23);
            this.buttoninsert.TabIndex = 22;
            this.buttoninsert.Text = "Insert";
            this.buttoninsert.UseVisualStyleBackColor = true;
            this.buttoninsert.Click += new System.EventHandler(this.buttoninsert_Click);
            // 
            // datagridviewsalesinfo
            // 
            this.datagridviewsalesinfo.AutoGenerateColumns = false;
            this.datagridviewsalesinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewsalesinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.carIDDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn});
            this.datagridviewsalesinfo.DataSource = this.salesinfotableBindingSource;
            this.datagridviewsalesinfo.Location = new System.Drawing.Point(242, 79);
            this.datagridviewsalesinfo.Name = "datagridviewsalesinfo";
            this.datagridviewsalesinfo.Size = new System.Drawing.Size(737, 343);
            this.datagridviewsalesinfo.TabIndex = 23;
            this.datagridviewsalesinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewsalesinfo_CellClick);
            // 
            // saleIDDataGridViewTextBoxColumn
            // 
            this.saleIDDataGridViewTextBoxColumn.DataPropertyName = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.HeaderText = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.Name = "saleIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "CarID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "CarID";
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            // 
            // salesinfotableBindingSource
            // 
            this.salesinfotableBindingSource.DataMember = "salesinfotable";
            this.salesinfotableBindingSource.DataSource = this.csmsDataSet2;
            // 
            // csmsDataSet2
            // 
            this.csmsDataSet2.DataSetName = "csmsDataSet2";
            this.csmsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonshowall
            // 
            this.buttonshowall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshowall.Location = new System.Drawing.Point(242, 50);
            this.buttonshowall.Name = "buttonshowall";
            this.buttonshowall.Size = new System.Drawing.Size(737, 23);
            this.buttonshowall.TabIndex = 24;
            this.buttonshowall.Text = "Show All";
            this.buttonshowall.UseVisualStyleBackColor = true;
            this.buttonshowall.Click += new System.EventHandler(this.buttonshowall_Click);
            // 
            // salesinfotableTableAdapter
            // 
            this.salesinfotableTableAdapter.ClearBeforeFill = true;
            // 
            // salesinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 431);
            this.Controls.Add(this.buttonshowall);
            this.Controls.Add(this.datagridviewsalesinfo);
            this.Controls.Add(this.buttoninsert);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.textboxsaleprice);
            this.Controls.Add(this.labelsaleprice);
            this.Controls.Add(this.textboxsaledate);
            this.Controls.Add(this.labelsaledate);
            this.Controls.Add(this.textboxcarid);
            this.Controls.Add(this.labelcarid);
            this.Controls.Add(this.textboxcustomerid);
            this.Controls.Add(this.labelcustomerid);
            this.Controls.Add(this.textboxsaleid);
            this.Controls.Add(this.labelsaleid);
            this.Controls.Add(this.labelsalesinfo);
            this.Name = "salesinfo";
            this.Text = "salesinfo";
            this.Load += new System.EventHandler(this.salesinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewsalesinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesinfotableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csmsDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelsalesinfo;
        private System.Windows.Forms.Label labelsaleid;
        private System.Windows.Forms.TextBox textboxsaleid;
        private System.Windows.Forms.Label labelcustomerid;
        private System.Windows.Forms.TextBox textboxcustomerid;
        private System.Windows.Forms.Label labelcarid;
        private System.Windows.Forms.TextBox textboxcarid;
        private System.Windows.Forms.Label labelsaledate;
        private System.Windows.Forms.TextBox textboxsaledate;
        private System.Windows.Forms.Label labelsaleprice;
        private System.Windows.Forms.TextBox textboxsaleprice;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttoninsert;
        private System.Windows.Forms.DataGridView datagridviewsalesinfo;
        private System.Windows.Forms.Button buttonshowall;
        private csmsDataSet2 csmsDataSet2;
        private System.Windows.Forms.BindingSource salesinfotableBindingSource;
        private csmsDataSet2TableAdapters.salesinfotableTableAdapter salesinfotableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
    }
}