using System;
using System.Collections.Generic;

public enum Suit
{
    Club,
    Spade,
    Heart,
    Diamond
}
public interface ICard
{
    int GetValue();
    Suit GetSuit();
}

public class Card : ICard
{
    public Suit Suit { get; set; }
    public int Value { get; set; }
    public Card(int value, Suit suit)
    {
        Value = value;
        Suit = suit;
    }

    public int GetValue()
    {
        return Value;
    }

    public Suit GetSuit()
    {
        return Suit;
    }
    
    public override string ToString()
    {
        return $"Card Value : {Value}\n Card Suit: {Suit}\n\n";
    }

}

public interface IDeckOfCards
{
    public void Add(int value, Suit suit);
    public void AddMultiple(List<Card> setOfCards);

    public Card DrawRandom();
    public Card DrawFromTop();
    public void Shuffle();

}
public class DeckOfCards : IDeckOfCards
{
    //Normally you would inject this into the class using dependecy injection
    Random Rand = new Random();
    public int Size { get; set; } = 52;
    public int NrOfCardsPerSuit { get; set; } = 13;

    public List<Card> Cards { get; set; }
    public DeckOfCards()
    {
        Cards = new List<Card>();
        var suits = Enum.GetValues<Suit>();

        foreach (Suit suit in suits)
        {
            for (int i = 1; i <= NrOfCardsPerSuit; i++)
            {
                this.Add(i, suit);
            }
        }
    }

    public void Add(int value, Suit suit)
    {
        Cards.Add(new Card(value, suit));
    }

    public void AddMultiple(List<Card> setOfCards)
    {
        Cards.AddRange(setOfCards);
    }

    public Card DrawRandom()
    {
        var index = Rand.Next(1, Cards.Count);

        var drawnCard = Cards[index];
        Cards.RemoveAt(index);

        return drawnCard;
    }

    public Card DrawFromTop()
    {
        var topIndex = Cards.Count - 1;
        var topCard = Cards[topIndex];
        Cards.RemoveAt(topIndex);

        return topCard;
    }

    public void Shuffle()
    {
        for (int i = 0; i < Cards.Count; i++)
        {
            var j = Rand.Next(0, Cards.Count - 1);
            if(i == j)continue;
            
            var tempCard = Cards[i];
            Cards[i] = Cards[j];
            Cards[j] = tempCard;
        }
    }
}