// The Card
// :: Level 24 - Boss Battle 3/5 ::
// :: Create instances of objects in loops ::

using _026_bb_the_card.Models;

Console.Title = "The Card";
Console.Clear();

// Global Variables
List<Card> deck = new List<Card>(); // Make sure all 56 cards are created

// App loop
foreach (object color in Enum.GetValues(typeof(Card.CardColors))) // Loop colors
{
    foreach (object rank in Enum.GetValues(typeof(Card.CardRanks))) // Loop ranks
    {
        Card card = new Card(color.ToString()!, rank.ToString()!); // Card instance
        Console.WriteLine($"The {card.CardColor} {card.CardRank}");
        deck.Add(card); // Add card to desk List
    }
}

Console.WriteLine("*********************************");
Console.WriteLine($"The deck has {deck.Count} cards.");