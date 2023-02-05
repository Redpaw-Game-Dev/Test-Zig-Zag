using TestZigZag.Input;
using Zenject;

namespace TestZigZag.UI
{
    public class PauseButton : Button
    {
        [Inject] private InputManager _inputManager;

        protected override void Click()
        {
            _inputManager.PauseGame();
        }
    }
}