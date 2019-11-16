using DapperDino.DapperTools.Components.Timers;
using NUnit.Framework;

namespace DapperDino.DapperTools.Tests.Components
{
    public class TimerTests
    {
        [Test]
        [TestCase(1f)]
        [TestCase(5f)]
        [TestCase(36.3f)]
        public void StartingDurationIsSet(float duration)
        {
            var timer = new Timer(duration);

            Assert.IsTrue(timer.RemainingSeconds == duration);
        }

        [Test]
        public void TickingBelowZeroSeconds_StopsAtZero()
        {
            var timer = new Timer(1f);

            timer.Tick(2f);

            Assert.IsTrue(timer.RemainingSeconds == 0f);
        }

        [Test]
        public void TimerEnds_EventIsRaised()
        {
            var timer = new Timer(1f);
            bool eventHasBeenRaised = false;
            timer.OnTimerEnd += () => eventHasBeenRaised = true;

            timer.Tick(1f);

            Assert.IsTrue(eventHasBeenRaised);
        }

        [Test]
        public void TimerDoesNotEnd_EventIsNotRaised()
        {
            var timer = new Timer(1f);
            bool eventHasBeenRaised = false;
            timer.OnTimerEnd += () => eventHasBeenRaised = true;

            timer.Tick(0.5f);

            Assert.IsFalse(eventHasBeenRaised);
        }
    }
}
