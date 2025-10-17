using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture(
            new Reference("John", 3, 16),
            new List<Word> {
                new Word("For"),
                new Word("God"),
                new Word("so"),
                new Word("loved"),
                new Word("the"),
                new Word("world"),
                new Word("that"),
                new Word("he"),
                new Word("gave"),
                new Word("his"),
                new Word("only"),
                new Word("begotten"),
                new Word("Son,"),
                new Word("that"),
                new Word("whosoever"),
                new Word("believeth"),
                new Word("in"),
                new Word("him"),
                new Word("should"),
                new Word("not"),
                new Word("perish,"),
                new Word("but"),
                new Word("have"),
                new Word("everlasting"),
                new Word("life.")
            }
        );

        Scripture secondscripture = new Scripture(
            new Reference("Proverbs", 3, "5-6"),
            new List<Word> {
                new Word("Trust"),
                new Word("in"),
                new Word("the"),
                new Word("Lord"),
                new Word("with"),
                new Word("all"),
                new Word("thine"),
                new Word("heart"),
                new Word("and"),
                new Word("lean"),
                new Word("not"),
                new Word("unto"),
                new Word("thine"),
                new Word("own"),
                new Word("understanding;"),
            },
            new List<Word> {
                new Word("In"),
                new Word("all"),
                new Word("thy"),
                new Word("ways"),
                new Word("acknowledge"),
                new Word("him,"),
                new Word("and"),
                new Word("he"),
                new Word("shall"),
                new Word("direct"),
                new Word("thy"),
                new Word("paths."),
            }
        );

        secondscripture.Display();
        secondscripture.Menu();
    }


}