namespace PrivacyVault
{
    partial class frmRecovery
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
            this.gB1 = new System.Windows.Forms.GroupBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.lblQuestion3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.gB1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB1
            // 
            this.gB1.Controls.Add(this.txtAnswer1);
            this.gB1.Controls.Add(this.lblQuestion1);
            this.gB1.Location = new System.Drawing.Point(17, 16);
            this.gB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gB1.Name = "gB1";
            this.gB1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gB1.Size = new System.Drawing.Size(477, 92);
            this.gB1.TabIndex = 0;
            this.gB1.TabStop = false;
            this.gB1.Text = "Question #1";
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Location = new System.Drawing.Point(16, 52);
            this.txtAnswer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.PasswordChar = '∙';
            this.txtAnswer1.Size = new System.Drawing.Size(439, 22);
            this.txtAnswer1.TabIndex = 1;
            this.txtAnswer1.TextChanged += new System.EventHandler(this.txtAnswer1_TextChanged);
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.AutoSize = true;
            this.lblQuestion1.Location = new System.Drawing.Point(15, 32);
            this.lblQuestion1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(74, 16);
            this.lblQuestion1.TabIndex = 0;
            this.lblQuestion1.Text = "Question 1:";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.txtAnswer2);
            this.gb2.Controls.Add(this.lblQuestion2);
            this.gb2.Location = new System.Drawing.Point(17, 116);
            this.gb2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb2.Name = "gb2";
            this.gb2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb2.Size = new System.Drawing.Size(477, 92);
            this.gb2.TabIndex = 2;
            this.gb2.TabStop = false;
            this.gb2.Text = "Question #2";
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(16, 52);
            this.txtAnswer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.PasswordChar = '∙';
            this.txtAnswer2.Size = new System.Drawing.Size(439, 22);
            this.txtAnswer2.TabIndex = 1;
            this.txtAnswer2.TextChanged += new System.EventHandler(this.txtAnswer2_TextChanged);
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.AutoSize = true;
            this.lblQuestion2.Location = new System.Drawing.Point(15, 32);
            this.lblQuestion2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(74, 16);
            this.lblQuestion2.TabIndex = 0;
            this.lblQuestion2.Text = "Question 2:";
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.txtAnswer3);
            this.gb3.Controls.Add(this.lblQuestion3);
            this.gb3.Location = new System.Drawing.Point(17, 215);
            this.gb3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb3.Name = "gb3";
            this.gb3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb3.Size = new System.Drawing.Size(477, 92);
            this.gb3.TabIndex = 3;
            this.gb3.TabStop = false;
            this.gb3.Text = "Question #3";
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.Location = new System.Drawing.Point(16, 52);
            this.txtAnswer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.PasswordChar = '∙';
            this.txtAnswer3.Size = new System.Drawing.Size(439, 22);
            this.txtAnswer3.TabIndex = 1;
            this.txtAnswer3.TextChanged += new System.EventHandler(this.txtAnswer3_TextChanged);
            // 
            // lblQuestion3
            // 
            this.lblQuestion3.AutoSize = true;
            this.lblQuestion3.Location = new System.Drawing.Point(15, 32);
            this.lblQuestion3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion3.Name = "lblQuestion3";
            this.lblQuestion3.Size = new System.Drawing.Size(74, 16);
            this.lblQuestion3.TabIndex = 0;
            this.lblQuestion3.Text = "Question 3:";
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(395, 319);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 40);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrect.Location = new System.Drawing.Point(29, 325);
            this.lblIncorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(0, 16);
            this.lblIncorrect.TabIndex = 5;
            // 
            // frmRecovery
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 372);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gB1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmRecovery";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Privacy Vault - Recover Profile";
            this.gB1.ResumeLayout(false);
            this.gB1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb3.ResumeLayout(false);
            this.gb3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gB1;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.Label lblQuestion3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblIncorrect;

    }
}