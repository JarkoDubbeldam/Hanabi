using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HanabiService {
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
  [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IHanabiServiceCallBack)]
  public interface IHanabiService {
    [OperationContract(IsOneWay = false)]
    int CreateGame();

    [OperationContract(IsOneWay = false)]
    void JoinGame(int game);
  }

  public interface IHanabiServiceCallBack {
    [OperationContract(IsOneWay = true)]
    void PushGameState(GameStateResponse gamestate);
  }
}
