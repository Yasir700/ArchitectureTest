using ArchitectureTest.Component.Cube;
using ArchitectureTest.Component.CubeSpawner.Abstract;
using ArchitectureTest.Enum;
using UnityEngine;

namespace ArchitectureTest.Component.CubeSpawner.Concrete
{
    public class SmallCubeSpawner : Spawner
    {
        public CubeDataLoad BigCubeDataLoad;
        public CubeDataLoad SmallCubeDataLoad;
        private new void Start()
        {
            base.Start();
            _cubeSpawnerData.OnSpawnSmallCubeNowChange.AddListener(() => { if (_cubeSpawnerData.SpawnSmallCubeNow) SpawnCube(); });
            BigCubeDataLoad.OnDataLoaded += (x) => OnCubeDataLoaded(x, CubeType.BigCube);
            SmallCubeDataLoad.OnDataLoaded += (x) => OnCubeDataLoaded(x, CubeType.SmallCube);
        }
        private void OnCubeDataLoaded(CubeData cubeData, CubeType cubeType)
        {
            Debug.Log(cubeData.name + (cubeType == CubeType.BigCube ? " is big" : "isSmall"));
        }
    }
}