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
            lec.Add(new lecarstva(1, "Нурофен", "Рекитт", "177 руб.", 50, "Да"));
            lec.Add(new lecarstva(2, "Пенталгин", "Фармстандарт", "119 Руб.", 27, "Да"));
            lec.Add(new lecarstva(3, "Лазолван", ", Дельфарм", "228 Руб.",  40, "Да"));
            lec.Add(new lecarstva(4, "Корвалол Реневал", "Обновление", "122 Руб.", 30, "Да"));
            lec.Add(new lecarstva(5, "Амбробене сироп", "Меркле", "133 Руб.", 10, "Да"));
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
            Console.WriteLine("6- Список формацевтов родившихся в определённом году");
            if ((!int.TryParse(Console.ReadLine(), out var cam)) || cam < 1 || cam > 6)
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

                    var sorted2 = from p in lec
                                  orderby p.Price, p.Proizvoditel
                                  select p;
                    foreach (var p in sorted2)
                        Console.WriteLine(p);
                }

                if (cam == 4)
                {

                    var sorted2 = from p in lec
                                  orderby p.Price descending, p.Proizvoditel
                                  select p;
                    foreach (var p in sorted2)
                        Console.WriteLine(p);
                }

                Console.WriteLine("Введите название товара для покупки:");
                string ss = Console.ReadLine();
                var sorted3 = from r in lec
                              orderby r.Name
                              select r;

                foreach (var r in sorted3)
                {
                    if (ss == r.Name)
                    {
                        cc = r.Colichestvo;
                        Console.WriteLine($"Параметр: {r.Parametr}, Наименование: {r.Name}, Описание: {r.Opisanie}, Производитель: {r.Proizvoditel}, Цена: {r.Price}руб., Активный:{r.Activity}, Количество:{r.Colichestvo}");
                    }
                }
                Console.WriteLine("Введите количество товара:");
                if ((!int.TryParse(Console.ReadLine(), out var call)) || call < 1 || call > cc)
                {
                    Console.WriteLine("Ошибка!");
                }
                else
                {
                    Console.WriteLine("Выберите вид оплаты:");
                    Console.WriteLine("1- Банковскаякарта");
                    Console.WriteLine("2- Google pay");
                    Console.WriteLine("3- Apple pay");
                    Console.WriteLine("4- Наличные");
                    if ((!int.TryParse(Console.ReadLine(), out var plata)) || plata < 1 || plata > 4)
                    {
                        Console.WriteLine("Ошибка!");
                    }
                    else
                    {
                        Console.WriteLine("Введите ваше ФИО и номер телефона");
                        string fioPh = Console.ReadLine();
                        Console.WriteLine("Выберите вид доставки:");
                        Console.WriteLine("1- Самовывоз");
                        Console.WriteLine("2- Доставка");
                        Console.WriteLine("3- Срочная доставка");
                        if ((!int.TryParse(Console.ReadLine(), out var dostavka)) || dostavka < 1 || dostavka > 3)
                        {
                            Console.WriteLine("Ошибка!");
                        }
                        else
                        {
                            if (dostavka == 2 || dostavka == 3)
                            {
                                Console.WriteLine("Введите адрес(улица, дом квартира):");
                                string adres = Console.ReadLine();
                                Console.WriteLine("Заказ оформлен!");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка");
                            }
                        }
                    }
                }
            }
        }
    }
}
