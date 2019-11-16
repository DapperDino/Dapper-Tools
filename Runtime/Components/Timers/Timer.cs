using System;

namespace DapperDino.DapperTools.Components.Timers
{
    public class Timer
    {
        public float RemainingSeconds { get; private set; }

        public Timer(float duration) => RemainingSeconds = duration;

        public event Action OnTimerEnd;

        public void Tick(float deltaTime)
        {
            // Stop ticking if the timer has already ended
            if (RemainingSeconds == 0f) { return; }

            // Tick the timer down by the time it took to complete last frame
            RemainingSeconds -= deltaTime;

            // Check to see if the timer has finished ticking
            CheckForTimerEnd();
        }

        private void CheckForTimerEnd()
        {
            // Leave if there is still time left to tick
            if (RemainingSeconds > 0f) { return; }

            // Set to zero due to duration possibly going below zero with the deltaTime subtraction
            RemainingSeconds = 0f;

            // Alert any listeners that the timer has ended
            OnTimerEnd?.Invoke();
        }
    }
}
