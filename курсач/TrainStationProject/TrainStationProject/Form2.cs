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
    public partial class frmAdd : Form
    {
        string path = "Data Source=D:\\УЧЁБА_ТИМ\\курсач\\dataBaseTrains.db";
        frmMain parent;

        public frmAdd(frmMain f)
        {
            InitializeComponent();
            parent = f;
            Location = parent.Location;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqliteConnection connection = new SqliteConnection(path))
            {
                connection.Open();
                string sql_exp =
                "insert into table_trains (num_, from_, to_, time_arr_, time_dep_) values(" + "'" + txtNum.Text + "', "
                                                                                            + "'" + txtFrom.Text + "', "
                                                                                            + "'" + txtTo.Text + "', "
                                                                                            + "'" + timeArr.Value.ToShortTimeString() + "', "
                                                                                            + "'" + timeDep.Value.ToShortTimeString() + "');";
                SqliteCommand command = new SqliteCommand(sql_exp, connection);
                int res = command.ExecuteNonQuery();
                //Console.WriteLine($"Добавлено записей: {res}");
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
