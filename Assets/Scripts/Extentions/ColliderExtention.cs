using UnityEngine;

namespace ArchitectureTest.Extentions
{
    public class ColliderExtention : MonoBehaviour
    {
        protected Collider _collider;

        protected void Start()
        {
            _collider = GetComponent<Collider>();
        }
    }
}