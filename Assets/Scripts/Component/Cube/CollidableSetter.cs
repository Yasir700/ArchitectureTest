using ArchitectureTest.Extentions;

namespace ArchitectureTest.Component.Cube
{
    public class CollidableSetter : ColliderExtention
    {
        CubeData _cubeData;

        private new void Start()
        {
            base.Start();
            _cubeData = DataContainer.Get<CubeData>().GetOnThisEntity(gameObject);

            _cubeData.OnIsCollidableChanged.AddListener(SetCollidable);
        }

        void SetCollidable() => _collider.enabled = _cubeData.IsCollidable;
    }
}