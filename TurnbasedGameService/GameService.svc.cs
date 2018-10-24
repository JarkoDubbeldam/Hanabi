using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace TurnbasedGameService {
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
  [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
  public class GameService : IGameService {
    public async Task<Guid?> AuthenticateUser(PlayerCredentials request) {
      var authenticator = new PlayerAuthenticator();
      return await authenticator.AuthenticatePlayer(request.PlayerNickname, request.Password);
    }

    public async Task<RegisterPlayerResponse> RegisterPlayer(PlayerCredentials request) {
      var registrator = new PlayerAuthenticator();
      var id = await registrator.RegisterPlayer(request.PlayerNickname, request.Password);
      return new RegisterPlayerResponse {
        PlayerID = id
      };
    }

    public async Task<bool> UsernameAvailable(string username) {
      var authenticator = new PlayerAuthenticator();
      return await authenticator.UsernameAvailable(username);
    }
  }
}
