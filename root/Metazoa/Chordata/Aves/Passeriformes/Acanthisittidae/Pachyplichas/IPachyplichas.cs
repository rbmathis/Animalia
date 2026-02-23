namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthisittidae.Pachyplichas;

/// <summary>
/// Interface defining characteristics of Pachyplichas (genus).
/// </summary>
public interface IPachyplichas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
