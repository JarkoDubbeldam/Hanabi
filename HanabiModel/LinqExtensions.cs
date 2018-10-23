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

    /// <summary>
    /// Creates an infinite loop of the input sequence. Important! Do not try to completely enumerate the result, it will take a while!
    /// </summary>
    /// <typeparam name="T">Type that is enumerated.</typeparam>
    /// <param name="sequence">The sequence to infinitely repeat.</param>
    /// <returns>An infinite repetition of the input sequence.</returns>
    public static IEnumerable<T> InfiniteLoop<T>(this IEnumerable<T> sequence) {
      if (sequence == null) {
        throw new ArgumentNullException(nameof(sequence));
      }

      while (true) {
        foreach(var value in sequence) {
          yield return value;
        }
      }
    }
  }
}
