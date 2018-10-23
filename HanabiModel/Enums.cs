using System;

namespace Hanabi.Model {
  [Flags]
  public enum Colour {
    Red = 1,
    Yellow = 2,
    White = 4,
    Blue = 8,
    Green = 16
  }

  [Flags]
  public enum Value {
    One = 1,
    Two = 2,
    Three = 4,
    Four = 8,
    Five = 16
  }
}

