using TestZigZag.Game;
using Zenject;

namespace TestZigZag.StateMachineSystem
{
    public class GameStartedCondition : Condition
    {
        [Inject] private GameManager _gameManager;
        
        public override bool IsFulfilled()
        {
            return _logicalNot ? !_gameManager.IsGameStarted : _gameManager.IsGameStarted;
        }
    }
}