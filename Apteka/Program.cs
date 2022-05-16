using System;
using System.Collections.Generic;
using System.Linq;

namespace Apteka
{
    class Program
    {
        static void Main(string[] args)
        {
            int cc = 0;
            List<lecarstva> lec = new List<lecarstva>();
            lec.Add(new lecarstva(1, "Нурофен", "Рекитт", 370, 50, true));
            lec.Add(new lecarstva(2, "Пенталгин", "Фармстандарт", 1523, 27, true));
            lec.Add(new lecarstva(3, "Лазолван", ", Дельфарм", 760,  40, false));
            lec.Add(new lecarstva(4, "Корвалол Реневал", "Обновление", 540, 30, true));
            lec.Add(new lecarstva(5, "Амбробене сироп", "Меркле", 814, 10, false));
            List<Farmacevt> farmacevts = new List<Farmacevt>();
            farmacevts.Add(new Farmacevt(1, "Иван", "Иванов", "Иванович", 1975, 20));
            farmacevts.Add(new Farmacevt(2, "Александр", "Семёнов", "Борисович", 1968, 15));
            farmacevts.Add(new Farmacevt(3, "Данил", "Надеждин", "Денисович", 1984, 10));
            farmacevts.Add(new Farmacevt(4, "Булат", "Смирнов", "Дмитриевич", 1976, 24));
            farmacevts.Add(new Farmacevt(5, "Юрий", "Моисеев", "Александрович", 1992, 6));
            foreach (var Komplectyushie in lec)
            {
                Console.WriteLine(Komplectyushie);
            }
            foreach (var Komplectyushie in farmacevts)
            {
                Console.WriteLine(Komplectyushie);
            }
            Console.WriteLine("Выберите команду:");
            Console.WriteLine("1- Получение списка по наванию лекарства");
            Console.WriteLine("2- Получение списка по наванию производителя");
            Console.WriteLine("3- Получение самого дорогого лекарства");
            Console.WriteLine("4- Сортировка товара по возрастанию цены ");
            Console.WriteLine("5- Сортировка товара по убыванию цены ");
            Console.WriteLine("6- Список лекарств которые есть в наличие");
            Console.WriteLine("7- Список формацевтов родившихся в определённом году");
            if ((!int.TryParse(Console.ReadLine(), out var cam)) || cam < 1 || cam > 7)
            {
                Console.WriteLine("Ошибка, недопустимы диапазон!");
            }
            else
            {
                if (cam == 1)
                {
                    One();
                }
                if (cam == 2)
                {
                    Two();
                }
                if (cam == 3)
                {
                    Three();
                }

                if (cam == 4)
                {
                    Four();
                }

                if (cam == 5)
                {
                    Five();
                }
                if (cam == 6)
                {
                    Six();
                }
                if (cam == 7)
                {
                    Seven();
                }
            }
        }
        public static void One()
        {
            int cc = 0;
            List<lecarstva> lec = new List<lecarstva>();
            lec.Add(new lecarstva(1, "Нурофен", "Рекитт", 370, 50, true));
            lec.Add(new lecarstva(2, "Пенталгин", "Фармстандарт", 1523, 27, true));
            lec.Add(new lecarstva(3, "Лазолван", ", Дельфарм", 760, 40, false));
            lec.Add(new lecarstva(4, "Корвалол Реневал", "Обновление", 540, 30, true));
            lec.Add(new lecarstva(5, "Амбробене сироп", "Меркле", 814, 10, false));
            {
                int b = 0;
                Console.WriteLine("Введите название лекарства:");
                string s = Console.ReadLine();
                var sorted1 = from p in lec
                              orderby p.Name
                              select p;

                foreach (var p in sorted1)
                {

                    if (s == p.Name)
                    {
                        cc = p.Colichestvo;
                        Console.WriteLine($"Параметр: {p.Parametr}, Наименование: {p.Name}, Производитель: {p.Proizvoditel}, Цена: {p.Price}руб., Количество:{p.Colichestvo}, Активный:{p.Activity}");
                        b++;
                    }
                }
                if (b == 0)
                {
                    Console.WriteLine("Такого товара нет!");
                }
            }
        }
        public static void Two()
        {
            int cc = 0;
            List<lecarstva> lec = new List<lecarstva>();
            lec.Add(new lecarstva(1, "Нурофен", "Рекитт", 370, 50, true));
            lec.Add(new lecarstva(2, "Пенталгин", "Фармстандарт", 1523, 27, true));
            lec.Add(new lecarstva(3, "Лазолван", ", Дельфарм", 760, 40, false));
            lec.Add(new lecarstva(4, "Корвалол Реневал", "Обновление", 540, 30, true));
            lec.Add(new lecarstva(5, "Амбробене сироп", "Меркле", 814, 10, false));
            int b = 0;
            Console.WriteLine("Введите название производителя:");
            string s = Console.ReadLine();
            var sorted2 = from p in lec
                          orderby p.Proizvoditel
                          select p;
            foreach (var p in sorted2)
            {
                if (s == p.Proizvoditel)
                {
                    Console.WriteLine($"Производитель: {p.Proizvoditel}");
                    b++;
                }
            }
            if (b == 0)
            {
                Console.WriteLine("Такого производителя нет!");
            }
        }
        public static void Three()
        {
            int cc = 0;
            List<lecarstva> lec = new List<lecarstva>();
            lec.Add(new lecarstva(1, "Нурофен", "Рекитт", 370, 50, true));
            lec.Add(new lecarstva(2, "Пенталгин", "Фармстандарт", 1523, 27, true));
            lec.Add(new lecarstva(3, "Лазолван", ", Дельфарм", 760, 40, false));
            lec.Add(new lecarstva(4, "Корвалол Реневал", "Обновление", 540, 30, true));
            lec.Add(new lecarstva(5, "Амбробене сироп", "Меркле", 814, 10, false));
            var sorted2 = from p in lec
                          orderby p.Price
                          where p.Price > 1000
                          select p;
            foreach (var p in sorted2)
                Console.WriteLine(p);
        }
        public static void Four()
        {
            int cc = 0;
            List<lecarstva> lec = new List<lecarstva>();
            lec.Add(new lecarstva(1, "Нурофен", "Рекитт", 370, 50, true));
            lec.Add(new lecarstva(2, "Пенталгин", "Фармстандарт", 1523, 27, true));
            lec.Add(new lecarstva(3, "Лазолван", ", Дельфарм", 760, 40, false));
            lec.Add(new lecarstva(4, "Корвалол Реневал", "Обновление", 540, 30, true));
            lec.Add(new lecarstva(5, "Амбробене сироп", "Меркле", 814, 10, false));
            var sorted2 = from p in lec
                          orderby p.Price, p.Proizvoditel
                          select p;
            foreach (var p in sorted2)
                Console.WriteLine(p);
        }
        public static void Five()
        {
            int cc = 0;
            List<lecarstva> lec = new List<lecarstva>();
            lec.Add(new lecarstva(1, "Нурофен", "Рекитт", 370, 50, true));
            lec.Add(new lecarstva(2, "Пенталгин", "Фармстандарт", 1523, 27, true));
            lec.Add(new lecarstva(3, "Лазолван", ", Дельфарм", 760, 40, false));
            lec.Add(new lecarstva(4, "Корвалол Реневал", "Обновление", 540, 30, true));
            lec.Add(new lecarstva(5, "Амбробене сироп", "Меркле", 814, 10, false));
            var sorted2 = from p in lec
                          orderby p.Price descending, p.Proizvoditel
                          select p;
            foreach (var p in sorted2)
                Console.WriteLine(p);
        }
        public static void Six()
        {
            int cc = 0;
            List<lecarstva> lec = new List<lecarstva>();
            lec.Add(new lecarstva(1, "Нурофен", "Рекитт", 370, 50, true));
            lec.Add(new lecarstva(2, "Пенталгин", "Фармстандарт", 1523, 27, true));
            lec.Add(new lecarstva(3, "Лазолван", ", Дельфарм", 760, 40, false));
            lec.Add(new lecarstva(4, "Корвалол Реневал", "Обновление", 540, 30, true));
            lec.Add(new lecarstva(5, "Амбробене сироп", "Меркле", 814, 10, false));
            var sorted2 = from p in lec
                          orderby p.Activity
                          select p;
            foreach (var p in sorted2)
                if (p.Activity)
                    Console.WriteLine(p.Name + " " + p.Activity);
        }
        public static void Seven()
        {
            int cc = 0;
            List<Farmacevt> farmacevts = new List<Farmacevt>();
            farmacevts.Add(new Farmacevt(1, "Иван", "Иванов", "Иванович", 1975, 20));
            farmacevts.Add(new Farmacevt(2, "Александр", "Семёнов", "Борисович", 1968, 15));
            farmacevts.Add(new Farmacevt(3, "Данил", "Надеждин", "Денисович", 1984, 10));
            farmacevts.Add(new Farmacevt(4, "Булат", "Смирнов", "Дмитриевич", 1976, 24));
            farmacevts.Add(new Farmacevt(5, "Юрий", "Моисеев", "Александрович", 1992, 6));
            int b = 0;
            Console.WriteLine("Введите год рождения фармацевта:");
            int s = Convert.ToInt32(Console.ReadLine());
            var sorted1 = from p in farmacevts
                          orderby p.Age
                          select p;

            foreach (var p in sorted1)
            {

                if (s == p.Age)
                {
                    Console.WriteLine($"Параметр: {p.Parametr}, Имя: {p.Name}, Фамилия: {p.Surname}, Отчество: {p.Family}, Год рождения:{p.Age} год, Стаж работы:{p.Staj}");
                    b++;
                }
            }
            if (b == 0)
            {
                Console.WriteLine("Такого формацевта нет!");
            }
        }
    }
}
