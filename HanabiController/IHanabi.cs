using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Hanabi.Controller {
  public interface IHanabi {
    Guid CreateGame(int numberOfPlayers);

    GameStateResponse GetGameState(Guid gameID, Guid playerID);

    GameStateResponse MakeMove(MoveRequest request);

  }
}
