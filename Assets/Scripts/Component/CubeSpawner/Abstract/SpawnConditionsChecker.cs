using ArchitectureTest.Service.Compare.Abstract;
using ArchitectureTest.Service.Compare.Concrete;
using UnityEngine;

namespace ArchitectureTest.Component.CubeSpawner.Abstract
{
    public abstract class SpawnConditionsChecker : MonoBehaviour
    {
        CubeSpawnerData _cubeSpawnerData;

        protected ICompare _cubeTypeIsBig = new CubeTypeIsBig();

        private void Start()
        {
            _cubeSpawnerData = DataContainer.Get<CubeSpawnerData>();

            _cubeSpawnerData.OnSpawnRequestChange.AddListener(() =>
            {
                if (_cubeSpawnerData.SpawnRequest && ConditionsMet())
                    _cubeSpawnerData.SpawnBigCubeNow = true;
            });
        }

        abstract protected bool ConditionsMet();
    }
}