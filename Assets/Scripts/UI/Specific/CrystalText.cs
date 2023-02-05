using TestZigZag.CrystalManagement;
using TMPro;
using UnityEngine;
using Zenject;

namespace TestZigZag.UI
{
    public class CrystalText : UiElement
    {
        [SerializeField] private TMP_Text _tmpText;
        
        private CrystalManager _crystalManager;
        
        [Inject]
        private void Construct(CrystalManager crystalManager)
        {
            _crystalManager = crystalManager;
        }

        private void UpdateText(int score)
        {
            _tmpText.text = score.ToString();
        }

        private void OnEnable()
        {
            UpdateText(_crystalManager.CollectedCrystalsCount);
        }
    }
}