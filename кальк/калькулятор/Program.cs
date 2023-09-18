using System.Numerics;

namespace калькулятор
{
    internal class Program
    {
        public int Num1;
        public static int Num2;
        public static int Count;
        static void Main(string[] args)
        {

            Console.WriteLine("1. Сложить 2 числа\n" +
                "2. Вычесть первое из второго\n" +
                "3. Перемножить два числа\n" +
                "4. Разделить первое на второе\n" +
                "5. Возвести в степень N первое число\n" +
                "6. Найти квадратный корень из числа\n" +
                "7. Найти 1 процент от числа\n" +
                "8. Найти факториал из числа\n" +
                "9. Выйти из программы");

            Console.WriteLine("введите выбранное действие");

            SelectedCase(Convert.ToInt32(Console.ReadLine()));
            
        }

        public static void SelectedCase(int id)
        {
            switch(id)
            {
                case 1:

                    Console.WriteLine("введите первое число для сложения:");

                    int Num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("введите второе число для сложения:");
                    Num2 = Convert.ToInt32(Console.ReadLine());

                    Count = Num1 + Num2;
                    Console.WriteLine("сумма данных чисел:");
                    Console.WriteLine(Count);

                    Console.WriteLine("введите выбранное действие");

                    SelectedCase(Convert.ToInt32(Console.ReadLine()));
                    break;

                case 2:

                    Console.WriteLine("введите первое число для вычитания:");

                    Num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("введите второе число для вычитания:");
                    Num2 = Convert.ToInt32(Console.ReadLine());

                    Count = Num1 - Num2;
                    Console.WriteLine("Ответ:");
                    Console.WriteLine(Count);

                    Console.WriteLine("введите выбранное действие");

                    SelectedCase(Convert.ToInt32(Console.ReadLine()));
                    break;

                case 3:
        
                    Console.WriteLine("введите первое число для умножения:");

                    Num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("введите второе число для умножения:");
                    Num2 = Convert.ToInt32(Console.ReadLine());

                    Count = Num1 * Num2;
                    Console.WriteLine("Ответ:");
                    Console.WriteLine(Count);

                    Console.WriteLine("введите выбранное действие");

                    SelectedCase(Convert.ToInt32(Console.ReadLine()));
                    break;

                 case 4:

                    Console.WriteLine("введите первое число для деления:");

                    Num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("введите второе число для деления:");
                    Num2 = Convert.ToInt32(Console.ReadLine());

                    Count = Num1 / Num2;
                    Console.WriteLine("Ответ:");
                    Console.WriteLine(Count);

                    Console.WriteLine("введите выбранное действие");

                    SelectedCase(Convert.ToInt32(Console.ReadLine()));
                    break;

                case 5:
                    double a, b, c;
                    Console.WriteLine("введите первое число для возведения в степень:");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("введите второе число для степени:");
                    b = Convert.ToInt32(Console.ReadLine());

                    c = Math.Pow(a, b);

                    Console.WriteLine("Ответ:");
                    Console.WriteLine(c);

                    Console.WriteLine("введите выбранное действие");

                    SelectedCase(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 6:

                    double aa, cc;
                    Console.WriteLine("введите первое число для нахождения корня:");
                    aa = Convert.ToInt32(Console.ReadLine());


                    cc = Math.Sqrt(aa);

                    Console.WriteLine("Ответа:");
                    Console.WriteLine(Count);

                    Console.WriteLine("введите выбранное действие");

                    SelectedCase(Convert.ToInt32(Console.ReadLine()));
                    break;

                case 7:

                    Console.WriteLine("введите первое число для нахождения процента :");
                    Num1 = Convert.ToInt32(Console.ReadLine());

                    Count = Num1 / 100;

                    Console.WriteLine("Ответ:");
                    Console.WriteLine(Count);

                    Console.WriteLine("Введите выбранное действие");

                    SelectedCase(Convert.ToInt32(Console.ReadLine()));
                    break;

                case 8:                  

                    Console.WriteLine("введите первое число для нахождения факториала:");
                    Num1 = Convert.ToInt32(Console.ReadLine());

                    Factarial(Num1);

                    Console.WriteLine("введите выбранное действие");

                    SelectedCase(Convert.ToInt32(Console.ReadLine()));
                    break;

                case 9:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("этой операции нет!");
                    break;
            }
        }

        static BigInteger Factarial(int n)
        {
            var Fact = new BigInteger(n);
            for (int i = 1; i <= n; i++)
            {
                Fact *= i;
            }
            Console.WriteLine("ответ фактариал " + Fact);
            return Fact;
        }
    }
}