namespace carsalemanagementsystem
{
    partial class customerinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerinfo));
            this.labelcustomerinfo = new System.Windows.Forms.Label();
            this.labelcustomerid = new System.Windows.Forms.Label();
            this.textboxcustomerid = new System.Windows.Forms.TextBox();
            this.labelbrand = new System.Windows.Forms.Label();
            this.textboxname = new System.Windows.Forms.TextBox();
            this.labeladdress = new System.Windows.Forms.Label();
            this.textboxaddress = new System.Windows.Forms.TextBox();
            this.labeltelno = new System.Windows.Forms.Label();
            this.textboxtelno = new System.Windows.Forms.TextBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.textboxemail = new System.Windows.Forms.TextBox();
            this.buttonback = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.datagridviewcustomerinfo = new System.Windows.Forms.DataGridView();
            this.buttonshowall = new System.Windows.Forms.Button();
            this.csmsDataSet1 = new carsalemanagementsystem.csmsDataSet1();
            this.customerinfotableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerinfotableTableAdapter = new carsalemanagementsystem.csmsDataSet1TableAdapters.customerinfotableTableAdapter();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttoninsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewcustomerinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csmsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerinfotableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelcustomerinfo
            // 
            this.labelcustomerinfo.AutoSize = true;
            this.labelcustomerinfo.BackColor = System.Drawing.Color.Transparent;
            this.labelcustomerinfo.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcustomerinfo.Location = new System.Drawing.Point(418, 9);
            this.labelcustomerinfo.Name = "labelcustomerinfo";
            this.labelcustomerinfo.Size = new System.Drawing.Size(165, 33);
            this.labelcustomerinfo.TabIndex = 1;
            this.labelcustomerinfo.Text = "Customer Info";
            // 
            // labelcustomerid
            // 
            this.labelcustomerid.AutoSize = true;
            this.labelcustomerid.BackColor = System.Drawing.Color.Transparent;
            this.labelcustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcustomerid.Location = new System.Drawing.Point(12, 51);
            this.labelcustomerid.Name = "labelcustomerid";
            this.labelcustomerid.Size = new System.Drawing.Size(88, 16);
            this.labelcustomerid.TabIndex = 2;
            this.labelcustomerid.Text = "CustomerID";
            // 
            // textboxcustomerid
            // 
            this.textboxcustomerid.Location = new System.Drawing.Point(15, 70);
            this.textboxcustomerid.Name = "textboxcustomerid";
            this.textboxcustomerid.Size = new System.Drawing.Size(201, 20);
            this.textboxcustomerid.TabIndex = 7;
            // 
            // labelbrand
            // 
            this.labelbrand.AutoSize = true;
            this.labelbrand.BackColor = System.Drawing.Color.Transparent;
            this.labelbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbrand.Location = new System.Drawing.Point(12, 102);
            this.labelbrand.Name = "labelbrand";
            this.labelbrand.Size = new System.Drawing.Size(49, 16);
            this.labelbrand.TabIndex = 8;
            this.labelbrand.Text = "Name";
            this.labelbrand.Click += new System.EventHandler(this.labelbrand_Click);
            // 
            // textboxname
            // 
            this.textboxname.Location = new System.Drawing.Point(15, 121);
            this.textboxname.Name = "textboxname";
            this.textboxname.Size = new System.Drawing.Size(201, 20);
            this.textboxname.TabIndex = 9;
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.BackColor = System.Drawing.Color.Transparent;
            this.labeladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladdress.Location = new System.Drawing.Point(12, 156);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(66, 16);
            this.labeladdress.TabIndex = 10;
            this.labeladdress.Text = "Address";
            // 
            // textboxaddress
            // 
            this.textboxaddress.Location = new System.Drawing.Point(15, 175);
            this.textboxaddress.Name = "textboxaddress";
            this.textboxaddress.Size = new System.Drawing.Size(201, 20);
            this.textboxaddress.TabIndex = 11;
            // 
            // labeltelno
            // 
            this.labeltelno.AutoSize = true;
            this.labeltelno.BackColor = System.Drawing.Color.Transparent;
            this.labeltelno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltelno.Location = new System.Drawing.Point(12, 212);
            this.labeltelno.Name = "labeltelno";
            this.labeltelno.Size = new System.Drawing.Size(51, 16);
            this.labeltelno.TabIndex = 12;
            this.labeltelno.Text = "TelNo";
            // 
            // textboxtelno
            // 
            this.textboxtelno.Location = new System.Drawing.Point(15, 231);
            this.textboxtelno.Name = "textboxtelno";
            this.textboxtelno.Size = new System.Drawing.Size(201, 20);
            this.textboxtelno.TabIndex = 13;
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.BackColor = System.Drawing.Color.Transparent;
            this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(12, 264);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(47, 16);
            this.labelemail.TabIndex = 14;
            this.labelemail.Text = "Email";
            // 
            // textboxemail
            // 
            this.textboxemail.Location = new System.Drawing.Point(15, 283);
            this.textboxemail.Name = "textboxemail";
            this.textboxemail.Size = new System.Drawing.Size(201, 20);
            this.textboxemail.TabIndex = 15;
            // 
            // buttonback
            // 
            this.buttonback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonback.Location = new System.Drawing.Point(15, 309);
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
            this.buttonclear.Location = new System.Drawing.Point(117, 309);
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
            this.buttonsearch.Location = new System.Drawing.Point(15, 338);
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
            this.buttonexit.Location = new System.Drawing.Point(117, 338);
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
            this.buttondelete.Location = new System.Drawing.Point(15, 367);
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
            this.buttonupdate.Location = new System.Drawing.Point(117, 367);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(99, 23);
            this.buttonupdate.TabIndex = 21;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // datagridviewcustomerinfo
            // 
            this.datagridviewcustomerinfo.AutoGenerateColumns = false;
            this.datagridviewcustomerinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewcustomerinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.datagridviewcustomerinfo.DataSource = this.customerinfotableBindingSource;
            this.datagridviewcustomerinfo.Location = new System.Drawing.Point(241, 80);
            this.datagridviewcustomerinfo.Name = "datagridviewcustomerinfo";
            this.datagridviewcustomerinfo.Size = new System.Drawing.Size(737, 343);
            this.datagridviewcustomerinfo.TabIndex = 23;
            this.datagridviewcustomerinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewcustomerinfo_CellClick);
            // 
            // buttonshowall
            // 
            this.buttonshowall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshowall.Location = new System.Drawing.Point(241, 51);
            this.buttonshowall.Name = "buttonshowall";
            this.buttonshowall.Size = new System.Drawing.Size(737, 23);
            this.buttonshowall.TabIndex = 24;
            this.buttonshowall.Text = "Show All";
            this.buttonshowall.UseVisualStyleBackColor = true;
            this.buttonshowall.Click += new System.EventHandler(this.buttonshowall_Click);
            // 
            // csmsDataSet1
            // 
            this.csmsDataSet1.DataSetName = "csmsDataSet1";
            this.csmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerinfotableBindingSource
            // 
            this.customerinfotableBindingSource.DataMember = "customerinfotable";
            this.customerinfotableBindingSource.DataSource = this.csmsDataSet1;
            // 
            // customerinfotableTableAdapter
            // 
            this.customerinfotableTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // telNoDataGridViewTextBoxColumn
            // 
            this.telNoDataGridViewTextBoxColumn.DataPropertyName = "TelNo";
            this.telNoDataGridViewTextBoxColumn.HeaderText = "TelNo";
            this.telNoDataGridViewTextBoxColumn.Name = "telNoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // buttoninsert
            // 
            this.buttoninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoninsert.Location = new System.Drawing.Point(15, 396);
            this.buttoninsert.Name = "buttoninsert";
            this.buttoninsert.Size = new System.Drawing.Size(201, 23);
            this.buttoninsert.TabIndex = 25;
            this.buttoninsert.Text = "Insert";
            this.buttoninsert.UseVisualStyleBackColor = true;
            this.buttoninsert.Click += new System.EventHandler(this.buttoninsert_Click);
            // 
            // customerinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 435);
            this.Controls.Add(this.buttoninsert);
            this.Controls.Add(this.buttonshowall);
            this.Controls.Add(this.datagridviewcustomerinfo);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.textboxemail);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.textboxtelno);
            this.Controls.Add(this.labeltelno);
            this.Controls.Add(this.textboxaddress);
            this.Controls.Add(this.labeladdress);
            this.Controls.Add(this.textboxname);
            this.Controls.Add(this.labelbrand);
            this.Controls.Add(this.textboxcustomerid);
            this.Controls.Add(this.labelcustomerid);
            this.Controls.Add(this.labelcustomerinfo);
            this.Name = "customerinfo";
            this.Text = "customerinfo";
            this.Load += new System.EventHandler(this.customerinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewcustomerinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csmsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerinfotableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelcustomerinfo;
        private System.Windows.Forms.Label labelcustomerid;
        private System.Windows.Forms.TextBox textboxcustomerid;
        private System.Windows.Forms.Label labelbrand;
        private System.Windows.Forms.TextBox textboxname;
        private System.Windows.Forms.Label labeladdress;
        private System.Windows.Forms.TextBox textboxaddress;
        private System.Windows.Forms.Label labeltelno;
        private System.Windows.Forms.TextBox textboxtelno;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox textboxemail;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.DataGridView datagridviewcustomerinfo;
        private System.Windows.Forms.Button buttonshowall;
        private csmsDataSet1 csmsDataSet1;
        private System.Windows.Forms.BindingSource customerinfotableBindingSource;
        private csmsDataSet1TableAdapters.customerinfotableTableAdapter customerinfotableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttoninsert;
    }
}