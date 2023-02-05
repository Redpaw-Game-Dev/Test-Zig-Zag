using System;
using TestZigZag.ScoreManagement;
using TMPro;
using UnityEngine;
using Zenject;

namespace TestZigZag.UI
{
    public class ScoreText : UiElement
    {
        [SerializeField] private TMP_Text _tmpText;
        
        private ScoreManager _scoreManager;
        
        [Inject]
        private void Construct(ScoreManager scoreManager)
        {
            _scoreManager = scoreManager;
        }

        private void UpdateText(int score)
        {
            _tmpText.text = score.ToString();
        }

        private void OnEnable()
        {
            _scoreManager.OnScoreChanged += UpdateText;
            UpdateText(_scoreManager.Score);
        }
        
        private void OnDisable()
        {
            _scoreManager.OnScoreChanged -= UpdateText;
        }
    }
}