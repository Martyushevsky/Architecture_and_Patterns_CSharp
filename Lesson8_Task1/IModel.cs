namespace Lesson8_Task1
{
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);

    public interface IModel
    {
        void Attach(IModelObserver modelObserver);
        void AddString(string v);
        void ShowCollection();
    }
}