using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameService.Model {
  public static class GamesCollection {
    public static List<Game> Games { get; } = new List<Game>();
    public static Dictionary<int, GameBuilder> GamesUnderConstruction { get; } = new Dictionary<int, GameBuilder>();
  }
}