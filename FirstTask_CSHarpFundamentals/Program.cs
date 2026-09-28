namespace FirstTask_CSHarpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Carpet cleaning Service
            Console.Write("Enter number of small carpets: ");
            int small = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of large carpets: ");
            int large = Convert.ToInt32(Console.ReadLine());
            int cost = (25 * small) + (35 * large);
            double tax = cost * 0.06 ;
            Console.WriteLine("Price per small carpets : $25");
            Console.WriteLine("Price per large carpets : $35");
            Console.WriteLine($"Cost : ${cost}");
            Console.WriteLine($"Tax : ${tax}");
            Console.WriteLine("======================");
            Console.WriteLine($"Total estimate:${cost+tax}");
            Console.WriteLine("This estimate is valid for 30 days");
            
            
        }
    }
}
