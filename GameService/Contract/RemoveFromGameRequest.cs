using System;
using System.Runtime.Serialization;

namespace GameService.Contract {
  [DataContract]
  public class RemoveFromGameRequest {
    [DataMember]
    public Guid GameID { get; set; }
    [DataMember]
    public Guid ActingPlayerID { get; set; }
    [DataMember]
    public string RemovedPlayerName { get; set; }
  }
}