using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Runtime.Intrinsics.Arm;

namespace TrainStationProject
{
    public partial class frmMain : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        string path = "Data Source=D:\\УЧЁБА_ТИМ\\курсач\\dataBaseTrains.db";
        frmLogin parent;

        public frmMain(frmLogin f, string user)
        {
            InitializeComponent();
            //AllocConsole();
            parent = f;
            Location = parent.Location;
            rebuild();
            lbUser.Text = user;
            if (user != "admin")
            {
                btnAdd.Hide();
                btnUpd.Hide();
                btnDel.Hide();
            }
        }

        public void rebuild()
        {
            int saveRow = 0;
            if (dgv.Rows.Count > 1)
                saveRow = dgv.FirstDisplayedCell.RowIndex;
            dgv.Rows.Clear();
            using (SqliteConnection connection = new SqliteConnection(path))
            {
                connection.Open();
                string sql_exp = "select * from table_trains where id_ >= 0";
                if (cbId.SelectedIndex != -1) sql_exp += " and id_ = " + cbId.SelectedItem;
                if (cbNum.SelectedIndex != -1) sql_exp += " and num_ = '" + cbNum.SelectedItem + "'";
                if (cbFrom.SelectedIndex != -1) sql_exp += " and from_ = '" + cbFrom.SelectedItem + "'";
                if (cbTo.SelectedIndex != -1) sql_exp += " and to_ = '" + cbTo.SelectedItem + "'";
                if (cbArr.SelectedIndex != -1) sql_exp += " and time_arr_ = '" + cbArr.SelectedItem + "'";
                if (cbDep.SelectedIndex != -1) sql_exp += " and time_dep_ = '" + cbDep.SelectedItem + "'";
                sql_exp += ";";
                //Console.WriteLine(sql_exp);
                SqliteCommand command = new SqliteCommand(sql_exp, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgv.Rows.Add(new object[]
                        {
                            reader.GetValue(0),
                            reader.GetValue(1),
                            reader.GetValue(2),
                            reader.GetValue(3),
                            reader.GetValue(4),
                            reader.GetValue(5)
                        });
                    }
                }
            }
            if (saveRow != 0 && saveRow < dgv.Rows.Count)
                dgv.FirstDisplayedScrollingRowIndex = saveRow;
            rebuild_combo();
        }

        private void rebuild_combo()
        {
            var saveId = cbId.SelectedItem;
            var saveNum = cbNum.SelectedItem;
            var saveFrom = cbFrom.SelectedItem;
            var saveTo = cbTo.SelectedItem;
            var saveArr = cbArr.SelectedItem;
            var saveDep = cbDep.SelectedItem;

            cbId.Items.Clear();
            cbNum.Items.Clear();
            cbFrom.Items.Clear();
            cbTo.Items.Clear();
            cbArr.Items.Clear();
            cbDep.Items.Clear();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Index == dgv.Rows.Count - 1) break;

                string id = row.Cells["id"].Value.ToString();
                if (!cbId.Items.Contains(id)) cbId.Items.Add(id);

                string num = row.Cells["num"].Value.ToString();
                if (!cbNum.Items.Contains(num)) cbNum.Items.Add(num);

                string from = row.Cells["from"].Value.ToString();
                if (!cbFrom.Items.Contains(from)) cbFrom.Items.Add(from);

                string to = row.Cells["to"].Value.ToString();
                if (!cbTo.Items.Contains(to)) cbTo.Items.Add(to);

                string arr = row.Cells["time_arr"].Value.ToString();
                if (!cbArr.Items.Contains(arr)) cbArr.Items.Add(arr);

                string dep = row.Cells["time_dep"].Value.ToString();
                if (!cbDep.Items.Contains(dep)) cbDep.Items.Add(dep);
            }

            cbId.SelectedItem = saveId;
            cbNum.SelectedItem = saveNum;
            cbFrom.SelectedItem = saveFrom;
            cbTo.SelectedItem = saveTo;
            cbArr.SelectedItem = saveArr;
            cbDep.SelectedItem = saveDep;
        }

        private bool mode = true;
        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode)
            {
                mode = false;
                rebuild();
                mode = true;
            }
        }

        private void cbNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode)
            {
                mode = false;
                rebuild();
                mode = true;
            }
        }

        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode)
            {
                mode = false;
                rebuild();
                mode = true;
            }
        }

        private void cbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode)
            {
                mode = false;
                rebuild();
                mode = true;
            }
        }

        private void cbArr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode)
            {
                mode = false;
                rebuild();
                mode = true;
            }
        }

        private void cbDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode)
            {
                mode = false;
                rebuild();
                mode = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mode = false;
            cbId.SelectedItem = null;
            cbId.Text = "Id";
            cbNum.SelectedItem = null;
            cbNum.Text = "Номер";
            cbFrom.SelectedItem = null;
            cbFrom.Text = "Откуда";
            cbTo.SelectedItem = null;
            cbTo.Text = "Куда";
            cbArr.SelectedItem = null;
            cbArr.Text = "Отправление";
            cbDep.SelectedItem = null;
            cbDep.Text = "Прибытие";
            rebuild();
            mode = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdd f = new frmAdd(this);
            f.Show();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedCells.Count == 0)
            {
                return;
            }
            this.Hide();
            frmChange f = new frmChange(this, dgv);
            f.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedCells.Count == 0)
            {
                return;
            }
            int row_ind = dgv.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgv.Rows[row_ind];
            string id = row.Cells["id"].Value.ToString();
            using (SqliteConnection connection = new SqliteConnection(path))
            {
                connection.Open();
                string sql_exp = "delete from table_trains where id_ = " + id + ";";
                SqliteCommand command = new SqliteCommand(sql_exp, connection);
                int res = command.ExecuteNonQuery();
                //Console.WriteLine($"Удалено записей: {res}");
            }
            rebuild();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                base.WndProc(ref m);
                if ((int)m.Result == 0x1)
                    m.Result = (IntPtr)0x2;
                return;
            }
            base.WndProc(ref m);
        }
    }
}