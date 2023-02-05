using TestZigZag.Input;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

namespace TestZigZag.UI
{
    public class PauseButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [Inject] private InputManager _inputManager;
        
        public void OnPointerDown(PointerEventData eventData)
        {
            _inputManager.PauseGame();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            
        }
    }
}