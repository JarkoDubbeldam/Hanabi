using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace TurnbasedGameService {
  public class PlayerDB {
    public async Task AddUser(Guid userID, string username, string hash, string salt) {
      using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jarko\source\repos\Hanabi\Hanabi\TurnbasedGameService\App_Data\Users.mdf;Integrated Security=True")) {
        using (var command = new SqlCommand("AddUser", connection)) {
          command.CommandType = System.Data.CommandType.StoredProcedure;
          command.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = userID;
          command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = username;
          command.Parameters.Add("@Hash", SqlDbType.NVarChar, 512).Value = hash;
          command.Parameters.Add("@Salt", SqlDbType.NVarChar, 32).Value = salt;
          connection.Open();
          await command.ExecuteNonQueryAsync();
        }
      }
    }
  }
}