using System;
using System.ServiceModel.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace TurnbasedGameService {
  [DataContract]
  public class RegisterPlayerResponse {
    [DataMember]
    public Guid PlayerID { get; set; }
  }
}