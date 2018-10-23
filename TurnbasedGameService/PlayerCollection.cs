using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnbasedGameService {
  static class PlayerCollection {
    public static Dictionary<Guid, Player> Players { get; set; } = new Dictionary<Guid, Player>();
  }
}