namespace ParsingJsonWithLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deals = HandlerJson.GetDeals();
            var numbers = HandlerJson.GetNumbersOfDeals(deals);
            var sumByMonth = HandlerJson.GetSumsByMonth(deals);

            foreach (var sum in sumByMonth)
            { 
                Console.WriteLine(sum);
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}