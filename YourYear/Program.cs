
public class Program      //hay nhap vao nam sinh cua ban va tinh tuoi cua ban in ra man hinh
{
public static void Main(string[] args)
{
        Console.WriteLine("Hay nhap vao nam sinh cua ban");
        int namsinh = Convert.ToInt32(Console.ReadLine());
        int namhientai = DateTime.Now.Year;
        int tuoi = namhientai - namsinh;
        Console.WriteLine("Tuoi cua ban la " + tuoi);
        // (a+b)*c;

} 
}
