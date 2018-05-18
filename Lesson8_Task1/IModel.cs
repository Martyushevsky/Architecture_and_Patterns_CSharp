namespace Lesson8_Task1
{
    public interface IModel
    {
        void Attach(IModelObserver imo);
        void AddString(string v);
    }
}
