using ArchitectureTest.Component.CubeSpawner.Abstract;

namespace ArchitectureTest.Component.CubeSpawner.Concrete
{
    public class BigCubeSpawnConditionChecker : SpawnConditionsChecker
    {
        protected override bool ConditionsMet() => _cubeTypeIsBig.Check();
    }
}