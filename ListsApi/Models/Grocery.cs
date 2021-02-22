namespace ListsApi.Models
{
    public class Grocery
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public bool Bought { get; set; }
    }
}