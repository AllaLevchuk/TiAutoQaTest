using System;

namespace triangleCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату по оси х для точки А: ");
            double xA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату по оси y для точки А: ");
            double yA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату по оси х для точки B: ");
            double xB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату по оси y для точки B: ");
            double yB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату по оси х для точки C: ");
            double xC = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату по оси y для точки C: ");
            double yC = Convert.ToDouble(Console.ReadLine());

            if (((xA == xB) && (xA == xC)) || ((yA == yB) && (yA == yC)))
            {
                Console.WriteLine("Все точки находятся на одной прямой, фигура не может быть треугольником");
            }
            else if ((xA == xB && yA == yB) || (xA == xC && yA == yC) || (xB == xC && yB == yC))
            {
                Console.WriteLine("Две точки имеют одинаковые координаты, фигура не может быть треугольником");
            }
            else
            {
                double abLength = GetLength(xB, xA, yB, yA);
                Console.WriteLine($"Длина стороны AB: {abLength}");
                double bcLength = GetLength(xC, xB, yC, yB);
                Console.WriteLine($"Длина стороны BC: {bcLength}");
                double caLength = GetLength(xA, xC, yA, yC);
                Console.WriteLine($"Длина стороны CA: {caLength}");
                if ((abLength == bcLength) || (bcLength == caLength) || (abLength == caLength))
                {
                    Console.WriteLine("Треугольник равнобедренный");
                }
                else
                {
                    Console.WriteLine("Треугольник не равнобедренный");
                }
                if ((abLength == bcLength) && (bcLength == caLength))
                {

                    Console.WriteLine("Треугольник равносторонний");
                }
                else
                {
                    Console.WriteLine("Треугольник не равносторонний");
                }
                double ABpow = Math.Pow(abLength, 2);
                double BCpow = Math.Pow(bcLength, 2);
                double CApow = Math.Pow(caLength, 2);
                double ABhypotenuse = Math.Abs(ABpow - (BCpow + CApow));
                double BChypotenuse = Math.Abs(BCpow - (ABpow + CApow));
                double CAhypotenuse = Math.Abs(CApow - (ABpow + BCpow));
                double delta = 0.01;
                if (ABhypotenuse <= delta)
                {
                    Console.WriteLine("Треугольник прямоугольный с гипотенузой АВ");
                }
                else if (BChypotenuse <= delta)
                {
                    Console.WriteLine("Треугольник прямоугольный с гипотенузой BC");
                }
                else if (CAhypotenuse <= delta)
                {
                    Console.WriteLine("Треугольник прямоугольный с гипотенузой CA");

                }
                else
                {
                    Console.WriteLine("Треугольник не прямоугольный");
                }
                double perimeter = abLength + bcLength + caLength;
                Console.WriteLine($"Периметр треугольника АВС: {perimeter}");
                Console.WriteLine("Bсе чётные числа от 0 до величины периметра треугольника включительно:");
                for (int i = 0; i <= perimeter; i = i + 2)
                { Console.WriteLine(i); }
            }
        }
        private static double GetLength(double point1, double point2, double point3, double point4)
        {
            return Math.Sqrt(Math.Pow((point1 - point2), 2) + Math.Pow((point3 - point4), 2));
        }
    }
}