using System;

namespace Lesson8_Task1
{
    public class ViewEventArgs : EventArgs
    {
        public string value;
        public ViewEventArgs(string v) => value = v;
    }
}