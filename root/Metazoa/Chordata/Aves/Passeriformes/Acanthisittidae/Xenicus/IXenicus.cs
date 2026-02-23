namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthisittidae.Xenicus;

/// <summary>
/// Interface defining characteristics of Xenicus (genus).
/// </summary>
public interface IXenicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
