using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heldenwuerfler.Logik
{
    internal class TalentWuerfler
    {
        #region Attributes
        private Wuerfel wuerfel;
        #endregion Attributes

        #region Constructors
        public TalentWuerfler()
        {
            this.wuerfel = new Wuerfel(20);
        }
        #endregion Constructors

        #region Public Methods
        public (TalentErgebnis, int) TalentProbe(int talentWert, int[] eigenschaftsWerte, int erschwernis = 0, int erleichterung = 0)
        {
            int[] talentWurf = this.TalentWurf();
            return (TalentErgebnis.Misserfolg, 0);
        }
        #endregion Public Methods

        #region Private Methods
        private int[] TalentWurf()
        {
            int[] talentWurf = new int[3];
            for (int i = 0; i < 3; i++)
            {
                talentWurf[i] = this.wuerfel.Wuerfeln();
            }

            return talentWurf;
        }
        #endregion Private Methods
    }
}
