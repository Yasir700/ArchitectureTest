using ArchitectureTest.Component.Cube;
using ArchitectureTest.Component.CubeSpawner;
using System.Collections.Generic;
using UnityEngine;

namespace ArchitectureTest.Component.CubeCenter
{
    public class ParentSetter : MonoBehaviour
    {
        CubeCenterData _cubesCommonData;
        CubeSpawnerData _cubeSpawnerData;
        List<CubeData> _cubeDatas => DataContainer.Get<CubeData>();

        private void Start()
        {
            _cubesCommonData = DataContainer.Get<CubeCenterData>();
            _cubeSpawnerData = DataContainer.Get<CubeSpawnerData>();

            _cubesCommonData.OnCubesParentChanged.AddListener(SetParents);
            _cubeSpawnerData.OnCubeSpawned += () => { if (_cubeSpawnerData.CubeSpawned) SetParents(); };
        }

        void SetParents()
        {
            foreach (var cubeData in _cubeDatas)
                cubeData.CubeParent = _cubesCommonData.CubesParent;

            _cubeSpawnerData.CubePlacedInHierachy = true;
        }
    }
}
