using Machine.Specifications;

namespace kXtensions.Specs
{
    public class when_checking_if_a_number_is_between_a_range
    {
        private static int _value;
        private static int _leftValue;
        private static int _rightValue;
        private static bool _result;

        private Establish context = () =>
            {
                _value = 5;
                _leftValue = 3;
                _rightValue = 5;
            };

        private Because of = () => { _result = _value.IsBetween(_leftValue, _rightValue); };

        private It should_return_true_if_it_is_between_a_range = () => _result.ShouldBeTrue();
    }
}