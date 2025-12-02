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
        public TalentProbenErgebnis TalentProbe(int talentWert, List<int> eigenschaftsWerte, int erschwernis = 0, int erleichterung = 0)
        {
            TalentProbenErgebnis ergebnis = new TalentProbenErgebnis();
            TalentErgebnis talentErgebnis = TalentErgebnis.Misserfolg;
            List<int> talentWurf = this.TalentWurf();
            ergebnis.TalentWurf = talentWurf;
            int taPStern = talentWert - erschwernis;
            if (talentWurf.Contains(1) || talentWurf.Contains(20))
            {
                talentErgebnis = this.CheckTalentWurf(talentWurf);
            }
            if (talentErgebnis == TalentErgebnis.Erfolg || talentErgebnis == TalentErgebnis.Misserfolg)
            {
                
                for (int i = 0; i < 3; i++)
                {
                    int eigenschaftsWert = eigenschaftsWerte[i];
                    int wurf = talentWurf[i];
                    if (wurf > eigenschaftsWert)
                    {
                        int diff = wurf - eigenschaftsWert;
                        taPStern -= diff;
                    }
                }
                if (taPStern < talentWert && erleichterung > 0)
                {
                    if ((taPStern + erleichterung) < talentWert)
                    {
                        taPStern += erleichterung;
                    }
                    else
                    {
                        taPStern = talentWert;
                    }
                }
                if (taPStern < 0)
                {
                    talentErgebnis = TalentErgebnis.Misserfolg;
                }
                else if (taPStern >= 0)
                {
                    talentErgebnis = TalentErgebnis.Erfolg;
                }
            }
            else if(talentErgebnis == TalentErgebnis.Doppel1 || talentErgebnis == TalentErgebnis.Dreifach1)
            {
                ergebnis.TaPStern = taPStern;
            }
            else if (talentErgebnis == TalentErgebnis.Doppel20 || talentErgebnis == TalentErgebnis.Dreifach20)
            {
                ergebnis.TaPStern = 0;
            }
                return ergebnis;
        }
        #endregion Public Methods

        #region Private Methods
        private List<int> TalentWurf()
        {
            List<int> talentWurf = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                talentWurf[i] = this.wuerfel.Wuerfeln();
            }

            return talentWurf;
        }
        private TalentErgebnis CheckTalentWurf(List<int> talentWurf)
        {
            TalentErgebnis ergebnis = TalentErgebnis.Erfolg;
            if (talentWurf.Contains(1))
            {
                int einser = 0;
                for (int i = 0; i < talentWurf.Count; i++)
                {
                    if (talentWurf[i].Equals(1))
                    {
                        einser++;
                    }
                }
                if (einser == 3)
                {
                    ergebnis = TalentErgebnis.Dreifach1;
                }
                else if (einser == 2)
                {
                    ergebnis = TalentErgebnis.Doppel1;
                }
                else
                {
                    ergebnis = TalentErgebnis.Erfolg;
                }
            }
            else if (talentWurf.Contains(20)) 
            {
                int zwanziger = 0;
                for(int i = 0;i < talentWurf.Count;i++)
                {
                    if (talentWurf[i].Equals(20))
                    {
                        zwanziger++; 
                    }
                }
                if (zwanziger == 3)
                {
                    ergebnis = TalentErgebnis.Dreifach20;
                }
                else if (zwanziger == 2)
                {
                    ergebnis = TalentErgebnis.Doppel20;
                }
                else 
                { 
                    ergebnis = TalentErgebnis.Misserfolg; 
                }
            }
            return ergebnis;
        }
        #endregion Private Methods
    }
}
