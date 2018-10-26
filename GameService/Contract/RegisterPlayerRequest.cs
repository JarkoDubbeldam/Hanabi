using System.Runtime.Serialization;

namespace GameService.Contract {
  [DataContract]
  public class PlayerCredentials {
    [DataMember]
    public string PlayerNickname { get; set; }
    [DataMember]
    public byte[] Password { get; set; }
  }
}