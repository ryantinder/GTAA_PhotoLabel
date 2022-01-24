using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTAA_PhotoLabel
{
    public partial class Form1 : Form
    {
        private string[] sportsArr = {"Basketball", "Football", "Volleyball" };
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
        private void rosterSelected(object sender, EventArgs e)
        {
            var actualSender = (ToolStripRadioButtonMenuItem)sender;
            Console.WriteLine(actualSender.Text);
        }

        private void configureRosterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
