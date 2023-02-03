using UnityEngine;
using Zenject;

namespace TestZigZag.Utilities
{
    public class CanvasWorldCameraInjector : MonoBehaviour
    {
        [SerializeField] private Canvas _canvas;

        [Inject]
        private void Construct([Inject(Id = "UiCamera")] Camera _uiCamera)
        {
            _canvas.worldCamera = _uiCamera;
        }
    }
}