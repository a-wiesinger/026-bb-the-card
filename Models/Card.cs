namespace _026_bb_the_card.Models;

public class Card
{
    // Properties
    public string NumberOrSymbol
    {
        get
        {
            // TODO - Check the property of card for number or face
            return "Result of above check";
        }
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