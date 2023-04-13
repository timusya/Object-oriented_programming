namespace Lab4_2
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
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            numericA = new NumericUpDown();
            numericB = new NumericUpDown();
            numericC = new NumericUpDown();
            trackBarA = new TrackBar();
            trackBarB = new TrackBar();
            trackBarC = new TrackBar();
            label1 = new Label();
            labelA = new Label();
            labelB = new Label();
            label2 = new Label();
            labelC = new Label();
            ((System.ComponentModel.ISupportInitialize)numericA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarC).BeginInit();
            SuspendLayout();
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(116, 237);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(150, 31);
            textBoxA.TabIndex = 0;
            textBoxA.KeyDown += textBoxA_KeyDown;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(352, 237);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(150, 31);
            textBoxB.TabIndex = 1;
            textBoxB.KeyDown += textBoxB_KeyDown;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(590, 237);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(150, 31);
            textBoxC.TabIndex = 2;
            textBoxC.KeyDown += textBoxC_KeyDown;
            // 
            // numericA
            // 
            numericA.Location = new Point(116, 287);
            numericA.Name = "numericA";
            numericA.Size = new Size(150, 31);
            numericA.TabIndex = 3;
            numericA.ValueChanged += numericA_ValueChanged;
            // 
            // numericB
            // 
            numericB.Location = new Point(352, 287);
            numericB.Name = "numericB";
            numericB.Size = new Size(150, 31);
            numericB.TabIndex = 4;
            numericB.ValueChanged += numericB_ValueChanged;
            // 
            // numericC
            // 
            numericC.Location = new Point(590, 287);
            numericC.Name = "numericC";
            numericC.Size = new Size(150, 31);
            numericC.TabIndex = 5;
            numericC.ValueChanged += numericC_ValueChanged;
            // 
            // trackBarA
            // 
            trackBarA.Location = new Point(116, 336);
            trackBarA.Maximum = 100;
            trackBarA.Name = "trackBarA";
            trackBarA.Size = new Size(150, 69);
            trackBarA.TabIndex = 6;
            trackBarA.MouseUp += trackBarA_MouseUp;
            // 
            // trackBarB
            // 
            trackBarB.Location = new Point(352, 336);
            trackBarB.Maximum = 100;
            trackBarB.Name = "trackBarB";
            trackBarB.Size = new Size(150, 69);
            trackBarB.TabIndex = 7;
            trackBarB.MouseUp += trackBarB_MouseUp;
            // 
            // trackBarC
            // 
            trackBarC.Location = new Point(590, 336);
            trackBarC.Maximum = 100;
            trackBarC.Name = "trackBarC";
            trackBarC.Size = new Size(150, 69);
            trackBarC.TabIndex = 8;
            trackBarC.MouseUp += trackBarC_MouseUp;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(264, 150);
            label1.Name = "label1";
            label1.Size = new Size(82, 79);
            label1.TabIndex = 9;
            label1.Text = "<=";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelA
            // 
            labelA.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point);
            labelA.Location = new Point(116, 153);
            labelA.Name = "labelA";
            labelA.Size = new Size(150, 76);
            labelA.TabIndex = 10;
            labelA.Text = "A";
            labelA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelB
            // 
            labelB.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point);
            labelB.Location = new Point(352, 153);
            labelB.Name = "labelB";
            labelB.Size = new Size(150, 76);
            labelB.TabIndex = 11;
            labelB.Text = "B";
            labelB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(502, 153);
            label2.Name = "label2";
            label2.Size = new Size(89, 81);
            label2.TabIndex = 12;
            label2.Text = "<=";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelC
            // 
            labelC.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point);
            labelC.Location = new Point(590, 153);
            labelC.Name = "labelC";
            labelC.Size = new Size(150, 76);
            labelC.TabIndex = 13;
            labelC.Text = "C";
            labelC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 503);
            Controls.Add(labelC);
            Controls.Add(label2);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(label1);
            Controls.Add(trackBarC);
            Controls.Add(trackBarB);
            Controls.Add(trackBarA);
            Controls.Add(numericC);
            Controls.Add(numericB);
            Controls.Add(numericA);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)numericA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericC).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private NumericUpDown numericA;
        private NumericUpDown numericB;
        private NumericUpDown numericC;
        private TrackBar trackBarA;
        private TrackBar trackBarB;
        private TrackBar trackBarC;
        private Label label1;
        private Label labelA;
        private Label labelB;
        private Label label2;
        private Label labelC;
    }
}