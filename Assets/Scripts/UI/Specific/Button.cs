using UnityEngine;
using UnityEngine.EventSystems;

namespace TestZigZag.UI
{
    public abstract class Button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        protected abstract void Click();
        
        public void OnPointerDown(PointerEventData eventData)
        {
            Click();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            
        }
    }
}