using UnityEngine;

namespace ArchitectureTest.Component.Cube
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private CubeDataLoad cubeDataLoad;
        CubeData _cubeData;

        private void Start()
        {
            _cubeData = DataContainer.Get<CubeData>().GetOnThisEntity(gameObject);
            Debug.Log(cubeDataLoad.LatestValue.name);
        }

        private void Update()
        {
            if (_cubeData.IsMoving)
                Move(_cubeData.MoveSpeed * Time.deltaTime);
        }

        void Move(float speed) => transform.Translate(Vector3.forward * speed);
    }
}