using System;
public class Mainclass
{
    public static void Main()
    {
        int num, res1, res2, res3;
        Console.WriteLine("Введите число:");
        num = int.Parse(Console.ReadLine());
        if (num >= 1 && num <= 150)
        {
            var numTest = num % 3;
            if (numTest == 0)
            {
                res1 = (num / 3) % 10;
                Console.WriteLine($"1) {res1}");
            }
            else if (numTest == 1)
            {
                res2 = 1;
                Console.WriteLine($"2) {res2}");
            }
            else
            {
                if (num >= 2 && num <= 26)
                {
                    res3 = 0;
                    Console.WriteLine($"3) {res3}");
                }
                else if (num >= 29 && num <= 56)
                {
                    res3 = 1;
                    Console.WriteLine($"3) {res3}");
                }
                else if (num >= 59 && num <= 86)
                {
                    res3 = 2;
                    Console.WriteLine($"3) {res3}");
                }
                else if (num >= 89 && num <= 116)
                {
                    res3 = 3;
                    Console.WriteLine($"3) {res3}");
                }
                else if (num >= 119 && num <= 146)
                {
                    res3 = 4;
                    Console.WriteLine($"3) {res3}");
                }
                else if (num == 149)
                {
                    res3 = 5;
                    Console.WriteLine($"3) {res3}");
                }
            }
        }
    }
}
