using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heldenwuerfler.Logik
{
    internal class EigenschaftsProbenErgebnis
    {
        #region Properties
        public int EigenschaftsWurf {  get; set; }
        public int Punkte {  get; set; }
        public EigenschaftsErgebnis Ergebnis { get; set; }
        #endregion Properties
    }
}
