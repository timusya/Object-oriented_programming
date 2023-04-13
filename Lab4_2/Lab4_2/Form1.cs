using System.Security.Cryptography.X509Certificates;

namespace Lab4_2
{
    public partial class Form1 : Form
    {
        Model model;

        public Form1() {
            InitializeComponent();
            model = new Model();
            model.observers += new System.EventHandler(this.UpdateFromModel);
        }

        private void UpdateFromModel(object sender, EventArgs e) {
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

        public class Model {

            private int A;
            private int B;
            private int C;
            public System.EventHandler observers;

            public void setValueA(int value) {
                if (value < 0 || value > 100) {
                    observers.Invoke(this, null);
                    return;
                }
                A = value;
                if (A > B) B = A;
                if (A > C) C = A;
                observers.Invoke(this, null);
            }

            public void setValueB(int value) {
                if (value < 0 || value > 100 || value < A || value > C) {
                    observers.Invoke(this, null);
                    return;
                }
                B = value;
                observers.Invoke(this, null);
            }

            public void setValueC(int value) {
                if (value < 0 || value > 100) {
                    observers.Invoke(this, null);
                    return;
                }
                C = value;
                if (C < A) A = C;
                if (C < B) B = C;
                observers.Invoke(this, null);
            }

            public int getValueA() {
                return A;
            }

            public int getValueB() {
                return B;
            }

            public int getValueC() {
                return C;
            }
        }
    }
}