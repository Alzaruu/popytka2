using System.ComponentModel.DataAnnotations.Schema;


namespace Две_Игры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool y = true;
            do
            {
                Console.WriteLine("Введите число программы, в которую хотите поиграть");
                Console.WriteLine("1. Игра Угадай число");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Выход");
                string num = Console.ReadLine();
                int b = Convert.ToInt32(num);

                if (b == 1)
                {
                    Ugadaika();
                }

                else if (b == 2)
                {
                    Tabl();
                }

                else if (b == 3)
                {
                    Console.WriteLine("Дотвидания");
                    y = false;
                }

            } while (y == true);
        }
        static void Ugadaika()
        {

            bool n = true;
            //угадай число
            Random chislo = new Random();
            int l = chislo.Next(0, 100);
            do
            {
                Console.WriteLine("Введите предполагаемое число");
                string k = Console.ReadLine();
                int a = Convert.ToInt32(k);

                if (a > l)
                {
                    Console.WriteLine("Меньше");
                }
                else if (a < l)
                {
                    Console.WriteLine("Больше");
                }
                else if (a == l)
                {
                    Console.WriteLine("Ура, победа");
                    n = false;
                }
            } while (n == true);




        }
        static void Tabl()
        {
            //Таблица умножения

            int[,] tabl = new int[10, 9];
            for (int i = 1; i < 10; i++)
            {
                for (int v = 1; v < 9; v++) //я пробовала сделать с табл ленгс, но не получилось, говорит, что выходит за рамки массива
                {
                    tabl[i,v] = i * v;
                    Console.WriteLine(tabl[i, v] + "\t");
                }
                Console.WriteLine();
               // здесь я не поняла, что я сделала не так и почему у меня выводится всё вертикально
            }

        }  
    }
}


