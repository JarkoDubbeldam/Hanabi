using System;
using System.Collections.Generic;
using Hanabi.Model;

namespace HanabiService {
  public class GameStateResponse {
    public Guid GameID { get; internal set; }
    public Guid CurrentPlayerId { get; internal set; }
    public IReadOnlyList<Guid> Players { get; internal set; }

    public int RoundNumber { get; internal set; }
    public int Score { get; internal set; }
    public int Hints { get; internal set; }
    public int Errors { get; internal set; }

    public IReadOnlyDictionary<Guid, IReadOnlyList<Card>> VisibleCards { get; internal set; }
    public IReadOnlyList<Guid> HiddenCards { get; internal set; }

    public IReadOnlyList<Card> BoardCards { get; internal set; }
    public IReadOnlyList<Card> DiscardPile { get; internal set; }
    public int NumberOfCardsLeft { get; internal set; }
  }
}