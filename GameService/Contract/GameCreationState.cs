using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using GameService.Model;
namespace GameService.Contract {
  [DataContract]
  [KnownType(typeof(User))]
  public class GameCreationState {
    [DataMember]
    public Guid GameID { get; set; }
    [DataMember]
    public string GameName { get; set; }
    [DataMember]
    public int JoinCode { get; set; }
    [DataMember]
    public Player Owner { get; set; }
    [DataMember]
    public List<Player> Players { get; set; }
  }
}