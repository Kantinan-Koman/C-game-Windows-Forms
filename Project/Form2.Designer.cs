namespace Project
{
    partial class Form2
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
            this.lblregister = new System.Windows.Forms.Label();
            this.lblusername2 = new System.Windows.Forms.Label();
            this.lblpassword2 = new System.Windows.Forms.Label();
            this.txtusername2 = new System.Windows.Forms.TextBox();
            this.txtpassword2 = new System.Windows.Forms.TextBox();
            this.lblConpassword = new System.Windows.Forms.Label();
            this.txtConpassword = new System.Windows.Forms.TextBox();
            this.btnregister2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblregister
            // 
            this.lblregister.AutoSize = true;
            this.lblregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregister.Location = new System.Drawing.Point(46, 44);
            this.lblregister.Name = "lblregister";
            this.lblregister.Size = new System.Drawing.Size(144, 39);
            this.lblregister.TabIndex = 0;
            this.lblregister.Text = "Register";
            // 
            // lblusername2
            // 
            this.lblusername2.AutoSize = true;
            this.lblusername2.Location = new System.Drawing.Point(178, 158);
            this.lblusername2.Name = "lblusername2";
            this.lblusername2.Size = new System.Drawing.Size(76, 16);
            this.lblusername2.TabIndex = 1;
            this.lblusername2.Text = "Username :";
            // 
            // lblpassword2
            // 
            this.lblpassword2.AutoSize = true;
            this.lblpassword2.Location = new System.Drawing.Point(181, 233);
            this.lblpassword2.Name = "lblpassword2";
            this.lblpassword2.Size = new System.Drawing.Size(73, 16);
            this.lblpassword2.TabIndex = 2;
            this.lblpassword2.Text = "Password :";
            // 
            // txtusername2
            // 
            this.txtusername2.Location = new System.Drawing.Point(302, 152);
            this.txtusername2.Name = "txtusername2";
            this.txtusername2.Size = new System.Drawing.Size(223, 22);
            this.txtusername2.TabIndex = 3;
            // 
            // txtpassword2
            // 
            this.txtpassword2.Location = new System.Drawing.Point(302, 230);
            this.txtpassword2.Name = "txtpassword2";
            this.txtpassword2.Size = new System.Drawing.Size(223, 22);
            this.txtpassword2.TabIndex = 4;
            // 
            // lblConpassword
            // 
            this.lblConpassword.AutoSize = true;
            this.lblConpassword.Location = new System.Drawing.Point(133, 305);
            this.lblConpassword.Name = "lblConpassword";
            this.lblConpassword.Size = new System.Drawing.Size(121, 16);
            this.lblConpassword.TabIndex = 5;
            this.lblConpassword.Text = "Confrim Password :";
            // 
            // txtConpassword
            // 
            this.txtConpassword.Location = new System.Drawing.Point(302, 302);
            this.txtConpassword.Name = "txtConpassword";
            this.txtConpassword.Size = new System.Drawing.Size(223, 22);
            this.txtConpassword.TabIndex = 6;
            // 
            // btnregister2
            // 
            this.btnregister2.Location = new System.Drawing.Point(340, 387);
            this.btnregister2.Name = "btnregister2";
            this.btnregister2.Size = new System.Drawing.Size(139, 54);
            this.btnregister2.TabIndex = 7;
            this.btnregister2.Text = "Register";
            this.btnregister2.UseVisualStyleBackColor = true;
            this.btnregister2.Click += new System.EventHandler(this.btnregister2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 605);
            this.Controls.Add(this.btnregister2);
            this.Controls.Add(this.txtConpassword);
            this.Controls.Add(this.lblConpassword);
            this.Controls.Add(this.txtpassword2);
            this.Controls.Add(this.txtusername2);
            this.Controls.Add(this.lblpassword2);
            this.Controls.Add(this.lblusername2);
            this.Controls.Add(this.lblregister);
            this.Name = "Form2";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblregister;
        private System.Windows.Forms.Label lblusername2;
        private System.Windows.Forms.Label lblpassword2;
        private System.Windows.Forms.TextBox txtusername2;
        private System.Windows.Forms.TextBox txtpassword2;
        private System.Windows.Forms.Label lblConpassword;
        private System.Windows.Forms.TextBox txtConpassword;
        private System.Windows.Forms.Button btnregister2;
    }
}