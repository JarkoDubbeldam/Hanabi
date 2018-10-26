using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameService.Model {
  public class GameBuilder {
    public Player Owner { get; set; }
    private HashSet<Player> participants;
    public string Gamename { get; private set; }
    public int JoinID => this.GetHashCode();
    public IEnumerable<Player> Players => participants;
    public Guid GameID { get; } = Guid.NewGuid();

    public GameBuilder() {
      participants = new HashSet<Player>(new PlayerComparer());
    }

    public GameBuilder Initialise(Player owner, string gamename) {
      this.Owner = owner;
      this.Gamename = gamename;
      participants.Add(owner);
      return this;
    }

    public GameBuilder AddPlayer(Player player) {
      participants.Add(player);
      return this;
    }

    public GameBuilder RemovePlayer(Player player) {
      participants.Remove(player);
      return this;
    }

    public Game CreateGame() {
      return new Game {
        Owner = Owner,
        GameID = GameID,
        GameName = Gamename,
        Participants = participants
      };
    }
  }
}