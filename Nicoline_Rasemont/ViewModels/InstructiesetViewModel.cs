using Nicoline_Rasemont.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nicoline_Rasemont.ViewModels
{
    public class InstructiesetViewModel
    {
        public int Result { get; set; }
        public int BonusResult { get; set; }

        public InstructiesetViewModel()
        {
            InstructiesetHelper helper = new InstructiesetHelper();
            Result = helper.GetMaxValue();
            BonusResult = helper.GetAllTimeMaxValue();
        }
    }
}
