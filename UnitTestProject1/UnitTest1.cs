using Microsoft.VisualStudio.TestTools.UnitTesting;
using Apteka;
using System.Collections.Generic;
using System.Linq;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
         
            List< Farmacevt> farmacevt = new List<Farmacevt> ();
            farmacevt.Add(new Farmacevt(1, "����", "������", "��������", 1975, 5));
            farmacevt.Add(new Farmacevt(2, "���������", "������", "���������", 1968, 15));
            farmacevt.Add(new Farmacevt(3, "�����", "��������", "���������", 1984, 10));
            farmacevt.Add(new Farmacevt(4, "�����", "�������", "����������", 1976, 24));
            farmacevt.Add(new Farmacevt(5, "����", "�������", "�������������", 1992, 6));
            Farmacevt farmacevt1 = new Farmacevt();

            CollectionAssert.AreEqual(farmacevt.Where(x => x.Age == 1975).ToList(), farmacevt1.AgePrint(1975));

        }
        [TestMethod]
        public void Test2()
        {
            List<lecarstva> lec = new List<lecarstva>();
            lec.Add(new lecarstva(1, "�������", "������", 370, 50, true));
            lec.Add(new lecarstva(2, "���������", "������������", 1523, 27, true));
            lec.Add(new lecarstva(3, "��������", ", ��������", 760, 40, false));
            lec.Add(new lecarstva(4, "�������� �������", "����������", 540, 30, true));
            lec.Add(new lecarstva(5, "��������� �����", "������", 814, 10, false));
            lecarstva lec1 = new lecarstva();

            CollectionAssert.AreEqual(lec.Where(x => x.Name == "�������").ToList(), lec1.LecRet("�������"));

        }
        [TestMethod]
        public void Test3()
        {
            List<lecarstva> lec = new List<lecarstva>();
            lec.Add(new lecarstva(1, "�������", "������", 370, 50, true));
            lec.Add(new lecarstva(2, "���������", "������������", 1523, 27, true));
            lec.Add(new lecarstva(3, "��������", ", ��������", 760, 40, false));
            lec.Add(new lecarstva(4, "�������� �������", "����������", 540, 30, true));
            lec.Add(new lecarstva(5, "��������� �����", "������", 814, 10, false));
            lecarstva lec1 = new lecarstva();

            CollectionAssert.AreEqual(lec.Where(x => x.Proizvoditel == "������").ToList(), lec1.Proiz("������"));
        }
        [TestMethod]
        public void Test4()
        {
            List<lecarstva> lec = new List<lecarstva>();
            lec.Add(new lecarstva(1, "�������", "������", 370, 50, true));
            lec.Add(new lecarstva(2, "���������", "������������", 1523, 27, true));
            lec.Add(new lecarstva(3, "��������", ", ��������", 760, 40, false));
            lec.Add(new lecarstva(4, "�������� �������", "����������", 540, 30, true));
            lec.Add(new lecarstva(5, "��������� �����", "������", 814, 10, false));
            lecarstva lec1 = new lecarstva();

            CollectionAssert.AreEqual(lec.Where(x => x.Price == 1523).ToList(), lec1.Prices(1523));
        }
    }
}
