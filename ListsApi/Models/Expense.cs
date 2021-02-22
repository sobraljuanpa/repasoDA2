using System;

namespace ListsApi.Models
{
    public class Expense
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}