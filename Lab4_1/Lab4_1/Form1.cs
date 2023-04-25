using System.Diagnostics;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Lab4_1
{
    public partial class Form1 : Form
    {
        Bitmap map;
        Graphics g;
        bool Ctrl = false;
        bool SelectAll = false;
        List<CCircle> circles = new List<CCircle>();

        public Form1()
        {
            InitializeComponent();
            map = new Bitmap(pict.Width, pict.Height);
            g = Graphics.FromImage(map);
        }

        private void pict_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.White);
            foreach (var circle in circles)
                circle.Draw(g);
            pict.Image = map;
        }

        private void pict_MouseClick(object sender, MouseEventArgs e)
        {
            bool outside = true;
            int cnt1 = 0;
            int cnt2 = 0;

            if (!Ctrl)
            {
                foreach (var circle in circles)
                {
                    if (circle.Check(e) && (SelectAll || cnt1 == 0))
                    {
                        circle.SetCondition(1);
                        outside = false;
                    }
                    else
                    {
                        circle.SetCondition(0);
                    }
                    cnt1 += Convert.ToInt32(circle.GetCondition() == 1);
                }
            }

            if (Ctrl)
            {
                bool was = false;
                foreach (var circle in circles)
                {
                    if (circle.Check(e))
                    {
                        outside = false;
                    }
                    if (circle.Check(e) && (SelectAll || !was))
                    {
                        circle.SetCondition(2);
                        outside = false;
                        was = true;
                    }
                    else if (circle.GetCondition() != 2)
                    {
                        circle.SetCondition(0);
                    }
                    cnt1 += Convert.ToInt32(circle.GetCondition() == 1);
                    cnt2 += Convert.ToInt32(circle.GetCondition() == 2);
                }
            }

            if (outside)
            {
                CCircle circle = new CCircle(e.X, e.Y, 50);
                circle.SetCondition(cnt1 + cnt2 == 0 ? 1 : 0);
                circles.Add(circle);
            }
        }

        private void cbox1_CheckedChanged(object sender, EventArgs e)
        {
            Ctrl = cbox1.Checked;
        }

        private void cbox2_CheckedChanged(object sender, EventArgs e)
        {
            SelectAll = cbox2.Checked;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                cbox1.Checked = true;
            else if (e.KeyCode == Keys.Delete)
                btn_Click(sender, e);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                cbox1.Checked = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            List<CCircle> tmp = new List<CCircle>();
            foreach (var circle in circles)
            {
                if (circle.GetCondition() == 0)
                    tmp.Add(circle);
            }
            circles = tmp;
            if (circles.Count() > 0)
                circles[circles.Count() - 1].SetCondition(1);
        }
    }
}