using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanabi.Model {
  public class Deck {
    private Stack<Card> Cards;
    private Random rng = new Random();

    public event EventHandler DeckIsEmpty;

    public Deck() {
      Cards = new Stack<Card>(Shuffle(AllCards));
    }

    public bool TryDraw(out Card? card) {
      if(!HasCards) {
        card = null;
        DeckIsEmpty?.Invoke(this, new EventArgs());
        return false;
      }
      card = Cards.Pop();
      return true;
    }

    public IEnumerable<Card> DrawMany(int N) {
      for(var i = 0; i < N && HasCards; i++) {
        if(TryDraw(out Card? card)) {
          yield return card.Value;
        } else {
          yield break;
        }
      }
    }

    public bool HasCards => Cards.Count > 0;
    public int NumberOfCards => Cards.Count;

    private IEnumerable<Card> Shuffle(IEnumerable<Card> cards) {
      return cards
        .Select(card => new { card, index = rng.Next() })
        .OrderBy(x => x.index)
        .Select(x => x.card);
    }

    public static IEnumerable<Card> AllCards {
      get {
        var colours = Enumerable.Range(1, 5).Cast<Colour>();
        var values = Enumerable.Range(1, 5).Cast<Value>();

        return values
          .SelectMany(x => Enumerable.Repeat(x, Card.Quantity(x)))
          .CrossApply(colours)
          .Select(x => new Card { Value = x.Item1, Colour = x.Item2 });
      }
    }

    public override string ToString() {
      return $"{Cards.Count} card{(Cards.Count != 1 ? "s" : "")} left.";
    }
  }
}
