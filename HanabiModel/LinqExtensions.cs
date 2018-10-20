using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanabi.Model {
  static class LinqExtensions {

    public static IEnumerable<(TOne, TTwo)> CrossApply<TOne, TTwo>(this IEnumerable<TOne> ones, IEnumerable<TTwo> twos) {
      if (ones == null) {
        throw new ArgumentNullException(nameof(ones));
      }

      if (twos == null) {
        throw new ArgumentNullException(nameof(twos));
      }

      foreach(var one in ones) {
        foreach(var two in twos) {
          yield return (one, two);
        }
      }
    }
  }
}
