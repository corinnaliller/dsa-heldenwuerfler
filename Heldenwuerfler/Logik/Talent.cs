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
        internal List<string> Probe { get; set; }
        internal bool Basis { get; private set; }
        #endregion Properties

        #region Constructors
        public Talent() { }
        public Talent(string name, int wert, List<string> probe, TalentKategorie kategorie, bool basis)
        {
            Name = name;
            Wert = wert;
            Probe = probe;
            Basis = basis;
            Kategorie = kategorie;
        }
        public Talent(string name, string wert, string probe, string kategorie)
        {
            Name = name;
            if (!Int32.TryParse(wert, out Wert))
            {
                Wert = 0;
            }
            Probe = ParseEigenschaften(probe);
            Kategorie = KategorieSetzen(kategorie);
        }
        #endregion Constructors

        #region Private Methods
        private List<string> ParseEigenschaften(string eigenschaften)
        {
            string[] split = eigenschaften.Split("/");
            List<string> liste = new List<string>();
            foreach (string s in split)
            {
                liste.Add(s);
            }
            return liste;
        }
        private TalentKategorie KategorieSetzen(string kategorieName)
        {
            switch (kategorieName) {
                case "Körperlich": return TalentKategorie.Koerperlich;
                case "Gesellschaft": return TalentKategorie.Gesellschaft;
                case "Natur": return TalentKategorie.Natur;
                case "Wissen": return TalentKategorie.Wissen;
                case "Handwerk": return TalentKategorie.Handwerk;
            }
        #endregion Private Methods
    }
}
