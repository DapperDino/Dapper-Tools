using System;

namespace DapperDino.DapperTools.Components.Timers
{
    public class Timer
    {
        public float RemainingSeconds { get; private set;}
        public bool IsRepetitive { get; private set; }
        private float initialVal;
        public event Action OnTimerEnd;
        public Timer(float duration, bool isRepetitive)
        {
            RemainingSeconds = duration;
            IsRepetitive = isRepetitive;
            initialVal = duration;
        }
        public void Tick(float deltaTime)
        {
            if (RemainingSeconds == 0) { return; }

            RemainingSeconds -= deltaTime;
            CheckForTimerEnd();
    }
    private void CheckForTimerEnd()
    {
        if (RemainingSeconds > 0) { return; }

        if(IsRepetitive)
        {
            RemainingSeconds = initialVal;
            OnTimerEnd?.Invoke();
        }
        else
        {
            RemainingSeconds = 0f;
            OnTimerEnd?.Invoke();
        }
    }
    
}
}
