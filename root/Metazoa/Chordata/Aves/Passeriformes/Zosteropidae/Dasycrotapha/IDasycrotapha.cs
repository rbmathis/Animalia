namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Dasycrotapha;

/// <summary>
/// Interface defining characteristics of Dasycrotapha (genus).
/// </summary>
public interface IDasycrotapha
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
