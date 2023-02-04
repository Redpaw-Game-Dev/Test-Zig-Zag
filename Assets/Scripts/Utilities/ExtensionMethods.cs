using UnityEngine;

namespace TestZigZag.Utilities
{
    public static class ExtensionMethods
    {
        public static bool Contains(this LayerMask layerMask, int layer)
        {
            return layerMask == (layerMask | (1 << layer));
        }
    }
}