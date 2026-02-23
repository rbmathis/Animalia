namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Artamus;

/// <summary>
/// Interface defining characteristics of Artamus (genus).
/// </summary>
public interface IArtamus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
