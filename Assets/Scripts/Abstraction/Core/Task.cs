using System;

namespace TestZigZag.Abstraction
{
    [Serializable]
    public abstract class Task
    {
        public abstract void Do(IInfo info = null);
    }
}