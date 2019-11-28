namespace DapperDino.DapperTools.Inputs
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
                // Make sure we only read this value once and return the default value otherwise
                if (handled) { return default; }
                handled = true;

                // Return the actual value for this input
                return value;
            }
        }
    }
}
