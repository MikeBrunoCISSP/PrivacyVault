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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPasswords = new System.Windows.Forms.TabPage();
            this.dgvPasswords = new System.Windows.Forms.DataGridView();
            this.tabCards = new System.Windows.Forms.TabPage();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCardType = new System.Windows.Forms.DataGridViewImageColumn();
            this.colCCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPasswords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).BeginInit();
            this.tabCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPasswords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            // tabCards
            // 
            this.tabCards.Controls.Add(this.dataGridView1);
            this.tabCards.Location = new System.Drawing.Point(4, 25);
            this.tabCards.Name = "tabCards";
            this.tabCards.Padding = new System.Windows.Forms.Padding(3);
            this.tabCards.Size = new System.Drawing.Size(846, 356);
            this.tabCards.TabIndex = 1;
            this.tabCards.Text = "Credit Cards";
            this.tabCards.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCardType,
            this.colCCN,
            this.colExp,
            this.colCCV,
            this.colWebsite});
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(833, 343);
            this.dataGridView1.TabIndex = 1;
            // 
            // colCardType
            // 
            this.colCardType.Frozen = true;
            this.colCardType.HeaderText = "Card Type";
            this.colCardType.Name = "colCardType";
            this.colCardType.ReadOnly = true;
            this.colCardType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn colCardType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWebsite;
    }
}

