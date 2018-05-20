using System.Collections.Generic;

namespace Lesson8_Task1
{
    public class FormModel : IModel
    {
        public event ModelHandler<FormModel> Changed;

        List<string> value;

        public FormModel()
        {
            value = new List<string>();
        }

        public void AddString(string v)
        {
            value.Add(v);            
        }

        public void ShowCollection()
        {
            foreach (var item in value)
            {
                Changed.Invoke(this, new ModelEventArgs(item));
            }
        }

        public void Attach(IModelObserver modelObserver)
        {
            Changed += new ModelHandler<FormModel>(modelObserver.ListChanged);
        }
    }
}