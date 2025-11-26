using System;

public class EigenschaftsWuerfler
{
	public EigenschaftsWuerfler()
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
        public bool EigenschaftsProbe(int eigenschaftsWert, int erschwernis = 0)
        {
            int wuerfelErgebnis = this.wuerfel.Wuerfeln();
            if (erschwernis != 0)
            {
                eigenschaftsWert -= erschwernis;
            }
            if (wuerfelErgebnis == 1)
            {
                return BestaetigteEins(eigenschaftsWert);
            }
            else if (wuerfelErgebnis == 20)
            {

            }
            if (wuerfelErgebnis > eigenschaftsWert)
            {
                return false;
            }
            else
            {
                return true;
            }   
        }      
        public int ProbenErgebnis(int eigenschaftsWert, int erschwernis = 0)
        {   
            int wuerfelErgebnis = this.wuerfel.Wuerfeln();
            int differenz = 0;
            if (erschwernis >= 0)
            {
                eigenschaftsWert -= erschwernis;
                differenz = eigenschaftsWert - wuerfelErgebnis;
            }
            else
            {   
                differenz = eigenschaftsWert - wuerfelErgebnis;
                if (differenz < 0)
                {
                
                }
                else
                {
                    return differenz;
                }
            }
        #endregion Public Methods

        #region Private Methods
        private bool BestaetigteEins(int eigenschaftsWert)
        {
            int zweiterWurf = this.wuerfel.Wuerfeln();
            if(zweiterWurf <= eigenschaftsWert)
            {
                return true;
            }
            return false;
        }
        private bool BestaetigteZwanzig(int eigenschaftsWert)
        {
            int zweiterWurf = this.wuerfel.Wuerfeln();
            if(zweiterWurf >= eigenschaftsWert)
            {
                return true;
            }
        return false;
        }
        #endregion Private Methods
    }
}
