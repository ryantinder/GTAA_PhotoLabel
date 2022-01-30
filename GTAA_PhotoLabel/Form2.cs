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
        public Classes.Roster roster;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(List<Classes.Roster> rl)
        {
            InitializeComponent();
            this.rosterList = rl;

            rosterTable.Columns.Add("Sport", typeof(string));
            playerTable.Columns.Add("No.", typeof(string));
            playerTable.Columns.Add("Last Name", typeof(string));
            playerTable.Columns.Add("First Name", typeof(string));

            bindRows();

        }

        private void bindRows()
        {
            rosterTable.Rows.Clear();
            foreach (var roster in rosterList)
            {
                rosterTable.Rows.Add(roster.sport);
            }
            dataGridView1.DataSource = rosterTable;
            dataGridView1.Columns[0].FillWeight = 25;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            roster = rosterList.ElementAt(e.RowIndex);
            bindPlayerData();
        }

        private void bindPlayerData()
        {
            playerTable.AcceptChanges();
            playerTable.Rows.Clear();
            foreach (var player in roster.players)
            {
                playerTable.Rows.Add(player.number, player.lastName, player.firstName);
            }
            dataGridView2.DataSource = playerTable;
        }

        private void add_roster_Click(object sender, EventArgs e)
        {
            rosterList.Add(new Classes.Roster());
            bindRows();
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 parent = (Form1)this.Owner;
            parent.saveRosterData(rosterList);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            rosterList[e.RowIndex].sport = dataGridView1.Rows[e.RowIndex].Cells[0].Value as string ?? "";
            bindRows();
        }

        private void remove_roster_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                rosterList.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
            bindRows();
        }

        private void add_player_Click(object sender, EventArgs e)
        {
            roster.addPlayer(0, "First", "Last");
            bindPlayerData();
        }

        private void remove_player_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                roster.players.RemoveAt(dataGridView2.CurrentCell.RowIndex);
            }
            bindPlayerData();
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null || (string)dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "")
            {
                playerTable.RejectChanges();
                return;
            }

            if (e.ColumnIndex == 0)
            {
                if (int.TryParse(dataGridView2.Rows[e.RowIndex].Cells[0].Value as string, out int result))
                {
                    roster.players[e.RowIndex].number = result;
                } else
                {
                    roster.players[e.RowIndex].number = 0;
                }
            } 
            else if (e.ColumnIndex == 1) {
                roster.players[e.RowIndex].lastName = dataGridView2.Rows[e.RowIndex].Cells[1].Value as string;

            }
            else if (e.ColumnIndex == 2)
            {
                roster.players[e.RowIndex].firstName = dataGridView2.Rows[e.RowIndex].Cells[2].Value as string;
            }
            bindPlayerData();
        }
    }
}
