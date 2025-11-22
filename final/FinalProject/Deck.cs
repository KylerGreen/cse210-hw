using System;

class Deck
{
    // Attributes
    private List<Card> _cards = new List<Card>();

    private List<Card> _hand = new List<Card>();


    // Methods
    public void AddCard(Card card)
    {
        _cards.Add(card);
    }

    public void DrawCard(List<Card> _cards, List<Card> _hand)
    {
        _hand.Add(_cards[0]);
        _cards.RemoveAt(0);
    }

    public void DisplayHand()
    {
        foreach (var card in _hand)
        {
            card.Display();
        }
    }

    public void DisplayDeck()
    {
        foreach (var card in _cards)
        {
            card.Display();
        }
    }

    public void Shuffle()
    {
        Random rng = new Random();
        int n = _cards.Count;
        while (n > 1)
        {
            int i = rng.Next(n--);
            Card temp = _cards[n];
            _cards[n] = _cards[i];
            _cards[i] = temp;
        }
    }
}