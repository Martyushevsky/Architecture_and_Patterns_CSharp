namespace ActiveMVC
{
    public interface IModel
    {
        void Attach(IModelObserver imo);
        void AddString(string v);
    }
}