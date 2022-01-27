using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace GTAA_PhotoLabel
{
    public partial class Form1 : Form
    {
        private Form2 rosterConfigForm;
        public List<Classes.Roster> rosterList;
        private DataTable playerTable;
        private string[] activeFiles;
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
            loadRosters();
            foreach (Classes.Roster roster in rosterList) {
                var radioItem = new ToolStripRadioButtonMenuItem(roster);
                radioItem.Click += new EventHandler(this.rosterSelected);
                rosterToolStripMenuItem.DropDownItems.Insert(0, radioItem);
            }
            playerTable = new DataTable();
            playerTable.Columns.Add("No.", typeof(int));
            playerTable.Columns.Add("Last", typeof(string));
            playerTable.Columns.Add("First", typeof(string));

            rosterToolStripMenuItem.DropDownItems[0].PerformClick();
            Console.WriteLine(this.menuStrip1.Items["&Roster"]);
        }


        private void nextImage()
        {
            index = ++index > activeFiles.Length - 1 ? activeFiles.Length - 1 : index;
            string filePath = activeFiles[index];
            filePhoto.Load(filePath);
            setFilenameLabel(filePath);
        }
        private void loadImage()
        {
            filePhoto.Load(activeFiles[index]);
            setFilenameLabel(activeFiles[index]);
        }

        private void lastImage()
        {
            index = --index < 0 ? 0 : index;
            string filePath = activeFiles[index];
            filePhoto.Load(filePath);
            setFilenameLabel(filePath);
        }

        private void setFilenameLabel(string path)
        {
            FileName_label.Text = path.Split('\\').Last();
        }

        private void rosterSelected(object sender, EventArgs e)
        {
            ToolStripRadioButtonMenuItem actualSender = (ToolStripRadioButtonMenuItem)sender;
            playerTable.Rows.Clear();
            foreach (var player in actualSender.roster.players)
            {
                playerTable.Rows.Add(player.number, player.lastName, player.firstName);
            }
            dataGridView1.DataSource = playerTable;
        }

        private void configureRosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rosterConfigForm = new Form2(rosterList);
            rosterConfigForm.Show();
        }

        private string dirName;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                dirName = dialog.FileName;
                dialog.Dispose();
                activeFiles = Directory.GetFiles(dirName);
                index = 0;
                loadImage();
            }
        }
        private void renameFile(string newName, string oldPath)
        {
            
            try
            {
                filePhoto.Image.Dispose();
                nextImage();
                if (oldPath == null)
                {
                    throw new Exception("oldPath cannot be null");
                } 
                if (newName == null)
                {
                    throw new Exception("newName cannot be null");
                }
                var oldPathSplits = oldPath.Split('\\');
                oldPathSplits[oldPathSplits.Length - 1] = newName;
                oldPathSplits[0] += "\\";
                var newFilePath = Path.Combine(oldPathSplits);
                if (File.Exists(newFilePath))
                {
                    File.Delete(newFilePath);
                } 
                if (!File.Exists(oldPath))
                {
                    throw new Exception(oldPath + " path does not exist");
                }
             
                File.Move(oldPath, newFilePath);
                activeFiles[index] = newFilePath;
            } catch (ArgumentException e)
            {
                Console.WriteLine("Old path: " + oldPath);
                Console.WriteLine("new name: " + newName);
                Console.WriteLine("File name contains illegal characters.");
                Console.WriteLine(e.Message);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            Console.WriteLine(ConfigurationManager.AppSettings.Get("rosterArray"));
            //nextImage();
        }

        private void Prev_button_Click(object sender, EventArgs e)
        {
            lastImage();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Enter
            {
                var input = textBox1.Text.Trim();
                if (int.TryParse(input, out int num))
                {
                    inputPlayerNumber(num);
                }
                textBox1.Text = "";
            }
        }

        private void configRoster(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void inputPlayerNumber(int num)
        {
            throw new NotImplementedException();
        }
        private void loadRosters()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsin = new FileStream("rosters.binary", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    rosterList = (List<Classes.Roster>)bf.Deserialize(fsin);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void saveRosters()
        {
            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsout = new FileStream("rosters.binary", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, rosterList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
