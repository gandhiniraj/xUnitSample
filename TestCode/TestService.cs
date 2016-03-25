using System.Runtime.Remoting.Messaging;
using ProductCode;
using Xunit;

namespace MyFirstUnitTests
{
    public class TestService
    {
        public Service s;

        public TestService()
        {
            s = new Service();
        }

        [Fact]
        public void PassingTest1()
        {
            Assert.Equal(4, s.Add(2, 2));
        }

        [Fact]
        public void PassingTest2()
        {
            Assert.Equal(4, s.Add(2, 2));
        }

        [Fact]
        public void PassingTest3()
        {
            Assert.Equal(4, s.Add(2, 2));
        }

        [Fact]
        public void PassingTest4()
        {
            Assert.Equal(4, s.Add(2, 2));
        }

        [Fact]
        public void FailingTest1()
        {
            Assert.Equal(4, s.Add(2, 3));
        }
    }
}