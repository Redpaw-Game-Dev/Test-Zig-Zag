using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

namespace TestZigZag.UI
{
    [CreateAssetMenu(menuName = ("Game/UI Config"))]
    public class UiConfig : SerializedScriptableObject
    {
        [SerializeField] private string _mainCanvasTransformId = "MainCanvasTransform";
        [OdinSerialize] private Dictionary<Type, UiElement> _prefabs = new Dictionary<Type, UiElement>();

        public string MainCanvasTransformId => _mainCanvasTransformId;

        public T GetPrefab<T>(Type elementType = null) where T : UiElement
        {
            if (elementType != null)
            {
                foreach (var keyValuePair in _prefabs)
                {
                    if (keyValuePair.Key == elementType)
                    {
                        return (T)keyValuePair.Value;
                    }
                }
            }
            else
            {
                foreach (var keyValuePair in _prefabs)
                {
                    if (keyValuePair.Key == typeof(T))
                    {
                        return (T)keyValuePair.Value;
                    }
                }
            }
            return null;
        }
    }
}