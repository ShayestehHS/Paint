using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class frmMain : Form
    {
        Graphics Graph;
        Pen pen;
        int x = -1;
        int y = -1;
        bool isMoving = false;
        //Selected color is:
        string SelColor = "ColorBlack";

        public frmMain()
        {
            InitializeComponent();
            Graph = Panel.CreateGraphics();
            Graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving && x != -1 && y != -1)
            {
                switch (cbMode.SelectedItem.ToString())
                {
                    case "Line":
                        {
                            DrawLine(e);
                            break;
                        }
                    case "Square":
                        {
                            var Wid = e.Location.X - x;
                            var Hei = e.Location.Y - y;
                            Graph.DrawRectangle(pen, x, y, Wid, Hei);
                            break;
                        }
                }
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
            x = -1;
            y = -1;
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            x = e.X;
            y = e.Y;
        }

        private void Color_Click(object sender, EventArgs e)
        {
            //Previous Color => P
            Label P = (Label)ColorPicker.Controls.Find(SelColor, false).First();
            P.Width = 40;
            P.Height = 40;
            P.Top += 5;
            P.Left += 5;
            //Selected Color => S
            Label S = (Label)sender;
            pen.Color = S.BackColor;
            S.Width = 50;
            S.Height = 50;
            S.Left -= 5;
            S.Top -= 5;
            SelColor = S.Name;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void cbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen.Width = int.Parse((cbFont.SelectedItem.ToString()));
        }

        private void DrawLine(MouseEventArgs e)
        {
            Graph.DrawLine(pen, new Point(x, y), e.Location);
            x = e.X;
            y = e.Y;
        }
    }
}
