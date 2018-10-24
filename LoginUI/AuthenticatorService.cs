using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginUI.GameService;

namespace LoginUI {
  static class AuthenticatorService {
    public static IGameService Service = new GameServiceClient();
  }
}
