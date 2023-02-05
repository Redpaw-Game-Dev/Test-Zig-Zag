using TestZigZag.Game;
using Zenject;

namespace TestZigZag.StateMachineSystem
{
    public class GameModePlayerCondition : Condition
    {
        [Inject] private GameManager _gameManager;
        
        public override bool IsFulfilled()
        {
            return _logicalNot 
                ? _gameManager.GameMode != GameMode.Player 
                : _gameManager.GameMode == GameMode.Player;
        }
    }
}