using Xunit;

namespace Tests
{
    public class UnitTest
    {
        [Fact]
        public void Test1()
        {

            int a = 5;
            int b = a + 2; //OK

            bool test = true;

            // Error. Operator '+' cannot be applied to operands of type 'int' and 'bool'.
            // int c = a + test;
        }
    }
}
