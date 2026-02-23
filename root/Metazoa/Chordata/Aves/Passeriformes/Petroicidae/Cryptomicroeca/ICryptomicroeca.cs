namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Cryptomicroeca;

/// <summary>
/// Interface defining characteristics of Cryptomicroeca (genus).
/// </summary>
public interface ICryptomicroeca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
