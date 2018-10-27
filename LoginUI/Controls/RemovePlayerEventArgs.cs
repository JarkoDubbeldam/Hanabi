using System;
namespace LoginUI.Controls {
  public class RemovePlayerEventArgs {
    public Guid GameID { get; set; }
    public string RemovedPlayerName { get; set; }
  }
}