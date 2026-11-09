using LAB05;

try
{
    
    LAB05.Range range = new LAB05.Range(2, 5);
    range.PrintRange();

    
    Console.WriteLine($"2 внутри? {range.IsInside(2)}"); 
    Console.WriteLine($"4 внутри? {range.IsInside(4)}"); 
    Console.WriteLine($"5 внутри? {range.IsInside(5)}"); 
    Console.WriteLine($"1 внутри? {range.IsInside(1)}"); 

    Console.WriteLine("\nМеняем границы:");
    range.A = 3;
    range.B = 6;
    range.PrintRange();

    Console.WriteLine("\nПробуем сломать (А > В):");
    range.A = 10;
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}