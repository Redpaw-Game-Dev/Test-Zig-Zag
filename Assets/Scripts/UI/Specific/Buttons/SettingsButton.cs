using TestZigZag.Input;
using Zenject;

namespace TestZigZag.UI
{
    public class SettingsButton : Button
    {
        [Inject] private InputManager _inputManager;

        protected override void Click()
        {
            _inputManager.OpenSettings();
        }
    }
}