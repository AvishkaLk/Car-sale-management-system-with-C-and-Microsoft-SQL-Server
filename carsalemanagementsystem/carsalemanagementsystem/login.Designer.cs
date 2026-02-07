namespace carsalemanagementsystem
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.labelcsms = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.textboxusername = new System.Windows.Forms.TextBox();
            this.textboxpassword = new System.Windows.Forms.TextBox();
            this.pictureboxuser = new System.Windows.Forms.PictureBox();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxuser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelcsms
            // 
            this.labelcsms.AutoSize = true;
            this.labelcsms.BackColor = System.Drawing.Color.Transparent;
            this.labelcsms.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcsms.Location = new System.Drawing.Point(192, 9);
            this.labelcsms.Name = "labelcsms";
            this.labelcsms.Size = new System.Drawing.Size(411, 43);
            this.labelcsms.TabIndex = 0;
            this.labelcsms.Text = "Car Sale Management System";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.BackColor = System.Drawing.Color.Transparent;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.Location = new System.Drawing.Point(33, 349);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(79, 16);
            this.labelusername.TabIndex = 1;
            this.labelusername.Text = "Username";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.BackColor = System.Drawing.Color.Transparent;
            this.labelpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.Location = new System.Drawing.Point(33, 386);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(76, 16);
            this.labelpassword.TabIndex = 2;
            this.labelpassword.Text = "Password";
            // 
            // textboxusername
            // 
            this.textboxusername.Location = new System.Drawing.Point(137, 345);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(176, 20);
            this.textboxusername.TabIndex = 3;
            // 
            // textboxpassword
            // 
            this.textboxpassword.Location = new System.Drawing.Point(137, 382);
            this.textboxpassword.Name = "textboxpassword";
            this.textboxpassword.PasswordChar = '*';
            this.textboxpassword.Size = new System.Drawing.Size(176, 20);
            this.textboxpassword.TabIndex = 4;
            // 
            // pictureboxuser
            // 
            this.pictureboxuser.BackColor = System.Drawing.Color.Transparent;
            this.pictureboxuser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureboxuser.BackgroundImage")));
            this.pictureboxuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureboxuser.Location = new System.Drawing.Point(106, 120);
            this.pictureboxuser.Name = "pictureboxuser";
            this.pictureboxuser.Size = new System.Drawing.Size(136, 135);
            this.pictureboxuser.TabIndex = 5;
            this.pictureboxuser.TabStop = false;
            // 
            // buttonclear
            // 
            this.buttonclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclear.Location = new System.Drawing.Point(528, 375);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(75, 27);
            this.buttonclear.TabIndex = 7;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttonlogin
            // 
            this.buttonlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.Location = new System.Drawing.Point(673, 375);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(75, 27);
            this.buttonlogin.TabIndex = 8;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(383, 375);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(75, 27);
            this.buttonexit.TabIndex = 9;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.pictureboxuser);
            this.Controls.Add(this.textboxpassword);
            this.Controls.Add(this.textboxusername);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.labelcsms);
            this.Name = "login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelcsms;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox textboxusername;
        private System.Windows.Forms.TextBox textboxpassword;
        private System.Windows.Forms.PictureBox pictureboxuser;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttonexit;
    }
}

