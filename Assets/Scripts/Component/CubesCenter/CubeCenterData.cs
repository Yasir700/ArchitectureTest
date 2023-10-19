using ArchitectureTest.Utilities.Data;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace ArchitectureTest.Component.CubeCenter
{
    public class CubeCenterData : SingleData<CubeCenterData>
    {
        [SerializeField] Transform _cubesParent;
        public Transform CubesParent
        {
            set
            {
                _cubesParent = value;
                OnCubesParentChanged.Invoke();
            }
            get => _cubesParent;
        }
        [NonSerialized] public UnityEvent OnCubesParentChanged = new UnityEvent();
    }
}