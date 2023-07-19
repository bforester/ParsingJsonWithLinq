using Newtonsoft.Json;

namespace ParsingJsonWithLinq
{
    public class HandlerJson
    {
        const string pathJsonFile = @"../../../Resources/Deals.json";


        public static List<Deal> GetDeals() => JsonConvert.DeserializeObject<List<Deal>>(File.ReadAllText(pathJsonFile));

        public static IList<string> GetNumbersOfDeals(IEnumerable<Deal> deals)
        {
            var firstFetch = from deal in deals
                             orderby deal.Date ascending
                             where deal.Sum >= 100
                             select deal;

            var result = firstFetch.Take(5)
                                   .OrderByDescending(deal => deal.Sum)
                                   .Select(i => i.Id)
                                   .ToList<string>();


            var ultimateFetch = deals.OrderBy(deal => deal.Date)
                               .Where(deal => deal.Sum >= 100)
                               .Take(5)
                               .OrderByDescending(deal => deal.Sum)
                               .Select(deal => deal.Id)
                               .ToList<string>();

            return result;
        }



        public static IList<SumByMonth> GetSumsByMonth(IEnumerable<Deal> deals)
        {
            var sumByMonth = new List<SumByMonth>();
            var fetch = from deal in deals
                        group deal by deal.Date.Month;
            int sum=0;

            foreach (var fSecond in fetch)
            {              
                foreach (var f in fSecond)
                {             
                    sum += f.Sum;
                }
                sumByMonth.Add(new SumByMonth(fSecond.Key, sum));
                sum = 0;
            }

            return sumByMonth;
        }

    }

}
