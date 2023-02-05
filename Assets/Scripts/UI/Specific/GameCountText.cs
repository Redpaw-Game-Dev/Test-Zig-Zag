using ScoreManagement;
using TMPro;
using UnityEngine;
using Zenject;

namespace TestZigZag.UI
{
    public class GameCountText : UiElement
    {
        [SerializeField] private TMP_Text _tmpText;
        
        private ScoreManager _scoreManager;
        
        [Inject]
        private void Construct(ScoreManager scoreManager)
        {
            _scoreManager = scoreManager;
        }
        
        private void OnEnable()
        {
            _tmpText.text = _scoreManager.GameCount.ToString();
        }
    }
}