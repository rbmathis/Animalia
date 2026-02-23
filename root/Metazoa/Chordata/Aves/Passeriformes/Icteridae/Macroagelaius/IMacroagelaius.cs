namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Macroagelaius;

/// <summary>
/// Interface defining characteristics of Macroagelaius (genus).
/// </summary>
public interface IMacroagelaius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
