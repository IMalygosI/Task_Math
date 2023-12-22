using System.Runtime.CompilerServices;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("У нас имеется функция: sin2x - lnx = 0");
        
        Console.WriteLine("Введите значение a (от):");
        double a = Convert.ToDouble(Console.ReadLine()); //Граница отрезка начало Y1 -10
        Console.WriteLine("Введите значение b (до):");
        double b = Convert.ToDouble(Console.ReadLine());//Граница отрезка конец Y1 10 

        Console.WriteLine("Введите значение h (шаг):");
        double h = Convert.ToDouble(Console.ReadLine());// Шаг Ф

        Console.WriteLine("Введите значение Elipson(эпсилон):");
        Console.WriteLine("Число для Elipson(эпсилон):");
        double ChoiceElipson = Convert.ToDouble(Console.ReadLine());        
        Console.WriteLine("Степень для Elipson(эпсилон):");
        double DegreeElipson = Convert.ToDouble(Console.ReadLine());
        double Elipson = Math.Pow(ChoiceElipson, DegreeElipson);

        Console.WriteLine($"Вы ввели: \nОтрезок от {a} до {b} \nШаг {h} \nЭпсилон {Elipson}.");
        double X1 = a;
        double X2 = X1 + h;
        double Y1 = Math.Sin(2 * X1) - Math.Log10(X1);

        Console.WriteLine($"Вы получили: " +
                          $"\nЗначение х1: {X1}" +
                          $"\nЗначение х2: {X2}" +
                          $"\nЗначение у1: {Y1}");
        if (X2 < b)
        {
            double Y2 = Math.Sin(2 * X2) - Math.Log10(X2);
            Console.WriteLine($"Вы получили значение y2: {Y2}");
            double yy = Y1 * Y2;
            if (yy < 0)
            {
                X1 = X2;
                X2 = X1 + h;
                Y1 = Y2;
                Console.WriteLine($"Вы получили:" +
                                  $"\nЗначение х1: {X1}" +
                                  $"\nЗначение х2: {X2}."+
                                  $"\nЗначение у1: {Y1}");
            }
            else
            {
                X1 = X2;
                X2 = X1 + h;
                Y1 = Y2;
            }
        }
        else
        {
            Console.Clear();
        }
    }
}