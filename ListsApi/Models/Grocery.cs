namespace ListsApi.Models
{
    public class Grocery
    {
        public long id { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public bool bought { get; set; }
    }
}