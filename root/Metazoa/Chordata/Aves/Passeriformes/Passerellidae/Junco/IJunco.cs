namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Junco;

/// <summary>
/// Interface defining characteristics of Junco (genus).
/// </summary>
public interface IJunco
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
