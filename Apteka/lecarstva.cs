using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Apteka
{
   public class lecarstva
    {
        public lecarstva(int parametr, string name, string proizvoditel, double price, int colichestvo, bool activity)
        {
            Parametr = parametr;
            Name = name;
            Proizvoditel = proizvoditel;
            Price = price;
            Colichestvo = colichestvo;
            Activity = activity;
        }
        public lecarstva()
        {

        }
        public int Parametr { get; set; }
        public string Name { get; set; }
        public string Opisanie { get; set; }
        public string Proizvoditel { get; set; }
        public double Price { get; set; }
        public int Colichestvo { get; set; }
        public bool Activity { get; set; }

        List<lecarstva> lec = new List<lecarstva>();
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
        public List<lecarstva> LecRet(string name)
        {
            lec.Add(new lecarstva(1, "Нурофен", "Рекитт", 370, 50, true));
            lec.Add(new lecarstva(2, "Пенталгин", "Фармстандарт", 1523, 27, true));
            lec.Add(new lecarstva(3, "Лазолван", ", Дельфарм", 760, 40, false));
            lec.Add(new lecarstva(4, "Корвалол Реневал", "Обновление", 540, 30, true));
            lec.Add(new lecarstva(5, "Амбробене сироп", "Меркле", 814, 10, false));

            return lec.Where(x => x.Name == name).ToList();
        }
        public List<lecarstva> Proiz(string proizvoditel)
        {
            lec.Add(new lecarstva(1, "Нурофен", "Рекитт", 370, 50, true));
            lec.Add(new lecarstva(2, "Пенталгин", "Фармстандарт", 1523, 27, true));
            lec.Add(new lecarstva(3, "Лазолван", ", Дельфарм", 760, 40, false));
            lec.Add(new lecarstva(4, "Корвалол Реневал", "Обновление", 540, 30, true));
            lec.Add(new lecarstva(5, "Амбробене сироп", "Меркле", 814, 10, false));

            return lec.Where(x => x.Proizvoditel == proizvoditel).ToList();
        }
        public List<lecarstva> Activiry(bool activity)
        {
            lec.Add(new lecarstva(1, "Нурофен", "Рекитт", 370, 50, true));
            lec.Add(new lecarstva(2, "Пенталгин", "Фармстандарт", 1523, 27, true));
            lec.Add(new lecarstva(3, "Лазолван", ", Дельфарм", 760, 40, false));
            lec.Add(new lecarstva(4, "Корвалол Реневал", "Обновление", 540, 30, true));
            lec.Add(new lecarstva(5, "Амбробене сироп", "Меркле", 814, 10, false));

            return lec.Where(x => x.Activity == activity).ToList();
        }
        public List<lecarstva> Prices(int price)
        {
            lec.Add(new lecarstva(1, "Нурофен", "Рекитт", 370, 50, true));
            lec.Add(new lecarstva(2, "Пенталгин", "Фармстандарт", 1523, 27, true));
            lec.Add(new lecarstva(3, "Лазолван", ", Дельфарм", 760, 40, false));
            lec.Add(new lecarstva(4, "Корвалол Реневал", "Обновление", 540, 30, true));
            lec.Add(new lecarstva(5, "Амбробене сироп", "Меркле", 814, 10, false));

            return lec.Where(x => x.Price == price).ToList();
        }
        public List<lecarstva> PricesPlus()
        {
            lec.Add(new lecarstva(1, "Нурофен", "Рекитт", 370, 50, true));
            lec.Add(new lecarstva(4, "Корвалол Реневал", "Обновление", 540, 30, true));
            lec.Add(new lecarstva(3, "Лазолван", ", Дельфарм", 760, 40, false));
            lec.Add(new lecarstva(5, "Амбробене сироп", "Меркле", 814, 10, false));
            lec.Add(new lecarstva(2, "Пенталгин", "Фармстандарт", 1523, 27, true));

            return lec.ToList();
        }
        public List<lecarstva> PricesMinus()
        {
            lec.Add(new lecarstva(2, "Пенталгин", "Фармстандарт", 1523, 27, true));
            lec.Add(new lecarstva(5, "Амбробене сироп", "Меркле", 814, 10, false));
            lec.Add(new lecarstva(3, "Лазолван", ", Дельфарм", 760, 40, false));
            lec.Add(new lecarstva(4, "Корвалол Реневал", "Обновление", 540, 30, true));
            lec.Add(new lecarstva(1, "Нурофен", "Рекитт", 370, 50, true));

            return lec.ToList();
        }

    }
}
