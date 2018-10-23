using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanabi.Model {
  public class Player {
    public Hand Hand { get; } 

    public Guid PlayerID { get; }

    public Player(Guid ID, Hand hand) {
      PlayerID = ID;
      Hand = hand;
    }

    internal void ReceiveHint(object hint) {
      if(hint.GetType() == typeof(Colour)) {
        Hand.ReceiveHint((Colour)hint);
      } else if(hint.GetType() == typeof(Value)) {
        Hand.ReceiveHint((Value)hint);
      } else {
        throw new ArgumentException(nameof(hint));
      }
    }
  }
}
