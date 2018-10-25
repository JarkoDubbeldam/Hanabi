using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace GameService {
  public class PlayerAuthenticator {


    public async Task<Guid?> RegisterPlayer(string username, string password) {
      var salt = GetSalt();
      var hash = HashPassword(password, salt);
      var newID = Guid.NewGuid();

      var db = new PlayerDB();
      var user = new User {
        Userid = newID,
        Username = username,
        Hash = hash,
        Salt = salt
      };

      try {
        await db.AddUser(user);
      }
      catch (SqlException) {
        return null;
      }
      return newID;
    }

    public async Task<bool> UsernameAvailable(string username) {
      var db = new PlayerDB();
      return await db.GetUser(username) == null;
    }

    public async Task<Guid?> AuthenticatePlayer(string username, string password) {
      var db = new PlayerDB();
      var userInfo = await db.GetUser(username);
      if(userInfo == null) {
        return null;
      }

      var hash = HashPassword(password, userInfo.Salt);
      if (hash.SequenceEqual(userInfo.Hash)) {
        return userInfo.Userid;
      } else {
        return null;
      }
    }

    private byte[] HashPassword(string password, byte[] salt) {
      var algorithm = new SHA256Managed();
      var plaintext = Encoding.UTF8.GetBytes(password).Concat(salt);
      return algorithm.ComputeHash(plaintext.ToArray());
    }

    private byte[] GetSalt() {
      byte[] salt;
      var rng = RandomNumberGenerator.Create();
      salt = new byte[4];
      rng.GetBytes(salt);
      return salt;
    }
  }
}