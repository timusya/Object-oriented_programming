namespace TrainStationProject
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            dgv = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            num = new DataGridViewTextBoxColumn();
            from = new DataGridViewTextBoxColumn();
            to = new DataGridViewTextBoxColumn();
            time_arr = new DataGridViewTextBoxColumn();
            time_dep = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnDel = new Button();
            btnUpd = new Button();
            panelUp = new Panel();
            button1 = new Button();
            lbTit = new Label();
            btnExit = new Button();
            cbFrom = new ComboBox();
            cbId = new ComboBox();
            cbNum = new ComboBox();
            cbTo = new ComboBox();
            cbArr = new ComboBox();
            cbDep = new ComboBox();
            btnCancel = new Button();
            lbUser = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panelUp.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv.BackgroundColor = Color.LightGray;
            dgv.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { id, num, from, to, time_arr, time_dep });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle4;
            dgv.EnableHeadersVisualStyles = false;
            dgv.Location = new Point(19, 178);
            dgv.Name = "dgv";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Silver;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv.RowHeadersWidth = 62;
            dgv.RowTemplate.Height = 33;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.Size = new Size(964, 363);
            dgv.TabIndex = 0;
            // 
            // id
            // 
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            id.DefaultCellStyle = dataGridViewCellStyle3;
            id.HeaderText = "Id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.Width = 150;
            // 
            // num
            // 
            num.HeaderText = "Номер";
            num.MinimumWidth = 8;
            num.Name = "num";
            num.Width = 150;
            // 
            // from
            // 
            from.HeaderText = "Откуда";
            from.MinimumWidth = 8;
            from.Name = "from";
            from.Width = 150;
            // 
            // to
            // 
            to.HeaderText = "Куда";
            to.MinimumWidth = 8;
            to.Name = "to";
            to.Width = 150;
            // 
            // time_arr
            // 
            time_arr.HeaderText = "Прибытие";
            time_arr.MinimumWidth = 8;
            time_arr.Name = "time_arr";
            time_arr.Width = 150;
            // 
            // time_dep
            // 
            time_dep.HeaderText = "Отправление";
            time_dep.MinimumWidth = 8;
            time_dep.Name = "time_dep";
            time_dep.Width = 150;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(47, 581);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(231, 54);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Black;
            btnDel.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(707, 581);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(227, 54);
            btnDel.TabIndex = 2;
            btnDel.Text = "Удалить";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnUpd
            // 
            btnUpd.BackColor = Color.Black;
            btnUpd.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpd.ForeColor = Color.White;
            btnUpd.Location = new Point(376, 581);
            btnUpd.Name = "btnUpd";
            btnUpd.Size = new Size(223, 54);
            btnUpd.TabIndex = 3;
            btnUpd.Text = "Изменить";
            btnUpd.UseVisualStyleBackColor = false;
            btnUpd.Click += btnUpd_Click;
            // 
            // panelUp
            // 
            panelUp.BackColor = Color.Black;
            panelUp.Controls.Add(lbUser);
            panelUp.Controls.Add(button1);
            panelUp.Controls.Add(lbTit);
            panelUp.Controls.Add(btnExit);
            panelUp.Location = new Point(0, 0);
            panelUp.Name = "panelUp";
            panelUp.Size = new Size(995, 60);
            panelUp.TabIndex = 4;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 7);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = true;
            // 
            // lbTit
            // 
            lbTit.AutoSize = true;
            lbTit.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbTit.ForeColor = Color.White;
            lbTit.Location = new Point(376, 9);
            lbTit.Name = "lbTit";
            lbTit.Size = new Size(270, 38);
            lbTit.TabIndex = 6;
            lbTit.Text = "Ж/д станция г. Уфа";
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(933, 7);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 5;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // cbFrom
            // 
            cbFrom.FormattingEnabled = true;
            cbFrom.Location = new Point(385, 117);
            cbFrom.MaxDropDownItems = 100;
            cbFrom.Name = "cbFrom";
            cbFrom.Size = new Size(143, 33);
            cbFrom.Sorted = true;
            cbFrom.TabIndex = 5;
            cbFrom.Text = "Откуда";
            cbFrom.SelectedIndexChanged += cbFrom_SelectedIndexChanged;
            // 
            // cbId
            // 
            cbId.BackColor = SystemColors.Window;
            cbId.ForeColor = SystemColors.WindowText;
            cbId.FormattingEnabled = true;
            cbId.Location = new Point(83, 117);
            cbId.MaxDropDownItems = 100;
            cbId.Name = "cbId";
            cbId.Size = new Size(146, 33);
            cbId.TabIndex = 6;
            cbId.Text = "Id";
            cbId.SelectedIndexChanged += cbId_SelectedIndexChanged;
            // 
            // cbNum
            // 
            cbNum.FormattingEnabled = true;
            cbNum.Location = new Point(237, 117);
            cbNum.MaxDropDownItems = 100;
            cbNum.Name = "cbNum";
            cbNum.Size = new Size(142, 33);
            cbNum.Sorted = true;
            cbNum.TabIndex = 7;
            cbNum.Text = "Номер";
            cbNum.SelectedIndexChanged += cbNum_SelectedIndexChanged;
            // 
            // cbTo
            // 
            cbTo.FormattingEnabled = true;
            cbTo.Location = new Point(534, 117);
            cbTo.MaxDropDownItems = 100;
            cbTo.Name = "cbTo";
            cbTo.Size = new Size(144, 33);
            cbTo.Sorted = true;
            cbTo.TabIndex = 8;
            cbTo.Text = "Куда";
            cbTo.SelectedIndexChanged += cbTo_SelectedIndexChanged;
            // 
            // cbArr
            // 
            cbArr.FormattingEnabled = true;
            cbArr.Location = new Point(684, 117);
            cbArr.MaxDropDownItems = 100;
            cbArr.Name = "cbArr";
            cbArr.Size = new Size(145, 33);
            cbArr.Sorted = true;
            cbArr.TabIndex = 9;
            cbArr.Text = "Прибытие";
            cbArr.SelectedIndexChanged += cbArr_SelectedIndexChanged;
            // 
            // cbDep
            // 
            cbDep.FormattingEnabled = true;
            cbDep.Location = new Point(835, 117);
            cbDep.MaxDropDownItems = 100;
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(148, 33);
            cbDep.Sorted = true;
            cbDep.TabIndex = 10;
            cbDep.Text = "Отправление";
            cbDep.SelectedIndexChanged += cbDep_SelectedIndexChanged;
            // 
            // btnCancel
            // 
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(19, 107);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(50, 50);
            btnCancel.TabIndex = 11;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUser.ForeColor = Color.White;
            lbUser.Location = new Point(68, 15);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(63, 32);
            lbUser.TabIndex = 8;
            lbUser.Text = "User";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(995, 657);
            Controls.Add(btnCancel);
            Controls.Add(cbDep);
            Controls.Add(cbArr);
            Controls.Add(cbTo);
            Controls.Add(cbNum);
            Controls.Add(cbId);
            Controls.Add(cbFrom);
            Controls.Add(panelUp);
            Controls.Add(btnUpd);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(dgv);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panelUp.ResumeLayout(false);
            panelUp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv;
        private Button btnDel;
        private Button btnUpd;
        private Panel panelUp;
        private Button btnExit;
        private Button button1;
        private Label lbTit;
        private Button btnAdd;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn num;
        private DataGridViewTextBoxColumn from;
        private DataGridViewTextBoxColumn to;
        private DataGridViewTextBoxColumn time_arr;
        private DataGridViewTextBoxColumn time_dep;
        private ComboBox cbFrom;
        private ComboBox cbId;
        private ComboBox cbNum;
        private ComboBox cbTo;
        private ComboBox cbArr;
        private ComboBox cbDep;
        private Button btnCancel;
        private Label lbUser;
    }
}