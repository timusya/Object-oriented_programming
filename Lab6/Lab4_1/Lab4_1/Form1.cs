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
        Container figures = new Container();
        int distUp;
        int distRight;

        public Form1()
        {
            InitializeComponent();
            map = new Bitmap(pict.Width, pict.Height);
            g = Graphics.FromImage(map);
            distUp = this.Size.Height - pict.Height;
            distRight = this.Size.Width - pict.Width;
            comboBoxFigures.SelectedIndex = 0;
        }

        private void pict_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.White);
            for (int i = 0; i < figures.Get_size(); i++)
                if (figures[i].GetCondition() == 0) figures[i].Draw(g);
            for (int i = 0; i < figures.Get_size(); i++)
                if (figures[i].GetCondition() > 0) figures[i].Draw(g);
            pict.Image = map;
        }

        private void pict_MouseClick(object sender, MouseEventArgs e)
        {
            bool outside = true;
            int cnt1 = 0;
            int cnt2 = 0;

            if (!Ctrl)
            {
                for (int i = 0; i < figures.Get_size(); i++)
                {
                    var fig = figures[i];
                    if (fig.Check(e) && (SelectAll || cnt1 == 0))
                    {
                        fig.SetCondition(1);
                        outside = false;
                    }
                    else
                    {
                        fig.SetCondition(0);
                    }
                    cnt1 += Convert.ToInt32(fig.GetCondition() == 1);
                }
            }

            if (Ctrl)
            {
                bool was = false;
                for (int i = 0; i < figures.Get_size(); i++)
                {
                    var fig = figures[i];
                    if (fig.Check(e))
                    {
                        outside = false;
                    }
                    if (fig.Check(e) && (SelectAll || !was))
                    {
                        fig.SetCondition(2);
                        outside = false;
                        was = true;
                    }
                    else if (fig.GetCondition() != 2)
                    {
                        fig.SetCondition(0);
                    }
                    cnt1 += Convert.ToInt32(fig.GetCondition() == 1);
                    cnt2 += Convert.ToInt32(fig.GetCondition() == 2);
                }
            }

            if (outside)
            {
                Figure fig;
                if (comboBoxFigures.SelectedItem.ToString() == "Circle") fig = new CCircle(e.X, e.Y, 50);
                else if (comboBoxFigures.SelectedItem.ToString() == "Square") fig = new Square(e.X, e.Y, 50);
                else fig = new Triangle(e.X, e.Y, 50);
                fig.Move(0, 0, 0, pict);
                fig.SetCondition(cnt1 + cnt2 == 0 ? 1 : 0);
                figures.Insert(figures.Get_size(), fig);
            }
        }

        private void cboxCtrl_CheckedChanged(object sender, EventArgs e)
        {
            Ctrl = cboxCtrl.Checked;
        }

        private void cboxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            SelectAll = cboxSelectAll.Checked;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                cboxCtrl.Checked = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(sender, e);
            }
            else
            {
                int cnt_selected = 0;
                int pos = 0;
                for (int i = 0; i < figures.Get_size(); i++)
                {
                    if (figures[i].GetCondition() > 0)
                    {
                        cnt_selected++;
                        pos = i;
                    }
                }
                if (e.KeyCode == Keys.A && cnt_selected == 1)
                {
                    figures[pos].Move(-30, 0, 0, pict);
                }
                if (e.KeyCode == Keys.D && cnt_selected == 1)
                {
                    figures[pos].Move(+30, 0, 0, pict);
                }
                if (e.KeyCode == Keys.S && cnt_selected == 1)
                {
                    figures[pos].Move(0, +30, 0, pict);
                }
                if (e.KeyCode == Keys.W && cnt_selected == 1)
                {
                    figures[pos].Move(0, -30, 0, pict);
                }
                if (e.KeyCode == Keys.Add && cnt_selected == 1)
                {
                    figures[pos].Move(0, 0, +15, pict);
                }
                if (e.KeyCode == Keys.Subtract && cnt_selected == 1)
                {
                    figures[pos].Move(0, 0, -15, pict);
                }
                if (e.KeyCode == Keys.ShiftKey && cnt_selected == 1)
                {
                    ColorDialog cd = new ColorDialog();
                    if (cd.ShowDialog() == DialogResult.OK)
                    {
                        figures[pos].SetColor(cd.Color);
                    }
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                cboxCtrl.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Container tmp = new Container();
            for (int i = 0; i < figures.Get_size(); i++)
            {
                if (figures[i].GetCondition() == 0)
                    tmp.Insert(tmp.Get_size(), figures[i]);
            }
            figures = tmp;
            if (figures.Get_size() > 0)
                figures[figures.Get_size() - 1].SetCondition(1);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            pict.Height = this.Size.Height - distUp;
            pict.Width = this.Size.Width - distRight;
            map = new Bitmap(pict.Width, pict.Height);
            g = Graphics.FromImage(map);
            for (int i = 0; i < figures.Get_size(); i++)
            {
                figures[i].Move(0, 0, 0, pict);
            }
        }

        private void comboBoxFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelFigures.Focus();
        }
    }
}