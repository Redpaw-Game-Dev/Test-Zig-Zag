using TestZigZag.Game;
using Zenject;

namespace TestZigZag.StateMachineSystem
{
    public class GameModeAiCondition : Condition
    {
        [Inject] private GameManager _gameManager;
        
        public override bool IsFulfilled()
        {
            return _logicalNot 
                ? _gameManager.GameMode != GameMode.AI 
                : _gameManager.GameMode == GameMode.AI;
        }
    }
}