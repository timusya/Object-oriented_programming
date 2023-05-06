namespace Lab4_1
{
    partial class Form1
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
            pict = new PictureBox();
            cboxSelectAll = new CheckBox();
            cboxCtrl = new CheckBox();
            btnDelete = new Button();
            colorDialog1 = new ColorDialog();
            panel1 = new Panel();
            labelFigures = new Label();
            comboBoxFigures = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pict).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pict
            // 
            pict.Dock = DockStyle.Left;
            pict.Location = new Point(0, 0);
            pict.Margin = new Padding(4, 5, 4, 5);
            pict.Name = "pict";
            pict.Size = new Size(877, 750);
            pict.TabIndex = 0;
            pict.TabStop = false;
            pict.Paint += pict_Paint;
            pict.MouseClick += pict_MouseClick;
            // 
            // cboxSelectAll
            // 
            cboxSelectAll.AutoSize = true;
            cboxSelectAll.Location = new Point(48, 183);
            cboxSelectAll.Margin = new Padding(4, 5, 4, 5);
            cboxSelectAll.Name = "cboxSelectAll";
            cboxSelectAll.Size = new Size(104, 29);
            cboxSelectAll.TabIndex = 1;
            cboxSelectAll.Text = "SelectAll";
            cboxSelectAll.UseVisualStyleBackColor = true;
            cboxSelectAll.CheckedChanged += cboxSelectAll_CheckedChanged;
            // 
            // cboxCtrl
            // 
            cboxCtrl.AutoSize = true;
            cboxCtrl.Location = new Point(48, 133);
            cboxCtrl.Margin = new Padding(4, 5, 4, 5);
            cboxCtrl.Name = "cboxCtrl";
            cboxCtrl.Size = new Size(65, 29);
            cboxCtrl.TabIndex = 2;
            cboxCtrl.Text = "Ctrl";
            cboxCtrl.UseVisualStyleBackColor = true;
            cboxCtrl.CheckedChanged += cboxCtrl_CheckedChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(48, 235);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 44);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelFigures);
            panel1.Controls.Add(comboBoxFigures);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(cboxCtrl);
            panel1.Controls.Add(cboxSelectAll);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(876, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 750);
            panel1.TabIndex = 5;
            // 
            // labelFigures
            // 
            labelFigures.AutoSize = true;
            labelFigures.Location = new Point(48, 31);
            labelFigures.Name = "labelFigures";
            labelFigures.Size = new Size(73, 25);
            labelFigures.TabIndex = 6;
            labelFigures.Text = "Figures:";
            // 
            // comboBoxFigures
            // 
            comboBoxFigures.FormattingEnabled = true;
            comboBoxFigures.Items.AddRange(new object[] { "Circle", "Square", "Triangle" });
            comboBoxFigures.Location = new Point(48, 74);
            comboBoxFigures.Name = "comboBoxFigures";
            comboBoxFigures.Size = new Size(182, 33);
            comboBoxFigures.TabIndex = 5;
            comboBoxFigures.SelectedIndexChanged += comboBoxFigures_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(panel1);
            Controls.Add(pict);
            KeyPreview = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            SizeChanged += Form1_SizeChanged;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pict).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox pict;
        private CheckBox cboxSelectAll;
        private CheckBox cboxCtrl;
        private Button btnDelete;
        public ColorDialog colorDialog1;
        private Panel panel1;
        private ComboBox comboBoxFigures;
        private Label labelFigures;
    }
}