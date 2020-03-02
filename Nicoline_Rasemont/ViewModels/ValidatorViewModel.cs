using Nicoline_Rasemont.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nicoline_Rasemont.ViewModels
{
    public class ValidatorViewModel
    {
        public int Result { get; set; }
        public ValidatorViewModel()
        {
            ValidatorHelper helper = new ValidatorHelper();
            Result = helper.ValidateInput();

        }
    }
}
