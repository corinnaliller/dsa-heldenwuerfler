using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heldenwuerfler.Logik
{
    internal class TalentProbenErgebnis
    {
        #region Properties
        public List<int> TalentWurf {  get; set; }
        public int TaPStern {  get; set; }
        public TalentErgebnis Ergebnis { get; set; }
        #endregion Properties
    }
}
