using System;
using System.Runtime.Serialization;

namespace GameService.Contract {
  [DataContract]
  public class JoinGameRequest {
    [DataMember]
    public Guid PlayerID { get; set; }
    [DataMember]
    public int GameJoinCode { get; set; }
  }
}