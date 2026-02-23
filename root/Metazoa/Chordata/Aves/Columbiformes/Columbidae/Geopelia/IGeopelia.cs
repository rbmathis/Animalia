namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Geopelia;

/// <summary>
/// Interface defining characteristics of Geopelia (genus).
/// </summary>
public interface IGeopelia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
