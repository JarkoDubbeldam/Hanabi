using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace GameService {
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
  [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
  public class LoginService : ILoginService, IDisposable {
    private readonly string privateKey;
    private RSACryptoServiceProvider rsa;
    private bool Authenticated = false;
    private Guid Userid;

    public LoginService() {
      rsa = new RSACryptoServiceProvider();
      privateKey = rsa.ToXmlString(true);
    }



    public string InitiateSession() {
      return rsa.ToXmlString(false);
    }


    public async Task<LoginResult> AuthenticateUser(PlayerCredentials request) {
      var authenticator = new PlayerAuthenticator();
      var password = rsa.Decrypt(request.Password, false);

      var result = await authenticator.AuthenticatePlayer(request.PlayerNickname, password);
      var response = new LoginResult { UserID = result };
      if (result.HasValue) {
        lock (Connections.connections) {
          if (!Connections.connections.ContainsKey(result.Value)) {
            Connections.connections.Add(result.Value, this);
            Authenticated = true;
            Userid = result.Value;
          } else {
            response.FailureReason = FailureReason.AlreadyLoggedIn;
            response.UserID = null;
          }
        }
      } else {
        response.FailureReason = FailureReason.InvalidCredentials;
      }

      return response;
    }

    public async Task<RegisterPlayerResponse> RegisterPlayer(PlayerCredentials request) {
      var registrator = new PlayerAuthenticator();
      var password = rsa.Decrypt(request.Password, false);

      var id = await registrator.RegisterPlayer(request.PlayerNickname, password);
      return new RegisterPlayerResponse {
        PlayerID = id
      };
    }

    public void Dispose() {
      if (Authenticated) {
        lock (Connections.connections) {
          Connections.connections.Remove(Userid);
        }
      }
    }

    public void LogOff() {
      Dispose();
    }
  }
}
