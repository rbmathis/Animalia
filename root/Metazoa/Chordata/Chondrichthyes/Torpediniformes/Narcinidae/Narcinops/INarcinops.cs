namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narcinidae.Narcinops;

/// <summary>
/// Interface defining characteristics of Narcinops (genus).
/// </summary>
public interface INarcinops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
