namespace ItemService.Models
{
    public class Item
    {
        public string ItemName { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }
        public bool ItemIsValid { get; set; }
    }
}
