using System.Runtime.Serialization;

namespace TurnbasedGameService {
  [DataContract]
  public class RegisterPlayerRequest {
    [DataMember]
    public string PlayerNickname { get; set; }
    [DataMember]
    public string Password { get; set; }
  }
}