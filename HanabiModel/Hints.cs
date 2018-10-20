using System;

namespace Hanabi.Model {
  public class Hints {
    public int NumberOfHints { get; } = 8;

    public Hints() { }

    private Hints(int hints) {
      NumberOfHints = hints;
    }

    public static Hints operator++(Hints hints) {
      if(hints.NumberOfHints < 8) {
        return new Hints(hints.NumberOfHints + 1);
      } else {
        return new Hints(8);
      }
    }

    public static Hints operator--(Hints hints) {
      var newhints = hints.NumberOfHints - 1;
      if(newhints < 0) {
        throw new InvalidOperationException();
      }
      return new Hints(newhints);
    }
  }
}