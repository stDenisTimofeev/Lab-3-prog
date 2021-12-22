using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_prog
{
    public class PanelView : Panel, IView
    {
        

        IModel model;
        public IModel Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public delegate void Clicked(int X, int Y);
        public event Clicked ClickedXY;

        public void UpdateView()
        {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Model == null) return;
            Graphics g = e.Graphics;
            foreach (Node n in Model.AllNodes)
            {
                g.DrawEllipse(n.ColorPen, n.X - 10, n.Y - 10, 20, 20);
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            ClickedXY(e.X, e.Y);
        }

    }
}
