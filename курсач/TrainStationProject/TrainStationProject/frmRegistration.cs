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
    public partial class frmRegistration : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        string path = "Data Source=D:\\УЧЁБА_ТИМ\\курсач\\dataBaseTrains.db";
        frmLogin parent;

        public frmRegistration(frmLogin f)
        {
            InitializeComponent();
            //AllocConsole();
            parent = f;
            Location = parent.Location;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            DataGridView cur = new DataGridView();
            cur.Columns.Add("id", "text-id");
            cur.Columns.Add("login", "text-login");
            cur.Columns.Add("password", "text-password");
            using (SqliteConnection connection = new SqliteConnection(path))
            {
                connection.Open();
                string sql_exp = "select * from table_users where login_ = '" + txtLogin.Text + "';";
                SqliteCommand command = new SqliteCommand(sql_exp, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cur.Rows.Add(new object[]
                        {
                            reader.GetValue(0),
                            reader.GetValue(1),
                            reader.GetValue(2)
                        });
                    }
                }
            }
            if (cur.Rows.Count - 1 == 0)
            {
                using (SqliteConnection connection = new SqliteConnection(path))
                {
                    connection.Open();
                    string sql_exp =
                    "insert into table_users (login_, password_) values ('" + txtLogin.Text + "', '" + txtPassword.Text + "');";
                    SqliteCommand command = new SqliteCommand(sql_exp, connection);
                    int res = command.ExecuteNonQuery();
                    //if (res == 1) Console.WriteLine("Registration: " + txtLogin.Text + " " + txtPassword.Text);
                }
                this.Hide();
                parent.Location = Location;
                parent.Show();
            }
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
