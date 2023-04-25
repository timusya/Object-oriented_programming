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
            cbox2 = new CheckBox();
            cbox1 = new CheckBox();
            btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pict).BeginInit();
            SuspendLayout();
            // 
            // pict
            // 
            pict.Dock = DockStyle.Left;
            pict.Location = new Point(0, 0);
            pict.Name = "pict";
            pict.Size = new Size(568, 450);
            pict.TabIndex = 0;
            pict.TabStop = false;
            pict.Paint += pict_Paint;
            pict.MouseClick += pict_MouseClick;
            // 
            // cbox2
            // 
            cbox2.AutoSize = true;
            cbox2.Location = new Point(638, 177);
            cbox2.Name = "cbox2";
            cbox2.Size = new Size(71, 19);
            cbox2.TabIndex = 1;
            cbox2.Text = "SelectAll";
            cbox2.UseVisualStyleBackColor = true;
            cbox2.CheckedChanged += cbox2_CheckedChanged;
            // 
            // cbox1
            // 
            cbox1.AutoSize = true;
            cbox1.Location = new Point(638, 136);
            cbox1.Name = "cbox1";
            cbox1.Size = new Size(45, 19);
            cbox1.TabIndex = 2;
            cbox1.Text = "Ctrl";
            cbox1.UseVisualStyleBackColor = true;
            cbox1.CheckedChanged += cbox1_CheckedChanged;
            // 
            // btn
            // 
            btn.Location = new Point(638, 211);
            btn.Name = "btn";
            btn.Size = new Size(75, 25);
            btn.TabIndex = 3;
            btn.Text = "Delete";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn);
            Controls.Add(cbox1);
            Controls.Add(cbox2);
            Controls.Add(pict);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pict).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pict;
        private CheckBox cbox2;
        private CheckBox cbox1;
        private Button btn;
    }
}