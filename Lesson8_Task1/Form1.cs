using System;
using System.Windows.Forms;

namespace Lesson8_Task1
{
    public partial class Form1 : Form, IView, IModelObserver
    {
        IController controller;

        public event ViewHandler<IView> AddString;

        public void SetController(IController cont)
        {
            controller = cont;
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void ListChanged(IModel model, ModelEventArgs e)
        {
            DataListBox.Items.Add(e.newval);
        }

        private void LoadData_Click(object sender, EventArgs e)
        {

        }
    }
}