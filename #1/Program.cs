// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2.    b1 k1 и b2 и k2 заданы

double readInt(string message){
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine()!);
    }

Console.WriteLine("Даны уравнения: y = k1 * x + b1, y = k2 * x + b2");
double k1 = readInt("Введите коэффициент к1:");
double b1 = readInt("Введите значение b1:");
double k2 = readInt("Введите коэффициент к2:");
double b2 = readInt("Введите значение b2:");

double x = Math.Round((b2-b1)/(k1-k2),2);
double y = Math.Round(k1*x+b1,2);

Console.WriteLine($"Координаты точки пересения прямых: {x}; {y}");