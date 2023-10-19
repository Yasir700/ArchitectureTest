using ArchitectureTest.Enum;
using ArchitectureTest.Utilities.Data;
using System;
using UnityEngine.Events;

namespace ArchitectureTest.Component.CubeSpawner
{
    public class CubeSpawnerData : SingleData<CubeSpawnerData>
    {
        CubeType _cubeType;
        public CubeType CubeType
        {
            set
            {
                _cubeType = value;
                OnCubeTypeChange?.Invoke();
            }
            get => _cubeType;
        }
        [NonSerialized] public UnityEvent OnCubeTypeChange = new UnityEvent();


        bool _spawnRequest;
        public bool SpawnRequest
        {
            set
            {
                _spawnRequest = value;
                OnSpawnRequestChange?.Invoke();
            }
            get => _spawnRequest;
        }
        [NonSerialized] public UnityEvent OnSpawnRequestChange = new UnityEvent();


        bool _spawnBigCubeNow;
        public bool SpawnBigCubeNow
        {
            set
            {
                _spawnBigCubeNow = value;
                OnSpawnBigCubeNowChange?.Invoke();
            }
            get => _spawnBigCubeNow;
        }
        [NonSerialized] public UnityEvent OnSpawnBigCubeNowChange = new UnityEvent();


        bool _spawnSmallCubeNow;
        public bool SpawnSmallCubeNow
        {
            set
            {
                _spawnSmallCubeNow = value;
                OnSpawnSmallCubeNowChange?.Invoke();
            }
            get => _spawnSmallCubeNow;
        }
        [NonSerialized] public UnityEvent OnSpawnSmallCubeNowChange = new UnityEvent();


        bool _cubeSpawned;
        public bool CubeSpawned
        {
            set
            {
                _cubeSpawned = value;
                OnCubeSpawned?.Invoke();
            }
            get => _cubeSpawned;
        }
        public event Action OnCubeSpawned;


        bool _cubePlacedInHierachy;
        public bool CubePlacedInHierachy
        {
            set
            {
                _cubePlacedInHierachy = value;
                OnCubePlacedInHierachy?.Invoke();
            }
            get => _cubePlacedInHierachy;
        }
        [NonSerialized] public UnityEvent OnCubePlacedInHierachy = new UnityEvent();

    }
}