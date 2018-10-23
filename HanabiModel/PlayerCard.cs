using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanabi.Model {
  public class PlayerCard {
    public Card Card;
    public Possibilities Possibilities { get; } = new Possibilities();
    public Guid Guid { get; } = new Guid();

    public PlayerCard(Card card) {
      Card = card;
    }

    public void GetHint(Colour colour) {
      if(Card.Colour == colour) {
        Possibilities.PossibleColours = colour;
      } else {
        Possibilities.PossibleColours &= ~colour;
      }
    }

    public void GetHint(Value value) {
      if (Card.Value == value) {
        Possibilities.PossibleValues = value;
      } else {
        Possibilities.PossibleValues &= ~value;
      }
    }
  }
}
