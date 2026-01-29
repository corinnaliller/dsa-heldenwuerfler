using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heldenwuerfler.Logik
{
    internal class Talent
    {
        #region Properties
        internal TalentKategorie Kategorie { get; set; }
        internal string Name { get; set; }
        internal int Wert { get; set; }
        internal List<Eigenschaft> Probe { get; set; }
        internal bool Basis { get; private set; }
        #endregion Properties

        #region Constructors
        public Talent() { }
        public Talent(string name, int wert, List<Eigenschaft> probe, TalentKategorie kategorie, bool basis)
        {
            Name = name;
            Wert = wert;
            Probe = probe;
            Basis = basis;
            Kategorie = kategorie;
        }
        #endregion Constructors
    }
}
