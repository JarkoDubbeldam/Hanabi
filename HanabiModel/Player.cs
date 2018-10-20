using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanabi.Model {
  class Player {
    public Hand Hand { get; } 

    public int PlayerID { get; }

    public Player(int ID, Hand hand) {
      PlayerID = ID;
      Hand = hand;
    }
  }
}
