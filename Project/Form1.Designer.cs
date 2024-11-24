namespace Project
{
    partial class Form1
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
            this.lbllogin = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.Location = new System.Drawing.Point(54, 56);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(112, 39);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "Log In";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(350, 240);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(261, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(350, 163);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(261, 22);
            this.txtusername.TabIndex = 2;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(216, 243);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(73, 16);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Password :";
            this.lblpassword.Click += new System.EventHandler(this.lblpassword_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(213, 166);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(76, 16);
            this.lblusername.TabIndex = 4;
            this.lblusername.Text = "Username :";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(350, 318);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(127, 57);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Log In";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(512, 318);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(127, 57);
            this.btnregister.TabIndex = 6;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 605);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbllogin);
            this.Name = "Form1";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnregister;
    }
}

