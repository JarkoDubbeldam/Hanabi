using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace GameService {
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
  [ServiceContract(SessionMode = SessionMode.Required)]
  public interface ILoginService {
    [OperationContract]
    string InitiateSession();

    [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign)]
    Task<RegisterPlayerResponse> RegisterPlayer(PlayerCredentials request);
    
    [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign)]
    Task<LoginResult> AuthenticateUser(PlayerCredentials request);

    [OperationContract]
    void LogOff();
  }



}
