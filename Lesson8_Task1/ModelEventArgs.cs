using System;

namespace Lesson8_Task1
{
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);

    public class ModelEventArgs : EventArgs
    {
        public string newval;
        public ModelEventArgs(string v) => newval = v;
    }
}