using ArchitectureTest.Component.Cube;
using ArchitectureTest.Service.Compare.Abstract;
using ArchitectureTest.Service.Compare.Concrete;
using UnityEngine;

namespace ArchitectureTest.Component.CubeSpawner.Abstract
{
    public abstract class Spawner : MonoBehaviour
    {
        protected CubeSpawnerData _cubeSpawnerData;

        [SerializeField] GameObject CubePrefab;

        protected ICompare _cubeTypeIsBig;

        protected void Start()
        {
            _cubeSpawnerData = DataContainer.Get<CubeSpawnerData>();

            _cubeTypeIsBig = new CubeTypeIsBig();
        }

        protected CubeData SpawnCube()
        {
            var spawnedObject = Instantiate(CubePrefab);
            _cubeSpawnerData.CubeSpawned = true;
            return spawnedObject.GetComponent<CubeData>();
        }
    }
}