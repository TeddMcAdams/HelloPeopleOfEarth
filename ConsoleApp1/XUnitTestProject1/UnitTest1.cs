using ConsoleApp1;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ReverseItExtensionMethodActuallyWorks()
        {
            // Arrange
            string test1 = "abc";
            string test2 = "abcd#!g";

            // Act
            string actual1 = test1.ReverseIt();
            string actual2 = test2.ReverseIt();

            // Assert
            Assert.Equal("cba", actual1);
            Assert.Equal("g!#dcba", actual2);
        }

        [Fact]
        public void ReverseItSpecialExtensionMethodAlsoWorksHopefully()
        {
            // Arrange
            string test1 = "abc";
            string test2 = "abcd#!g";
            string test3 = "!abc123@#$zzz$";
            string test4 = "abc!@#4az@";
            string test5 = "$bcd@$%test";

            // Act
            string actual1 = test1.ReverseItSpecial();
            string actual2 = test2.ReverseItSpecial();
            string actual3 = test3.ReverseItSpecial();
            string actual4 = test4.ReverseItSpecial();
            string actual5 = test5.ReverseItSpecial();

            // Assert
            Assert.Equal("cba", actual1);
            Assert.Equal("gdcb#!a", actual2);
            Assert.Equal("!zzz321@#$cba$", actual3);
            Assert.Equal("za4!@#cba@", actual4);
            Assert.Equal("$tse@$%tdcb", actual5);
        }
    }
}
