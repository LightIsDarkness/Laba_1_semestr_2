using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_semestr_2
{
    public class Cart<T> where T: IShoes
    {
        public int Grace1 = 0;
        public int Expensive1 = 0;
        public int Convenience1 = 0;
        public int k = 0;
        public int l = 0;
        public int ö = 0;
        public int z = 0;
        public int maxxx;
        public int randomShoes;
        public List<IShoes> ShoesStuffs = new List<IShoes>();
        public List<IShoes> Shoes = new List<IShoes>();
        public List<IShoes> AShoes = new List<IShoes>();
        public Random randonGen = new Random();

        public void Add(T item)
        {
            Shoes.Add(item);
        }
        public void foodsN()
        {
            var n = new U_Tyagi();
            for (int i = 0; i < n.Things.Count; i++)
            {
                if (n.Things[i] is IShoes)
                {
                    Add((T)n.Things[i]);
                }
            }
        }
        public void Halyava(List<IShoes> list)
        {
            AShoes.Clear();
            for (int i = 0; i < ShoesStuffs.Count; i++)
            {
                if (ShoesStuffs[i].Expensive)
                {
                    Expensive1++;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is IGucci)
                {
                    AShoes.Add(list[i]);
                }
            }
            randomShoes = randonGen.Next(0, AShoes.Count);
            if (Expensive1 >= 5)
            {
                Console.WriteLine($"Вы получаете бесплатную пару обуви от Gucci - {AShoes[randomShoes].Name} по акции 5+1! Нажмите любую клавишу чтобы продолжить");
                ShoesStuffs.Add(AShoes[randomShoes]);
                Console.ReadKey();
            }
            Expensive1 = 0;
        }
        public void CartAnaliz(List<IShoes> list)
        {
            AShoes = new List<IShoes>();
            for (int i = 0; i < ShoesStuffs.Count; i++)
            {
                if (ShoesStuffs[i].Grace)
                {
                    Grace1++;
                }
                if (ShoesStuffs[i].Expensive)
                {
                    Expensive1++;
                }
                if (ShoesStuffs[i].Convenience)
                {
                    Convenience1++;
                }
            }
            int max = new int[] { Grace1, Expensive1, Convenience1 }.Max();
            if (Grace1 == max)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Grace == true && Grace1 == max)
                    {
                        AShoes.Add(list[i]);
                    }
                }
                randomShoes = randonGen.Next(0, AShoes.Count);
                Console.WriteLine($"Желаете ли дополнительно приобрести {AShoes[randomShoes].Name} co скидкой 20%?");
            }
            if (Expensive1 == max)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Expensive == true && Expensive1 == max)
                    {
                        AShoes.Add(list[i]);
                    }
                }
                randomShoes = randonGen.Next(0, AShoes.Count);
                Console.WriteLine($"Желаете ли дополнительно приобрести {AShoes[randomShoes].Name} co скидкой 20%?");
            }
            if (Convenience1 == max)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Convenience == true && Convenience1 == max)
                    {
                        AShoes.Add(list[i]);
                    }
                }
               randomShoes = randonGen.Next(0, AShoes.Count);
               Console.WriteLine($"Желаете ли дополнительно приобрести {AShoes[randomShoes].Name} co скидкой 20%?");
            }

            Grace1 = 0;
            Expensive1 = 0;
            Convenience1 = 0;
        }
        public void CartBalansing(List<IShoes> list)
        {
            for (int i = 0; i < ShoesStuffs.Count; i++)
            {
                if (ShoesStuffs[i].Grace)
                {
                    Grace1++;
                }
                if (ShoesStuffs[i].Expensive)
                {
                    Expensive1++;
                }
                if (ShoesStuffs[i].Convenience)
                {
                    Convenience1++;
                }
            }
            if (Grace1 == 0 && Expensive1 == 0 && Convenience1 == 0)
            {
                Console.WriteLine("Нельзя сбалансировать пустую корзину");
            }
            else if (Grace1 == Expensive1 && Expensive1 == Convenience1)
            {
                Console.WriteLine("Корзина балансна");
            }
            else
            {
                int max = new int[] { Grace1, Expensive1, Convenience1 }.Max();
                z =ShoesStuffs.Count;
                if (Grace1 < max)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].Grace == true && Grace1 < max)
                        {
                            ShoesStuffs.Add(list[i]);
                            Grace1++;
                        }
                    }
                }
                if (Expensive1 < max)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].Expensive == true && Expensive1 < max)
                        {
                            ShoesStuffs.Add(list[i]);
                            Expensive1++;
                        }
                    }
                }
                if (Convenience1 < max)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].Convenience == true && Convenience1 < max)
                        {
                            ShoesStuffs.Add(list[i]);
                            Convenience1++;
                        }
                    }
                }


                if (ShoesStuffs.Count == z)
                {
                    Console.WriteLine("Не удалось сбалансировать корзину, необходимые продукты отсутствуют в наличии");
                }
                else 
                {
                    Console.WriteLine("Корзина была сбалансирована, текущий состав:");
                    for (int i = 0;i < ShoesStuffs.Count; i++) 
                    {
                        Console.WriteLine(ShoesStuffs[i].Name + "\n");
                    }
                }
            }
            Grace1 = 0;
            Expensive1 = 0;
            Convenience1 = 0;
        }
    }
}
