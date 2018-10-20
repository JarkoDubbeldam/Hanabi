using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanabi.Model {
  class Board {
    public List<Card> Cards { get; }

    public Board() {
      Cards = new List<Card>();
    }

    public bool CanPlay(Card card) {
      var highestCardInThatColour = Cards
        .Where(x => x.Colour == card.Colour)
        .DefaultIfEmpty() // (colourless 0)
        .Max(x => x.Value);
      var nextvalue = highestCardInThatColour + 1;
      return card.Value == nextvalue; // Colour is already validated by Where.
    }
  }
}
