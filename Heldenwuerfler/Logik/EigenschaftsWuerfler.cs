using System;

namespace Heldenwuerfler;

public class EigenschaftsWuerfler
{
    #region Attributes
    private Wuerfel wuerfel;
    #endregion Attributes

    #region Constructors
    public EigenschaftsWuerfler()
    {
        this.wuerfel = new Wuerfel(20);
    }
    #endregion Constructors

    #region Public Methods
    public (AttributErgebnis, int) EigenschaftsProbe(int eigenschaftsWert, int erschwernis = 0, int erleichterung = 0)
    {
        AttributErgebnis ergebnis = AttributErgebnis.Misserfolg;
        int punkte = 0;
        int wuerfelErgebnis = this.wuerfel.Wuerfeln();
        eigenschaftsWert -= erschwernis;
        if (wuerfelErgebnis == 1)
        {
            if (BestaetigteEins(eigenschaftsWert))
            {
                ergebnis = AttributErgebnis.KritischerErfolg;
            }
        }
        else if (wuerfelErgebnis == 20)
        {
            if (BestaetigteZwanzig(eigenschaftsWert))
            {
                ergebnis = AttributErgebnis.Patzer;
            }
        }
        else
        {
            if (wuerfelErgebnis <= eigenschaftsWert)
            {
                ergebnis = AttributErgebnis.Erfolg;
                punkte = eigenschaftsWert - wuerfelErgebnis;
            }
            else
            {
                if (erleichterung > 0)
                {

                }
                else
                {

                }
            }
        }
        return (ergebnis, punkte);
    }
    #endregion Public Methods

    #region Private Methods
    private bool BestaetigteEins(int eigenschaftsWert)
    {
        int zweiterWurf = this.wuerfel.Wuerfeln();
        if (zweiterWurf <= eigenschaftsWert)
        {
            return true;
        }
        return false;
    }
    private bool BestaetigteZwanzig(int eigenschaftsWert)
    {
        int zweiterWurf = this.wuerfel.Wuerfeln();
        if (zweiterWurf >= eigenschaftsWert)
        {
            return true;
        }
        return false;
    }
    #endregion Private Methods
}
