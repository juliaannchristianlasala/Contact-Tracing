namespace Contact_tracing
{
    partial class Form4
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
            this.qrgenbutton = new System.Windows.Forms.Button();
            this.qrpicbox = new System.Windows.Forms.PictureBox();
            this.qrgenlabel = new System.Windows.Forms.Label();
            this.infoslabel = new System.Windows.Forms.Label();
            this.InfpPicbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrpicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfpPicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // qrgenbutton
            // 
            this.qrgenbutton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qrgenbutton.Location = new System.Drawing.Point(755, 537);
            this.qrgenbutton.Name = "qrgenbutton";
            this.qrgenbutton.Size = new System.Drawing.Size(439, 46);
            this.qrgenbutton.TabIndex = 0;
            this.qrgenbutton.Text = "Generate";
            this.qrgenbutton.UseVisualStyleBackColor = true;
            this.qrgenbutton.Click += new System.EventHandler(this.qrgenbutton_Click);
            // 
            // qrpicbox
            // 
            this.qrpicbox.Location = new System.Drawing.Point(737, 72);
            this.qrpicbox.Name = "qrpicbox";
            this.qrpicbox.Size = new System.Drawing.Size(473, 452);
            this.qrpicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrpicbox.TabIndex = 1;
            this.qrpicbox.TabStop = false;
            this.qrpicbox.Click += new System.EventHandler(this.qrpicbox_Click);
            // 
            // qrgenlabel
            // 
            this.qrgenlabel.AutoSize = true;
            this.qrgenlabel.Font = new System.Drawing.Font("Engravers MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.qrgenlabel.ForeColor = System.Drawing.Color.White;
            this.qrgenlabel.Location = new System.Drawing.Point(818, 30);
            this.qrgenlabel.Name = "qrgenlabel";
            this.qrgenlabel.Size = new System.Drawing.Size(326, 35);
            this.qrgenlabel.TabIndex = 3;
            this.qrgenlabel.Text = "QR CODE HERE";
            // 
            // infoslabel
            // 
            this.infoslabel.AutoSize = true;
            this.infoslabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.infoslabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoslabel.Location = new System.Drawing.Point(17, 84);
            this.infoslabel.Name = "infoslabel";
            this.infoslabel.Size = new System.Drawing.Size(0, 18);
            this.infoslabel.TabIndex = 4;
            // 
            // InfpPicbox
            // 
            this.InfpPicbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InfpPicbox.Location = new System.Drawing.Point(-28, 72);
            this.InfpPicbox.Name = "InfpPicbox";
            this.InfpPicbox.Size = new System.Drawing.Size(759, 531);
            this.InfpPicbox.TabIndex = 6;
            this.InfpPicbox.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1234, 635);
            this.Controls.Add(this.infoslabel);
            this.Controls.Add(this.qrgenlabel);
            this.Controls.Add(this.qrpicbox);
            this.Controls.Add(this.qrgenbutton);
            this.Controls.Add(this.InfpPicbox);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrpicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfpPicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button qrgenbutton;
        private PictureBox qrpicbox;
        private Label qrgenlabel;
        private Label infoslabel;
        private PictureBox InfpPicbox;
    }
}