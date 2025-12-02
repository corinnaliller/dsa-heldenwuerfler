using System;
using System.ComponentModel;

namespace Heldenwuerfler.Logik;

internal enum EigenschaftsErgebnis
{
    Erfolg,
    Misserfolg,
    KritischerErfolg,
    Patzer,
    UltraKritischerErfolg,
    TotalerPatzer
}

internal enum TalentErgebnis
{
    Erfolg, 
    Misserfolg,
    Doppel1,
    Doppel20,
    Dreifach1,
    Dreifach20
}
internal enum EigenschaftsKategorie
{
    [Description("Geistig")]
    Geistig,
    [Description("Körperlich")]
    Koerperlich
}
internal enum EigenschaftKurzname
{
    [Description("MU")]
    MU,
    [Description("KL")]
    KL,
    [Description("IN")]
    IN,
    [Description("CH")]
    CH,
    [Description("FF")]
    FF,
    [Description("GE")]
    GE,
    [Description("KO")]
    KO,
    [Description("KK")]
    KK
}
internal enum TalentKategorie
{
    [Description("Körperlich")]
    Koerperlich,
    [Description("Waffe")]
    Waffe,
    [Description("Gesellschaft")]
    Gesellschaft,
    [Description("Natur")]
    Natur,
    [Description("Wissen")]
    Wissen,
    [Description("Schrift")]
    Schrift,
    [Description("Sprache")]
    Sprache,
    [Description("Handwerk")]
    Handwerk,
    [Description("Gabe")]
    Gabe
}
