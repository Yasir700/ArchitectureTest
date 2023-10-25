using System.Collections;
using System.Collections.Generic;
using ArchitectureTest.Component.Cube;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "CubeData", menuName = "Data/CubeData")]
public class CubeDataLoad : DataLoadHandler<CubeData>
{
    public UnityAction OnCubeSpawned;
    public override void Spawn()
    {
        OnCubeSpawned?.Invoke();
    }
}
