using TestZigZag.Input;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace TestZigZag.UI
{
    public class SwitchModeButton : Button
    {
        [SerializeField] private Slider _slider;

        [Inject] private InputManager _inputManager;
        
        private void Awake()
        {
            _slider.value = _slider.minValue;
        }

        protected override void Click()
        {
            _slider.value = _slider.value == _slider.minValue ? _slider.maxValue : _slider.minValue;
            _inputManager.SwitchMode();
        }
    }
}