using System;
using System.Collections.Generic;
using System.Text;

namespace Apteka
{
   public class lecarstva
    {
        public lecarstva(int parametr, string name, string proizvoditel, string price, int colichestvo, bool activity)
        {
            Parametr = parametr;
            Name = name;
            Proizvoditel = proizvoditel;
            Price = price;
            Colichestvo = colichestvo;
            Activity = activity;
        }
        public int Parametr { get; set; }
        public string Name { get; set; }
        public string Opisanie { get; set; }
        public string Proizvoditel { get; set; }
        public string Price { get; set; }
        public int Colichestvo { get; set; }
        public bool Activity { get; set; }
        public override string ToString()
        {
            return "Параметр товара" + " " + Parametr + " " + "Наименование товара:" + Name + " "  + "Производитель:" + Proizvoditel + " " + "Цена:" + Price + " " + "Количество" + " " + Colichestvo + "Актуальный?" + Activity + " ";
        }
        public override bool Equals(object Tovar) /*Осуществление на то что значения не повторялись и пуст ли список?*/
        {
            if (Tovar == null) return false;
            lecarstva objAsPart = Tovar as lecarstva;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return Parametr;
        }
        public bool Equals(lecarstva other)
        {
            if (other == null) return false;
            return (this.Parametr.Equals(other.Parametr));
        }
    }
}
