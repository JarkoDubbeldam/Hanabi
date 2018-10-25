using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameService {
  public class LoginResult {
    public Guid? UserID { get; set; }
    public FailureReason FailureReason { get; set; } = FailureReason.None;
  }

  public enum FailureReason {
    None,
    InvalidCredentials,
    AlreadyLoggedIn
  }
}