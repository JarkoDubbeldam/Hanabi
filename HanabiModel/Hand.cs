using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanabi.Model {
  public class Hand {
    public Dictionary<Guid, PlayerCard> Cards { get; }


    public Hand(IEnumerable<Card> cards) {
      Cards = cards.Select(x => new PlayerCard(x)).ToDictionary(x => x.Guid, x => x);
    }

    public PlayerCard Play(Guid cardID) {
      var card = Cards[cardID];
      Cards.Remove(cardID);
      return card;
    }

    public void Add(Card card) {
      var newcard = new PlayerCard(card);
      Cards.Add(newcard.Guid, newcard);
    }

    public bool CanHint(Colour colour) => Cards.Any(x => x.Value.Card.Colour == colour);
    public bool CanHint(Value value) => Cards.Any(x => x.Value.Card.Value == value);

    public bool ReceiveHint(Colour colour) {
      if (CanHint(colour)) {
        foreach(var card in Cards) {
          card.Value.GetHint(colour);
        }
        return true;
      }
      return false;
    }

    public bool ReceiveHint(Value value) {
      if (CanHint(value)) {
        foreach (var card in Cards) {
          card.Value.GetHint(value);
        }
        return true;
      }
      return false;
    }

    public bool HasCard(Guid cardID) {
      return Cards.TryGetValue(cardID, out _);
    }

    public PlayerCard GetCard(Guid cardID) => Cards[cardID];
  }
}
