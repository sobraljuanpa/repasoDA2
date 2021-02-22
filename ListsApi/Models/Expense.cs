using System;

namespace ListsApi.Models
{
    public class Expense
    {
        public long id { get; set; }
        public string name { get; set; }
        public int amoung { get; set; }
        public DateTime date { get; set; }
    }
}