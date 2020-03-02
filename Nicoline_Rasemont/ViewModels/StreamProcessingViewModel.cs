using Nicoline_Rasemont.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nicoline_Rasemont.ViewModels
{
    public class StreamProcessingViewModel
    {
        public int Result { get; set; }
        public int BonusResult { get; set; }

        public StreamProcessingViewModel()
        {
            StreamProcessingHelper helper = new StreamProcessingHelper();
            Result = helper.CountGroups();
            BonusResult = helper.CountNonsense();
        }
    }
}
