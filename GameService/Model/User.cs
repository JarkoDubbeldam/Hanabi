using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace GameService.Model {
  [DataContract]
  public class User : Player {
    [IgnoreDataMember]
    public byte[] Hash { get; set; }
    [IgnoreDataMember]
    public byte[] Salt { get; set; }
  }
}