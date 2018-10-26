using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Configuration;
using GameService.Model;
namespace GameService {
  public class PlayerDB {
    private readonly string ConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

    public async Task AddUser(User user) {
      using (var connection = new SqlConnection(ConnectionString)) {
        using (var command = new SqlCommand("AddUser", connection)) {
          command.CommandType = System.Data.CommandType.StoredProcedure;
          command.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = user.PlayerID;
          command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = user.Username;
          command.Parameters.Add("@Hash", SqlDbType.VarBinary, 512).Value = user.Hash;
          command.Parameters.Add("@Salt", SqlDbType.VarBinary, 32).Value = user.Salt;
          connection.Open();
          await command.ExecuteNonQueryAsync();
        }
      }
    }

    public async Task<User> GetUser(string username) {
      using (var connection = new SqlConnection(ConnectionString)) {
        using (var command = new SqlCommand("GetUser", connection)) {
          command.CommandType = CommandType.StoredProcedure;
          command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = username;
          connection.Open();

          var result = await command.ExecuteReaderAsync();
          if (result.Read()) {
            var hash = new byte[32];
            var salt = new byte[4];
            result.GetBytes(2, 0, hash, 0, 64);
            result.GetBytes(3, 0, salt, 0, 4);

            return new User {
              PlayerID = result.GetGuid(0),
              Username = result.GetString(1),
              Hash = hash,
              Salt = salt
            };
          } else {
            return null;
          }
        }
      }
    }
  }
}