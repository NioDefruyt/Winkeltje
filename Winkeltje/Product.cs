namespace Winkeltje
{
        public class Product 
        { 
            public int Id { get; set; } 
            public string Naam { get; set; } 
            public string Beschrijving { get; set; } = ""; 
            public decimal Prijs { get; set; } 
            public int Voorraad { get; set; } 
            public string Afbeelding { get; set; } = ""; 
        }
}
