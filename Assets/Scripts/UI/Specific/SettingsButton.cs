using TestZigZag.Input;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

namespace TestZigZag.UI
{
    public class SettingsButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [Inject] private InputManager _inputManager;
        
        public void OnPointerDown(PointerEventData eventData)
        {
            _inputManager.OpenSettings();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            
        }
    }
}