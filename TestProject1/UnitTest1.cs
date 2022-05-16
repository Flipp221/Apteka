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
            int d = 23;
            int f = 5;
            Farmacevt farmacevt = new Farmacevt(1,"Иван", "Иванов", "Иванович",d,f);

            farmacevt.Equals(d);
            string s = farmacevt.Names;
            Assert.AreEqual(s,farmacevt.Names );
        }
    }
}