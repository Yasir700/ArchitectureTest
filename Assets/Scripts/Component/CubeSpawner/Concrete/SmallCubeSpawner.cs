using ArchitectureTest.Component.CubeSpawner.Abstract;

namespace ArchitectureTest.Component.CubeSpawner.Concrete
{
    public class SmallCubeSpawner : Spawner
    {
        private new void Start()
        {
            base.Start();

            _cubeSpawnerData.OnSpawnSmallCubeNowChange.AddListener(() => { if (_cubeSpawnerData.SpawnSmallCubeNow) SpawnCube(); });
        }
    }
}