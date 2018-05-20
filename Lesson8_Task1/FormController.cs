namespace Lesson8_Task1
{
    public class FormController : IController
    {
        IView view;
        IModel model;

        public FormController(IView v, IModel m)
        {
            view = v;
            model = m;

            view.SetController(this);

            model.Attach((IModelObserver)view);

            view.StringAdded += new ViewHandler<IView>(this.ChangeModel);
            view.ButtonPressed += new ViewHandler<IView>(this.ChangeView);
        }

        public void ChangeModel(IView v, ViewEventArgs e)
        {
            model.AddString(e.value);
        }

        public void ChangeView(IView v, ViewEventArgs e)
        {
            model.ShowCollection();
        }
    }
}