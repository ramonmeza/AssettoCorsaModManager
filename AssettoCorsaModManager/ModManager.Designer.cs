namespace AssettoCorsaModManager
{
    partial class ModManager
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
            this.lbl_MainDirectory = new System.Windows.Forms.Label();
            this.btn_MainDirectory = new System.Windows.Forms.Button();
            this.dialog_MainDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_MainHeader = new System.Windows.Forms.Label();
            this.lbl_CarsDisabled = new System.Windows.Forms.Label();
            this.lbl_CarsEnabled = new System.Windows.Forms.Label();
            this.btn_Enable = new System.Windows.Forms.Button();
            this.btn_Disable = new System.Windows.Forms.Button();
            this.list_CarsDisabled = new System.Windows.Forms.CheckedListBox();
            this.list_CarsEnabled = new System.Windows.Forms.CheckedListBox();
            this.TabGroup = new System.Windows.Forms.TabControl();
            this.tab_Cars = new System.Windows.Forms.TabPage();
            this.tab_Tracks = new System.Windows.Forms.TabPage();
            this.list_TracksEnabled = new System.Windows.Forms.CheckedListBox();
            this.list_TracksDisabled = new System.Windows.Forms.CheckedListBox();
            this.lbl_TracksEnabled = new System.Windows.Forms.Label();
            this.lbl_TracksDisabled = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabGroup.SuspendLayout();
            this.tab_Cars.SuspendLayout();
            this.tab_Tracks.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MainDirectory
            // 
            this.lbl_MainDirectory.AutoSize = true;
            this.lbl_MainDirectory.Location = new System.Drawing.Point(106, 56);
            this.lbl_MainDirectory.Name = "lbl_MainDirectory";
            this.lbl_MainDirectory.Size = new System.Drawing.Size(41, 13);
            this.lbl_MainDirectory.TabIndex = 0;
            this.lbl_MainDirectory.Text = "Not set";
            // 
            // btn_MainDirectory
            // 
            this.btn_MainDirectory.Location = new System.Drawing.Point(16, 51);
            this.btn_MainDirectory.Name = "btn_MainDirectory";
            this.btn_MainDirectory.Size = new System.Drawing.Size(75, 23);
            this.btn_MainDirectory.TabIndex = 1;
            this.btn_MainDirectory.Text = "Choose";
            this.btn_MainDirectory.UseVisualStyleBackColor = true;
            this.btn_MainDirectory.Click += new System.EventHandler(this.btn_MainDirectory_Click);
            // 
            // dialog_MainDirectory
            // 
            this.dialog_MainDirectory.Description = "Please select your Assetto Corsa game folder";
            this.dialog_MainDirectory.ShowNewFolderButton = false;
            // 
            // lbl_MainHeader
            // 
            this.lbl_MainHeader.AutoSize = true;
            this.lbl_MainHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MainHeader.Location = new System.Drawing.Point(12, 28);
            this.lbl_MainHeader.Name = "lbl_MainHeader";
            this.lbl_MainHeader.Size = new System.Drawing.Size(197, 20);
            this.lbl_MainHeader.TabIndex = 4;
            this.lbl_MainHeader.Text = "Assetto Corsa Main Folder";
            // 
            // lbl_CarsDisabled
            // 
            this.lbl_CarsDisabled.AutoSize = true;
            this.lbl_CarsDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CarsDisabled.Location = new System.Drawing.Point(6, 10);
            this.lbl_CarsDisabled.Name = "lbl_CarsDisabled";
            this.lbl_CarsDisabled.Size = new System.Drawing.Size(71, 20);
            this.lbl_CarsDisabled.TabIndex = 7;
            this.lbl_CarsDisabled.Text = "Disabled";
            // 
            // lbl_CarsEnabled
            // 
            this.lbl_CarsEnabled.AutoSize = true;
            this.lbl_CarsEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CarsEnabled.Location = new System.Drawing.Point(397, 10);
            this.lbl_CarsEnabled.Name = "lbl_CarsEnabled";
            this.lbl_CarsEnabled.Size = new System.Drawing.Size(68, 20);
            this.lbl_CarsEnabled.TabIndex = 8;
            this.lbl_CarsEnabled.Text = "Enabled";
            // 
            // btn_Enable
            // 
            this.btn_Enable.Location = new System.Drawing.Point(138, 407);
            this.btn_Enable.Name = "btn_Enable";
            this.btn_Enable.Size = new System.Drawing.Size(112, 23);
            this.btn_Enable.TabIndex = 9;
            this.btn_Enable.Text = "Enable Selected";
            this.btn_Enable.UseVisualStyleBackColor = true;
            this.btn_Enable.Click += new System.EventHandler(this.btn_Enable_Click);
            // 
            // btn_Disable
            // 
            this.btn_Disable.Location = new System.Drawing.Point(543, 407);
            this.btn_Disable.Name = "btn_Disable";
            this.btn_Disable.Size = new System.Drawing.Size(112, 23);
            this.btn_Disable.TabIndex = 10;
            this.btn_Disable.Text = "Disable Selected";
            this.btn_Disable.UseVisualStyleBackColor = true;
            this.btn_Disable.Click += new System.EventHandler(this.btn_Disable_Click);
            // 
            // list_CarsDisabled
            // 
            this.list_CarsDisabled.FormattingEnabled = true;
            this.list_CarsDisabled.Location = new System.Drawing.Point(6, 33);
            this.list_CarsDisabled.Name = "list_CarsDisabled";
            this.list_CarsDisabled.Size = new System.Drawing.Size(370, 259);
            this.list_CarsDisabled.TabIndex = 12;
            // 
            // list_CarsEnabled
            // 
            this.list_CarsEnabled.FormattingEnabled = true;
            this.list_CarsEnabled.Location = new System.Drawing.Point(401, 33);
            this.list_CarsEnabled.Name = "list_CarsEnabled";
            this.list_CarsEnabled.Size = new System.Drawing.Size(370, 259);
            this.list_CarsEnabled.TabIndex = 13;
            // 
            // TabGroup
            // 
            this.TabGroup.Controls.Add(this.tab_Cars);
            this.TabGroup.Controls.Add(this.tab_Tracks);
            this.TabGroup.Location = new System.Drawing.Point(12, 81);
            this.TabGroup.Name = "TabGroup";
            this.TabGroup.SelectedIndex = 0;
            this.TabGroup.Size = new System.Drawing.Size(785, 324);
            this.TabGroup.TabIndex = 14;
            // 
            // tab_Cars
            // 
            this.tab_Cars.Controls.Add(this.list_CarsEnabled);
            this.tab_Cars.Controls.Add(this.list_CarsDisabled);
            this.tab_Cars.Controls.Add(this.lbl_CarsEnabled);
            this.tab_Cars.Controls.Add(this.lbl_CarsDisabled);
            this.tab_Cars.Location = new System.Drawing.Point(4, 22);
            this.tab_Cars.Name = "tab_Cars";
            this.tab_Cars.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Cars.Size = new System.Drawing.Size(777, 298);
            this.tab_Cars.TabIndex = 1;
            this.tab_Cars.Text = "Cars";
            this.tab_Cars.UseVisualStyleBackColor = true;
            // 
            // tab_Tracks
            // 
            this.tab_Tracks.Controls.Add(this.list_TracksEnabled);
            this.tab_Tracks.Controls.Add(this.list_TracksDisabled);
            this.tab_Tracks.Controls.Add(this.lbl_TracksEnabled);
            this.tab_Tracks.Controls.Add(this.lbl_TracksDisabled);
            this.tab_Tracks.Location = new System.Drawing.Point(4, 22);
            this.tab_Tracks.Name = "tab_Tracks";
            this.tab_Tracks.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Tracks.Size = new System.Drawing.Size(777, 298);
            this.tab_Tracks.TabIndex = 0;
            this.tab_Tracks.Text = "Tracks";
            this.tab_Tracks.UseVisualStyleBackColor = true;
            // 
            // list_TracksEnabled
            // 
            this.list_TracksEnabled.FormattingEnabled = true;
            this.list_TracksEnabled.Location = new System.Drawing.Point(401, 33);
            this.list_TracksEnabled.Name = "list_TracksEnabled";
            this.list_TracksEnabled.Size = new System.Drawing.Size(370, 259);
            this.list_TracksEnabled.TabIndex = 17;
            // 
            // list_TracksDisabled
            // 
            this.list_TracksDisabled.FormattingEnabled = true;
            this.list_TracksDisabled.Location = new System.Drawing.Point(6, 33);
            this.list_TracksDisabled.Name = "list_TracksDisabled";
            this.list_TracksDisabled.Size = new System.Drawing.Size(370, 259);
            this.list_TracksDisabled.TabIndex = 16;
            // 
            // lbl_TracksEnabled
            // 
            this.lbl_TracksEnabled.AutoSize = true;
            this.lbl_TracksEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TracksEnabled.Location = new System.Drawing.Point(397, 10);
            this.lbl_TracksEnabled.Name = "lbl_TracksEnabled";
            this.lbl_TracksEnabled.Size = new System.Drawing.Size(68, 20);
            this.lbl_TracksEnabled.TabIndex = 15;
            this.lbl_TracksEnabled.Text = "Enabled";
            // 
            // lbl_TracksDisabled
            // 
            this.lbl_TracksDisabled.AutoSize = true;
            this.lbl_TracksDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TracksDisabled.Location = new System.Drawing.Point(6, 10);
            this.lbl_TracksDisabled.Name = "lbl_TracksDisabled";
            this.lbl_TracksDisabled.Size = new System.Drawing.Size(71, 20);
            this.lbl_TracksDisabled.TabIndex = 14;
            this.lbl_TracksDisabled.Text = "Disabled";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.viewSourceToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.howToUseToolStripMenuItem.Text = "How to Use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // viewSourceToolStripMenuItem
            // 
            this.viewSourceToolStripMenuItem.Name = "viewSourceToolStripMenuItem";
            this.viewSourceToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.viewSourceToolStripMenuItem.Text = "View Source";
            this.viewSourceToolStripMenuItem.Click += new System.EventHandler(this.viewSourceToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AssettoCorsaModManager.Properties.Resources.ACMM;
            this.pictureBox1.Location = new System.Drawing.Point(566, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // ModManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 434);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TabGroup);
            this.Controls.Add(this.btn_Disable);
            this.Controls.Add(this.btn_Enable);
            this.Controls.Add(this.lbl_MainHeader);
            this.Controls.Add(this.btn_MainDirectory);
            this.Controls.Add(this.lbl_MainDirectory);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ModManager";
            this.Text = "Assetto Corsa Mod Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModManager_FormClosing);
            this.Load += new System.EventHandler(this.ModManager_Load);
            this.TabGroup.ResumeLayout(false);
            this.tab_Cars.ResumeLayout(false);
            this.tab_Cars.PerformLayout();
            this.tab_Tracks.ResumeLayout(false);
            this.tab_Tracks.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MainDirectory;
        private System.Windows.Forms.Button btn_MainDirectory;
        private System.Windows.Forms.FolderBrowserDialog dialog_MainDirectory;
        private System.Windows.Forms.Label lbl_MainHeader;
        private System.Windows.Forms.Label lbl_CarsDisabled;
        private System.Windows.Forms.Label lbl_CarsEnabled;
        private System.Windows.Forms.Button btn_Enable;
        private System.Windows.Forms.Button btn_Disable;
        private System.Windows.Forms.CheckedListBox list_CarsDisabled;
        private System.Windows.Forms.CheckedListBox list_CarsEnabled;
        private System.Windows.Forms.TabControl TabGroup;
        private System.Windows.Forms.TabPage tab_Cars;
        private System.Windows.Forms.TabPage tab_Tracks;
        private System.Windows.Forms.CheckedListBox list_TracksEnabled;
        private System.Windows.Forms.CheckedListBox list_TracksDisabled;
        private System.Windows.Forms.Label lbl_TracksEnabled;
        private System.Windows.Forms.Label lbl_TracksDisabled;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewSourceToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

