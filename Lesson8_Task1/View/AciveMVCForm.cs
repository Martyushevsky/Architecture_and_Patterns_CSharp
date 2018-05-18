using System;
using System.Windows.Forms;

namespace ActiveMVC
{
    public partial class ActiveMVCForm : Form, IView, IModelObserver
    {
        IController controller;

        public event ViewHandler<IView> AddString;
        public void SetController(IController cont)
        {
            controller = cont;
        }

        public ActiveMVCForm()
        {
            InitializeComponent();
        }

        private void ButtonAddString_Click(object sender, EventArgs e)
        {
            try
            {
                AddString.Invoke(this, new ViewEventArgs(textBoxValue.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Введите строку.");
            }
        }

        public void ListChanged(IModel model, ModelEventArgs e)
        {
            listBox.Items.Add(e.newval);
        }
    }
}
