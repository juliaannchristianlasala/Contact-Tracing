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
            this.qrgentxtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrpicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // qrgenbutton
            // 
            this.qrgenbutton.Location = new System.Drawing.Point(306, 393);
            this.qrgenbutton.Name = "qrgenbutton";
            this.qrgenbutton.Size = new System.Drawing.Size(94, 29);
            this.qrgenbutton.TabIndex = 0;
            this.qrgenbutton.Text = "Generate";
            this.qrgenbutton.UseVisualStyleBackColor = true;
            this.qrgenbutton.Click += new System.EventHandler(this.qrgenbutton_Click);
            // 
            // qrpicbox
            // 
            this.qrpicbox.Location = new System.Drawing.Point(36, 68);
            this.qrpicbox.Name = "qrpicbox";
            this.qrpicbox.Size = new System.Drawing.Size(364, 319);
            this.qrpicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrpicbox.TabIndex = 1;
            this.qrpicbox.TabStop = false;
            // 
            // qrgentxtbox
            // 
            this.qrgentxtbox.Location = new System.Drawing.Point(36, 35);
            this.qrgentxtbox.Name = "qrgentxtbox";
            this.qrgentxtbox.Size = new System.Drawing.Size(364, 27);
            this.qrgentxtbox.TabIndex = 2;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 452);
            this.Controls.Add(this.qrgentxtbox);
            this.Controls.Add(this.qrpicbox);
            this.Controls.Add(this.qrgenbutton);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.qrpicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button qrgenbutton;
        private PictureBox qrpicbox;
        private TextBox qrgentxtbox;
    }
}