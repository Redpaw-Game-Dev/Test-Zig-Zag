using TestZigZag.Input;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Zenject;

namespace TestZigZag.UI
{
    public class SwitchModeButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField] private Slider _slider;

        [Inject] private InputManager _inputManager;
        
        private void Awake()
        {
            _slider.value = _slider.minValue;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            _slider.value = _slider.value == _slider.minValue ? _slider.maxValue : _slider.minValue;
            _inputManager.SwitchMode();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            
        }
    }
}