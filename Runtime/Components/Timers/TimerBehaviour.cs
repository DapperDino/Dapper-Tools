using UnityEngine;
using UnityEngine.Events;

namespace DapperDino.DapperTools.Components.Timers
{
    public class TimerComponent : MonoBehaviour
    {
        [SerializeField] private float _duration = 1f;
        [SerializeField] private bool _isRepetitive = false;
        [SerializeField] private UnityEvent _onTimerEnd = null;
        private Timer _timer;

        private void Start()
        {
            _timer = new Timer(_duration, _isRepetitive);
            _timer.OnTimerEnd += HandlerTimerEnd;
        }
        private void HandlerTimerEnd()
        {
            _onTimerEnd?.Invoke();
        }
        private void Update()
        {
            _timer.Tick(Time.deltaTime);
        }
    }
}
