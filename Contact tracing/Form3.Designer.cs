namespace Contact_tracing
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.datagathered = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datagathered
            // 
            this.datagathered.AutoSize = true;
            this.datagathered.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datagathered.Location = new System.Drawing.Point(26, 61);
            this.datagathered.Name = "datagathered";
            this.datagathered.Size = new System.Drawing.Size(45, 24);
            this.datagathered.TabIndex = 0;
            this.datagathered.Text = "       ";
            this.datagathered.Click += new System.EventHandler(this.gathereddata_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.datagathered);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Data Gathered";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label datagathered;
    }
}