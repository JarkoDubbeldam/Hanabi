using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanabi.Model {
  struct Card {
    public Colour Colour { get; set; }
    public Value Value { get; set; }

    public static int Quantity(Value value) {
      switch (value) {
        case Value.One:
          return 3;
        case Value.Two:
        case Value.Three:
        case Value.Four:
          return 2;
        case Value.Five:
          return 1;
        default:
          throw new ArgumentOutOfRangeException(nameof(value));
      }
    }

    public override string ToString() {
      return $"{Colour} {Value}";
    }
  }
}
