using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameService.Model {
  public class User : Player {
    public byte[] Hash { get; set; }
    public byte[] Salt { get; set; }
  }
}