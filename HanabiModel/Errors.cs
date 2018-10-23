using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanabi.Model {
  public class Errors {
    public int NumberOfErrors { get; private set; } = 0;
    private static int MaxErrors = 3;
    public Errors() {
    }

    public static Errors operator++(Errors errors){
      errors.NumberOfErrors++;
      if(errors.NumberOfErrors == MaxErrors) {
        errors.MaxErrorsReached(errors, null);
      }

      return errors;
    }

    public event EventHandler MaxErrorsReached;
  }
}
