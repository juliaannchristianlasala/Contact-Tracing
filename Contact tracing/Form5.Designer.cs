namespace Contact_tracing
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.QRScanLabel = new System.Windows.Forms.Label();
            this.StScanButton = new System.Windows.Forms.Button();
            this.ScanPicbox = new System.Windows.Forms.PictureBox();
            this.ScanInfoLabel = new System.Windows.Forms.Label();
            this.BgPicbox = new System.Windows.Forms.PictureBox();
            this.camcombox = new System.Windows.Forms.ComboBox();
            this.CamLabel = new System.Windows.Forms.Label();
            this.ScanTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ScanPicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgPicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // QRScanLabel
            // 
            this.QRScanLabel.AutoSize = true;
            this.QRScanLabel.Font = new System.Drawing.Font("Engravers MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QRScanLabel.ForeColor = System.Drawing.Color.White;
            this.QRScanLabel.Location = new System.Drawing.Point(35, 27);
            this.QRScanLabel.Name = "QRScanLabel";
            this.QRScanLabel.Size = new System.Drawing.Size(272, 38);
            this.QRScanLabel.TabIndex = 8;
            this.QRScanLabel.Text = "SCAN HERE";
            // 
            // StScanButton
            // 
            this.StScanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.StScanButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StScanButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StScanButton.Location = new System.Drawing.Point(36, 118);
            this.StScanButton.Name = "StScanButton";
            this.StScanButton.Size = new System.Drawing.Size(475, 43);
            this.StScanButton.TabIndex = 9;
            this.StScanButton.Text = "START";
            this.StScanButton.UseVisualStyleBackColor = false;
            this.StScanButton.Click += new System.EventHandler(this.StScanButton_Click);
            // 
            // ScanPicbox
            // 
            this.ScanPicbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ScanPicbox.Location = new System.Drawing.Point(37, 169);
            this.ScanPicbox.Name = "ScanPicbox";
            this.ScanPicbox.Size = new System.Drawing.Size(472, 442);
            this.ScanPicbox.TabIndex = 10;
            this.ScanPicbox.TabStop = false;
            // 
            // ScanInfoLabel
            // 
            this.ScanInfoLabel.AutoSize = true;
            this.ScanInfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ScanInfoLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScanInfoLabel.Location = new System.Drawing.Point(538, 91);
            this.ScanInfoLabel.Name = "ScanInfoLabel";
            this.ScanInfoLabel.Size = new System.Drawing.Size(0, 20);
            this.ScanInfoLabel.TabIndex = 11;
            // 
            // BgPicbox
            // 
            this.BgPicbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BgPicbox.Location = new System.Drawing.Point(531, 83);
            this.BgPicbox.Name = "BgPicbox";
            this.BgPicbox.Size = new System.Drawing.Size(482, 528);
            this.BgPicbox.TabIndex = 12;
            this.BgPicbox.TabStop = false;
            // 
            // camcombox
            // 
            this.camcombox.FormattingEnabled = true;
            this.camcombox.Location = new System.Drawing.Point(126, 83);
            this.camcombox.Name = "camcombox";
            this.camcombox.Size = new System.Drawing.Size(383, 28);
            this.camcombox.TabIndex = 13;
            // 
            // CamLabel
            // 
            this.CamLabel.AutoSize = true;
            this.CamLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CamLabel.Location = new System.Drawing.Point(37, 85);
            this.CamLabel.Name = "CamLabel";
            this.CamLabel.Size = new System.Drawing.Size(85, 24);
            this.CamLabel.TabIndex = 14;
            this.CamLabel.Text = "Camera:";
            // 
            // ScanTimer
            // 
            this.ScanTimer.Interval = 1000;
            this.ScanTimer.Tick += new System.EventHandler(this.ScanTimer_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1045, 640);
            this.Controls.Add(this.CamLabel);
            this.Controls.Add(this.camcombox);
            this.Controls.Add(this.ScanInfoLabel);
            this.Controls.Add(this.ScanPicbox);
            this.Controls.Add(this.StScanButton);
            this.Controls.Add(this.QRScanLabel);
            this.Controls.Add(this.BgPicbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTACT TRACING: Scan QR Code";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScanPicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgPicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label QRScanLabel;
        private Button StScanButton;
        private PictureBox ScanPicbox;
        private Label ScanInfoLabel;
        private PictureBox BgPicbox;
        private ComboBox camcombox;
        private Label CamLabel;
        private System.Windows.Forms.Timer ScanTimer;
    }
}