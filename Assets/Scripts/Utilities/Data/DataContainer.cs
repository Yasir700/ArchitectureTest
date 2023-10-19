using ArchitectureTest.Utilities.Data;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ArchitectureTest
{
    public abstract class DataContainer : MonoBehaviour
    {
        protected static Dictionary<Type, object> Container = new Dictionary<Type, object>();

        private void Awake()
        {
            RegisterToContainer();
        }

        protected abstract void RegisterToContainer();

        public static DataList<T> Get<T>() where T : MultiData<T>
        {
            return Container[typeof(DataList<T>)] as DataList<T>;
        }

        public static T Get<T>(bool dontDefineThis = false) where T : SingleData<T>
        {
            return Container[typeof(T)] as T;
        }
    }
}