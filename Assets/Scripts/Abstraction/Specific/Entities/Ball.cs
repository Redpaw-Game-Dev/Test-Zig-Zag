using System;

namespace TestZigZag.Abstraction
{
    public class Ball : SerializedEntity
    {
        public event Action OnDead;
        public event Action OnTurned;

        public void CallDeathEvent()
        {
            OnDead?.Invoke();
        }
        
        public void CallTurnEvent()
        {
            OnTurned?.Invoke();
        }
    }
}