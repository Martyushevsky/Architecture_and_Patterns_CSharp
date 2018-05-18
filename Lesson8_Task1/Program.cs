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

            Form1 view = new Form1();
            IModel mdl = new ListModel();
            IController cnt = new IncrementController(view, mdl);
            Application.Run(view);
        }
    }
}