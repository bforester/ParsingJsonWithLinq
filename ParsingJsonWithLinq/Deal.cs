namespace ParsingJsonWithLinq
{

    public class Deal
    {
        public DateTime Date { get; set; }
        public string Id { get; set; }
        public int Sum { get; set; }

        public override string ToString()
        {
            return $"Date: {Date}\nId: {Id}\nSum: {Sum}\n\n";
        }

    }
}
