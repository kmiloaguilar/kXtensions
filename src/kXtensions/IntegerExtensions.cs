namespace kXtensions
{
    public static class IntegerExtensions
    {
        public static bool IsBetween(this int value, int leftValue, int rightValue)
        {
            return value >= leftValue && value <= rightValue;
        }

        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }   
    }
}