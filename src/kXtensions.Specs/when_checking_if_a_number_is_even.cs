using Machine.Specifications;

namespace kXtensions.Specs
{
    public class when_checking_if_a_number_is_even
    {
        private Establish context = () =>
            {
                _value = 4;
            };

        private Because of = () => {
                                       _result = _value.IsEven();
        };

        private It should_return_true_if_it_is_even = () => _result.ShouldBeTrue();

        private static int _value;
        private static bool _result;
    }
}