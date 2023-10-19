namespace ArchitectureTest.Utilities.Data
{
    public abstract class SingleData<T> : DataContainer where T : class
    {
        protected sealed override void RegisterToContainer()
        {
            if (!Container.ContainsKey(typeof(T)))
                Container.Add(typeof(T), this);
        }
    }
}