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
            this.rosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.configureRosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePhoto = new System.Windows.Forms.PictureBox();
            this.FileName_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Next_button = new System.Windows.Forms.Button();
            this.Prev_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.menuStrip1.Size = new System.Drawing.Size(995, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
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
            // filePhoto
            // 
            this.filePhoto.Location = new System.Drawing.Point(0, 51);
            this.filePhoto.Name = "filePhoto";
            this.filePhoto.Size = new System.Drawing.Size(735, 467);
            this.filePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filePhoto.TabIndex = 1;
            this.filePhoto.TabStop = false;
            // 
            // FileName_label
            // 
            this.FileName_label.AutoSize = true;
            this.FileName_label.Location = new System.Drawing.Point(265, 32);
            this.FileName_label.Name = "FileName_label";
            this.FileName_label.Size = new System.Drawing.Size(87, 16);
            this.FileName_label.TabIndex = 2;
            this.FileName_label.Text = "Select Folder";
            this.FileName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 568);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(743, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 467);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 637);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Prev_button);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FileName_label);
            this.Controls.Add(this.filePhoto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hello";
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
        private ToolStripMenuItem configureRosterToolStripMenuItem;
        private PictureBox filePhoto;
        private Label FileName_label;
        private TextBox textBox1;
        private Button Next_button;
        private Button Prev_button;
        private DataGridView dataGridView1;
    }
}

