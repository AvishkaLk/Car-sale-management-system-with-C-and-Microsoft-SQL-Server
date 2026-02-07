namespace carsalemanagementsystem
{
    partial class carinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carinfo));
            this.labelcarinfo = new System.Windows.Forms.Label();
            this.labelcarid = new System.Windows.Forms.Label();
            this.labelbrand = new System.Windows.Forms.Label();
            this.labelcolour = new System.Windows.Forms.Label();
            this.labelyear = new System.Windows.Forms.Label();
            this.labelprice = new System.Windows.Forms.Label();
            this.textboxcarid = new System.Windows.Forms.TextBox();
            this.textboxbrand = new System.Windows.Forms.TextBox();
            this.textboxcolour = new System.Windows.Forms.TextBox();
            this.textboxyear = new System.Windows.Forms.TextBox();
            this.textboxprice = new System.Windows.Forms.TextBox();
            this.buttonback = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttoninsert = new System.Windows.Forms.Button();
            this.datagridviewcarinfo = new System.Windows.Forms.DataGridView();
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carinfotableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csmsDataSet = new carsalemanagementsystem.csmsDataSet();
            this.buttonshowall = new System.Windows.Forms.Button();
            this.carsalemanagementsystemDataSet = new carsalemanagementsystem.carsalemanagementsystemDataSet();
            this.carinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carinfoTableAdapter = new carsalemanagementsystem.carsalemanagementsystemDataSetTableAdapters.carinfoTableAdapter();
            this.carinfotableTableAdapter = new carsalemanagementsystem.csmsDataSetTableAdapters.carinfotableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewcarinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carinfotableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsalemanagementsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelcarinfo
            // 
            this.labelcarinfo.AutoSize = true;
            this.labelcarinfo.BackColor = System.Drawing.Color.Transparent;
            this.labelcarinfo.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcarinfo.Location = new System.Drawing.Point(448, 5);
            this.labelcarinfo.Name = "labelcarinfo";
            this.labelcarinfo.Size = new System.Drawing.Size(104, 33);
            this.labelcarinfo.TabIndex = 0;
            this.labelcarinfo.Text = "Car Info";
            // 
            // labelcarid
            // 
            this.labelcarid.AutoSize = true;
            this.labelcarid.BackColor = System.Drawing.Color.Transparent;
            this.labelcarid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcarid.Location = new System.Drawing.Point(12, 51);
            this.labelcarid.Name = "labelcarid";
            this.labelcarid.Size = new System.Drawing.Size(47, 16);
            this.labelcarid.TabIndex = 1;
            this.labelcarid.Text = "CarID";
            // 
            // labelbrand
            // 
            this.labelbrand.AutoSize = true;
            this.labelbrand.BackColor = System.Drawing.Color.Transparent;
            this.labelbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbrand.Location = new System.Drawing.Point(12, 100);
            this.labelbrand.Name = "labelbrand";
            this.labelbrand.Size = new System.Drawing.Size(49, 16);
            this.labelbrand.TabIndex = 2;
            this.labelbrand.Text = "Brand";
            // 
            // labelcolour
            // 
            this.labelcolour.AutoSize = true;
            this.labelcolour.BackColor = System.Drawing.Color.Transparent;
            this.labelcolour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcolour.Location = new System.Drawing.Point(12, 153);
            this.labelcolour.Name = "labelcolour";
            this.labelcolour.Size = new System.Drawing.Size(53, 16);
            this.labelcolour.TabIndex = 3;
            this.labelcolour.Text = "Colour";
            // 
            // labelyear
            // 
            this.labelyear.AutoSize = true;
            this.labelyear.BackColor = System.Drawing.Color.Transparent;
            this.labelyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelyear.Location = new System.Drawing.Point(12, 207);
            this.labelyear.Name = "labelyear";
            this.labelyear.Size = new System.Drawing.Size(41, 16);
            this.labelyear.TabIndex = 4;
            this.labelyear.Text = "Year";
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.BackColor = System.Drawing.Color.Transparent;
            this.labelprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprice.Location = new System.Drawing.Point(12, 258);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(44, 16);
            this.labelprice.TabIndex = 5;
            this.labelprice.Text = "Price";
            // 
            // textboxcarid
            // 
            this.textboxcarid.Location = new System.Drawing.Point(15, 70);
            this.textboxcarid.Name = "textboxcarid";
            this.textboxcarid.Size = new System.Drawing.Size(201, 20);
            this.textboxcarid.TabIndex = 6;
            // 
            // textboxbrand
            // 
            this.textboxbrand.Location = new System.Drawing.Point(15, 119);
            this.textboxbrand.Name = "textboxbrand";
            this.textboxbrand.Size = new System.Drawing.Size(201, 20);
            this.textboxbrand.TabIndex = 7;
            this.textboxbrand.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textboxcolour
            // 
            this.textboxcolour.Location = new System.Drawing.Point(15, 172);
            this.textboxcolour.Name = "textboxcolour";
            this.textboxcolour.Size = new System.Drawing.Size(201, 20);
            this.textboxcolour.TabIndex = 8;
            // 
            // textboxyear
            // 
            this.textboxyear.Location = new System.Drawing.Point(15, 226);
            this.textboxyear.Name = "textboxyear";
            this.textboxyear.Size = new System.Drawing.Size(201, 20);
            this.textboxyear.TabIndex = 9;
            // 
            // textboxprice
            // 
            this.textboxprice.Location = new System.Drawing.Point(15, 277);
            this.textboxprice.Name = "textboxprice";
            this.textboxprice.Size = new System.Drawing.Size(201, 20);
            this.textboxprice.TabIndex = 10;
            // 
            // buttonback
            // 
            this.buttonback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonback.Location = new System.Drawing.Point(15, 303);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(99, 23);
            this.buttonback.TabIndex = 11;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclear.Location = new System.Drawing.Point(120, 303);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(99, 23);
            this.buttonclear.TabIndex = 12;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttonsearch
            // 
            this.buttonsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsearch.Location = new System.Drawing.Point(15, 332);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(99, 23);
            this.buttonsearch.TabIndex = 13;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(120, 332);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(99, 23);
            this.buttonexit.TabIndex = 14;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.Location = new System.Drawing.Point(15, 361);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(99, 23);
            this.buttondelete.TabIndex = 15;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdate.Location = new System.Drawing.Point(120, 361);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(99, 23);
            this.buttonupdate.TabIndex = 16;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttoninsert
            // 
            this.buttoninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoninsert.Location = new System.Drawing.Point(15, 390);
            this.buttoninsert.Name = "buttoninsert";
            this.buttoninsert.Size = new System.Drawing.Size(204, 23);
            this.buttoninsert.TabIndex = 17;
            this.buttoninsert.Text = "Insert";
            this.buttoninsert.UseVisualStyleBackColor = true;
            this.buttoninsert.Click += new System.EventHandler(this.buttoninsert_Click);
            // 
            // datagridviewcarinfo
            // 
            this.datagridviewcarinfo.AutoGenerateColumns = false;
            this.datagridviewcarinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewcarinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIDDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.colourDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.datagridviewcarinfo.DataSource = this.carinfotableBindingSource;
            this.datagridviewcarinfo.Location = new System.Drawing.Point(241, 70);
            this.datagridviewcarinfo.Name = "datagridviewcarinfo";
            this.datagridviewcarinfo.Size = new System.Drawing.Size(737, 343);
            this.datagridviewcarinfo.TabIndex = 18;
            this.datagridviewcarinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewcarinfo_CellClick);
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "CarID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "CarID";
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // colourDataGridViewTextBoxColumn
            // 
            this.colourDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colourDataGridViewTextBoxColumn.DataPropertyName = "Colour";
            this.colourDataGridViewTextBoxColumn.HeaderText = "Colour";
            this.colourDataGridViewTextBoxColumn.Name = "colourDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // carinfotableBindingSource
            // 
            this.carinfotableBindingSource.DataMember = "carinfotable";
            this.carinfotableBindingSource.DataSource = this.csmsDataSet;
            // 
            // csmsDataSet
            // 
            this.csmsDataSet.DataSetName = "csmsDataSet";
            this.csmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonshowall
            // 
            this.buttonshowall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshowall.Location = new System.Drawing.Point(241, 41);
            this.buttonshowall.Name = "buttonshowall";
            this.buttonshowall.Size = new System.Drawing.Size(737, 23);
            this.buttonshowall.TabIndex = 19;
            this.buttonshowall.Text = "Show All";
            this.buttonshowall.UseVisualStyleBackColor = true;
            this.buttonshowall.Click += new System.EventHandler(this.buttonshowall_Click);
            // 
            // carsalemanagementsystemDataSet
            // 
            this.carsalemanagementsystemDataSet.DataSetName = "carsalemanagementsystemDataSet";
            this.carsalemanagementsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carinfoBindingSource
            // 
            this.carinfoBindingSource.DataMember = "carinfo";
            this.carinfoBindingSource.DataSource = this.carsalemanagementsystemDataSet;
            // 
            // carinfoTableAdapter
            // 
            this.carinfoTableAdapter.ClearBeforeFill = true;
            // 
            // carinfotableTableAdapter
            // 
            this.carinfotableTableAdapter.ClearBeforeFill = true;
            // 
            // carinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 430);
            this.Controls.Add(this.buttonshowall);
            this.Controls.Add(this.datagridviewcarinfo);
            this.Controls.Add(this.buttoninsert);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.textboxprice);
            this.Controls.Add(this.textboxyear);
            this.Controls.Add(this.textboxcolour);
            this.Controls.Add(this.textboxbrand);
            this.Controls.Add(this.textboxcarid);
            this.Controls.Add(this.labelprice);
            this.Controls.Add(this.labelyear);
            this.Controls.Add(this.labelcolour);
            this.Controls.Add(this.labelbrand);
            this.Controls.Add(this.labelcarid);
            this.Controls.Add(this.labelcarinfo);
            this.Name = "carinfo";
            this.Text = "carinfo";
            this.Load += new System.EventHandler(this.carinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewcarinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carinfotableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsalemanagementsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carinfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelcarinfo;
        private System.Windows.Forms.Label labelcarid;
        private System.Windows.Forms.Label labelbrand;
        private System.Windows.Forms.Label labelcolour;
        private System.Windows.Forms.Label labelyear;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.TextBox textboxcarid;
        private System.Windows.Forms.TextBox textboxbrand;
        private System.Windows.Forms.TextBox textboxcolour;
        private System.Windows.Forms.TextBox textboxyear;
        private System.Windows.Forms.TextBox textboxprice;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttoninsert;
        private System.Windows.Forms.DataGridView datagridviewcarinfo;
        private System.Windows.Forms.Button buttonshowall;
        private carsalemanagementsystemDataSet carsalemanagementsystemDataSet;
        private System.Windows.Forms.BindingSource carinfoBindingSource;
        private carsalemanagementsystemDataSetTableAdapters.carinfoTableAdapter carinfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private csmsDataSet csmsDataSet;
        private System.Windows.Forms.BindingSource carinfotableBindingSource;
        private csmsDataSetTableAdapters.carinfotableTableAdapter carinfotableTableAdapter;
    }
}