namespace Contact_tracing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CTLabel = new System.Windows.Forms.Label();
            this.fnamelabel = new System.Windows.Forms.Label();
            this.mnamelabel = new System.Windows.Forms.Label();
            this.lnamelabel = new System.Windows.Forms.Label();
            this.snamelabel = new System.Windows.Forms.Label();
            this.fnametxtbox = new System.Windows.Forms.TextBox();
            this.mnametxtbox = new System.Windows.Forms.TextBox();
            this.lnametxtbox = new System.Windows.Forms.TextBox();
            this.snametxtbox = new System.Windows.Forms.TextBox();
            this.agelabel = new System.Windows.Forms.Label();
            this.agenumericud = new System.Windows.Forms.NumericUpDown();
            this.sexlabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datelabel = new System.Windows.Forms.Label();
            this.sextxtbox = new System.Windows.Forms.TextBox();
            this.pnumtxtbox = new System.Windows.Forms.TextBox();
            this.pnumlabel = new System.Windows.Forms.Label();
            this.pemailltxtbox = new System.Windows.Forms.TextBox();
            this.pemaillabel = new System.Windows.Forms.Label();
            this.addresslabel = new System.Windows.Forms.Label();
            this.sttxtbox = new System.Windows.Forms.TextBox();
            this.citytxtbox = new System.Windows.Forms.TextBox();
            this.sprovtxtbox = new System.Windows.Forms.TextBox();
            this.pzipctxtbox = new System.Windows.Forms.TextBox();
            this.stlabellabel = new System.Windows.Forms.Label();
            this.citylabel = new System.Windows.Forms.Label();
            this.sprovlabel = new System.Windows.Forms.Label();
            this.pzipclabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agenumericud)).BeginInit();
            this.SuspendLayout();
            // 
            // CTLabel
            // 
            this.CTLabel.AutoSize = true;
            this.CTLabel.BackColor = System.Drawing.Color.Black;
            this.CTLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTLabel.Font = new System.Drawing.Font("Elephant", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CTLabel.ForeColor = System.Drawing.Color.Lavender;
            this.CTLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CTLabel.Location = new System.Drawing.Point(37, 25);
            this.CTLabel.Name = "CTLabel";
            this.CTLabel.Size = new System.Drawing.Size(622, 64);
            this.CTLabel.TabIndex = 0;
            this.CTLabel.Text = "CONTACT TRACING";
            // 
            // fnamelabel
            // 
            this.fnamelabel.AutoSize = true;
            this.fnamelabel.BackColor = System.Drawing.Color.Transparent;
            this.fnamelabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fnamelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fnamelabel.Location = new System.Drawing.Point(52, 113);
            this.fnamelabel.Name = "fnamelabel";
            this.fnamelabel.Size = new System.Drawing.Size(132, 24);
            this.fnamelabel.TabIndex = 1;
            this.fnamelabel.Text = "FIRST NAME";
            // 
            // mnamelabel
            // 
            this.mnamelabel.AutoSize = true;
            this.mnamelabel.BackColor = System.Drawing.Color.Transparent;
            this.mnamelabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnamelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnamelabel.Location = new System.Drawing.Point(286, 113);
            this.mnamelabel.Name = "mnamelabel";
            this.mnamelabel.Size = new System.Drawing.Size(157, 24);
            this.mnamelabel.TabIndex = 2;
            this.mnamelabel.Text = "MIDDLE NAME";
            // 
            // lnamelabel
            // 
            this.lnamelabel.AutoSize = true;
            this.lnamelabel.BackColor = System.Drawing.Color.Transparent;
            this.lnamelabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnamelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lnamelabel.Location = new System.Drawing.Point(482, 113);
            this.lnamelabel.Name = "lnamelabel";
            this.lnamelabel.Size = new System.Drawing.Size(123, 24);
            this.lnamelabel.TabIndex = 3;
            this.lnamelabel.Text = "LAST NAME";
            // 
            // snamelabel
            // 
            this.snamelabel.AutoSize = true;
            this.snamelabel.BackColor = System.Drawing.Color.Transparent;
            this.snamelabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.snamelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.snamelabel.Location = new System.Drawing.Point(666, 113);
            this.snamelabel.Name = "snamelabel";
            this.snamelabel.Size = new System.Drawing.Size(82, 24);
            this.snamelabel.TabIndex = 4;
            this.snamelabel.Text = "SUFFIX";
            // 
            // fnametxtbox
            // 
            this.fnametxtbox.Location = new System.Drawing.Point(49, 140);
            this.fnametxtbox.Name = "fnametxtbox";
            this.fnametxtbox.Size = new System.Drawing.Size(216, 27);
            this.fnametxtbox.TabIndex = 5;
            // 
            // mnametxtbox
            // 
            this.mnametxtbox.Location = new System.Drawing.Point(283, 140);
            this.mnametxtbox.Name = "mnametxtbox";
            this.mnametxtbox.Size = new System.Drawing.Size(178, 27);
            this.mnametxtbox.TabIndex = 6;
            // 
            // lnametxtbox
            // 
            this.lnametxtbox.Location = new System.Drawing.Point(479, 140);
            this.lnametxtbox.Name = "lnametxtbox";
            this.lnametxtbox.Size = new System.Drawing.Size(171, 27);
            this.lnametxtbox.TabIndex = 7;
            // 
            // snametxtbox
            // 
            this.snametxtbox.Location = new System.Drawing.Point(667, 140);
            this.snametxtbox.Name = "snametxtbox";
            this.snametxtbox.Size = new System.Drawing.Size(78, 27);
            this.snametxtbox.TabIndex = 8;
            // 
            // agelabel
            // 
            this.agelabel.AutoSize = true;
            this.agelabel.BackColor = System.Drawing.Color.Transparent;
            this.agelabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.agelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.agelabel.Location = new System.Drawing.Point(53, 179);
            this.agelabel.Name = "agelabel";
            this.agelabel.Size = new System.Drawing.Size(51, 24);
            this.agelabel.TabIndex = 9;
            this.agelabel.Text = "AGE";
            // 
            // agenumericud
            // 
            this.agenumericud.Location = new System.Drawing.Point(49, 205);
            this.agenumericud.Name = "agenumericud";
            this.agenumericud.Size = new System.Drawing.Size(87, 27);
            this.agenumericud.TabIndex = 10;
            // 
            // sexlabel
            // 
            this.sexlabel.AutoSize = true;
            this.sexlabel.BackColor = System.Drawing.Color.Transparent;
            this.sexlabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sexlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sexlabel.Location = new System.Drawing.Point(154, 177);
            this.sexlabel.Name = "sexlabel";
            this.sexlabel.Size = new System.Drawing.Size(48, 24);
            this.sexlabel.TabIndex = 13;
            this.sexlabel.Text = "SEX";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(779, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 30);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.BackColor = System.Drawing.Color.Transparent;
            this.datelabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datelabel.Location = new System.Drawing.Point(782, 23);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(63, 24);
            this.datelabel.TabIndex = 15;
            this.datelabel.Text = "DATE";
            // 
            // sextxtbox
            // 
            this.sextxtbox.Location = new System.Drawing.Point(150, 205);
            this.sextxtbox.Name = "sextxtbox";
            this.sextxtbox.Size = new System.Drawing.Size(115, 27);
            this.sextxtbox.TabIndex = 16;
            // 
            // pnumtxtbox
            // 
            this.pnumtxtbox.Location = new System.Drawing.Point(281, 204);
            this.pnumtxtbox.Name = "pnumtxtbox";
            this.pnumtxtbox.Size = new System.Drawing.Size(178, 27);
            this.pnumtxtbox.TabIndex = 17;
            // 
            // pnumlabel
            // 
            this.pnumlabel.AutoSize = true;
            this.pnumlabel.BackColor = System.Drawing.Color.Transparent;
            this.pnumlabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnumlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnumlabel.Location = new System.Drawing.Point(284, 179);
            this.pnumlabel.Name = "pnumlabel";
            this.pnumlabel.Size = new System.Drawing.Size(175, 24);
            this.pnumlabel.TabIndex = 18;
            this.pnumlabel.Text = "PHONE NUMBER";
            // 
            // pemailltxtbox
            // 
            this.pemailltxtbox.Location = new System.Drawing.Point(479, 204);
            this.pemailltxtbox.Name = "pemailltxtbox";
            this.pemailltxtbox.Size = new System.Drawing.Size(266, 27);
            this.pemailltxtbox.TabIndex = 19;
            // 
            // pemaillabel
            // 
            this.pemaillabel.AutoSize = true;
            this.pemaillabel.BackColor = System.Drawing.Color.Transparent;
            this.pemaillabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pemaillabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pemaillabel.Location = new System.Drawing.Point(483, 179);
            this.pemaillabel.Name = "pemaillabel";
            this.pemaillabel.Size = new System.Drawing.Size(185, 24);
            this.pemaillabel.TabIndex = 20;
            this.pemaillabel.Text = "PERSONAL EMAIL";
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.BackColor = System.Drawing.Color.Transparent;
            this.addresslabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addresslabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addresslabel.Location = new System.Drawing.Point(49, 243);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(170, 24);
            this.addresslabel.TabIndex = 21;
            this.addresslabel.Text = "HOME ADDRESS";
            // 
            // sttxtbox
            // 
            this.sttxtbox.Location = new System.Drawing.Point(49, 270);
            this.sttxtbox.Name = "sttxtbox";
            this.sttxtbox.Size = new System.Drawing.Size(696, 27);
            this.sttxtbox.TabIndex = 22;
            // 
            // citytxtbox
            // 
            this.citytxtbox.Location = new System.Drawing.Point(49, 322);
            this.citytxtbox.Name = "citytxtbox";
            this.citytxtbox.Size = new System.Drawing.Size(318, 27);
            this.citytxtbox.TabIndex = 23;
            // 
            // sprovtxtbox
            // 
            this.sprovtxtbox.Location = new System.Drawing.Point(385, 322);
            this.sprovtxtbox.Name = "sprovtxtbox";
            this.sprovtxtbox.Size = new System.Drawing.Size(360, 27);
            this.sprovtxtbox.TabIndex = 24;
            // 
            // pzipctxtbox
            // 
            this.pzipctxtbox.Location = new System.Drawing.Point(49, 375);
            this.pzipctxtbox.Name = "pzipctxtbox";
            this.pzipctxtbox.Size = new System.Drawing.Size(318, 27);
            this.pzipctxtbox.TabIndex = 25;
            // 
            // stlabellabel
            // 
            this.stlabellabel.AutoSize = true;
            this.stlabellabel.BackColor = System.Drawing.Color.Transparent;
            this.stlabellabel.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stlabellabel.ForeColor = System.Drawing.SystemColors.Control;
            this.stlabellabel.Location = new System.Drawing.Point(49, 297);
            this.stlabellabel.Name = "stlabellabel";
            this.stlabellabel.Size = new System.Drawing.Size(98, 16);
            this.stlabellabel.TabIndex = 26;
            this.stlabellabel.Text = "Street Address";
            // 
            // citylabel
            // 
            this.citylabel.AutoSize = true;
            this.citylabel.BackColor = System.Drawing.Color.Transparent;
            this.citylabel.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.citylabel.ForeColor = System.Drawing.SystemColors.Control;
            this.citylabel.Location = new System.Drawing.Point(49, 349);
            this.citylabel.Name = "citylabel";
            this.citylabel.Size = new System.Drawing.Size(32, 16);
            this.citylabel.TabIndex = 27;
            this.citylabel.Text = "City";
            // 
            // sprovlabel
            // 
            this.sprovlabel.AutoSize = true;
            this.sprovlabel.BackColor = System.Drawing.Color.Transparent;
            this.sprovlabel.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sprovlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.sprovlabel.Location = new System.Drawing.Point(387, 352);
            this.sprovlabel.Name = "sprovlabel";
            this.sprovlabel.Size = new System.Drawing.Size(101, 16);
            this.sprovlabel.TabIndex = 28;
            this.sprovlabel.Text = "State/Province";
            // 
            // pzipclabel
            // 
            this.pzipclabel.AutoSize = true;
            this.pzipclabel.BackColor = System.Drawing.Color.Transparent;
            this.pzipclabel.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pzipclabel.ForeColor = System.Drawing.SystemColors.Control;
            this.pzipclabel.Location = new System.Drawing.Point(50, 403);
            this.pzipclabel.Name = "pzipclabel";
            this.pzipclabel.Size = new System.Drawing.Size(106, 16);
            this.pzipclabel.TabIndex = 29;
            this.pzipclabel.Text = "Postal/Zip Code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 753);
            this.Controls.Add(this.pzipclabel);
            this.Controls.Add(this.sprovlabel);
            this.Controls.Add(this.citylabel);
            this.Controls.Add(this.stlabellabel);
            this.Controls.Add(this.pzipctxtbox);
            this.Controls.Add(this.sprovtxtbox);
            this.Controls.Add(this.citytxtbox);
            this.Controls.Add(this.sttxtbox);
            this.Controls.Add(this.addresslabel);
            this.Controls.Add(this.pemaillabel);
            this.Controls.Add(this.pemailltxtbox);
            this.Controls.Add(this.pnumlabel);
            this.Controls.Add(this.pnumtxtbox);
            this.Controls.Add(this.sextxtbox);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.sexlabel);
            this.Controls.Add(this.agenumericud);
            this.Controls.Add(this.agelabel);
            this.Controls.Add(this.snametxtbox);
            this.Controls.Add(this.lnametxtbox);
            this.Controls.Add(this.mnametxtbox);
            this.Controls.Add(this.fnametxtbox);
            this.Controls.Add(this.snamelabel);
            this.Controls.Add(this.lnamelabel);
            this.Controls.Add(this.mnamelabel);
            this.Controls.Add(this.fnamelabel);
            this.Controls.Add(this.CTLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTACT TRACING";
            ((System.ComponentModel.ISupportInitialize)(this.agenumericud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CTLabel;
        private Label fnamelabel;
        private Label mnamelabel;
        private Label lnamelabel;
        private Label snamelabel;
        private TextBox fnametxtbox;
        private TextBox mnametxtbox;
        private TextBox lnametxtbox;
        private TextBox snametxtbox;
        private Label agelabel;
        private NumericUpDown agenumericud;
        private Label sexlabel;
        private DateTimePicker dateTimePicker1;
        private Label datelabel;
        private TextBox sextxtbox;
        private TextBox pnumtxtbox;
        private Label pnumlabel;
        private TextBox pemailltxtbox;
        private Label pemaillabel;
        private Label addresslabel;
        private TextBox sttxtbox;
        private TextBox citytxtbox;
        private TextBox sprovtxtbox;
        private TextBox pzipctxtbox;
        private Label stlabellabel;
        private Label citylabel;
        private Label sprovlabel;
        private Label pzipclabel;
    }
}