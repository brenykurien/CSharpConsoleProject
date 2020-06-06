using Xunit;

namespace GradeBook.Tests
{
    public class FunctionParameterTest
    {
        [Fact]
        public void CSharpUsesPassByValue()
        {
            int x = 3;
            SetValue(x);
            Assert.Equal(3, x);
        }

        private void SetValue(int x)
        {
            x = 31;
        }

        [Fact]
        public void CSharpByRef()
        {
            int x = 3;
            SetByRef(ref x);
            Assert.Equal(31, x);
        }

        private void SetByRef(ref int x)
        {
            x = 31;
        }
    }
}
