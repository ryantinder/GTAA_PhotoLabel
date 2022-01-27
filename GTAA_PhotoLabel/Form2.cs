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
    public partial class Form2 : Form
    {
        public List<Classes.Roster> rosterList;
        public List<Classes.Player> playerList;
        public DataTable rosterTable = new DataTable();
        public DataTable playerTable = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(List<Classes.Roster> rl)
        {
            InitializeComponent();
            this.rosterList = rl;

            rosterTable.Columns.Add("Sport", typeof(string));
            playerTable.Columns.Add("No.", typeof(int));
            playerTable.Columns.Add("First Name", typeof(string));
            playerTable.Columns.Add("Last Name", typeof(string));

            bindRows();

        }

        private void bindRows()
        {
            foreach (var roster in rosterList)
            {
                rosterTable.Rows.Add(roster.sport);
            }
            dataGridView1.DataSource = rosterTable;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            bindPlayerData(rosterList.ElementAt(e.RowIndex));
        }

        private void bindPlayerData(Classes.Roster roster)
        {
            playerTable.Rows.Clear();
            foreach (var player in roster.players)
            {
                playerTable.Rows.Add(player.number, player.firstName, player.lastName);
            }
            dataGridView2.DataSource = playerTable;
        }
    }
}
