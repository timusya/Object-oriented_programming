using System.Security.Cryptography.X509Certificates;

namespace Lab4_2
{
    public partial class Form1 : Form
    {
        Model model;

        public Form1()
        {
            InitializeComponent();
            // �������� ����� ������
            model = new Model();
            model.observers += new System.EventHandler(this.UpdateFromModel);
            // ��������� ����������� �������� A, B � C
            model.setValueC(Properties.Settings.Default.valueC);
            model.setValueB(Properties.Settings.Default.valueB);
            model.setValueA(Properties.Settings.Default.valueA);
        }

        // ������ ����������
        private void UpdateFromModel(object sender, EventArgs e)
        {
            // ��������� �������� ��� ���� ��������
            textBoxA.Text = model.getValueA().ToString();
            numericA.Value = model.getValueA();
            trackBarA.Value = model.getValueA();

            textBoxB.Text = model.getValueB().ToString();
            numericB.Value = model.getValueB();
            trackBarB.Value = model.getValueB();

            textBoxC.Text = model.getValueC().ToString();
            numericC.Value = model.getValueC();
            trackBarC.Value = model.getValueC();
        }

        // ������� ��� A
        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setValueA(Int32.Parse(textBoxA.Text));
        }

        private void numericA_ValueChanged(object sender, EventArgs e)
        {
            model.setValueA(Decimal.ToInt32(numericA.Value));
        }

        private void trackBarA_MouseUp(object sender, MouseEventArgs e)
        {
            model.setValueA(Decimal.ToInt32(trackBarA.Value));
        }

        // ������� ��� B
        private void textBoxB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setValueB(Int32.Parse(textBoxB.Text));
        }

        private void numericB_ValueChanged(object sender, EventArgs e)
        {
            model.setValueB(Decimal.ToInt32(numericB.Value));
        }

        private void trackBarB_MouseUp(object sender, MouseEventArgs e)
        {
            model.setValueB(Decimal.ToInt32(trackBarB.Value));
        }

        // ������� ��� C
        private void textBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setValueC(Int32.Parse(textBoxC.Text));
        }

        private void numericC_ValueChanged(object sender, EventArgs e)
        {
            model.setValueC(Decimal.ToInt32(numericC.Value));
        }

        private void trackBarC_MouseUp(object sender, MouseEventArgs e)
        {
            model.setValueC(Decimal.ToInt32(trackBarC.Value));
        }

        // ������� - �������� �����
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ���������� �������� A, B � � � ����������
            Properties.Settings.Default.valueA = model.getValueA();
            Properties.Settings.Default.valueB = model.getValueB();
            Properties.Settings.Default.valueC = model.getValueC();
            Properties.Settings.Default.Save();
        }

        // ����� ������
        public class Model
        {

            private int A;
            private int B;
            private int C;
            public System.EventHandler observers;

            // ��������� �������� ��� A
            public void setValueA(int value)
            {
                if (value < 0 || value > 100)
                {
                    observers.Invoke(this, null);
                    return;
                }
                A = value;
                if (A > B) B = A;
                if (A > C) C = A;
                observers.Invoke(this, null);
            }

            // ��������� �������� ��� B
            public void setValueB(int value)
            {
                if (value < 0 || value > 100 || value < A || value > C)
                {
                    observers.Invoke(this, null);
                    return;
                }
                B = value;
                observers.Invoke(this, null);
            }

            // ��������� �������� ��� C
            public void setValueC(int value)
            {
                if (value < 0 || value > 100)
                {
                    observers.Invoke(this, null);
                    return;
                }
                C = value;
                if (C < A) A = C;
                if (C < B) B = C;
                observers.Invoke(this, null);
            }

            // ��������� �������� A
            public int getValueA()
            {
                return A;
            }

            // ��������� �������� B
            public int getValueB()
            {
                return B;
            }

            // ��������� �������� C
            public int getValueC()
            {
                return C;
            }
        }
    }
}