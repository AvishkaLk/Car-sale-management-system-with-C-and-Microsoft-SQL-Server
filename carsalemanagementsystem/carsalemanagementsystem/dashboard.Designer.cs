namespace carsalemanagementsystem
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.buttoncarinfo = new System.Windows.Forms.Button();
            this.buttoncustomerinfo = new System.Windows.Forms.Button();
            this.buttonsalesinfo = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttoncarinfo
            // 
            this.buttoncarinfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttoncarinfo.BackgroundImage")));
            this.buttoncarinfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttoncarinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncarinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncarinfo.Location = new System.Drawing.Point(73, 71);
            this.buttoncarinfo.Name = "buttoncarinfo";
            this.buttoncarinfo.Size = new System.Drawing.Size(159, 243);
            this.buttoncarinfo.TabIndex = 0;
            this.buttoncarinfo.Text = "Car Info";
            this.buttoncarinfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttoncarinfo.UseVisualStyleBackColor = true;
            this.buttoncarinfo.Click += new System.EventHandler(this.buttoncarinfo_Click);
            // 
            // buttoncustomerinfo
            // 
            this.buttoncustomerinfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttoncustomerinfo.BackgroundImage")));
            this.buttoncustomerinfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttoncustomerinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncustomerinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncustomerinfo.Location = new System.Drawing.Point(314, 71);
            this.buttoncustomerinfo.Name = "buttoncustomerinfo";
            this.buttoncustomerinfo.Size = new System.Drawing.Size(159, 243);
            this.buttoncustomerinfo.TabIndex = 1;
            this.buttoncustomerinfo.Text = "Customer Info";
            this.buttoncustomerinfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttoncustomerinfo.UseVisualStyleBackColor = true;
            this.buttoncustomerinfo.Click += new System.EventHandler(this.buttoncustomerinfo_Click);
            // 
            // buttonsalesinfo
            // 
            this.buttonsalesinfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonsalesinfo.BackgroundImage")));
            this.buttonsalesinfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonsalesinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsalesinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsalesinfo.Location = new System.Drawing.Point(550, 71);
            this.buttonsalesinfo.Name = "buttonsalesinfo";
            this.buttonsalesinfo.Size = new System.Drawing.Size(159, 243);
            this.buttonsalesinfo.TabIndex = 2;
            this.buttonsalesinfo.Text = "Sales Info";
            this.buttonsalesinfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonsalesinfo.UseVisualStyleBackColor = true;
            this.buttonsalesinfo.Click += new System.EventHandler(this.buttonsalesinfo_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(229, 367);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(89, 39);
            this.buttonexit.TabIndex = 3;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttonback
            // 
            this.buttonback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonback.Location = new System.Drawing.Point(469, 367);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(89, 39);
            this.buttonback.TabIndex = 4;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonsalesinfo);
            this.Controls.Add(this.buttoncustomerinfo);
            this.Controls.Add(this.buttoncarinfo);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttoncarinfo;
        private System.Windows.Forms.Button buttoncustomerinfo;
        private System.Windows.Forms.Button buttonsalesinfo;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttonback;
    }
}