using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameService.Model {
  public class Game {
    public Player Owner { get; internal set; }
    public HashSet<Player> Participants { get; internal set; }
    public Guid GameID { get; internal set; }    
    public string GameName { get; internal set; }
  }
}