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

            farmacevt.AgePrint(d);
            CollectionAssert.AreEqual(farmacevt.Age, d);
        }
        [Test]
        public void Test2()
        {
            string s = "Нурофен";
            double a = 370;
            int b = 50;
            lecarstva lec = new lecarstva(1, "Нурофен", "Рекитт", a, b, true);

            lec.LecRet(s);
            Assert.AreEqual(lec.Name, s);
        }
        [Test]
        public void Test3()
        {
            string s = "Рекитт";
            double a = 370;
            int b = 50;
            lecarstva lec = new lecarstva(1, "Нурофен", "Рекитт", a, b, true);

            lec.Proiz(s);
            Assert.AreEqual(lec.Proizvoditel, s);
        }
        [Test]
        public void Test4()
        {
            bool s = true;
            double a = 370;
            int b = 50;
            lecarstva lec = new lecarstva(1, "Нурофен", "Рекитт", a, b, s);

            lec.Activiry(s);
            Assert.AreEqual(lec.Activity, s);
        }
    }
}