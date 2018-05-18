namespace Lesson8_Task1
{
    public interface IModelObserver
    {
        void ListChanged(IModel model, ModelEventArgs e);
    }
}