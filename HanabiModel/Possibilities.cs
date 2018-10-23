using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanabi.Model {
  public class Possibilities {
    public Value PossibleValues { get; internal set; } = (Value)0b11111;
    public Colour PossibleColours { get; internal set; } = (Colour)0b11111;


  }
}
