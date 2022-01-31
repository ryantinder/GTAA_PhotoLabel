using System.Windows.Forms;

namespace GTAA_PhotoLabel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.jpgOption = new GTAA_PhotoLabel.ToolStripRadioButtonMenuItem();
            this.pngOption = new GTAA_PhotoLabel.ToolStripRadioButtonMenuItem();
            this.appendUnderscoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendTrue = new GTAA_PhotoLabel.ToolStripRadioButtonMenuItem();
            this.appendFalse = new GTAA_PhotoLabel.ToolStripRadioButtonMenuItem();
            this.rosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.configureRosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.filePhoto = new System.Windows.Forms.PictureBox();
            this.FileName_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Next_button = new System.Windows.Forms.Button();
            this.Prev_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.current_sport = new System.Windows.Forms.Label();
            this.config_roster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.revert = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.rosterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.ImageFormat,
            this.appendUnderscoreToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.openToolStripMenuItem.Text = "&Open Folder";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // ImageFormat
            // 
            this.ImageFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jpgOption,
            this.pngOption});
            this.ImageFormat.Name = "ImageFormat";
            this.ImageFormat.Size = new System.Drawing.Size(227, 26);
            this.ImageFormat.Text = "Image Format";
            // 
            // jpgOption
            // 
            this.jpgOption.CheckOnClick = true;
            this.jpgOption.Name = "jpgOption";
            this.jpgOption.Size = new System.Drawing.Size(172, 26);
            this.jpgOption.Text = "Format JPG";
            this.jpgOption.Click += new System.EventHandler(this.toggleJPG_PNG);
            // 
            // pngOption
            // 
            this.pngOption.CheckOnClick = true;
            this.pngOption.Name = "pngOption";
            this.pngOption.Size = new System.Drawing.Size(172, 26);
            this.pngOption.Text = "Format PNG";
            this.pngOption.Click += new System.EventHandler(this.toggleJPG_PNG);
            // 
            // appendUnderscoreToolStripMenuItem
            // 
            this.appendUnderscoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appendTrue,
            this.appendFalse});
            this.appendUnderscoreToolStripMenuItem.Name = "appendUnderscoreToolStripMenuItem";
            this.appendUnderscoreToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.appendUnderscoreToolStripMenuItem.Text = "Append Underscore";
            // 
            // appendTrue
            // 
            this.appendTrue.CheckOnClick = true;
            this.appendTrue.Name = "appendTrue";
            this.appendTrue.Size = new System.Drawing.Size(224, 26);
            this.appendTrue.Text = "Append \"_\"";
            this.appendTrue.Click += new System.EventHandler(this.toggleAppend);
            // 
            // appendFalse
            // 
            this.appendFalse.CheckOnClick = true;
            this.appendFalse.Name = "appendFalse";
            this.appendFalse.Size = new System.Drawing.Size(224, 26);
            this.appendFalse.Text = "Do NOT Append \"_\"";
            this.appendFalse.Click += new System.EventHandler(this.toggleAppend);
            // 
            // rosterToolStripMenuItem
            // 
            this.rosterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.configureRosterToolStripMenuItem});
            this.rosterToolStripMenuItem.Name = "rosterToolStripMenuItem";
            this.rosterToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.rosterToolStripMenuItem.Text = "&Roster";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(206, 6);
            // 
            // configureRosterToolStripMenuItem
            // 
            this.configureRosterToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.configureRosterToolStripMenuItem.Name = "configureRosterToolStripMenuItem";
            this.configureRosterToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.configureRosterToolStripMenuItem.Text = "&Configure Rosters";
            this.configureRosterToolStripMenuItem.Click += new System.EventHandler(this.configureRosterToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(222, 6);
            // 
            // filePhoto
            // 
            this.filePhoto.Location = new System.Drawing.Point(0, 66);
            this.filePhoto.Name = "filePhoto";
            this.filePhoto.Size = new System.Drawing.Size(735, 452);
            this.filePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filePhoto.TabIndex = 1;
            this.filePhoto.TabStop = false;
            // 
            // FileName_label
            // 
            this.FileName_label.AutoSize = true;
            this.FileName_label.Location = new System.Drawing.Point(324, 47);
            this.FileName_label.Name = "FileName_label";
            this.FileName_label.Size = new System.Drawing.Size(87, 16);
            this.FileName_label.TabIndex = 2;
            this.FileName_label.Text = "Select Folder";
            this.FileName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 560);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(735, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Next_button
            // 
            this.Next_button.Location = new System.Drawing.Point(415, 525);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(75, 23);
            this.Next_button.TabIndex = 4;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // Prev_button
            // 
            this.Prev_button.Location = new System.Drawing.Point(277, 525);
            this.Prev_button.Name = "Prev_button";
            this.Prev_button.Size = new System.Drawing.Size(75, 23);
            this.Prev_button.TabIndex = 5;
            this.Prev_button.Text = "Previous";
            this.Prev_button.UseVisualStyleBackColor = true;
            this.Prev_button.Click += new System.EventHandler(this.Prev_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(741, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(299, 452);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // current_sport
            // 
            this.current_sport.AutoSize = true;
            this.current_sport.Location = new System.Drawing.Point(738, 47);
            this.current_sport.Name = "current_sport";
            this.current_sport.Size = new System.Drawing.Size(90, 16);
            this.current_sport.TabIndex = 7;
            this.current_sport.Text = "Current Sport: ";
            this.current_sport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // config_roster
            // 
            this.config_roster.Location = new System.Drawing.Point(935, 40);
            this.config_roster.Name = "config_roster";
            this.config_roster.Size = new System.Drawing.Size(105, 23);
            this.config_roster.TabIndex = 8;
            this.config_roster.Text = "Configure";
            this.config_roster.UseVisualStyleBackColor = true;
            this.config_roster.Click += new System.EventHandler(this.configureRosterToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Console Input:";
            // 
            // revert
            // 
            this.revert.Location = new System.Drawing.Point(601, 525);
            this.revert.Name = "revert";
            this.revert.Size = new System.Drawing.Size(134, 23);
            this.revert.TabIndex = 10;
            this.revert.Text = "Revert Name";
            this.revert.UseVisualStyleBackColor = true;
            this.revert.Click += new System.EventHandler(this.revert_Click);
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Location = new System.Drawing.Point(668, 47);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(67, 16);
            this.counter.TabIndex = 11;
            this.counter.Text = "9999/9999";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 594);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.revert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.config_roster);
            this.Controls.Add(this.current_sport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Prev_button);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FileName_label);
            this.Controls.Add(this.filePhoto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Photo Labeller";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;

        private ToolStripMenuItem rosterToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem configureRosterToolStripMenuItem;
        private PictureBox filePhoto;
        private Label FileName_label;
        private TextBox textBox1;
        private Button Next_button;
        private Button Prev_button;
        private DataGridView dataGridView1;
        private Label current_sport;
        private Button config_roster;
        private Label label1;
        private ToolStripMenuItem ImageFormat;
        private ToolStripRadioButtonMenuItem appendTrue;
        private ToolStripRadioButtonMenuItem appendFalse;
        private ToolStripRadioButtonMenuItem jpgOption;
        private ToolStripRadioButtonMenuItem pngOption;
        private ToolStripMenuItem appendUnderscoreToolStripMenuItem;
        private Button revert;
        private Label counter;
    }
}

