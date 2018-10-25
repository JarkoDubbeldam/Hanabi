using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameService {
  public class Connections {
    public static Dictionary<Guid, LoginService> connections = new Dictionary<Guid, LoginService>();
  }
}