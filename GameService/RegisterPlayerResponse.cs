using System;
using System.ServiceModel.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace GameService {
  [DataContract]
  public class RegisterPlayerResponse {
    [DataMember]
    public Guid? PlayerID { get; set; }
  }
}