using System;

namespace Heldenwuerfler.Logik;

internal class EigenschaftsWuerfler
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
    public EigenschaftsProbenErgebnis EigenschaftsProbe(int eigenschaftsWert, int erschwernis = 0, int erleichterung = 0)
    {
        EigenschaftsProbenErgebnis probenErgebnis = new EigenschaftsProbenErgebnis();
        EigenschaftsErgebnis ergebnis;
        int punkte = 0;
        int wuerfelErgebnis = this.wuerfel.Wuerfeln();
        probenErgebnis.EigenschaftsWurf = wuerfelErgebnis;
        eigenschaftsWert -= erschwernis;
        if (wuerfelErgebnis == 1)
        {
            ergebnis = EinserProbe(eigenschaftsWert);
            punkte = eigenschaftsWert;
        }
        else if (wuerfelErgebnis == 20)
        {
            ergebnis = ZwanzigerProbe(eigenschaftsWert);
            punkte = eigenschaftsWert - wuerfelErgebnis;
        }
        else
        {
            if (wuerfelErgebnis <= eigenschaftsWert)
            {
                ergebnis = EigenschaftsErgebnis.Erfolg;
                punkte = eigenschaftsWert - wuerfelErgebnis;
            }
            else
            {
                if (erleichterung > 0)
                {
                    int diff = wuerfelErgebnis - eigenschaftsWert;
                    if (diff <= erleichterung)
                    {
                        punkte = erleichterung - diff;
                        ergebnis = EigenschaftsErgebnis.Erfolg;
                    }
                    else
                    {
                        ergebnis = EigenschaftsErgebnis.Misserfolg;
                        punkte = -diff;
                    }
                }
                else
                {
                    ergebnis = EigenschaftsErgebnis.Misserfolg;
                    punkte = eigenschaftsWert - wuerfelErgebnis;
                }
            }
        }
        probenErgebnis.Ergebnis = ergebnis;
        probenErgebnis.Punkte = punkte;
        
        return probenErgebnis;
    }
    #endregion Public Methods

    #region Private Methods
    private EigenschaftsErgebnis EinserProbe(int eigenschaftsWert)
    {
        int zweiterWurf = this.wuerfel.Wuerfeln();
        if (zweiterWurf == 1)
        {
            return EigenschaftsErgebnis.UltraKritischerErfolg;
        }
        else if (zweiterWurf <= eigenschaftsWert)
        {
            return EigenschaftsErgebnis.KritischerErfolg;
        }
        return EigenschaftsErgebnis.Erfolg;
    }
    private EigenschaftsErgebnis ZwanzigerProbe(int eigenschaftsWert)
    {
        int zweiterWurf = this.wuerfel.Wuerfeln();
        if (zweiterWurf == 20)
        {
            return EigenschaftsErgebnis.TotalerPatzer;
        }
        else if (zweiterWurf >= eigenschaftsWert)
        {
            return EigenschaftsErgebnis.Patzer;
        }
        return EigenschaftsErgebnis.Misserfolg;
    }
    #endregion Private Methods
}
