using ArchitectureTest.Component.CubeSpawner.Abstract;

namespace ArchitectureTest.Component.CubeSpawner.Concrete
{
    public class BigCubeSpawner : Spawner
    {
        private new void Start()
        {
            base.Start();

            _cubeSpawnerData.OnSpawnBigCubeNowChange.AddListener(() => { if (_cubeSpawnerData.SpawnBigCubeNow) SpawnCube(); });
        }
    }
}