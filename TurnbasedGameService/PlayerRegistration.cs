using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TurnbasedGameService {
  public class PlayerRegistration {
    private readonly string username;
    private readonly string plaintext;

    public PlayerRegistration(string username, string plaintext) {
      this.username = username;
      this.plaintext = plaintext;
    }

    public async Task<Guid> RegisterPlayer() {
      HashPassword(out byte[] salt, out byte[] hash);
      var newID = Guid.NewGuid();

      var db = new PlayerDB();
      await db.AddUser(newID, username, Encoding.UTF8.GetString(hash), Encoding.UTF8.GetString(salt));
      return newID;
    }

    private void HashPassword(out byte[] salt, out byte[] hash) {
      var algorithm = new SHA256Managed();

      var rng = RandomNumberGenerator.Create();
      salt = new byte[4];
      rng.GetBytes(salt);

      var plaintext = Encoding.UTF8.GetBytes(this.plaintext).Concat(salt);
      hash = algorithm.ComputeHash(plaintext.ToArray());
    }
  }
}