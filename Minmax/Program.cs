public class Program    //nhap 2 so tu ban phim sau do tinh gia tri lon nhat
{
public static void Main(string[] args)
{
        Console.WriteLine("Nhap so thu nhat");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so thu hai");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so thu ba");
        int c = Convert.ToInt32(Console.ReadLine());

        int max = Math.Max(a, b);
        int maxabc = Math.Max(c, max);
        Console.WriteLine($"Gia tri lon nhat cua 2 so la{maxabc}");
}
}
