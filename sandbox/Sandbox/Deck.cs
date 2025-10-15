using System;

class Deck
{
    private List<Card> cards = new List<Card>();

    public void AddCard(Card card)
    {
        cards.Add(card);
    }

    public void DisplayDeck()
    {
        foreach (var card in cards)
        {
            card.Display();
        }
    }

    // public void Shuffle()
    // {
    //     Random rng = new Random();
    //     int n = cards.Count;
    //     while (n > 1)
    //     {
    //         int i = rng.Next(n--);
    //         Card temp = cards[n];
    //         cards[n] = cards[i];
    //         cards[i] = temp;
    //     }
    // }
}