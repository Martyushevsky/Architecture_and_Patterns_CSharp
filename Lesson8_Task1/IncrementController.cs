namespace Lesson8_Task1
{
    public class IncrementController : IController
    {
        IView view;
        IModel model;

        public IncrementController(IView v, IModel m)
        {
            view = v;
            model = m;
            view.SetController(this);
            model.Attach((IModelObserver)view);
            view.AddString += new ViewHandler<IView>(this.ViewChanged);
        }

        public void ViewChanged(IView v, ViewEventArgs e) => model.AddString(e.value);
    }
}