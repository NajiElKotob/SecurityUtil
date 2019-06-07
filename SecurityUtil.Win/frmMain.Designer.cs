namespace SecurityUtil.Win
{
    partial class frmMain
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
            this.btnGUID = new System.Windows.Forms.Button();
            this.txtGUID = new System.Windows.Forms.TextBox();
            this.btnProcessorId = new System.Windows.Forms.Button();
            this.txtProcessorId = new System.Windows.Forms.TextBox();
            this.txtHardDriveSN1 = new System.Windows.Forms.TextBox();
            this.btnHardDriveSN = new System.Windows.Forms.Button();
            this.txtHardDriveSN2 = new System.Windows.Forms.TextBox();
            this.btnVSN = new System.Windows.Forms.Button();
            this.txtHashing = new System.Windows.Forms.TextBox();
            this.btnComputeHash = new System.Windows.Forms.Button();
            this.btnMACAddresses = new System.Windows.Forms.Button();
            this.cboMACAddresses = new System.Windows.Forms.ComboBox();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGUID
            // 
            this.btnGUID.Location = new System.Drawing.Point(10, 12);
            this.btnGUID.Name = "btnGUID";
            this.btnGUID.Size = new System.Drawing.Size(167, 23);
            this.btnGUID.TabIndex = 0;
            this.btnGUID.Text = "GUID";
            this.btnGUID.UseVisualStyleBackColor = true;
            this.btnGUID.Click += new System.EventHandler(this.btnGUID_Click);
            // 
            // txtGUID
            // 
            this.txtGUID.Location = new System.Drawing.Point(197, 13);
            this.txtGUID.Name = "txtGUID";
            this.txtGUID.Size = new System.Drawing.Size(236, 24);
            this.txtGUID.TabIndex = 1;
            // 
            // btnProcessorId
            // 
            this.btnProcessorId.Location = new System.Drawing.Point(10, 67);
            this.btnProcessorId.Name = "btnProcessorId";
            this.btnProcessorId.Size = new System.Drawing.Size(167, 23);
            this.btnProcessorId.TabIndex = 2;
            this.btnProcessorId.Text = "Processor Id";
            this.btnProcessorId.UseVisualStyleBackColor = true;
            this.btnProcessorId.Click += new System.EventHandler(this.btnProcessorId_Click);
            // 
            // txtProcessorId
            // 
            this.txtProcessorId.Location = new System.Drawing.Point(197, 66);
            this.txtProcessorId.Name = "txtProcessorId";
            this.txtProcessorId.Size = new System.Drawing.Size(236, 24);
            this.txtProcessorId.TabIndex = 3;
            // 
            // txtHardDriveSN1
            // 
            this.txtHardDriveSN1.Location = new System.Drawing.Point(197, 95);
            this.txtHardDriveSN1.Name = "txtHardDriveSN1";
            this.txtHardDriveSN1.Size = new System.Drawing.Size(236, 24);
            this.txtHardDriveSN1.TabIndex = 5;
            // 
            // btnHardDriveSN
            // 
            this.btnHardDriveSN.Location = new System.Drawing.Point(10, 96);
            this.btnHardDriveSN.Name = "btnHardDriveSN";
            this.btnHardDriveSN.Size = new System.Drawing.Size(167, 23);
            this.btnHardDriveSN.TabIndex = 4;
            this.btnHardDriveSN.Text = "Hard Drive VSN (C:)";
            this.btnHardDriveSN.UseVisualStyleBackColor = true;
            this.btnHardDriveSN.Click += new System.EventHandler(this.btnHardDriveSN_Click);
            // 
            // txtHardDriveSN2
            // 
            this.txtHardDriveSN2.Location = new System.Drawing.Point(197, 124);
            this.txtHardDriveSN2.Name = "txtHardDriveSN2";
            this.txtHardDriveSN2.Size = new System.Drawing.Size(236, 24);
            this.txtHardDriveSN2.TabIndex = 7;
            // 
            // btnVSN
            // 
            this.btnVSN.Location = new System.Drawing.Point(10, 125);
            this.btnVSN.Name = "btnVSN";
            this.btnVSN.Size = new System.Drawing.Size(167, 23);
            this.btnVSN.TabIndex = 6;
            this.btnVSN.Text = "Hard Drive VSN (D:)";
            this.btnVSN.UseVisualStyleBackColor = true;
            this.btnVSN.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHashing
            // 
            this.txtHashing.Location = new System.Drawing.Point(197, 211);
            this.txtHashing.Name = "txtHashing";
            this.txtHashing.Size = new System.Drawing.Size(236, 24);
            this.txtHashing.TabIndex = 9;
            // 
            // btnComputeHash
            // 
            this.btnComputeHash.Location = new System.Drawing.Point(10, 210);
            this.btnComputeHash.Name = "btnComputeHash";
            this.btnComputeHash.Size = new System.Drawing.Size(167, 23);
            this.btnComputeHash.TabIndex = 8;
            this.btnComputeHash.Text = "Hashing \"Hello\"";
            this.btnComputeHash.UseVisualStyleBackColor = true;
            this.btnComputeHash.Click += new System.EventHandler(this.btnComputeHash_Click);
            // 
            // btnMACAddresses
            // 
            this.btnMACAddresses.Location = new System.Drawing.Point(10, 154);
            this.btnMACAddresses.Name = "btnMACAddresses";
            this.btnMACAddresses.Size = new System.Drawing.Size(167, 23);
            this.btnMACAddresses.TabIndex = 10;
            this.btnMACAddresses.Text = "NICs MAC Addresses";
            this.btnMACAddresses.UseVisualStyleBackColor = true;
            this.btnMACAddresses.Click += new System.EventHandler(this.btnMACAddresses_Click);
            // 
            // cboMACAddresses
            // 
            this.cboMACAddresses.FormattingEnabled = true;
            this.cboMACAddresses.Location = new System.Drawing.Point(197, 154);
            this.cboMACAddresses.Name = "cboMACAddresses";
            this.cboMACAddresses.Size = new System.Drawing.Size(236, 24);
            this.cboMACAddresses.TabIndex = 11;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(12, 249);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(167, 23);
            this.btnGeneratePassword.TabIndex = 12;
            this.btnGeneratePassword.Text = "Generate New Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(232, 252);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 17);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "[Password]";
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.Image = global::DotNETHeroes.SecurityUtil.Win.Properties.Resources.copy_16x16;
            this.btnCopyPassword.Location = new System.Drawing.Point(197, 249);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(29, 24);
            this.btnCopyPassword.TabIndex = 14;
            this.btnCopyPassword.UseVisualStyleBackColor = true;
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 293);
            this.Controls.Add(this.btnCopyPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.cboMACAddresses);
            this.Controls.Add(this.btnMACAddresses);
            this.Controls.Add(this.txtHashing);
            this.Controls.Add(this.btnComputeHash);
            this.Controls.Add(this.txtHardDriveSN2);
            this.Controls.Add(this.btnVSN);
            this.Controls.Add(this.txtHardDriveSN1);
            this.Controls.Add(this.btnHardDriveSN);
            this.Controls.Add(this.txtProcessorId);
            this.Controls.Add(this.btnProcessorId);
            this.Controls.Add(this.txtGUID);
            this.Controls.Add(this.btnGUID);
            this.Name = "frmMain";
            this.Text = "SecurityUtil - Winform Test App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGUID;
        private System.Windows.Forms.TextBox txtGUID;
        private System.Windows.Forms.Button btnProcessorId;
        private System.Windows.Forms.TextBox txtProcessorId;
        private System.Windows.Forms.TextBox txtHardDriveSN1;
        private System.Windows.Forms.Button btnHardDriveSN;
        private System.Windows.Forms.TextBox txtHardDriveSN2;
        private System.Windows.Forms.Button btnVSN;
        private System.Windows.Forms.TextBox txtHashing;
        private System.Windows.Forms.Button btnComputeHash;
        private System.Windows.Forms.Button btnMACAddresses;
        private System.Windows.Forms.ComboBox cboMACAddresses;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCopyPassword;
    }
}

