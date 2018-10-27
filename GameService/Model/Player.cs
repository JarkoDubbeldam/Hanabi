using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using GameService;

namespace GameService.Model {
  [DataContract]
  public class Player {
    [DataMember]
    public string Username { get; set; }
    [IgnoreDataMember]
    public Guid PlayerID { get; set; }
    [IgnoreDataMember]
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