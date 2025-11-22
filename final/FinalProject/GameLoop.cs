using System;

class GameLoop
{
    public void Loop()
    {

        Deck deck = new Deck();
        Card attack1 = new AttackCard("attack1", "attack", 1, "The first basic attack", 10);
        Card attack2 = new AttackCard("attack2", "attack", 2, "The second basic attack", 30);

        deck.AddCard(attack1);
        deck.AddCard(attack1);
        deck.AddCard(attack2);
        deck.AddCard(attack2);


        deck.Shuffle();
        deck.DisplayDeck();
    }
}