using ArchitectureTest.Component.Cube;
using ArchitectureTest.Component.CubeSpawner.Abstract;

namespace ArchitectureTest.Component.CubeSpawner.Concrete
{
    public class BigCubeSpawner : Spawner
    {
        public CubeDataLoad CubeDataLoad;
        private new void Start()
        {
            base.Start();

            _cubeSpawnerData.OnSpawnBigCubeNowChange.AddListener(() =>
            {
                if (_cubeSpawnerData.SpawnBigCubeNow)
                {
                    CubeData spawnedCubeData = SpawnCube();
                    CubeDataLoad.Invoke(spawnedCubeData);
                }
            });
        }
    }
}