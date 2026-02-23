namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Rhynchospiza;

/// <summary>
/// Interface defining characteristics of Rhynchospiza (genus).
/// </summary>
public interface IRhynchospiza
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
