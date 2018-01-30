namespace PrivacyVault
{
    partial class frmRandomPassword
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
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.chkDigits = new System.Windows.Forms.CheckBox();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.SuspendLayout();
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Checked = true;
            this.chkUpper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpper.Location = new System.Drawing.Point(13, 26);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(166, 20);
            this.chkUpper.TabIndex = 0;
            this.chkUpper.Text = "Use Uppercase Letters";
            this.chkUpper.UseVisualStyleBackColor = true;
            // 
            // chkLower
            // 
            this.chkLower.AutoSize = true;
            this.chkLower.Checked = true;
            this.chkLower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLower.Location = new System.Drawing.Point(13, 52);
            this.chkLower.Name = "chkLower";
            this.chkLower.Size = new System.Drawing.Size(164, 20);
            this.chkLower.TabIndex = 1;
            this.chkLower.Text = "Use Lowercase Letters";
            this.chkLower.UseVisualStyleBackColor = true;
            // 
            // chkDigits
            // 
            this.chkDigits.AutoSize = true;
            this.chkDigits.Checked = true;
            this.chkDigits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDigits.Location = new System.Drawing.Point(13, 78);
            this.chkDigits.Name = "chkDigits";
            this.chkDigits.Size = new System.Drawing.Size(89, 20);
            this.chkDigits.TabIndex = 2;
            this.chkDigits.Text = "Use Digits";
            this.chkDigits.UseVisualStyleBackColor = true;
            // 
            // chkSymbols
            // 
            this.chkSymbols.AutoSize = true;
            this.chkSymbols.Checked = true;
            this.chkSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSymbols.Location = new System.Drawing.Point(12, 104);
            this.chkSymbols.Name = "chkSymbols";
            this.chkSymbols.Size = new System.Drawing.Size(187, 20);
            this.chkSymbols.TabIndex = 3;
            this.chkSymbols.Text = "Use Symbols (e.g. $ # @...)";
            this.chkSymbols.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password Length:";
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(136, 142);
            this.nudLength.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudLength.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(43, 22);
            this.nudLength.TabIndex = 5;
            this.nudLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(129, 181);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 36);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(226, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmRandomPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 229);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.nudLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkSymbols);
            this.Controls.Add(this.chkDigits);
            this.Controls.Add(this.chkLower);
            this.Controls.Add(this.chkUpper);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRandomPassword";
            this.Text = "Generate Random Password";
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.CheckBox chkDigits;
        private System.Windows.Forms.CheckBox chkSymbols;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}