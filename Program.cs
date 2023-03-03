using System;
using System.IO;
using System.Text;
namespace FiILE02._03._2023LB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            //////////////////// 1
            StreamWriter log_out = new StreamWriter("Random.txt",false, Encoding.UTF8);
            TextWriter tmp = Console.Out;
            Console.SetOut(log_out);
            Console.WriteLine("Это рандомные числа :");
            int[] Mass = new int[30];
            Random random = new Random();
            for (int i = 0; i<Mass.Length; i++)
            {
                Mass[i] = random.Next(1, 15);
                Console.Write("{0} ",Mass[i]);
            }
            Console.WriteLine();
            log_out.Close();
            Console.SetOut(tmp);
            for (int i = 0; i < Mass.Length; i++)
            {
                Mass[i] = random.Next(1, 15);
                Console.Write("{0}\t", Mass[i]);
            }
            Console.WriteLine("\n");


            //////////////////// 2
            StreamWriter writer = new StreamWriter("Замена",false,Encoding.UTF8);
            TextWriter text = Console.Out;
            Console.SetOut(writer);
            string S = "C# самый топовый язык программирования!!!";
            Console.WriteLine(S+"\n");
            Console.WriteLine("Введите слово которое вы хотите найти в файле:");
            string Text = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите словo на которое вы хотите заменить слово:");
            string Text_1 = Convert.ToString(Console.ReadLine());
            S = S.Replace(Text,Text_1);
            Console.WriteLine(S);
            Console.WriteLine();
            writer.Close();
            Console.SetOut(text);



            //////////////////// 5
            StreamWriter writer1 = new StreamWriter("1000 Чисел", false, Encoding.UTF8);
            TextWriter text1 = Console.Out;
            Console.SetOut(writer1);
            Console.WriteLine("Рандомные числа");
            int[] mass = new int[1000];
            Random random1 = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random1.Next(-230, 54321);
                Console.Write("{0}\t", mass[i]);
            }
            Console.WriteLine("\n");
            writer1.Close();
            Console.SetOut(text1);
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random1.Next(-10, 54321);
                Console.Write("{0}\t", mass[i]);
            }
            StreamWriter writer2 = new StreamWriter("Положителые числа!", false, Encoding.UTF8);
            TextWriter text2 = Console.Out;
            Console.SetOut(writer2);
            int Count = 0; 
            for (int i = 0; i<mass.Length; i++)
            {
                if (mass[i]>0)
                {
                    Count++;
                }
            }
            Console.WriteLine("Количество положительных чиcел ---> " + Count);
            writer2.Close();
            Console.SetOut(text2);
            StreamWriter writer3 = new StreamWriter("Отрицательные числа!",false,Encoding.UTF8);
            TextWriter writer0 = Console.Out;
            Console.SetOut(writer0);
            int Count1 = 0;
            for (int i = 0; i<mass.Length; i++)
            {
                if (mass[i]<0)
                {
                    Count1++;
                }
            }
            Console.WriteLine("Количество отрицательных чиcел---> " + Count1);
            writer3.Close();
            Console.SetOut(writer0);
            StreamWriter writer4 = new StreamWriter("Количество двузначных чисел!!",false,Encoding.UTF8);
            TextWriter writer5 = Console.Out;
            Console.SetOut(writer4);
            int Count2 = 0;
            for (int i = 0; i<mass.Length;i++)
            {
                if (mass[i]>=10&&mass[i]<100)
                {
                    Count2++;
                }
            }
            Console.WriteLine("Количество двузначных чиcел---> " + Count2);
            writer4.Close();
            Console.SetOut(writer5);
            StreamWriter writer7 = new StreamWriter("Количество пятизначных чисел!!", false, Encoding.UTF8);
            TextWriter writer6 = Console.Out;
            Console.SetOut(writer7);
            int Count_3 = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] >= 100000 && mass[i] < 1000000)
                {
                    Count_3++;
                }
            }
            Console.WriteLine("Количество пятизначных чиcел---> " + Count_3);
            writer7.Close();
            Console.SetOut(writer6);
        }
    }
}
