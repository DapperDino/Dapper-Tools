using DapperDino.DapperTools.StateMachines;
using Moq;
using NUnit.Framework;

namespace DapperDino.DapperTools.Tests.StateMachines
{
    public class StateMachineTests
    {
        [Test]
        public void StartingStateIsSet()
        {
            var mock = new Mock<IState>();

            var stateMachine = new StateMachine(mock.Object);

            Assert.AreSame(mock.Object, stateMachine.CurrentState);
        }

        [Test]
        public void StateMachineTick_CurrentStateIsTicket()
        {
            var mock = new Mock<IState>();

            var stateMachine = new StateMachine(mock.Object);
            stateMachine.Tick(0);

            mock.Verify(x => x.Tick(0), Times.Once());
        }

        [Test]
        public void StateMachineTickWithTransitionStateReady_TransitionsToState()
        {
            var startingStateMock = new Mock<IState>();
            var transitionToStateMock = new Mock<IState>();
            startingStateMock.Setup(x => x.ProcessTransitions()).Returns(transitionToStateMock.Object);

            var stateMachine = new StateMachine(startingStateMock.Object);
            stateMachine.Tick(0);

            Assert.AreSame(transitionToStateMock.Object, stateMachine.CurrentState);
        }
    }
}
