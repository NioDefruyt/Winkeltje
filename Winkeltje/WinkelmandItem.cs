namespace Winkeltje
{
    public class WinkelmandItem
    {
        public Product Product { get; set; } = new();
        public int Aantal { get; set; }

        List<WinkelmandItem> winkelmand = new();
    }
}
