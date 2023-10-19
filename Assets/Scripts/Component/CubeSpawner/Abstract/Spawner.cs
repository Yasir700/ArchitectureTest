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

        protected void SpawnCube()
        {
            Instantiate(CubePrefab);

            _cubeSpawnerData.CubeSpawned = true;
        }
    }
}