using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTAA_PhotoLabel
{
    public partial class Form1 : Form
    {
        private string[] sportsArr = {"Basketball", "Football", "Volleyball" };
        private string[] activeFiles;
        public Form1()
        {
            InitializeComponent();
            foreach (string val in sportsArr) {
                var radioItem = new ToolStripRadioButtonMenuItem(val);
                radioItem.Click += new EventHandler(this.rosterSelected);

                rosterToolStripMenuItem.DropDownItems.Insert(0, radioItem);
            }
            Console.WriteLine(this.menuStrip1.Items["&Roster"]);
        }
        private void loadFiles()
        {
            filePhoto.Load(activeFiles[0]);
            FileName_label.Text = activeFiles[0].Split('\\').Last();
            Console.WriteLine(activeFiles[0]);
        }


        private void rosterSelected(object sender, EventArgs e)
        {
            var actualSender = (ToolStripRadioButtonMenuItem)sender;
            Console.WriteLine(actualSender.Text);
        }

        private void configureRosterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                activeFiles = Directory.GetFiles(dialog.FileName);
                loadFiles();
            }
        }
    }
}
