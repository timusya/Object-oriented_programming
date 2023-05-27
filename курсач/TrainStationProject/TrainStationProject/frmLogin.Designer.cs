namespace TrainStationProject
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panelUp = new Panel();
            lbTit = new Label();
            btnExit = new Button();
            btnImage = new Button();
            lbPassword = new Label();
            lbLogin = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegistration = new Button();
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
            panelUp.TabIndex = 14;
            // 
            // lbTit
            // 
            lbTit.AutoSize = true;
            lbTit.BackColor = Color.Black;
            lbTit.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbTit.ForeColor = Color.White;
            lbTit.Location = new Point(23, 9);
            lbTit.Name = "lbTit";
            lbTit.Size = new Size(191, 38);
            lbTit.TabIndex = 6;
            lbTit.Text = "Авторизация";
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
            btnImage.TabIndex = 15;
            btnImage.UseVisualStyleBackColor = true;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbPassword.Location = new Point(126, 491);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(88, 28);
            lbPassword.TabIndex = 18;
            lbPassword.Text = "Пароль:";
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbLogin.Location = new Point(126, 433);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(75, 28);
            lbLogin.TabIndex = 19;
            lbLogin.Text = "Логин:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(259, 433);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(150, 31);
            txtLogin.TabIndex = 20;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(259, 488);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 21;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(36, 570);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(228, 62);
            btnLogin.TabIndex = 26;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegistration
            // 
            btnRegistration.BackColor = Color.Black;
            btnRegistration.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistration.ForeColor = Color.White;
            btnRegistration.Location = new Point(318, 570);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(228, 62);
            btnRegistration.TabIndex = 27;
            btnRegistration.Text = "Зарегистрироваться";
            btnRegistration.UseVisualStyleBackColor = false;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(558, 655);
            Controls.Add(btnRegistration);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(lbLogin);
            Controls.Add(lbPassword);
            Controls.Add(btnImage);
            Controls.Add(panelUp);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label1;
        private Label label2;
        private Label lbPassword;
        private Label lbLogin;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegistration;
    }
}