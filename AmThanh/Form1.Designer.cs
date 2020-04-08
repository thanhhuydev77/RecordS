namespace AmThanh
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cdDelete = new DevExpress.XtraEditors.CheckEdit();
            this.sbtPause = new DevExpress.XtraEditors.SimpleButton();
            this.sbtSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.sbtStop = new DevExpress.XtraEditors.SimpleButton();
            this.sbtOpen = new DevExpress.XtraEditors.SimpleButton();
            this.sbtPlay = new DevExpress.XtraEditors.SimpleButton();
            this.sbtRecord = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenFile = new System.Windows.Forms.TextBox();
            this.txtPathSave = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdDelete.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.cdDelete);
            this.groupBox2.Controls.Add(this.sbtPause);
            this.groupBox2.Controls.Add(this.sbtSave);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Controls.Add(this.sbtStop);
            this.groupBox2.Controls.Add(this.sbtOpen);
            this.groupBox2.Controls.Add(this.sbtPlay);
            this.groupBox2.Controls.Add(this.sbtRecord);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTenFile);
            this.groupBox2.Controls.Add(this.txtPathSave);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 334);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // cdDelete
            // 
            this.cdDelete.Location = new System.Drawing.Point(9, 149);
            this.cdDelete.Name = "cdDelete";
            this.cdDelete.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdDelete.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.cdDelete.Properties.Appearance.Options.UseFont = true;
            this.cdDelete.Properties.Appearance.Options.UseForeColor = true;
            this.cdDelete.Properties.Caption = "Delete 2 file speaker and mic";
            this.cdDelete.Size = new System.Drawing.Size(229, 19);
            this.cdDelete.TabIndex = 11;
            this.cdDelete.CheckedChanged += new System.EventHandler(this.cdDelete_CheckedChanged);
            // 
            // sbtPause
            // 
            this.sbtPause.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtPause.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.sbtPause.Appearance.Options.UseFont = true;
            this.sbtPause.Appearance.Options.UseForeColor = true;
            this.sbtPause.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtPause.ImageOptions.Image")));
            this.sbtPause.Location = new System.Drawing.Point(161, 276);
            this.sbtPause.Name = "sbtPause";
            this.sbtPause.Size = new System.Drawing.Size(84, 41);
            this.sbtPause.TabIndex = 9;
            this.sbtPause.Text = "Pause";
            this.sbtPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // sbtSave
            // 
            this.sbtSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtSave.ImageOptions.Image")));
            this.sbtSave.Location = new System.Drawing.Point(195, 219);
            this.sbtSave.Name = "sbtSave";
            this.sbtSave.Size = new System.Drawing.Size(41, 41);
            this.sbtSave.TabIndex = 9;
            this.sbtSave.Click += new System.EventHandler(this.sbtSave_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(24, 277);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(41, 41);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // sbtStop
            // 
            this.sbtStop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtStop.ImageOptions.Image")));
            this.sbtStop.Location = new System.Drawing.Point(81, 219);
            this.sbtStop.Name = "sbtStop";
            this.sbtStop.Size = new System.Drawing.Size(41, 41);
            this.sbtStop.TabIndex = 9;
            this.sbtStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // sbtOpen
            // 
            this.sbtOpen.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtOpen.Appearance.ForeColor = System.Drawing.Color.Green;
            this.sbtOpen.Appearance.Options.UseFont = true;
            this.sbtOpen.Appearance.Options.UseForeColor = true;
            this.sbtOpen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtOpen.ImageOptions.Image")));
            this.sbtOpen.Location = new System.Drawing.Point(72, 276);
            this.sbtOpen.Name = "sbtOpen";
            this.sbtOpen.Size = new System.Drawing.Size(83, 41);
            this.sbtOpen.TabIndex = 9;
            this.sbtOpen.Text = "Open";
            this.sbtOpen.Click += new System.EventHandler(this.sbtOpen_Click);
            // 
            // sbtPlay
            // 
            this.sbtPlay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtPlay.ImageOptions.Image")));
            this.sbtPlay.Location = new System.Drawing.Point(138, 219);
            this.sbtPlay.Name = "sbtPlay";
            this.sbtPlay.Size = new System.Drawing.Size(41, 41);
            this.sbtPlay.TabIndex = 9;
            this.sbtPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // sbtRecord
            // 
            this.sbtRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sbtRecord.BackgroundImage")));
            this.sbtRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sbtRecord.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtRecord.ImageOptions.Image")));
            this.sbtRecord.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.sbtRecord.Location = new System.Drawing.Point(24, 219);
            this.sbtRecord.Name = "sbtRecord";
            this.sbtRecord.Size = new System.Drawing.Size(41, 41);
            this.sbtRecord.TabIndex = 9;
            this.sbtRecord.Click += new System.EventHandler(this.btRecord_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(86, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "RecordS";
            // 
            // txtTenFile
            // 
            this.txtTenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenFile.Location = new System.Drawing.Point(6, 115);
            this.txtTenFile.Name = "txtTenFile";
            this.txtTenFile.Size = new System.Drawing.Size(229, 20);
            this.txtTenFile.TabIndex = 4;
            this.txtTenFile.TextChanged += new System.EventHandler(this.txtTenFile_TextChanged);
            // 
            // txtPathSave
            // 
            this.txtPathSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathSave.Location = new System.Drawing.Point(9, 63);
            this.txtPathSave.Name = "txtPathSave";
            this.txtPathSave.Size = new System.Drawing.Size(197, 20);
            this.txtPathSave.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.sptOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "File lưu";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(274, 341);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(200, 0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RecordS V1.0";
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdDelete.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton sbtPause;
        private DevExpress.XtraEditors.SimpleButton sbtSave;
        private DevExpress.XtraEditors.SimpleButton sbtStop;
        private DevExpress.XtraEditors.SimpleButton sbtOpen;
        private DevExpress.XtraEditors.SimpleButton sbtPlay;
        private DevExpress.XtraEditors.SimpleButton sbtRecord;
        private DevExpress.XtraEditors.CheckEdit cdDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

