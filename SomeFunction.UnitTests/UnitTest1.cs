using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging.Abstractions;

namespace SomeFunction.UnitTests
{
    public class UnitTest1
    {
        private Function1 _function1;

        public UnitTest1()
        {
            _function1 = new Function1(new NullLoggerFactory());
        }

        [Fact]
        public void Test1()
        {
            _function1.Run(new TimerInfo());
        }
    }
}