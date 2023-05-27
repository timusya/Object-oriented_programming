namespace TrainStationProject
{
    partial class frmChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChange));
            panelUp = new Panel();
            btnPic = new Button();
            lbTit = new Label();
            btnExit = new Button();
            txtTo = new TextBox();
            txtFrom = new TextBox();
            txtNum = new TextBox();
            lbDep = new Label();
            lbArr = new Label();
            lbTo = new Label();
            lbFrom = new Label();
            lbNum = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            timeDep = new DateTimePicker();
            timeArr = new DateTimePicker();
            panelUp.SuspendLayout();
            SuspendLayout();
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
            panelUp.TabIndex = 14;
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
            lbTit.Size = new Size(169, 38);
            lbTit.TabIndex = 6;
            lbTit.Text = "Изменение";
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
            // txtTo
            // 
            txtTo.Location = new Point(212, 215);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(150, 31);
            txtTo.TabIndex = 22;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(212, 173);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(150, 31);
            txtFrom.TabIndex = 21;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(212, 127);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(150, 31);
            txtNum.TabIndex = 20;
            // 
            // lbDep
            // 
            lbDep.AutoSize = true;
            lbDep.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbDep.Location = new Point(63, 302);
            lbDep.Name = "lbDep";
            lbDep.Size = new Size(143, 28);
            lbDep.TabIndex = 19;
            lbDep.Text = "Отправление:";
            // 
            // lbArr
            // 
            lbArr.AutoSize = true;
            lbArr.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbArr.Location = new Point(63, 262);
            lbArr.Name = "lbArr";
            lbArr.Size = new Size(115, 28);
            lbArr.TabIndex = 18;
            lbArr.Text = "Прибытие:";
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbTo.Location = new Point(63, 218);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(61, 28);
            lbTo.TabIndex = 17;
            lbTo.Text = "Куда:";
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbFrom.Location = new Point(63, 173);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new Size(84, 28);
            lbFrom.TabIndex = 16;
            lbFrom.Text = "Откуда:";
            // 
            // lbNum
            // 
            lbNum.AutoSize = true;
            lbNum.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbNum.Location = new Point(63, 130);
            lbNum.Name = "lbNum";
            lbNum.Size = new Size(82, 28);
            lbNum.TabIndex = 15;
            lbNum.Text = "Номер:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Black;
            btnCancel.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(539, 403);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(241, 62);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            btnSave.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(98, 403);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(228, 62);
            btnSave.TabIndex = 25;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // timeDep
            // 
            timeDep.CustomFormat = "HH:mm";
            timeDep.Format = DateTimePickerFormat.Custom;
            timeDep.Location = new Point(212, 302);
            timeDep.Name = "timeDep";
            timeDep.Size = new Size(150, 31);
            timeDep.TabIndex = 27;
            timeDep.Value = new DateTime(2023, 5, 21, 23, 59, 0, 0);
            // 
            // timeArr
            // 
            timeArr.CustomFormat = "HH:mm";
            timeArr.Format = DateTimePickerFormat.Custom;
            timeArr.Location = new Point(212, 260);
            timeArr.Name = "timeArr";
            timeArr.Size = new Size(150, 31);
            timeArr.TabIndex = 28;
            timeArr.Value = new DateTime(2023, 5, 21, 0, 0, 0, 0);
            // 
            // frmChange
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(995, 657);
            Controls.Add(timeArr);
            Controls.Add(timeDep);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Controls.Add(txtNum);
            Controls.Add(lbDep);
            Controls.Add(lbArr);
            Controls.Add(lbTo);
            Controls.Add(lbFrom);
            Controls.Add(lbNum);
            Controls.Add(panelUp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmChange";
            StartPosition = FormStartPosition.Manual;
            panelUp.ResumeLayout(false);
            panelUp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelUp;
        private Button btnPic;
        private Label lbTit;
        private Button btnExit;
        private TextBox txtTo;
        private TextBox txtFrom;
        private TextBox txtNum;
        private Label lbDep;
        private Label lbArr;
        private Label lbTo;
        private Label lbFrom;
        private Label lbNum;
        private Button btnCancel;
        private Button btnSave;
        private DateTimePicker timeDep;
        private DateTimePicker timeArr;
    }
}