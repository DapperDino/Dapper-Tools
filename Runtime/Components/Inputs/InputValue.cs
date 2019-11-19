namespace DapperDino.DapperTools.Components.Inputs
{
    public struct InputValue<T>
    {
        private readonly T value;

        private bool handled;

        public InputValue(T value) : this() => this.value = value;

        public T Value
        {
            get
            {
                if (handled) { return default; }
                handled = true;
                return value;
            }
        }
    }
}
