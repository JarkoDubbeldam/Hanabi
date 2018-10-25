using System.Runtime.Serialization;

namespace GameService {
  [DataContract]
  public class PlayerCredentials {
    [DataMember]
    public string PlayerNickname { get; set; }
    [DataMember]
    public string Password { get; set; }
  }
}