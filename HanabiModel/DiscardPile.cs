using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanabi.Model {
  class DiscardPile {
    public List<Card> Cards { get; }

    public DiscardPile() {
      Cards = new List<Card>();
    }

    public void Discard(Card card) {
      Cards.Add(card);
    }

    public override string ToString() {
      var counts = Cards
        .GroupBy(x => x)
        .Select(x => new { Card = x, Count = x.Count() })
        .Select(x => $"{x.Count}x: {x.Card}");
      return string.Join(Environment.NewLine, counts);
    }
  }
}
