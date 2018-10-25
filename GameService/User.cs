using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameService {
  public class User {
    public Guid Userid { get; set; }
    public string Username { get; set; }
    public byte[] Hash { get; set; }
    public byte[] Salt { get; set; }
  }
}