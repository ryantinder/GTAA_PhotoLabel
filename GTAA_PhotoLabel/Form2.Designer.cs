using System;
using System.Windows.Forms;

namespace GTAA_PhotoLabel
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.add_roster = new System.Windows.Forms.Button();
            this.remove_roster = new System.Windows.Forms.Button();
            this.add_player = new System.Windows.Forms.Button();
            this.remove_player = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(210, 334);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(368, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(363, 334);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // add_roster
            // 
            this.add_roster.Location = new System.Drawing.Point(41, 378);
            this.add_roster.Name = "add_roster";
            this.add_roster.Size = new System.Drawing.Size(75, 23);
            this.add_roster.TabIndex = 2;
            this.add_roster.Text = "Add";
            this.add_roster.UseVisualStyleBackColor = true;
            this.add_roster.Click += new System.EventHandler(this.add_roster_Click);
            // 
            // remove_roster
            // 
            this.remove_roster.Location = new System.Drawing.Point(176, 378);
            this.remove_roster.Name = "remove_roster";
            this.remove_roster.Size = new System.Drawing.Size(75, 23);
            this.remove_roster.TabIndex = 3;
            this.remove_roster.Text = "Remove";
            this.remove_roster.UseVisualStyleBackColor = true;
            this.remove_roster.Click += new System.EventHandler(this.remove_roster_Click);
            // 
            // add_player
            // 
            this.add_player.Location = new System.Drawing.Point(368, 378);
            this.add_player.Name = "add_player";
            this.add_player.Size = new System.Drawing.Size(75, 23);
            this.add_player.TabIndex = 4;
            this.add_player.Text = "Add";
            this.add_player.UseVisualStyleBackColor = true;
            this.add_player.Click += new System.EventHandler(this.add_player_Click);
            // 
            // remove_player
            // 
            this.remove_player.Location = new System.Drawing.Point(656, 378);
            this.remove_player.Name = "remove_player";
            this.remove_player.Size = new System.Drawing.Size(75, 23);
            this.remove_player.TabIndex = 5;
            this.remove_player.Text = "Remove";
            this.remove_player.UseVisualStyleBackColor = true;
            this.remove_player.Click += new System.EventHandler(this.remove_player_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.remove_player);
            this.Controls.Add(this.add_player);
            this.Controls.Add(this.remove_roster);
            this.Controls.Add(this.add_roster);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Roster Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button add_roster;
        private System.Windows.Forms.Button remove_roster;
        private System.Windows.Forms.Button add_player;
        private System.Windows.Forms.Button remove_player;
    }
}