using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Lab4_1
{
    public partial class Form1 : Form, CObserver
    {
        Bitmap map;
        Graphics g;
        bool Ctrl = false;
        bool SelectAll = false;
        Container figures = new Container();
        int distUp;
        int distRight;
        string path = "D:\\�ר��_���\\���\\������������ ������ �6\\Lab4_1\\content.txt";
        //string path = "C:\\projects\\������������ ������ �6\\Lab4_1\\content.txt";
        TreeNode root;
        int id_obj = 0;
        int id_obs = 0;

        public Form1()
        {
            InitializeComponent();
            map = new Bitmap(pict.Width, pict.Height);
            g = Graphics.FromImage(map);
            distUp = this.Size.Height - pict.Height;
            distRight = this.Size.Width - pict.Width;
            comboBoxFigures.SelectedIndex = 0;
            figures.AddObserver(this);
        }

        private void pict_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.White);
            for (int i = 0; i < figures.Get_size(); i++)
                if (figures[i].GetCondition() == 0) figures[i].Draw(g);
            for (int i = 0; i < figures.Get_size(); i++)
                if (figures[i].GetCondition() > 0) figures[i].Draw(g);

            Pen pen = new Pen(Brushes.GreenYellow, 8);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            for (int i = 0; i < figures.Get_size(); i++)
            {
                var f = figures[i];
                foreach(var o in f.obs)
                {
                    Figure of = (Figure)o;
                    g.DrawLine(pen, f.GetX(), f.GetY(), of.GetX(), of.GetY());
                }
            }

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
            figures.NotifyRebuild();
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
                    figures[pos].NotifyMove(-30, 0, 0, pict);
                }
                if (e.KeyCode == Keys.D && cnt_selected == 1)
                {
                    figures[pos].Move(+30, 0, 0, pict);
                    figures[pos].NotifyMove(+30, 0, 0, pict);
                }
                if (e.KeyCode == Keys.S && cnt_selected == 1)
                {
                    figures[pos].Move(0, +30, 0, pict);
                    figures[pos].NotifyMove(0, +30, 0, pict);
                }
                if (e.KeyCode == Keys.W && cnt_selected == 1)
                {
                    figures[pos].Move(0, -30, 0, pict);
                    figures[pos].NotifyMove(0, -30, 0, pict);
                }
                if (e.KeyCode == Keys.Add && cnt_selected == 1)
                {
                    figures[pos].Move(0, 0, +15, pict);
                    figures[pos].NotifyMove(0, 0, +15, pict);
                }
                if (e.KeyCode == Keys.Subtract && cnt_selected == 1)
                {
                    figures[pos].Move(0, 0, -15, pict);
                    figures[pos].NotifyMove(0, 0, -15, pict);
                }
                if (e.KeyCode == Keys.T && cnt_selected == 1)
                {
                    id_obj = pos;
                }
                if (e.KeyCode == Keys.Y && cnt_selected == 1)
                {
                    id_obs = pos;
                    figures[id_obj].AddObserver(figures[id_obs]);
                }
                if (e.KeyCode == Keys.ShiftKey && cnt_selected == 1)
                {
                    ColorDialog cd = new ColorDialog();
                    if (cd.ShowDialog() == DialogResult.OK)
                    {
                        figures[pos].SetColor(cd.Color);
                    }
                }
                if (e.KeyCode == Keys.G)
                {
                    Group group = new Group();
                    Container tmp = new Container();
                    for (int i = 0; i < figures.Get_size(); i++)
                    {
                        if (figures[i].GetCondition() == 0)
                            tmp.Insert(tmp.Get_size(), figures[i]);
                        else
                            group.AddFigure(figures[i]);
                    }
                    tmp.Insert(tmp.Get_size(), group);
                    figures = tmp;
                    figures.AddObserver(this);
                    figures.NotifyRebuild();
                }
                if (e.KeyCode == Keys.U)
                {
                    Container tmp = new Container();
                    for (int i = 0; i < figures.Get_size(); i++)
                    {
                        var fig = figures[i];
                        if (fig.GetCondition() == 0 || !(fig is Group))
                        {
                            fig.SetCondition(0);
                            tmp.Insert(tmp.Get_size(), fig);
                        }
                        else
                        {
                            List<Figure> fs = ((Group)fig).GetFs();
                            foreach (var f in fs)
                            {
                                f.SetCondition(0);
                                tmp.Insert(tmp.Get_size(), f);
                            }
                        }
                    }
                    figures = tmp;
                    if (figures.Get_size() > 0)
                        figures[figures.Get_size() - 1].SetCondition(1);
                    figures.AddObserver(this);
                    figures.NotifyRebuild();
                }
                if (e.KeyCode == Keys.O)
                {
                    figures.SaveFigures(path);
                }
                if (e.KeyCode == Keys.P)
                {
                    figures = new Container();
                    figures.AddObserver(this);
                    MyFigureFactory factory = new MyFigureFactory();
                    figures.LoadFigures(path, factory);
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
            figures.AddObserver(this);
            figures.NotifyRebuild();
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

        public void BuildTree()
        {
            treeView1.Nodes.Clear();
            treeView1.CheckBoxes = true;
            root = new TreeNode("Figures");
            root.Name = "Figures";
            for (int i = 0; i < figures.Get_size(); i++)
            {
                BuildNode(root, figures[i]);
            }
            treeView1.Nodes.Add(root);
            treeView1.ExpandAll();
        }

        public void UpdateMove(int dx, int dy, int dr, PictureBox p)
        {

        }

        public void BuildNode(TreeNode root, Figure fig)
        {
            TreeNode child = new TreeNode(fig.GetType().Name);
            child.Name = fig.GetType().Name;
            if (fig is Group)
            {
                List<Figure> fs = ((Group)fig).GetFs();
                foreach (var f in fs)
                {
                    BuildNode(child, f);
                }
            }
            if (fig.GetCondition() > 0)
                child.Checked = true;
            root.Nodes.Add(child);
        }

        int idx;
        bool found;

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            idx = 0;
            found = false;
            TreeNode goal = e.Node;
            dfsTree(treeView1.Nodes, goal);
            idx--;

            List<Figure> fs = new List<Figure>();
            for (int i = 0; i < figures.Get_size(); i++)
                fs.Add(figures[i]);
            dfsFigures(fs, (goal.Checked == true ? 1 : 0));

            figures.NotifyRebuild();
        }

        public void dfsTree(TreeNodeCollection nodes, TreeNode goal)
        {
            foreach (TreeNode child in nodes)
            {
                if (child == goal || found)
                {
                    found = true;
                    return;
                }
                idx++;
                dfsTree(child.Nodes, goal);
            }
        }

        public void dfsFigures(List<Figure> fs, int val)
        {
            foreach (Figure f in fs)
            {
                if (idx == 0)
                    f.SetCondition(val);
                idx--;
                if (f is Group)
                    dfsFigures(((Group)f).GetFs(), val);
            }
        }
    }
}
