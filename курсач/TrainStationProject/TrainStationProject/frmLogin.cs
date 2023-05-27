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
    public partial class frmLogin : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        string path = "Data Source=D:\\УЧЁБА_ТИМ\\курсач\\dataBaseTrains.db";

        public frmLogin()
        {
            InitializeComponent();
            //AllocConsole();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataGridView cur = new DataGridView();
            cur.Columns.Add("id", "text-id");
            cur.Columns.Add("login", "text-login");
            cur.Columns.Add("password", "text-password");
            using (SqliteConnection connection = new SqliteConnection(path))
            {
                connection.Open();
                string sql_exp = "select * from table_users where login_ = '" + txtLogin.Text
                                                      + "' and password_ = '" + txtPassword.Text + "';";
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
            if (cur.Rows.Count - 1 > 0)
            {
                //Console.WriteLine("Login: " + txtLogin.Text + " " + txtPassword.Text);
                this.Hide();
                frmMain f = new frmMain(this, txtLogin.Text);
                f.Show();
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistration f = new frmRegistration(this);
            f.Show();
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
