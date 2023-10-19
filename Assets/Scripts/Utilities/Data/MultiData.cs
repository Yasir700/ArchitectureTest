namespace ArchitectureTest.Utilities.Data
{
    public abstract class MultiData<T> : DataContainer where T : class
    {
        protected sealed override void RegisterToContainer()
        {
            if (!Container.ContainsKey(typeof(DataList<T>)))
                Container.Add(typeof(DataList<T>), new DataList<T>());

            (Container[typeof(DataList<T>)] as DataList<T>).Add(this as T);
        }
    }
}