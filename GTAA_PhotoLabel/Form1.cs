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
        private MainMenu mainMenu;

        public Form1()
        {
            InitializeComponent();
            mainMenu = new MainMenu();
            MenuItem File = mainMenu.MenuItems.Add("&File");
            File.MenuItems.Add(new MenuItem("&New"));
            File.MenuItems.Add(new MenuItem("&Open"));
            File.MenuItems.Add(new MenuItem("&Exit"));
            this.Menu = mainMenu;
            MenuItem About = mainMenu.MenuItems.Add("&About");
            About.MenuItems.Add(new MenuItem("&About"));
            this.Menu = mainMenu;
            mainMenu.GetForm().BackColor = Color.Indigo;

        }
    }
}
