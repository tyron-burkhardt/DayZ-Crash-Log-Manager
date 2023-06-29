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
            this.txtbox_browsetarget = new System.Windows.Forms.TextBox();
            this.listbox_targetfiles = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_browse = new MaterialSkin.Controls.MaterialButton();
            this.btn_deletelogfiles = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox_browsetarget
            // 
            this.txtbox_browsetarget.Location = new System.Drawing.Point(238, 85);
            this.txtbox_browsetarget.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_browsetarget.Name = "txtbox_browsetarget";
            this.txtbox_browsetarget.ReadOnly = true;
            this.txtbox_browsetarget.Size = new System.Drawing.Size(384, 24);
            this.txtbox_browsetarget.TabIndex = 0;
            // 
            // listbox_targetfiles
            // 
            this.listbox_targetfiles.FormattingEnabled = true;
            this.listbox_targetfiles.ItemHeight = 17;
            this.listbox_targetfiles.Location = new System.Drawing.Point(18, 124);
            this.listbox_targetfiles.Margin = new System.Windows.Forms.Padding(4);
            this.listbox_targetfiles.Name = "listbox_targetfiles";
            this.listbox_targetfiles.Size = new System.Drawing.Size(921, 480);
            this.listbox_targetfiles.TabIndex = 2;
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
            // btn_browse
            // 
            this.btn_browse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_browse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_browse.Depth = 0;
            this.btn_browse.HighEmphasis = true;
            this.btn_browse.Icon = null;
            this.btn_browse.Location = new System.Drawing.Point(632, 76);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_browse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_browse.Size = new System.Drawing.Size(228, 36);
            this.btn_browse.TabIndex = 5;
            this.btn_browse.Text = "Get Path To DayZ App Data";
            this.btn_browse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_browse.UseAccentColor = false;
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click_1);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_deletelogfiles);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listbox_targetfiles);
            this.Controls.Add(this.txtbox_browsetarget);
            this.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4, 84, 4, 4);
            this.Text = "DayZ Crash Log Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_browsetarget;
        private System.Windows.Forms.ListBox listbox_targetfiles;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialButton btn_browse;
        private MaterialSkin.Controls.MaterialButton btn_deletelogfiles;
        private System.Windows.Forms.Label label1;
    }
}

