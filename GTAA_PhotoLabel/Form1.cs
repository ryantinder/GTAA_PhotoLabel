using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace GTAA_PhotoLabel
{
    public partial class Form1 : Form
    {
        private Form2 rosterConfigForm;
        public List<Classes.Roster> rosterList;
        private DataTable playerTable;
        private List<Classes.PhotoFile> activeFiles;
        private int index = 0;
        private List<Classes.Player> activeRoster;
        private ToolStripItem configButton;
        private ToolStripSeparator spacer;
        public Form1()
        {
            InitializeComponent();
            configButton = rosterToolStripMenuItem.DropDownItems[rosterToolStripMenuItem.DropDownItems.Count - 1];
            spacer = (ToolStripSeparator)rosterToolStripMenuItem.DropDownItems[rosterToolStripMenuItem.DropDownItems.Count - 2];
            playerTable = new DataTable();
            activeFiles = new List<Classes.PhotoFile>();
            rosterList = new List<Classes.Roster>();
            playerTable.Columns.Add("No.", typeof(string));
            playerTable.Columns.Add("Last", typeof(string));
            playerTable.Columns.Add("First", typeof(string));
            loadRosters();
            Initialize();

        }

        private void Initialize()
        {
            rosterToolStripMenuItem.DropDownItems.Clear();
            rosterToolStripMenuItem.DropDownItems.Add(spacer);
            rosterToolStripMenuItem.DropDownItems.Add(configButton);
            int i = 0;
            foreach (Classes.Roster roster in rosterList)
            {
                var radioItem = new ToolStripRadioButtonMenuItem(roster);
                radioItem.Click += new EventHandler(this.rosterSelected);
                rosterToolStripMenuItem.DropDownItems.Insert(0 + i++, radioItem);
            }
            rosterToolStripMenuItem.DropDownItems[0].PerformClick();
            jpgOption.PerformClick();
            appendTrue.PerformClick();
            counter.Text = "0/0";
        }
        private void nextImage()
        {
            index = ++index > activeFiles.Count - 1 ? activeFiles.Count - 1 : index;
            string filePath = activeFiles[index].filePath;
            filePhoto.Load(filePath);
            setFilenameLabel(filePath);
        }
        private void loadImage()
        {
            filePhoto.Load(activeFiles[index].filePath);
            setFilenameLabel(activeFiles[index].filePath);
            updateCounter();
        }

        private void lastImage()
        {
            index = --index < 0 ? 0 : index;
            string filePath = activeFiles[index].filePath;
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
            current_sport.Text = actualSender.roster.sport;
            activeRoster = actualSender.roster.players;
        }

        private void configureRosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rosterConfigForm = new Form2(rosterList);
            rosterConfigForm.Owner = this;
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
                foreach (var file in Directory.GetFiles(dirName))
                {
                    var photo = new Classes.PhotoFile(file);
                    activeFiles.Add(photo);
                }
                index = 0;
                loadImage();
            }
        }
        private void renameFile(Classes.Player player, string oldPath)
        {
            
            try
            {
                filePhoto.Image.Dispose();
                nextImage();
                if (oldPath == null)
                {
                    throw new Exception("oldPath cannot be null");
                } 
                if (player == null)
                {
                    throw new Exception("player cannot be null");
                }
                if (player.lastName == null || player.firstName == null)
                {
                    throw new Exception("Player names cannot be null");
                }
                var oldPathSplits = oldPath.Split('\\');
                if (append)
                {
                    oldPathSplits[oldPathSplits.Length - 1] = player.lastName + player.firstName[0] + "_" + oldPathSplits[oldPathSplits.Length - 1];
                } else
                {
                    oldPathSplits[oldPathSplits.Length - 1] = player.lastName + player.firstName[0] + oldPathSplits[oldPathSplits.Length - 1];
                }
                oldPathSplits[0] += "\\";
                var newFilePath = Path.Combine(oldPathSplits);
                if (useJPG)
                {
                    Path.ChangeExtension(newFilePath, ".jpg");
                } else
                {
                    Path.ChangeExtension(newFilePath, ".png");
                }
                if (File.Exists(newFilePath))
                {
                    File.Delete(newFilePath);
                } 
                if (!File.Exists(oldPath))
                {
                    throw new Exception(oldPath + " path does not exist");
                }
             
                File.Move(oldPath, newFilePath);
                activeFiles[index - 1].filePath = newFilePath;
            } catch (ArgumentException e)
            {
                Console.WriteLine("Old path: " + oldPath);
                Console.WriteLine("new name: " + player.lastName + player.firstName[0]);
                Console.WriteLine("File name contains illegal characters.");
                Console.WriteLine(e.Message);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
                if (useJPG)
                {
                    Path.ChangeExtension(newFilePath, ".jpg");
                }
                else
                {
                    Path.ChangeExtension(newFilePath, ".png");
                }
                if (File.Exists(newFilePath))
                {
                    File.Delete(newFilePath);
                }
                if (!File.Exists(oldPath))
                {
                    throw new Exception(oldPath + " path does not exist");
                }

                File.Move(oldPath, newFilePath);
                activeFiles[index - 1].filePath = newFilePath;

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Old path: " + oldPath);
                Console.WriteLine("new name: " + newName);
                Console.WriteLine("File name contains illegal characters.");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            if (activeFiles != null && activeFiles.Count > 0)
            {
                nextImage();
                updateCounter();
            }
        }

        private void Prev_button_Click(object sender, EventArgs e)
        {
            if (activeFiles != null && activeFiles.Count > 0)
            {
                lastImage();
                updateCounter();
            }
        }

        private void updateCounter()
        {
            counter.Text = (index + 1) + "/" + activeFiles.Count;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Enter
            {
                var input = textBox1.Text.Trim();
                if (int.TryParse(input, out int num) && activeFiles != null && activeFiles.Count > 0)
                {
                    inputPlayerNumber(num);
                }
                textBox1.Text = "";
            }
        }

        private void inputPlayerNumber(int num)
        {
            foreach(var player in activeRoster)
            {
                if (player.number == num)
                {
                    renameFile(player, activeFiles[index].filePath);
                    break;
                }
            }
        }
        private void loadRosters()
        {
            BinaryFormatter bf = new BinaryFormatter();
            if (!File.Exists("rosters.binary"))
            {
                File.Create("rosters.binary");
            }
            FileStream fsin = new FileStream("rosters.binary", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    if (fsin.Length == 0)
                    {
                        Classes.Roster r = new Classes.Roster("Placeholder");
                        rosterList.Add(r);
                        saveRosters();
                    }
                    else
                    {
                        rosterList = (List<Classes.Roster>)bf.Deserialize(fsin);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void saveRosterData(List<Classes.Roster> list)
        {
            rosterList = list;
            Initialize();
            saveRosters();

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (activeFiles != null && activeFiles.Count > 0 && int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value as string, out int num))
            {
                inputPlayerNumber(num);
            }
        }
        private bool append = false; //gets set to true on run
        private void toggleAppend(object sender, EventArgs e)
        {
            append = append == true ? false : true;
        }
        private bool useJPG = false; //Gets set to true on run
        private void toggleJPG_PNG(object sender, EventArgs e)
        {
            useJPG = useJPG == true ? false : true;
        }

        private void revert_Click(object sender, EventArgs e)
        {
            if (activeFiles != null && activeFiles.Count > 0)
            {
                renameFile(activeFiles[index].originalName, activeFiles[index].filePath);
                lastImage();
            }
        }
    }
}
