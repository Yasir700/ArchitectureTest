using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ArchitectureTest.Utilities.Data
{
    public class DataList<T> : List<T> where T : class
    {
        public T GetFirstCreated()
        {
            foreach (var instance in this)
                if (instance != null)
                    return instance;

            throw new System.Exception("There is not any instance of " + typeof(T));
        }

        public T GetLastCreated()
        {
            foreach (var instance in ToArray().Reverse())
                if (instance != null)
                    return instance;

            throw new System.Exception("There is not any instance of " + typeof(T));
        }

        public T GetByCreationOrder(int order)
        {
            return this[order];
        }

        public T GetByReverseCreationOrder(int reverseOrder)
        {
            return this[Count - reverseOrder - 1];
        }

        public T GetOnThisEntity(GameObject gameObject)
        {
            return gameObject.GetComponent<T>();
        }
    }
}