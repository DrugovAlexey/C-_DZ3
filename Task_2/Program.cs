int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double Length (int x, int y, int z)
{
   double temp = (x*x) + (y*y) + (z*z);
   return Math.Sqrt(temp); 
}

int x1 = ReadInt("Введите координату X первой точки ");
int y1 = ReadInt("Введите координату Y первой точки ");
int z1 = ReadInt("Введите координату z первой точки ");
int x2 = ReadInt("Введите координату X второй точки ");
int y2 = ReadInt("Введите координату Y второй точки ");
int z2 = ReadInt("Введите координату z второй точки ");

double Diagonale = Length(x1-x2, y1-y2, z1-z2);
Console.WriteLine($"Расстояние между тремя точками равно {Diagonale}");
