using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Cysharp.Threading.Tasks;
using TestZigZag.ObjectsManagement;
using Zenject;
using Object = UnityEngine.Object;

namespace TestZigZag.UI
{
    public class UiManager : IInitializable
    {
        private UiConfig _uiConfig;
        private Transform _mainCanvasTransform;
        private List<UiElement> _pooledElements = new List<UiElement>();
        private List<UiElement> _activeElements = new List<UiElement>();

        [Inject]
        private void Construct(UiConfig uiConfig, ObjectsManager objectsManager)
        {
            _uiConfig = uiConfig;
            _mainCanvasTransform = objectsManager.GetObject<Transform>(_uiConfig.MainCanvasTransformId, GetTransformCallback);
        }
        
        public void Initialize()
        {
            
        }
        
        public async UniTask<T> ShowElement<T>(Type elementType = null) where T : UiElement
        {
            await UniTask.WaitWhile(() => _mainCanvasTransform == null);
            T element = elementType == null
                ? (T)_pooledElements.FirstOrDefault(element => element.GetType() == typeof(T))
                : (T)_pooledElements.FirstOrDefault(element => element.GetType() == elementType);
            if (element == null)
            {
                var prefab = _uiConfig.GetPrefab<T>(elementType);
                var prefabTransform = prefab.transform;
                element = GameObject.Instantiate(prefab, prefabTransform.localPosition, prefabTransform.localRotation,
                    _mainCanvasTransform);
                RectTransform rectTransform = element.GetComponent<RectTransform>();
                rectTransform.offsetMin = Vector2.zero;
                rectTransform.offsetMax = Vector2.zero;
                rectTransform.localPosition = Vector3.zero;
                rectTransform.localRotation = Quaternion.Euler(Vector3.zero);
                rectTransform.localScale = Vector3.one;
            }
            element.gameObject.SetActive(true);
            _activeElements.Add(element);
            return element;
        }
        
        public void HideElement<T>(Type elementType = null) where T : UiElement
        {
            T element = elementType == null
                ? (T)_activeElements.FirstOrDefault(element => element.GetType() == typeof(T))
                : (T)_activeElements.FirstOrDefault(element => element.GetType() == elementType);
            if (element != null)
            {
                element.gameObject.SetActive(false);
                _activeElements.Remove(element);
                _pooledElements.Add(element);
            }
        }
        
        private void GetTransformCallback(Object obj)
        {
            _mainCanvasTransform = (Transform)obj;
        }
    }
}