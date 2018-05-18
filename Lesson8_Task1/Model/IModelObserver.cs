namespace ActiveMVC
{
    public interface IModelObserver
    {
        void ListChanged(IModel model, ModelEventArgs e);
    }
}