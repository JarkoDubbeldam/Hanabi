using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClientTest.GameServer;


namespace ClientTest {
  class Program {
    static void Main(string[] args) {
      var username = Console.ReadLine();

      IGameService gameClient = new GameServiceClient();

      var result = gameClient.RegisterPlayer(new TurnbasedGameService.RegisterPlayerRequest { PlayerNickname = username, Password = "blabla" });
    }
  }
}
