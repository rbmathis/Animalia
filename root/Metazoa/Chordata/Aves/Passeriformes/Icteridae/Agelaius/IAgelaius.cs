namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Agelaius;

/// <summary>
/// Interface defining characteristics of Agelaius (genus).
/// </summary>
public interface IAgelaius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
