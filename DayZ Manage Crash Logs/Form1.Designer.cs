namespace DayZ_Manage_Crash_Logs
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
            this.txtDayZPath = new System.Windows.Forms.TextBox();
            this.lstCrashLogs = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLocateLogs = new MaterialSkin.Controls.MaterialButton();
            this.btn_deletelogfiles = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.lblDiskSpace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDayZPath
            // 
            this.txtDayZPath.Location = new System.Drawing.Point(238, 85);
            this.txtDayZPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtDayZPath.Name = "txtDayZPath";
            this.txtDayZPath.ReadOnly = true;
            this.txtDayZPath.Size = new System.Drawing.Size(384, 24);
            this.txtDayZPath.TabIndex = 0;
            // 
            // lstCrashLogs
            // 
            this.lstCrashLogs.FormattingEnabled = true;
            this.lstCrashLogs.ItemHeight = 17;
            this.lstCrashLogs.Location = new System.Drawing.Point(18, 124);
            this.lstCrashLogs.Margin = new System.Windows.Forms.Padding(4);
            this.lstCrashLogs.Name = "lstCrashLogs";
            this.lstCrashLogs.Size = new System.Drawing.Size(921, 480);
            this.lstCrashLogs.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(947, 124);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 432);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btnLocateLogs
            // 
            this.btnLocateLogs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLocateLogs.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLocateLogs.Depth = 0;
            this.btnLocateLogs.HighEmphasis = true;
            this.btnLocateLogs.Icon = null;
            this.btnLocateLogs.Location = new System.Drawing.Point(632, 76);
            this.btnLocateLogs.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnLocateLogs.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLocateLogs.Name = "btnLocateLogs";
            this.btnLocateLogs.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLocateLogs.Size = new System.Drawing.Size(228, 36);
            this.btnLocateLogs.TabIndex = 5;
            this.btnLocateLogs.Text = "Get Path To DayZ App Data";
            this.btnLocateLogs.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLocateLogs.UseAccentColor = false;
            this.btnLocateLogs.UseVisualStyleBackColor = true;
            this.btnLocateLogs.Click += new System.EventHandler(this.btnLocateLogs_Click_1);
            // 
            // btn_deletelogfiles
            // 
            this.btn_deletelogfiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_deletelogfiles.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_deletelogfiles.Depth = 0;
            this.btn_deletelogfiles.HighEmphasis = true;
            this.btn_deletelogfiles.Icon = null;
            this.btn_deletelogfiles.Location = new System.Drawing.Point(947, 568);
            this.btn_deletelogfiles.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_deletelogfiles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_deletelogfiles.Name = "btn_deletelogfiles";
            this.btn_deletelogfiles.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_deletelogfiles.Size = new System.Drawing.Size(147, 36);
            this.btn_deletelogfiles.TabIndex = 6;
            this.btn_deletelogfiles.Text = "Delete Log Files";
            this.btn_deletelogfiles.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_deletelogfiles.UseAccentColor = false;
            this.btn_deletelogfiles.UseVisualStyleBackColor = true;
            this.btn_deletelogfiles.Click += new System.EventHandler(this.btn_deletelogfiles_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Path to AppData DayZ fodler:";
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Location = new System.Drawing.Point(629, 133);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(91, 17);
            this.lblFileCount.TabIndex = 8;
            this.lblFileCount.Text = "File Cout: 0";
            // 
            // lblDiskSpace
            // 
            this.lblDiskSpace.AutoSize = true;
            this.lblDiskSpace.Location = new System.Drawing.Point(629, 168);
            this.lblDiskSpace.Name = "lblDiskSpace";
            this.lblDiskSpace.Size = new System.Drawing.Size(166, 17);
            this.lblDiskSpace.TabIndex = 9;
            this.lblDiskSpace.Text = "Recoverable space: 0 B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 664);
            this.Controls.Add(this.lblDiskSpace);
            this.Controls.Add(this.lblFileCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_deletelogfiles);
            this.Controls.Add(this.btnLocateLogs);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstCrashLogs);
            this.Controls.Add(this.txtDayZPath);
            this.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4, 84, 4, 4);
            this.Text = "DayZ Crash Log Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDayZPath;
        private System.Windows.Forms.ListBox lstCrashLogs;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialButton btnLocateLogs;
        private MaterialSkin.Controls.MaterialButton btn_deletelogfiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.Label lblDiskSpace;
    }
}

