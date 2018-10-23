using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanabi.Model {
  public class Board {
    public List<Card> Cards { get; }

    public Board() {
      Cards = new List<Card>();
    }

    public bool CanPlay(Card card) {
      var highestCardInThatColour = Cards
        .Where(x => x.Colour == card.Colour)
        .DefaultIfEmpty() // (colourless 0)
        .Max(x => x.Value);
      var nextvalue = (Value)((int)highestCardInThatColour << 1);
      return card.Value == nextvalue; // Colour is already validated by Where.
    }

    public bool Play(Card card) {
      var success = CanPlay(card);
      if (success) {
        Cards.Add(card);
      }
      return success;
    }

    public int GetScore() => Cards.Count;
  }
}
