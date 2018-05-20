using System;
using System.Windows.Forms;

namespace Lesson8_Task1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormView view = new FormView();
            IModel model = new FormModel();
            IController controller = new FormController(view, model);

            Application.Run(view);
        }
    }
}