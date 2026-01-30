using System;
namespace Heldenwuerfler.Logik;

public class Char
{
    #region Properties
    internal string Name { get; set; }
    internal int Lebenspunkte { get; set; }
    internal int Ausdauerpunkte { get; set; }
    internal int Wundschwelle { get; set; }
    internal int Ruestschutz { get; set; }
    internal int Geschwindigkeit { get; set; }
    internal int Magieresistenz { get; set; }
    internal List<Eigenschaft> Eigenschaften
    {
        get;
        private set;
    }
    #endregion Properties

    #region Constructors
    public Char()
	{
        Name = "Menschenjäger/Gardist";
        Lebenspunkte = 32;
        Ausdauerpunkte = 30;
        Wundschwelle = 7;
        Ruestschutz = 2;
        Geschwindigkeit = 7;
        Magieresistenz = 3;
        Eigenschaften = new List<Eigenschaft>() { 
            new Eigenschaft("Mut", 13), 
            new Eigenschaft("Gewandtheit", 12), 
            new Eigenschaft("Konstitution", 14), 
            new Eigenschaft("Körperkraft",13) 
        };
    }
    #endregion Constructors

    
}
