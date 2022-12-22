namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Daxil edilmiş ədəd 40 - a bölünürsə 9 - a bölünməsini yoxla həmçinin 9 - bölünürsə 7 - yə bölünməsini yoxla

            

             while (true)
             { 
             Console.WriteLine("Bir eded daxil edin daxil edin:");
             int a = int.Parse(Console.ReadLine());
             if (a % 40 == 0)
             {
                 if (a % 9 == 0)
                 {
                     if (a % 7 == 0) Console.WriteLine("verilen eded 40-a, 9-a ve 7 ye bolunur");
                     else Console.WriteLine("verilmis eded 40-a ve 9-a bolunur, 7 ye bolunmur");
                 }
                 else Console.WriteLine("verilmis eded 40-a bolunur, 9 ve 7-ye bolunmur");
             }
             else Console.WriteLine("verilen eded 40-a, 9-a ve 7 ye bolunmur");
             }

             
        }
    }
}