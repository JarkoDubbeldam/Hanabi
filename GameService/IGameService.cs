using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using GameService.Contract; 

namespace GameService {
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGameService" in both code and config file together.
  [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IGameServiceCallback))]
  public interface IGameService {
    [OperationContract]
    CreateGameResponse CreateGame(CreateGameRequest request);

    [OperationContract(IsOneWay = true)]
    void JoinGame(JoinGameRequest request);

    [OperationContract]
    KickFromGameResponse KickFromGame(KickFromGameRequest request);

    [OperationContract]
    StartGameResponse StartGame(StartGameRequest request);
  }

  public interface IGameServiceCallback {
    [OperationContract(IsOneWay = true)]
    void PushGameCreationState(GameCreationState gameCreationState);
  }
}
