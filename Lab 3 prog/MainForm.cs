using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_prog
{
    public partial class MainForm : Form, IController
    {
        //List<IView> views = new List<IView>();
        static Random r = new Random();
        IModel model;
        public MainForm()
        {
            panelView1 = new PanelView();

            myDataGridView1 = new MyDataGridView();

            InitializeComponent();
            IView labView = new LabelView(label1);
            model = new MyModel();

            myDataGridView1.Model = model;
            AddView(myDataGridView1);

            labView.Model = model;
            AddView(labView);

            panelView1.Model = model;
            AddView(panelView1);
            panelView1.ClickedXY += (int X, int Y) => { Model.ChangeColorWithX(X); };
        }

        public IModel Model { get { return model; } set { model = value; } }

        public void Add()
        {
            model.AddNode(r.Next(100));
            
        }
  

        public void AddView(IView v)
        {
            model.Changed += new Action(v.UpdateView);
        }

        public void Remove()
        {
            if (model.Count > 0)
                model.RemoveLastNode();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }
    }
}
