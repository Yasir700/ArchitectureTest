using System;
using UnityEngine.Events;
using UnityEngine;
using ArchitectureTest.Utilities.Data;

namespace ArchitectureTest.Component.Cube
{
    public class CubeData : MultiData<CubeData>
    {
        bool _isMoving = true;
        public bool IsMoving
        {
            set
            {
                _isMoving = value;
                OnIsMovingChanged?.Invoke();
            }
            get => _isMoving;
        }
        [NonSerialized] public UnityEvent OnIsMovingChanged = new UnityEvent();


        float _moveSpeed = .5f;
        public float MoveSpeed
        {
            set
            {
                _moveSpeed = value;
                OnMoveSpeedChanged?.Invoke();
            }
            get => _moveSpeed;
        }
        [NonSerialized] public UnityEvent OnMoveSpeedChanged = new UnityEvent();


        bool _isCollidable;
        public bool IsCollidable
        {
            set
            {
                _isCollidable = value;
                OnIsCollidableChanged?.Invoke();
            }
            get => _isCollidable;
        }
        [NonSerialized] public UnityEvent OnIsCollidableChanged = new UnityEvent();


        Transform _cubeParent;
        public Transform CubeParent
        {
            set
            {
                _cubeParent = value;
                OnCubeParentChanged?.Invoke();
            }
            get => _cubeParent;
        }
        [NonSerialized] public UnityEvent OnCubeParentChanged = new UnityEvent();
    }
}