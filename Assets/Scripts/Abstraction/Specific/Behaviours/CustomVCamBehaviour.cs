using System;
using Cinemachine;
using Sirenix.OdinInspector;
using TestZigZag.Game;
using TestZigZag.ObjectsManagement;
using UnityEngine;
using Zenject;
using Object = UnityEngine.Object;

namespace TestZigZag.Abstraction
{
    public class CustomVCamBehaviour : SerializedMonoBehaviour
    {
        private readonly int _priorityActivated = 10;
        private readonly int _priorityDeactivated = -10;
        
        [SerializeField] protected CinemachineVirtualCameraBase _vCam;
        [SerializeField] protected bool _setFollowTarget;
        [SerializeField] protected bool _setLookAtTarget;
        [SerializeField] protected string _targetTransformId;

        protected Transform _targetTransform;
        protected bool _isActive;

        public int Priority => _vCam.m_Priority;

        public event Action<CustomVCamBehaviour> OnActivated;
        public event Action<CustomVCamBehaviour> OnDeactivated;
                
        [Inject]
        protected void Construct(ObjectsManager objectsManager, GameManager gameManager)
        {
            _targetTransform = objectsManager.GetObject<Transform>(_targetTransformId, GetTransformCallback);
        }

        public void StartFollowing()
        {
            if (_targetTransform != null)
            {
                if (_setFollowTarget) _vCam.Follow = _targetTransform;
                if (_setLookAtTarget) _vCam.LookAt = _targetTransform;
            }
        }

        public void StopFollowing()
        {
            if (_setFollowTarget) _vCam.Follow = null;
            if (_setLookAtTarget) _vCam.LookAt = null;
        }
        
        public void Activate()
        {
            if(_isActive) return;
            _isActive = true;
            SetPriority(_priorityActivated);
            OnActivated?.Invoke(this);
        }
        
        public void Deactivate()
        {
            if(!_isActive) return;
            _isActive = false;
            SetPriority(_priorityDeactivated);
            OnDeactivated?.Invoke(this);
        }
        
        private void SetPriority(int priority)
        {
            _vCam.Priority = priority;
        }
        
        private void GetTransformCallback(Object obj)
        {
            _targetTransform = (Transform)obj;
            StartFollowing();
        }
    }
}