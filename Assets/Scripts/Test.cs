using ArchitectureTest;
using ArchitectureTest.Component.CubeSpawner;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        Invoke("StartTest", 2);
    }

    void StartTest()
    {
        DataContainer.Get<CubeSpawnerData>().SpawnRequest = true;
    }
}