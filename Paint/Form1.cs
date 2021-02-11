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
        //Global
        Graphics Graph;
        Rectangle rec;
        Pen pen;
        int x = -1;
        int y = -1;
        bool isMoving = false;

        //Default color is:
        string SelColor = "ColorBlack";

        public frmMain()
        {
            InitializeComponent();
            Graph = Panel.CreateGraphics();
            Graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        //Panel Events
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
                            Graph.Clear(Color.White);
                            DrawSquare(x, y, e.X, e.Y);
                            break;
                        }
                }
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (cbMode.SelectedItem.Equals("Square") && cbFont.SelectedItem.Equals("Fill"))
            {
                SolidBrush bru = new SolidBrush(pen.Color);

                Graph.FillRectangle(bru, rec);
            }

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

        //Buttons Events
        private void btnErase_Click(object sender, EventArgs e)
        {
            Graph.Clear(Color.White);
        }

        //Selected color changed
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

        //Selected width changed
        private void cbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedItem = cbFont.SelectedItem.ToString();

            pen.Width = (SelectedItem.Equals("Fill")) ? 10 : int.Parse((cbFont.SelectedItem.ToString()));
        }

        //Main events
        private void DrawLine(MouseEventArgs e)
        {
            Graph.DrawLine(pen, new Point(x, y), e.Location);
            x = e.X;
            y = e.Y;
        }

        private void DrawSquare(int firstX, int firstY, int finallyX, int finallyY)
        {
            rec = new Rectangle();
            rec.Width = finallyX - firstX;
            rec.Height = finallyY - firstY;
            rec.X = firstX;
            rec.Y = firstY;
            Graph.DrawRectangle(pen, rec);

        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numRotate_ValueChanged(object sender, EventArgs e)
        {
            Graph.RotateTransform((float)numRotate.Value);
        }
    }
}