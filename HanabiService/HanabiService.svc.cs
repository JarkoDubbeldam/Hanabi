using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HanabiService {
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
  [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
  public class HanabiService : IHanabiService {
    readonly IHanabiServiceCallBack callback = null;

    public HanabiService() {
      callback = OperationContext.Current.GetCallbackChannel<IHanabiServiceCallBack>();
    }

    public Guid CreateGame(int numberOfPlayers) {
      throw new NotImplementedException();
    }

    public int CreateGame() {
      throw new NotImplementedException();
    }

    public GameStateResponse GetGameState(Guid gameID, Guid playerID) {
      throw new NotImplementedException();
    }

    public void JoinGame(int game) {
      throw new NotImplementedException();
    }

    public GameStateResponse MakeMove(MoveRequest request) {
      throw new NotImplementedException();
    }
  }
}
