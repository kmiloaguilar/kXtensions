using Machine.Specifications;

namespace kXtensions.Specs
{
    public class when_checking_if_string_is_email
    {
        private static string _inputText;
        private static bool _result;
        private Establish context = () => { _inputText = "john@me.com"; };

        private Because of = () => { _result = _inputText.IsEmailAddress(); };

        private It should_return_true_if_is_email = () => { _result.ShouldBeTrue(); };

    }
}