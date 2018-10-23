using System;

namespace Hanabi.Model {
  public class Hints {
    public int NumberOfHints { get; private set; } = 8;
    public bool CanHint => NumberOfHints > 0;
    public Hints() { }

    public static Hints operator++(Hints hints) {
      if(hints.NumberOfHints < 8) {
        hints.NumberOfHints++;
      }
      return hints;
    }

    public static Hints operator--(Hints hints) {
      
      if(hints.NumberOfHints == 0) {
        throw new InvalidOperationException();
      }
      hints.NumberOfHints--;
      return hints;
    }
  }
}