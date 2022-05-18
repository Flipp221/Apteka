using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Apteka
{
   public class Farmacevt
    {
        public Farmacevt(int parametr, string name, string surname, string family, int age, int staj)
        {
            Parametr = parametr;
            Name = name;
            Surname = surname;
            Family = family;
            Age = age;
            Staj = staj;

        }
        public Farmacevt()
        {

        }
        public int Parametr { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }
        public int Staj { get; set; }
       
        List<Farmacevt> farmacevts = new List<Farmacevt>();
    

        public override string ToString()
        {
            return "Параметр товара" + " " + Parametr + " " + "Имя:" + Name + " " + "Фамилия:" + Surname + " " + "Отчество:" + Family + " " + "Год рождения" + Age + " " + "Стаж работы" + Staj + " ";
        }
        public override bool Equals(object Tovar) /*Осуществление на то что значения не повторялись и пуст ли список?*/
        {
            if (Tovar == null) return false;
            Farmacevt objAsPart = Tovar as Farmacevt;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return Parametr;
        }
        public bool Equals(Farmacevt other)
        {
            if (other == null) return false;
            return (this.Parametr.Equals(other.Parametr));
        }
        public string Names
        {
            get { return Name; }
        }
        public List<Farmacevt> AgePrint(int age)
        {
            farmacevts.Add(new Farmacevt(1, "Иван", "Иванов", "Иванович", 1975, 20));
            farmacevts.Add(new Farmacevt(2, "Александр", "Семёнов", "Борисович", 1968, 15));
            farmacevts.Add(new Farmacevt(3, "Данил", "Надеждин", "Денисович", 1984, 10));
            farmacevts.Add(new Farmacevt(4, "Булат", "Смирнов", "Дмитриевич", 1976, 24));
            farmacevts.Add(new Farmacevt(5, "Юрий", "Моисеев", "Александрович", 1992, 6));

            return farmacevts.Where(x => x.Age == age).ToList();
        }
    }
}
