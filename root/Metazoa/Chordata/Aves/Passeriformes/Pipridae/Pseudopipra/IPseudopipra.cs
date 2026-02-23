namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Pseudopipra;

/// <summary>
/// Interface defining characteristics of Pseudopipra (genus).
/// </summary>
public interface IPseudopipra
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
