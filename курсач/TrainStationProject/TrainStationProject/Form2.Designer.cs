namespace TrainStationProject
{
    partial class frmAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd));
            lbNum = new Label();
            lbFrom = new Label();
            lbTo = new Label();
            lbArr = new Label();
            lbDep = new Label();
            txtNum = new TextBox();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            btnSave = new Button();
            panelUp = new Panel();
            btnPic = new Button();
            lbTit = new Label();
            btnExit = new Button();
            btnCancel = new Button();
            timeArr = new DateTimePicker();
            timeDep = new DateTimePicker();
            panelUp.SuspendLayout();
            SuspendLayout();
            // 
            // lbNum
            // 
            lbNum.AutoSize = true;
            lbNum.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbNum.Location = new Point(47, 116);
            lbNum.Name = "lbNum";
            lbNum.Size = new Size(82, 28);
            lbNum.TabIndex = 1;
            lbNum.Text = "Номер:";
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbFrom.Location = new Point(47, 159);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new Size(84, 28);
            lbFrom.TabIndex = 2;
            lbFrom.Text = "Откуда:";
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbTo.Location = new Point(47, 204);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(61, 28);
            lbTo.TabIndex = 3;
            lbTo.Text = "Куда:";
            // 
            // lbArr
            // 
            lbArr.AutoSize = true;
            lbArr.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbArr.Location = new Point(47, 248);
            lbArr.Name = "lbArr";
            lbArr.Size = new Size(115, 28);
            lbArr.TabIndex = 4;
            lbArr.Text = "Прибытие:";
            // 
            // lbDep
            // 
            lbDep.AutoSize = true;
            lbDep.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbDep.Location = new Point(47, 288);
            lbDep.Name = "lbDep";
            lbDep.Size = new Size(143, 28);
            lbDep.TabIndex = 5;
            lbDep.Text = "Отправление:";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(196, 113);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(150, 31);
            txtNum.TabIndex = 6;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(196, 159);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(150, 31);
            txtFrom.TabIndex = 7;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(196, 201);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(150, 31);
            txtTo.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            btnSave.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(83, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(228, 62);
            btnSave.TabIndex = 11;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panelUp
            // 
            panelUp.BackColor = Color.Black;
            panelUp.Controls.Add(btnPic);
            panelUp.Controls.Add(lbTit);
            panelUp.Controls.Add(btnExit);
            panelUp.Location = new Point(0, 0);
            panelUp.Name = "panelUp";
            panelUp.Size = new Size(995, 60);
            panelUp.TabIndex = 13;
            // 
            // btnPic
            // 
            btnPic.Image = (Image)resources.GetObject("btnPic.Image");
            btnPic.Location = new Point(12, 7);
            btnPic.Name = "btnPic";
            btnPic.Size = new Size(50, 50);
            btnPic.TabIndex = 7;
            btnPic.UseVisualStyleBackColor = true;
            // 
            // lbTit
            // 
            lbTit.AutoSize = true;
            lbTit.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbTit.ForeColor = Color.White;
            lbTit.Location = new Point(83, 9);
            lbTit.Name = "lbTit";
            lbTit.Size = new Size(181, 38);
            lbTit.TabIndex = 6;
            lbTit.Text = "Добавление";
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
            // btnCancel
            // 
            btnCancel.BackColor = Color.Black;
            btnCancel.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(532, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(241, 62);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // timeArr
            // 
            timeArr.CustomFormat = "HH:mm";
            timeArr.Format = DateTimePickerFormat.Custom;
            timeArr.Location = new Point(196, 246);
            timeArr.Name = "timeArr";
            timeArr.Size = new Size(150, 31);
            timeArr.TabIndex = 30;
            timeArr.Value = new DateTime(2023, 5, 21, 0, 0, 0, 0);
            // 
            // timeDep
            // 
            timeDep.CustomFormat = "HH:mm";
            timeDep.Format = DateTimePickerFormat.Custom;
            timeDep.Location = new Point(196, 288);
            timeDep.Name = "timeDep";
            timeDep.Size = new Size(150, 31);
            timeDep.TabIndex = 29;
            timeDep.Value = new DateTime(2023, 5, 21, 23, 59, 0, 0);
            // 
            // frmAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(995, 657);
            Controls.Add(timeArr);
            Controls.Add(timeDep);
            Controls.Add(btnCancel);
            Controls.Add(panelUp);
            Controls.Add(btnSave);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Controls.Add(txtNum);
            Controls.Add(lbDep);
            Controls.Add(lbArr);
            Controls.Add(lbTo);
            Controls.Add(lbFrom);
            Controls.Add(lbNum);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdd";
            StartPosition = FormStartPosition.Manual;
            panelUp.ResumeLayout(false);
            panelUp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbNum;
        private Label lbFrom;
        private Label lbTo;
        private Label lbArr;
        private Label lbDep;
        private TextBox txtNum;
        private TextBox txtFrom;
        private TextBox txtTo;
        private Button btnSave;
        private Panel panelUp;
        private Button btnPic;
        private Label lbTit;
        private Button btnExit;
        private Button btnCancel;
        private DateTimePicker timeArr;
        private DateTimePicker timeDep;
    }
}