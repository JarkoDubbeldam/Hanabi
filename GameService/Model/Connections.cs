using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameService.Model {
  public class Connections {
    public static HashSet<Player> LoggedInPlayers { get; set; } = new HashSet<Player>(new PlayerComparer());
  }
}