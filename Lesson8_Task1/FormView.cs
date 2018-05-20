using System;
using System.Windows.Forms;

namespace Lesson8_Task1
{
    public partial class FormView : Form, IView, IModelObserver
    {
        IController controller;

        public event ViewHandler<IView> StringAdded;
        public event ViewHandler<IView> ButtonPressed;

        public void SetController(IController cont)
        {
            controller = cont;
        }

        public FormView()
        {
            InitializeComponent();
        }

        public void ListChanged(IModel model, ModelEventArgs e)
        {
            DataListBox.Items.Add(e.value);
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            DataListBox.Items.Clear();
            ButtonPressed.Invoke(this, new ViewEventArgs(""));
        }
        
        private void InputField_Leave(object sender, EventArgs e)
        {
            StringAdded.Invoke(this, new ViewEventArgs(InputField.Text));
        }
    }
}