using Laba_1_semestr_2;
using Laba8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laba8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cart = new Cart<IShoes>();
            List<IShoes> list = new List<IShoes>();
            bool Analiz = true;
            bool u = true;
            bool g = true;
            bool p = true;
            var n = new U_Tyagi();
            int x = 1;
            int y = 0;
            bool f = true;

            cart.foodsN();
            while (f) 
            {
                Console.Clear();
                Console.WriteLine("1)Каталог товаров \n2)Составить корзину \n0)Настройки");
                switch (Console.ReadLine()) 
                {
                    case "0":
                        Console.Clear();
                        Console.WriteLine("1)Настройки анализатора корзины \n2)Настройки балансировщика корзины");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("1)Включить анализатор \n2)Выключить анализатор \n0)В меню");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        Analiz = true;
                                        Console.WriteLine("Анализатор включен");
                                        Console.ReadKey();
                                        break;
                                    case "2":
                                        Analiz = false;
                                        Console.WriteLine("Анализатор выключен");
                                        Console.ReadKey();
                                        break;
                                    case "0":
                                        break;
                                    
                                }
                                break;
                            case "2":
                                Console.Clear();
                                Console.WriteLine("Настройки балансировщика корзины появятся позже. \nПоддержать команду разработки вы можете отправив СМС с кодом 100" +
                                    " на номер 88005553535 \n0)В меню");
                                while (p)
                                {
                                    if (Console.ReadLine() == "0")
                                    {
                                        p = false;
                                    }
                                }

                                p = true;
                                break;
                            case "0":
                                Console.Clear();

                                break;
                        }
                        break;
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Нажмите 0 чтобы вернуться в меню");
                        for (int i = 0; i<n.Things.Count; i++)
                        {
                            Console.WriteLine(n.Things[i].Name);
                        }
                        while (p)
                        {
                            if (Console.ReadLine() == "0")
                            {
                                p=false;
                            }
                        }

                        p = true;
                        break;
                    case "2":
                        Console.Clear();
                        while (g) 
                        {
                            Console.Clear();
                            Console.WriteLine("Выберите категорию товаров: \n  1)Dolce & Gabbana \n  2)Gucci \n  3)Prada \n  4)Все бренды \n" +
                            "Нажмите 0 чтобы вернуться в меню");
                            switch (Console.ReadLine())
                            {
                                
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Введите номер продукта чтобы добавить его в корзину, введите 999 чтобы сбалансировать корзину," +
                                        " введите 0 чтобы очистить корзину и вернуться к выбору раздела");
                                        Console.WriteLine("Введите 77 чтобы совершить покупку");
                                    for (int j = 0; j < cart.Shoes.Count; j++)
                                    {
                                        if (cart.Shoes[j] is IDG)
                                        {
                                            Console.WriteLine(x + ")  " + cart.Shoes[j].Name + "\n");
                                            list.Add(cart.Shoes[j]);
                                            x++;
                                        }
                                    }
                                    
                                    while (u)
                                    {
                                        y = Int32.Parse(Console.ReadLine());
                                        if (y != 0 && y != 77 && y != 999 && y <= list.Count)
                                        {
                                            cart.ShoesStuffs.Add(list[y - 1]);
                                            Console.WriteLine("Вы добавили в корзину " + list[y-1].Name);
                                        }
                                        else if (y == 999)
                                        {
                                            cart.CartBalansing(list);
                                        }
                                        else if (y==0)
                                        {
                                            u = false;
                                            list.Clear();
                                            cart.ShoesStuffs.Clear();
                                        }
                                            if (y == 77)
                                            {
                                               if (Analiz == true)
                                                {
                                                    cart.Halyava();
                                                    cart.CartAnaliz();
                                                    Console.WriteLine("Чек:");
                                                    for (int i = 0; i < cart.ShoesStuffs.Count; i++)
                                                    {
                                                        Console.WriteLine(cart.ShoesStuffs[i].Name + "\n");
                                                    }
                                                    Console.ReadKey();
                                                    u = false;
                                                }
                                               else
                                                {
                                                Console.Clear();
                                                cart.Halyava();
                                                Console.Clear();
                                                Console.WriteLine("Чек:");
                                                    for (int i = 0; i < cart.ShoesStuffs.Count; i++)
                                                    {
                                                        Console.WriteLine(cart.ShoesStuffs[i].Name + "\n");
                                                    }
                                                }
                                                
                                            }
                                        
                                    }

                                    x = 1;
                                    cart.ShoesStuffs = new List<IShoes>();
                                    list = new List<IShoes>();
                                    y = 1;
                                    u = true;
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Введите номер продукта чтобы добавить его в корзину, введите 999 чтобы сбалансировать корзину," +
                                        " введите 0 чтобы очистить корзину и вернуться к выбору раздела");
                                    if (Analiz == true)
                                    {
                                        Console.WriteLine("Введите 77 чтобы совершить покупку");
                                    }
                                    for (int j = 0; j < cart.Shoes.Count; j++)
                                    {
                                        if (cart.Shoes[j] is IGucci)
                                        {
                                            Console.WriteLine(x + ")  " + cart.Shoes[j].Name + "\n");
                                            list.Add(cart.Shoes[j]);
                                            x++;
                                        }
                                    }
                                    
                                    while (u)
                                    {
                                        y = Int32.Parse(Console.ReadLine());
                                        if (y != 0 && y != 77 && y != 999 && y <=  list.Count)
                                        {
                                            cart.ShoesStuffs.Add(list[y - 1]);
                                            Console.WriteLine("Вы добавили в корзину " + list[y - 1].Name);
                                        }
                                        else if (y == 999)
                                        {
                                            cart.CartBalansing(list);
                                        }
                                        else if (y == 0)
                                        {
                                            u = false;
                                            list.Clear();
                                            cart.ShoesStuffs.Clear();
                                        }
                                        if (y == 77)
                                        {
                                            if (Analiz == true)
                                            {
                                                cart.Halyava();
                                                cart.CartAnaliz();
                                                Console.WriteLine("Чек:");
                                                for (int i = 0; i < cart.ShoesStuffs.Count; i++)
                                                {
                                                    Console.WriteLine(cart.ShoesStuffs[i].Name + "\n");
                                                }
                                                Console.ReadKey();
                                                u = false;
                                            }
                                            else
                                            {
                                                cart.Halyava();
                                                Console.WriteLine("Чек:");
                                                for (int i = 0; i < cart.ShoesStuffs.Count; i++)
                                                {
                                                    Console.WriteLine(cart.ShoesStuffs[i].Name + "\n");
                                                }
                                            }

                                        }
                                    }

                                    x = 1;
                                    cart.ShoesStuffs = new List<IShoes>();
                                    list = new List<IShoes>();
                                    u = true;
                                    y = 1;
                                    break;
                                case "3":
                                    Console.Clear();
                                    Console.WriteLine("Введите номер продукта чтобы добавить его в корзину, введите 999 чтобы сбалансировать корзину," +
                                        " введите 0 чтобы очистить корзину и вернуться к выбору раздела");
                                    if (Analiz == true)
                                    {
                                        Console.WriteLine("Введите 77 чтобы совершить покупку");
                                    }
                                    for (int j = 0; j < cart.Shoes.Count; j++)
                                    {
                                        if (cart.Shoes[j] is IPrada)
                                        {
                                            Console.WriteLine(x + ")  " + cart.Shoes[j].Name + "\n");
                                            list.Add(cart.Shoes[j]);
                                            x++;
                                        }
                                    }
                                    
                                    while (u)
                                    {
                                        y = Int32.Parse(Console.ReadLine());
                                        if (y != 0 && y != 77 && y != 999 && y <= list.Count)
                                        {
                                            cart.ShoesStuffs.Add(list[y - 1]);
                                            Console.WriteLine("Вы добавили в корзину " + list[y - 1].Name);
                                        }
                                        else if (y == 999)
                                        {
                                            cart.CartBalansing(list);
                                        }
                                        else if (y == 0)
                                        {
                                            u = false;
                                            list.Clear();
                                            cart.ShoesStuffs.Clear();
                                        }
                                        if (y == 77)
                                        {
                                            if (Analiz == true)
                                            {
                                                cart.Halyava();
                                                cart.CartAnaliz();
                                                Console.WriteLine("Чек:");
                                                for (int i = 0; i < cart.ShoesStuffs.Count; i++)
                                                {
                                                    Console.WriteLine(cart.ShoesStuffs[i].Name + "\n");
                                                }
                                                Console.ReadKey();
                                                u = false;
                                            }
                                            else
                                            {
                                                cart.Halyava();
                                                Console.WriteLine("Чек:");
                                                for (int i = 0; i < cart.ShoesStuffs.Count; i++)
                                                {
                                                    Console.WriteLine(cart.ShoesStuffs[i].Name + "\n");
                                                }
                                            }

                                        }
                                    }

                                    x = 1;
                                    cart.ShoesStuffs = new List<IShoes>();
                                    list = new List<IShoes>();
                                    u = true;
                                    y = 1;
                                    break;
                                case "4":
                                    Console.Clear();
                                    Console.WriteLine("Введите номер продукта чтобы добавить его в корзину, введите 999 чтобы сбалансировать корзину, " +
                                        " введите 0 чтобы очистить корзину и вернуться к выбору раздела");
                                    if (Analiz == true)
                                    {
                                        Console.WriteLine("Введите 77 чтобы совершить покупку");
                                    }
                                    for (int j = 0; j < cart.Shoes.Count; j++)
                                    {
                                        if (cart.Shoes[j] is IShoes)
                                        {
                                            Console.WriteLine(x + ")  " + cart.Shoes[j].Name + "\n");
                                            list.Add(cart.Shoes[j]);
                                            x++;
                                        }
                                    }
                                    
                                    while (u)
                                    {
                                        y = Int32.Parse(Console.ReadLine());
                                        if (y != 0 && y!=77 && y != 999 && y<list.Count)
                                        {
                                            cart.ShoesStuffs.Add(list[y - 1]);
                                            Console.WriteLine("Вы добавили в корзину " + list[y - 1].Name);
                                        }
                                        else if (y == 999)
                                        {
                                            cart.CartBalansing(list);
                                        }
                                        else if (y == 0)
                                        {
                                            u = false;
                                            list.Clear();
                                            cart.ShoesStuffs.Clear();
                                        }
                                        if (y == 77)
                                        {
                                            if (Analiz == true)
                                            {
                                                cart.Halyava();
                                                cart.CartAnaliz();
                                                Console.WriteLine("Чек:");
                                                for (int i = 0; i < cart.ShoesStuffs.Count; i++)
                                                {
                                                    Console.WriteLine(cart.ShoesStuffs[i].Name + "\n");
                                                }
                                                Console.ReadKey();
                                                u = false;
                                            }
                                            else
                                            {
                                                cart.Halyava();
                                                Console.WriteLine("Чек:");
                                                for (int i = 0; i < cart.ShoesStuffs.Count; i++)
                                                {
                                                    Console.WriteLine(cart.ShoesStuffs[i].Name + "\n");
                                                }
                                            }

                                        }
                                    }

                                    x = 1;
                                    cart.ShoesStuffs = new List<IShoes>();
                                    list = new List<IShoes>();
                                    u = true;
                                    y = 1;
                                    break;
                                case "0":
                                    Console.Clear();
                                    g = false;
                                    break;

                            }
                        }
                        break;
                }
            }
        }
    }
}