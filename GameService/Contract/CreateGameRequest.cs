using System;
using System.Runtime.Serialization;
namespace GameService.Contract {
  [DataContract]
  public class CreateGameRequest {
    [DataMember]
    public Guid PlayerId { get; set; }
    [DataMember]
    public string Gamename { get; set; }
  }
}