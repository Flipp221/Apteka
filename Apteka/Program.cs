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
            lec.Add(new lecarstva(1, "Нурофен", "Рекитт", "177 руб.", 50, true));
            lec.Add(new lecarstva(2, "Пенталгин", "Фармстандарт", "119 Руб.", 27, true));
            lec.Add(new lecarstva(3, "Лазолван", ", Дельфарм", "228 Руб.",  40, false));
            lec.Add(new lecarstva(4, "Корвалол Реневал", "Обновление", "122 Руб.", 30, true));
            lec.Add(new lecarstva(5, "Амбробене сироп", "Меркле", "133 Руб.", 10, false));
            foreach (var Komplectyushie in lec)
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
                if (cam == 2)
                {
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
                if (cam == 3)
                {
                    foreach (var item in lec)
                    {
                        if (true)
                        {

                        }
                    }
                    var sorted2 = from p in lec
                                  orderby p.Price
                                  select p;
                    foreach (var p in sorted2)                      
                        Console.WriteLine(p);
                }

                if (cam == 4)
                {

                    var sorted2 = from p in lec
                                  orderby p.Price, p.Proizvoditel
                                  select p;
                    foreach (var p in sorted2)
                        Console.WriteLine(p);
                }

                if (cam == 5)
                {

                    var sorted2 = from p in lec
                                  orderby p.Price descending, p.Proizvoditel
                                  select p;
                    foreach (var p in sorted2)
                        Console.WriteLine(p);
                }
                if (cam == 6)
                {

                    var sorted2 = from p in lec
                                  orderby p.Activity
                                  select p;
                    foreach (var p in sorted2)
                        if(p.Activity)
                        Console.WriteLine(p.Name  + " "+ p.Activity);
                }
            }
        }
    }
}
