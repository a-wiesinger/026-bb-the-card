namespace _026_bb_the_card.Models;

public class Card
{
    // Properties
    public string CardColor { get; }
    public string CardRank { get; }

// Constructor(s)
    public Card(string cardColor, string cardRank)
    {
        CardColor = cardColor;
        CardRank = cardRank;
    }
    
    // Enumerations
    public enum CardColors
    {
        Red,
        Green,
        Blue,
        Yellow
    }

    public enum CardRanks
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Dollar,
        Percent,
        Caret,
        Ampersand
    }
}