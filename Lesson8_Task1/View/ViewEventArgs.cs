using System;

namespace ActiveMVC
{
    public class ViewEventArgs : EventArgs
    {
        public string value;
        public ViewEventArgs(string v) => value = v; 
    }
}