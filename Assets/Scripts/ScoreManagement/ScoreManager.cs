using System;
using TestZigZag.Abstraction;
using TestZigZag.CrystalManagement;
using TestZigZag.Game;
using TestZigZag.ObjectsManagement;
using Zenject;
using Object = UnityEngine.Object;

namespace TestZigZag.ScoreManagement
{
    public class ScoreManager : IInitializable
    {
        private Ball _ball;
        private int _score;
        private int _bestScore;
        private int _gameCount;

        public int Score
        {
            get => _score;
            private set
            {
                _score = value;
                OnScoreChanged?.Invoke(_score);
            }
        }
        public int BestScore
        {
            get => _bestScore;
            private set
            {
                _bestScore = value;
                OnBestScoreChanged?.Invoke(_bestScore);
            }
        }
        public int GameCount => _gameCount;

        public event Action<int> OnScoreChanged; 
        public event Action<int> OnBestScoreChanged; 

        [Inject]
        private void Construct(string ballId, ObjectsManager objectsManager, GameManager gameManager, CrystalManager crystalManager)
        {
            _ball = objectsManager.GetObject<Ball>(ballId, GetBallCallback);
            gameManager.OnGameStarted += HandleGameStarted;
            gameManager.OnGameEnded += HandleGameEnded;
            crystalManager.OnCrystalCollected += HandleCrystalCollected;
        }

        private void HandleCrystalCollected(int points)
        {
            Score += points;
        }

        public void Initialize()
        {
            
        }
        
        private void HandleGameEnded()
        {
            if (_bestScore < _score) BestScore = _score;
        }

        private void HandleGameStarted()
        {
            Score = 0;
            _gameCount++;
        }

        private void GetBallCallback(Object obj)
        {
            _ball = (Ball)obj;
            _ball.OnTurned += HandleBallTurn;
        }

        private void HandleBallTurn()
        {
            Score++;
        }
    }
}