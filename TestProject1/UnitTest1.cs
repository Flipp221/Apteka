using Apteka;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string a = "Иван";
            string b = "Иванов";
            string c = "Сергеевич";
            int d = 23;
            int f = 5;
            Assert.Pass(a,b,c,d,f);
        }
    }
}