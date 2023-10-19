using UnityEngine;

namespace ArchitectureTest.Component.CubeSpawner.Concrete
{
    public class SpawnerRefresher : MonoBehaviour
    {
        CubeSpawnerData _cubeSpawnerData;

        private void Start()
        {
            _cubeSpawnerData = DataContainer.Get<CubeSpawnerData>();

            _cubeSpawnerData.OnCubePlacedInHierachy.AddListener(() => { if (_cubeSpawnerData.CubeSpawned && _cubeSpawnerData.CubePlacedInHierachy) Refresh(); });
        }

        void Refresh()
        {
            _cubeSpawnerData.SpawnBigCubeNow = false;
            _cubeSpawnerData.SpawnRequest = false;

            _cubeSpawnerData.CubeSpawned = false;
        }
    }
}