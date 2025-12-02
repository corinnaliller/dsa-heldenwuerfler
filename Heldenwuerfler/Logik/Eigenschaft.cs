using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heldenwuerfler.Logik
{
    internal class Eigenschaft
    {
        #region Properties
        public string Name { get; set; }
        public EigenschaftKurzname KurzName { get; set; }
        public int Wert {  get; set; }
        public EigenschaftsKategorie Kategorie { get; set; }
        #endregion Properties

        #region Constructors
        public Eigenschaft(string name, int wert)
        {
            Name = name;
            Wert = wert;
            Kategorie = KategorieSetzen(name);
            KurzName = KurznameSetzen(name);
        }
        #endregion Constructors

        #region Private Methods
        private EigenschaftsKategorie KategorieSetzen(string name)
        {
            switch (name)
            {
                case "Mut":
                case "Klugheit":
                case "Intuition":
                case "Charisma":
                    return EigenschaftsKategorie.Geistig;
                case "Gewandtheit":
                case "Fingerfertigkeit":
                case "Konstitution":
                case "Körperkraft":
                    return EigenschaftsKategorie.Koerperlich;
                default: return EigenschaftsKategorie.Koerperlich;
            }
        }
        private EigenschaftKurzname KurznameSetzen(string name)
        {
            switch (name)
            {
                case "Mut": return EigenschaftKurzname.MU;
                case "Klugheit": return EigenschaftKurzname.KL;
                case "Intuition": return EigenschaftKurzname.IN;
                case "Charisma": return EigenschaftKurzname.CH;
                case "Gewandtheit": return EigenschaftKurzname.GE;
                case "Fingerfertigkeit": return EigenschaftKurzname.FF;
                case "Konstitution": return EigenschaftKurzname.KO;
                case "Körperkraft": return EigenschaftKurzname.KK;
                default: return EigenschaftKurzname.GE;
            }
        #endregion Private Methods
    }
}
