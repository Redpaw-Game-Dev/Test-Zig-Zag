using UnityEngine;

namespace TestZigZag.CrystalManagement
{
    [CreateAssetMenu(menuName = ("Game/Crystal Config"))]
    public class CrystalConfig : ScriptableObject
    {
        [SerializeField] private string _platformsControllerId = "PlatformsController";
        [SerializeField] private Crystal _crystalPrefab;
        [SerializeField, Range(0f, 1f)] private float _spawnChance = 0.5f;

        public string PlatformsControllerId => _platformsControllerId;
        public Crystal CrystalPrefab => _crystalPrefab;
        public float SpawnChance => _spawnChance;
    }
}