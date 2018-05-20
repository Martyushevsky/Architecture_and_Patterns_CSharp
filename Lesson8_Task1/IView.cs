namespace Lesson8_Task1
{
    public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);

    public interface IView
    {
        event ViewHandler<IView> StringAdded;
        event ViewHandler<IView> ButtonPressed;
        void SetController(IController controller);
    }
}