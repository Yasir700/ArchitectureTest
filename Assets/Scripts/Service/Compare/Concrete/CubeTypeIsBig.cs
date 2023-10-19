using ArchitectureTest.Component.CubeSpawner;
using ArchitectureTest.Enum;
using ArchitectureTest.Service.Compare.Abstract;

namespace ArchitectureTest.Service.Compare.Concrete
{
    public class CubeTypeIsBig : ICompare
    {
        public bool Check() => DataContainer.Get<CubeSpawnerData>().CubeType == CubeType.BigCube;
    }
}