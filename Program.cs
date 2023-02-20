
internal class Program
{
    private static void Main(string[] args)
    {
        string[] renkler = new string[5];
        string[] hayvanlar = { "inek", "kedi", "köpek", "balık" };

        int[] sayikumesi;
        sayikumesi = new int[6];
        sayikumesi[2] = 4;

        //klavyeden girilen sayı kadar elemanlı dizinin ortalaması

        Console.Write("girilecek sayı adedini yazınız ");
        int adet = int.Parse(Console.ReadLine());
        int[] sayidizisi = new int[adet];  

        
        for (int i = 0; i < adet; i++)
        {
            Console.Write("lütfen " + (i + 1) + ". sayıyı giriniz ");
            sayidizisi[i] = int.Parse(Console.ReadLine());

        }

        int toplam = 0;

        foreach (var sayi in sayidizisi)
            toplam += sayi;

        Console.WriteLine("ortalama=" + toplam / adet);
    }
}