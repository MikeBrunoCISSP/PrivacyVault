namespace PrivacyVault
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPasswords = new System.Windows.Forms.TabPage();
            this.dgvPasswords = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCards = new System.Windows.Forms.TabPage();
            this.dgvCards = new System.Windows.Forms.DataGridView();
            this.colCardType = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPasswords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).BeginInit();
            this.tabCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPasswords);
            this.tabControl1.Controls.Add(this.tabCards);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 385);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPasswords
            // 
            this.tabPasswords.Controls.Add(this.dgvPasswords);
            this.tabPasswords.Location = new System.Drawing.Point(4, 25);
            this.tabPasswords.Name = "tabPasswords";
            this.tabPasswords.Padding = new System.Windows.Forms.Padding(3);
            this.tabPasswords.Size = new System.Drawing.Size(846, 356);
            this.tabPasswords.TabIndex = 0;
            this.tabPasswords.Text = "Internet Accounts";
            this.tabPasswords.UseVisualStyleBackColor = true;
            // 
            // dgvPasswords
            // 
            this.dgvPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPasswords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colUserName,
            this.colPassword,
            this.colURL});
            this.dgvPasswords.Location = new System.Drawing.Point(7, 7);
            this.dgvPasswords.Name = "dgvPasswords";
            this.dgvPasswords.Size = new System.Drawing.Size(833, 343);
            this.dgvPasswords.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name/Description";
            this.colName.Name = "colName";
            this.colName.Width = 150;
            // 
            // colUserName
            // 
            this.colUserName.HeaderText = "Username";
            this.colUserName.Name = "colUserName";
            this.colUserName.Width = 150;
            // 
            // colPassword
            // 
            this.colPassword.HeaderText = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Width = 150;
            // 
            // colURL
            // 
            this.colURL.HeaderText = "Web Address";
            this.colURL.Name = "colURL";
            this.colURL.Width = 340;
            // 
            // tabCards
            // 
            this.tabCards.Controls.Add(this.dgvCards);
            this.tabCards.Location = new System.Drawing.Point(4, 25);
            this.tabCards.Name = "tabCards";
            this.tabCards.Padding = new System.Windows.Forms.Padding(3);
            this.tabCards.Size = new System.Drawing.Size(846, 356);
            this.tabCards.TabIndex = 1;
            this.tabCards.Text = "Payment Cards";
            this.tabCards.UseVisualStyleBackColor = true;
            // 
            // dgvCards
            // 
            this.dgvCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCardType,
            this.Nickname,
            this.colCCN,
            this.colExp,
            this.colCCV,
            this.colWebsite});
            this.dgvCards.Location = new System.Drawing.Point(7, 7);
            this.dgvCards.Name = "dgvCards";
            this.dgvCards.Size = new System.Drawing.Size(833, 343);
            this.dgvCards.TabIndex = 1;
            // 
            // colCardType
            // 
            this.colCardType.Frozen = true;
            this.colCardType.HeaderText = "Card Type";
            this.colCardType.Name = "colCardType";
            this.colCardType.ReadOnly = true;
            this.colCardType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Nickname
            // 
            this.Nickname.Frozen = true;
            this.Nickname.HeaderText = "Nickname";
            this.Nickname.Name = "Nickname";
            // 
            // colCCN
            // 
            this.colCCN.Frozen = true;
            this.colCCN.HeaderText = "Card Number";
            this.colCCN.Name = "colCCN";
            this.colCCN.Width = 200;
            // 
            // colExp
            // 
            this.colExp.Frozen = true;
            this.colExp.HeaderText = "Exp Date";
            this.colExp.Name = "colExp";
            // 
            // colCCV
            // 
            this.colCCV.Frozen = true;
            this.colCCV.HeaderText = "CCV Code";
            this.colCCV.Name = "colCCV";
            // 
            // colWebsite
            // 
            this.colWebsite.Frozen = true;
            this.colWebsite.HeaderText = "Web Address";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.Width = 290;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 547);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Privacy Vault";
            this.tabControl1.ResumeLayout(false);
            this.tabPasswords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).EndInit();
            this.tabCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPasswords;
        private System.Windows.Forms.DataGridView dgvPasswords;
        private System.Windows.Forms.TabPage tabCards;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colURL;
        private System.Windows.Forms.DataGridView dgvCards;
        private System.Windows.Forms.DataGridViewImageColumn colCardType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWebsite;
    }
}

