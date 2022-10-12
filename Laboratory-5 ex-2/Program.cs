using System;

namespace Laborarory
{
    public static class Programm
    {
        static int SumTheNumbers(string str, int sum)//Метод считает сумму цифр
        {
            for (int i = 0; i < str.Length; i++)
            {
                //Переводим символ в его номер и сравниваем его с номером из ASCII
                if (Convert.ToInt32(str[i]) > 47 && Convert.ToInt32(str[i]) < 58)
                {
                    sum += Convert.ToInt32(str[i]) - 48;
                    /*В ASCII кажый символ имеет номер, цифры идут в порядке возрастания
                     , то есть если 0==48 , то 9==57. 
                    Следует вычитая из номемера 48 мы получаем его числовое значение */
                }
                else break;
            }
            return sum;
        }
        static void Main()
        {
            int sum = 0;
            Console.WriteLine("Put the number :");
            char[] deleteLettters = { ' ', '-' };
            string str = Console.ReadLine();
            str = str.Trim(deleteLettters);
            sum = SumTheNumbers(str, sum);
            if (sum != 0) Console.WriteLine(sum);
            else Console.WriteLine("You wrote not a number");
        }
    }
}