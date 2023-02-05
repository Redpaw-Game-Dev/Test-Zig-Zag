using TestZigZag.Input;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

namespace TestZigZag.UI
{
    public class StartButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [Inject] private InputManager _inputManager;
        
        public void OnPointerDown(PointerEventData eventData)
        {
            _inputManager.StartGame();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            
        }
    }
}