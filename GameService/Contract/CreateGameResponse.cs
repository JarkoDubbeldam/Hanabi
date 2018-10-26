using System;
using System.Runtime.Serialization;

namespace GameService.Contract {
  [DataContract]
  public class CreateGameResponse {
    [DataMember]
    public string GameName { get; set; }
    [DataMember]
    public int JoinCode { get; set; }
  }
}