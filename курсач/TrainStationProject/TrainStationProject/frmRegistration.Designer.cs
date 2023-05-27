namespace TrainStationProject
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            panelUp = new Panel();
            lbTit = new Label();
            btnExit = new Button();
            btnImage = new Button();
            btnCancel = new Button();
            btnRegistration = new Button();
            txtPassword = new TextBox();
            txtLogin = new TextBox();
            lbLogin = new Label();
            lbPassword = new Label();
            panelUp.SuspendLayout();
            SuspendLayout();
            // 
            // panelUp
            // 
            panelUp.BackColor = Color.Black;
            panelUp.Controls.Add(lbTit);
            panelUp.Controls.Add(btnExit);
            panelUp.Location = new Point(0, 0);
            panelUp.Name = "panelUp";
            panelUp.Size = new Size(560, 60);
            panelUp.TabIndex = 15;
            // 
            // lbTit
            // 
            lbTit.AutoSize = true;
            lbTit.BackColor = Color.Black;
            lbTit.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbTit.ForeColor = Color.White;
            lbTit.Location = new Point(23, 9);
            lbTit.Name = "lbTit";
            lbTit.Size = new Size(182, 38);
            lbTit.TabIndex = 6;
            lbTit.Text = "Регистрация";
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(507, 7);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 5;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnImage
            // 
            btnImage.Image = (Image)resources.GetObject("btnImage.Image");
            btnImage.Location = new Point(173, 120);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(215, 247);
            btnImage.TabIndex = 16;
            btnImage.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Black;
            btnCancel.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(303, 557);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(228, 62);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRegistration
            // 
            btnRegistration.BackColor = Color.Black;
            btnRegistration.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistration.ForeColor = Color.White;
            btnRegistration.Location = new Point(21, 557);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(228, 62);
            btnRegistration.TabIndex = 32;
            btnRegistration.Text = "Зарегистрироваться";
            btnRegistration.UseVisualStyleBackColor = false;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(244, 475);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 31;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(244, 420);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(150, 31);
            txtLogin.TabIndex = 30;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbLogin.Location = new Point(111, 420);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(75, 28);
            lbLogin.TabIndex = 29;
            lbLogin.Text = "Логин:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbPassword.Location = new Point(111, 478);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(88, 28);
            lbPassword.TabIndex = 28;
            lbPassword.Text = "Пароль:";
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(558, 655);
            Controls.Add(btnCancel);
            Controls.Add(btnRegistration);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(lbLogin);
            Controls.Add(lbPassword);
            Controls.Add(btnImage);
            Controls.Add(panelUp);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegistration";
            panelUp.ResumeLayout(false);
            panelUp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelUp;
        private Label lbTit;
        private Button btnExit;
        private Button btnImage;
        private Button btnCancel;
        private Button btnRegistration;
        private TextBox txtPassword;
        private TextBox txtLogin;
        private Label lbLogin;
        private Label lbPassword;
    }
}