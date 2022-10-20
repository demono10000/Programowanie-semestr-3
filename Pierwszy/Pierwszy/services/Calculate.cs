namespace Pierwszy.services
{
    public class Calculate
    {
        public Calculate(int initVal)
        {
            Value = initVal;
        }
        private int Value { get; set; }

        public void Add(int value)
        {
            Value += value;
        }
        public void Decrease(int value)
        {
            Value -= value;
        }
        public int GetValue()
        {
            return Value;
        }
    }
}
