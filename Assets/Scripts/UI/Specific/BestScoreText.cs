using TestZigZag.ScoreManagement;
using TMPro;
using UnityEngine;
using Zenject;

namespace TestZigZag.UI
{
    public class BestScoreText : UiElement
    {
        [SerializeField] private TMP_Text _tmpText;
        
        private ScoreManager _scoreManager;
        
        [Inject]
        private void Construct(ScoreManager scoreManager)
        {
            _scoreManager = scoreManager;
        }

        private void UpdateText(int bestScore)
        {
            _tmpText.text = bestScore.ToString();
        }

        private void OnEnable()
        {
            _scoreManager.OnBestScoreChanged += UpdateText;
            UpdateText(_scoreManager.BestScore);
        }
        
        private void OnDisable()
        {
            _scoreManager.OnBestScoreChanged -= UpdateText;
        }
    }
}