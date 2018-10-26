using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using GameService;

namespace GameService.Model {
  public class Player {
    public string Username { get; set; }
    public Guid PlayerID { get; set; }
    internal IGameServiceCallback callbackChannel = null;
  }

  public class PlayerComparer : IEqualityComparer<Player> {
    public bool Equals(Player x, Player y) {
      return x.PlayerID == y.PlayerID;
    }

    public int GetHashCode(Player obj) {
      return obj.PlayerID.GetHashCode();
    }
  }
}