using Machine.Specifications;

namespace kXtensions.Specs
{
    public class when_checking_if_string_is_number
    {
        private static string _inputText;
        private static bool _result;
        private Establish context = () => { _inputText = "123"; };

        private Because of = () => { _result = _inputText.IsNumber(); };

        private It should_return_true_if_is_number = () => { _result.ShouldBeTrue(); };
    }
}