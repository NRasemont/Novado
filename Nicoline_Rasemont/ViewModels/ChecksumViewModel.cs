using Nicoline_Rasemont.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nicoline_Rasemont.ViewModels
{
    public class ChecksumViewModel
    {
        public int Result { get; set; }
        public int BonusResult { get; set; }

        public ChecksumViewModel()
        {
            ChecksumHelper helper = new ChecksumHelper();
            Result = helper.Checksum();
            BonusResult = helper.ChecksumBonus();
        }
    }
}
