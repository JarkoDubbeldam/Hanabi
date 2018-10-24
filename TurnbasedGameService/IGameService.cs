﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace TurnbasedGameService {
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
  [ServiceContract]
  public interface IGameService {
    [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
    Task<RegisterPlayerResponse> RegisterPlayer(PlayerCredentials request);

    [OperationContract]
    Task<bool> UsernameAvailable(string username);

    [OperationContract]
    Task<Guid?> AuthenticateUser(PlayerCredentials request);
  }



}
