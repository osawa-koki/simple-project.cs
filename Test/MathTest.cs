using Xunit;
using simple_project_cs;

namespace Test
{
    public class MathTest
    {
        [Fact]
        public void AddTest()
        {
            int a = 5;
            int b = 10;
            int expected = 15;
            int actual = Math.add(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubTest()
        {
            int a = 5;
            int b = 10;
            int expected = -5;
            int actual = Math.sub(a, b);
            Assert.Equal(expected, actual);
        }
    }
}
