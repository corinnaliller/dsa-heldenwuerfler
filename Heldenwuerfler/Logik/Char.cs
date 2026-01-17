using System;
namespace Heldenwuerfler.Logik

public class Char
{
    #region Properties
    public string Name { get; set; }
    public int LeP { get; set; }
    public List<Eigenschaft> Eigenschaften { get; set; }
    #endregion Properties

    #region Constructors
    public Char()
	{
        Name = "Menschenjäger/Gardist";
        LeP = 32;
        Eigenschaften = new List<Eigenschaft>();
    }
    #endregion Constructors
}
