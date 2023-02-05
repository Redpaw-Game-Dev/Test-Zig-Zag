using Sirenix.OdinInspector;
using UnityEngine;

namespace TestZigZag.Game
{
    [CreateAssetMenu(menuName = ("Game/Game Config"))]
    public class GameConfig : SerializedScriptableObject
    {
        [SerializeField] private string _playerBallId = "PlayerBall";

        public string PlayerBallId => _playerBallId;
    }
}