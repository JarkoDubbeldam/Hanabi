using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginUI.LoginService;
using System.Security.Cryptography;
namespace LoginUI {
  static class AuthenticatorService {
    public static ILoginService Service = new LoginServiceClient();
    private static readonly string RSAPublicKey;
    private static RSACryptoServiceProvider rsa;

    static AuthenticatorService() {
      rsa = new RSACryptoServiceProvider();
      RSAPublicKey = Service.InitiateSession();
      rsa.FromXmlString(RSAPublicKey);
    }

    public static PlayerCredentials GetCredentials(string username, string password) {
      var encryptedPassword = rsa.Encrypt(Encoding.UTF8.GetBytes(password), false);
      return new PlayerCredentials {
        PlayerNickname = username,
        Password = encryptedPassword
      };
    }
  }
}
