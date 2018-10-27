using System;
  using LoginUI.GameService;

namespace LoginUI {
  internal class GameCreationStateChangedEventArgs : EventArgs {
    public GameCreationState GameCreationState { get; set; }
  }
}