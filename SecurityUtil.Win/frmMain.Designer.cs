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
            this.SuspendLayout();
            // 
            // btnGUID
            // 
            this.btnGUID.Location = new System.Drawing.Point(12, 12);
            this.btnGUID.Name = "btnGUID";
            this.btnGUID.Size = new System.Drawing.Size(156, 25);
            this.btnGUID.TabIndex = 0;
            this.btnGUID.Text = "GUID";
            this.btnGUID.UseVisualStyleBackColor = true;
            this.btnGUID.Click += new System.EventHandler(this.btnGUID_Click);
            // 
            // txtGUID
            // 
            this.txtGUID.Location = new System.Drawing.Point(174, 15);
            this.txtGUID.Name = "txtGUID";
            this.txtGUID.Size = new System.Drawing.Size(269, 22);
            this.txtGUID.TabIndex = 1;
            // 
            // btnProcessorId
            // 
            this.btnProcessorId.Location = new System.Drawing.Point(12, 42);
            this.btnProcessorId.Name = "btnProcessorId";
            this.btnProcessorId.Size = new System.Drawing.Size(156, 23);
            this.btnProcessorId.TabIndex = 2;
            this.btnProcessorId.Text = "Processor Id";
            this.btnProcessorId.UseVisualStyleBackColor = true;
            this.btnProcessorId.Click += new System.EventHandler(this.btnProcessorId_Click);
            // 
            // txtProcessorId
            // 
            this.txtProcessorId.Location = new System.Drawing.Point(174, 43);
            this.txtProcessorId.Name = "txtProcessorId";
            this.txtProcessorId.Size = new System.Drawing.Size(269, 22);
            this.txtProcessorId.TabIndex = 3;
            // 
            // txtHardDriveSN1
            // 
            this.txtHardDriveSN1.Location = new System.Drawing.Point(174, 72);
            this.txtHardDriveSN1.Name = "txtHardDriveSN1";
            this.txtHardDriveSN1.Size = new System.Drawing.Size(269, 22);
            this.txtHardDriveSN1.TabIndex = 5;
            // 
            // btnHardDriveSN
            // 
            this.btnHardDriveSN.Location = new System.Drawing.Point(12, 71);
            this.btnHardDriveSN.Name = "btnHardDriveSN";
            this.btnHardDriveSN.Size = new System.Drawing.Size(156, 23);
            this.btnHardDriveSN.TabIndex = 4;
            this.btnHardDriveSN.Text = "Hard Drive VSN";
            this.btnHardDriveSN.UseVisualStyleBackColor = true;
            this.btnHardDriveSN.Click += new System.EventHandler(this.btnHardDriveSN_Click);
            // 
            // txtHardDriveSN2
            // 
            this.txtHardDriveSN2.Location = new System.Drawing.Point(174, 101);
            this.txtHardDriveSN2.Name = "txtHardDriveSN2";
            this.txtHardDriveSN2.Size = new System.Drawing.Size(269, 22);
            this.txtHardDriveSN2.TabIndex = 7;
            // 
            // btnVSN
            // 
            this.btnVSN.Location = new System.Drawing.Point(12, 100);
            this.btnVSN.Name = "btnVSN";
            this.btnVSN.Size = new System.Drawing.Size(156, 23);
            this.btnVSN.TabIndex = 6;
            this.btnVSN.Text = "Hard Drive VSN (D:)";
            this.btnVSN.UseVisualStyleBackColor = true;
            this.btnVSN.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 293);
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
    }
}

