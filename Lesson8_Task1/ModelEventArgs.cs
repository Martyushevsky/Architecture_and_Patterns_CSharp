using System;

namespace Lesson8_Task1
{
    public class ModelEventArgs : EventArgs
    {
        public string value;
        public ModelEventArgs(string v) => value = v;
    }
}