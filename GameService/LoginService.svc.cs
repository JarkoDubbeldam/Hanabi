using System;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Threading.Tasks;

using GameService.Model;
using GameService.Contract;

namespace GameService {
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
  [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
  public class LoginService : ILoginService, IDisposable {
    private readonly string privateKey;
    private RSACryptoServiceProvider rsa;
    private bool Authenticated = false;
    private Player Player;

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
      var respons = new LoginResult();
      if (result != null) {
        if (Connections.LoggedInPlayers.Add(result)) {
          Authenticated = true;
          Player = result;
          respons.UserID = result.PlayerID;
        } else {
          respons.FailureReason = FailureReason.AlreadyLoggedIn;
          respons.UserID = null;
        }
      } else {
        respons.FailureReason = FailureReason.InvalidCredentials;
      }

      return respons;
    }

    public async Task<RegisterPlayerResponse> RegisterPlayer(PlayerCredentials request) {
      var registrator = new PlayerAuthenticator();
      var password = rsa.Decrypt(request.Password, false);

      var id = await registrator.RegisterPlayer(request.PlayerNickname, password);
      return new RegisterPlayerResponse {
        PlayerID = id
      };
    }


    public void LogOff() {
      if (Authenticated) {
        Connections.LoggedInPlayers.Remove(Player);
      }
    }

    #region IDisposable Support
    private bool disposedValue = false; // To detect redundant calls

    protected virtual void Dispose(bool disposing) {
      if (!disposedValue) {
        if (disposing) {
          LogOff();
        }

        // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
        // TODO: set large fields to null.

        disposedValue = true;
      }
    }

    // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
    // ~LoginService() {
    //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
    //   Dispose(false);
    // }

    // This code added to correctly implement the disposable pattern.
    public void Dispose() {
      // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
      Dispose(true);
      // TODO: uncomment the following line if the finalizer is overridden above.
      // GC.SuppressFinalize(this);
    }
    #endregion
  }
}
