namespace PrivacyVault
{
    partial class frmChange_Password
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSpecial = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPwdMatch = new System.Windows.Forms.Label();
            this.lbl8chars = new System.Windows.Forms.Label();
            this.lblDigit = new System.Windows.Forms.Label();
            this.lblLower = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMustMatch = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(614, 205);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 63);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(125, 74);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '∙';
            this.txtNewPassword.Size = new System.Drawing.Size(236, 22);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(125, 123);
            this.txtConfirmNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.PasswordChar = '∙';
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(236, 22);
            this.txtConfirmNewPassword.TabIndex = 3;
            this.txtConfirmNewPassword.TextChanged += new System.EventHandler(this.txtConfirmNewPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Your password must contain:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirm Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Password:";
            // 
            // lblSpecial
            // 
            this.lblSpecial.AutoSize = true;
            this.lblSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecial.ForeColor = System.Drawing.Color.Red;
            this.lblSpecial.Location = new System.Drawing.Point(9, 166);
            this.lblSpecial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(240, 16);
            this.lblSpecial.TabIndex = 45;
            this.lblSpecial.Text = "Must contain at least 1 symbol (*%!, etc)";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(497, 205);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(109, 63);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Change Password";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblPwdMatch
            // 
            this.lblPwdMatch.AutoSize = true;
            this.lblPwdMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwdMatch.ForeColor = System.Drawing.Color.Red;
            this.lblPwdMatch.Location = new System.Drawing.Point(9, 197);
            this.lblPwdMatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwdMatch.Name = "lblPwdMatch";
            this.lblPwdMatch.Size = new System.Drawing.Size(145, 16);
            this.lblPwdMatch.TabIndex = 44;
            this.lblPwdMatch.Text = "Passwords must match";
            // 
            // lbl8chars
            // 
            this.lbl8chars.AutoSize = true;
            this.lbl8chars.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8chars.ForeColor = System.Drawing.Color.Red;
            this.lbl8chars.Location = new System.Drawing.Point(9, 135);
            this.lbl8chars.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl8chars.Name = "lbl8chars";
            this.lbl8chars.Size = new System.Drawing.Size(177, 16);
            this.lbl8chars.TabIndex = 43;
            this.lbl8chars.Text = "Must be at least 8 characters";
            // 
            // lblDigit
            // 
            this.lblDigit.AutoSize = true;
            this.lblDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigit.ForeColor = System.Drawing.Color.Red;
            this.lblDigit.Location = new System.Drawing.Point(9, 105);
            this.lblDigit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDigit.Name = "lblDigit";
            this.lblDigit.Size = new System.Drawing.Size(90, 16);
            this.lblDigit.TabIndex = 42;
            this.lblDigit.Text = "At least 1 digit";
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLower.ForeColor = System.Drawing.Color.Red;
            this.lblLower.Location = new System.Drawing.Point(9, 74);
            this.lblLower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(162, 16);
            this.lblLower.TabIndex = 41;
            this.lblLower.Text = "At least 1 lower case letter";
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpper.ForeColor = System.Drawing.Color.Red;
            this.lblUpper.Location = new System.Drawing.Point(9, 43);
            this.lblUpper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(165, 16);
            this.lblUpper.TabIndex = 40;
            this.lblUpper.Text = "At least 1 upper case letter";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOldPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblMustMatch);
            this.groupBox1.Controls.Add(this.txtNewPassword);
            this.groupBox1.Controls.Add(this.txtConfirmNewPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(347, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(376, 176);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reset Password";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.Location = new System.Drawing.Point(125, 25);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '∙';
            this.txtOldPassword.Size = new System.Drawing.Size(236, 22);
            this.txtOldPassword.TabIndex = 1;
            this.txtOldPassword.TextChanged += new System.EventHandler(this.txtOldPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Old Password:";
            // 
            // lblMustMatch
            // 
            this.lblMustMatch.AutoSize = true;
            this.lblMustMatch.ForeColor = System.Drawing.Color.Red;
            this.lblMustMatch.Location = new System.Drawing.Point(167, 138);
            this.lblMustMatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMustMatch.Name = "lblMustMatch";
            this.lblMustMatch.Size = new System.Drawing.Size(0, 16);
            this.lblMustMatch.TabIndex = 13;
            this.lblMustMatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmChange_Password
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 281);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSpecial);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPwdMatch);
            this.Controls.Add(this.lbl8chars);
            this.Controls.Add(this.lblDigit);
            this.Controls.Add(this.lblLower);
            this.Controls.Add(this.lblUpper);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmChange_Password";
            this.Text = "Privacy Valut - Change Password";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSpecial;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPwdMatch;
        private System.Windows.Forms.Label lbl8chars;
        private System.Windows.Forms.Label lblDigit;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMustMatch;
    }
}