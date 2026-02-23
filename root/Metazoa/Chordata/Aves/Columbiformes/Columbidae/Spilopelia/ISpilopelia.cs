namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Spilopelia;

/// <summary>
/// Interface defining characteristics of Spilopelia (genus).
/// </summary>
public interface ISpilopelia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
