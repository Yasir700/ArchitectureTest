using UnityEngine;

namespace ArchitectureTest.Component.Cube
{
    public class ParentSetter : MonoBehaviour
    {
        CubeData _cubeData;

        private void Start()
        {
            _cubeData = DataContainer.Get<CubeData>().GetOnThisEntity(gameObject);

            SetParent();
            _cubeData.OnCubeParentChanged.AddListener(SetParent);
        }

        void SetParent()
        {
            transform.parent = _cubeData.CubeParent;
        }
    }
}