using UnityEngine;
using UnityEngine.Events;

public abstract class DataLoadHandler<T> : ScriptableObject
{
    public T FirstValue;
    public T LatestValue;
    public UnityAction<T> OnDataLoaded;
    public void Invoke(T data)
    {
        if (FirstValue == null)
        {
            FirstValue = data;
            LatestValue = data;
        }
        else
        {
            LatestValue = data;
        }
        OnDataLoaded?.Invoke(data);
    }
    public abstract void Spawn();
}
