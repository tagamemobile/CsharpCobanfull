public class Program         //nhap vao 2 canh cua hinh chu nhat sau do tinh dien tich va chu vi in ra man hinh
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hay nhap chieu dai hinh chu nhat");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Hay nhap chieu cao hinh chu nhat");
        double height = Convert.ToDouble(Console.ReadLine());
        //
        double area = width * height;
        double rect = (width + height) * 2;
        Console.WriteLine($"Dien tich hinh chu nhat la {area}");
        Console.WriteLine($"Chu vi hinh chu nhat la {rect}");

    }
}
