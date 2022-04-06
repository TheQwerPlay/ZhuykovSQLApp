using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZhuykovSQLApp
{
    public partial class MainForm : Form
    {
        DateBase db;
        DataTable table = null;
        MySqlDataAdapter adapter = null;
        public MainForm()
        {
            InitializeComponent();
            db = new DateBase();
            db.openConnection();
        }

        private void sweetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Clear();
            adapter = new MySqlDataAdapter("SELECT * FROM `sweets`", db.getConnection());
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Clear();
            adapter = new MySqlDataAdapter("SELECT * FROM `supplier`", db.getConnection());
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void arrivalLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Clear();
            adapter = new MySqlDataAdapter("SELECT * FROM `arrivallog`", db.getConnection());
            //ALTER TABLE `arrivallog` ADD FOREIGN KEY(`id_supplier`) REFERENCES `supplier`(`id_supplier`) ON DELETE RESTRICT ON UPDATE RESTRICT;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.closeConnection();
        }        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            table = new DataTable();
            if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText.ToString() == "id_sweet")
            {
                table.Clear();
                string s = dataGridView1.CurrentCell.Value.ToString();
                adapter = new MySqlDataAdapter($"SELECT * FROM `sweets` WHERE `id_sweet` = {s}", db.getConnection());
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText.ToString() == "id_supplier")
            {
                table.Clear();
                string s = dataGridView1.CurrentCell.Value.ToString();
                adapter = new MySqlDataAdapter($"SELECT * FROM `supplier` WHERE `id_supplier` = {s}", db.getConnection());
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void referenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ZhuykovSQLAppHelp.chm");
        }
    }
}
