// The Card
// :: Level 24 - Boss Battle 3/5 ::

using _026_bb_the_card.Models;

Console.Title = "The Card";
Console.Clear();


// TODO - Create Card instance for each permutation
foreach (var color in Enum.GetValues(typeof(Card.CardColors)))
{
    foreach (var rank in Enum.GetValues(typeof(Card.CardRanks)))
    {
        Console.WriteLine(($"The {color} {rank}"));
    }
}