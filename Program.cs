namespace Zadaniee2_Programowanie2023
{
    internal class Program
    {
        public static void Main()
        {
            Obliczenia kartka= Obliczenia.ArkuszPapieru("A3");
            Console.WriteLine($"Bok A (wysokość): {kartka.BokA} mm");
            Console.WriteLine($"Bok B (szerokość): {kartka.BokB} mm");
            Console.WriteLine($"Wymiary: {kartka.BokB}x{kartka.BokA} mm");

            Console.ReadLine();
        }
    }
}