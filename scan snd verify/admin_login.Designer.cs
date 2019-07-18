namespace scan_and_verify
{
    partial class admin_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_login));
            this.USERNAME = new System.Windows.Forms.Label();
            this.PROCEED = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // USERNAME
            // 
            this.USERNAME.AutoSize = true;
            this.USERNAME.Location = new System.Drawing.Point(48, 159);
            this.USERNAME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(93, 20);
            this.USERNAME.TabIndex = 0;
            this.USERNAME.Text = "USERNAME";
            // 
            // PROCEED
            // 
            this.PROCEED.Location = new System.Drawing.Point(170, 272);
            this.PROCEED.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PROCEED.Name = "PROCEED";
            this.PROCEED.Size = new System.Drawing.Size(260, 46);
            this.PROCEED.TabIndex = 1;
            this.PROCEED.Text = "PROCEED";
            this.PROCEED.UseVisualStyleBackColor = true;
            this.PROCEED.Click += new System.EventHandler(this.Button1_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(170, 156);
            this.user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(258, 28);
            this.user.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(170, 214);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(258, 28);
            this.pass.TabIndex = 4;
            this.pass.TextChanged += new System.EventHandler(this.Pass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "PASSWORD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(228, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "invalid password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(228, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "invalid username";
            // 
            // admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 370);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user);
            this.Controls.Add(this.PROCEED);
            this.Controls.Add(this.USERNAME);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "admin_login";
            this.Text = "admin_login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label USERNAME;
        private System.Windows.Forms.Button PROCEED;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}