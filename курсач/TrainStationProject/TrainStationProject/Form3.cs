using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainStationProject
{
    public partial class frmChange : Form
    {
        string path = "Data Source=D:\\УЧЁБА_ТИМ\\курсач\\dataBaseTrains.db";
        frmMain parent;
        DataGridView dgv;

        public frmChange(frmMain f, DataGridView dgv_)
        {
            InitializeComponent();
            parent = f;
            dgv = dgv_;
            int row_ind = dgv.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgv.Rows[row_ind];
            txtNum.Text = row.Cells["num"].Value.ToString();
            txtFrom.Text = row.Cells["from"].Value.ToString();
            txtTo.Text = row.Cells["to"].Value.ToString();
            timeArr.Value = DateTime.Parse(row.Cells["time_arr"].Value.ToString());
            timeDep.Value = DateTime.Parse(row.Cells["time_dep"].Value.ToString());
            Location = parent.Location;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int row_ind = dgv.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgv.Rows[row_ind];
            string id = row.Cells["id"].Value.ToString();
            using (SqliteConnection connection = new SqliteConnection(path))
            {
                connection.Open();
                string sql_exp =
                "update table_trains set num_ = '" + txtNum.Text
                                  + "', from_ = '" + txtFrom.Text
                                    + "', to_ = '" + txtTo.Text
                              + "', time_arr_ = '" + timeArr.Value.ToShortTimeString()
                              + "', time_dep_ = '" + timeDep.Value.ToShortTimeString()
                             + "' where id_ = " + id + ";";
                SqliteCommand command = new SqliteCommand(sql_exp, connection);
                int res = command.ExecuteNonQuery();
                //Console.WriteLine($"Обновлено записей: {res}");
            }
            this.Hide();
            parent.Location = Location;
            parent.Show();
            parent.rebuild();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Location = Location;
            parent.Show();
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
