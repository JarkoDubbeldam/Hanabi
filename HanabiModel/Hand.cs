using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanabi.Model {
  class Hand {
    public List<Card> Cards { get; }


    public Hand(IEnumerable<Card> cards) {
      Cards = new List<Card>(cards);
    }

    public Card Play(int index) {
      var card = Cards[index];
      Cards.RemoveAt(index);
      return card;
    }

    public void Add(Card card) => Cards.Add(card);

    public bool CanHint(Value value) => Cards.Any(x => x.Value == value);
    public bool CanHint(Colour colour) => Cards.Any(x => x.Colour == colour);
  }
}
