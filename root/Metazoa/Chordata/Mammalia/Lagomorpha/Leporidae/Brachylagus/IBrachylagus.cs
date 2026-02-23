namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Brachylagus;

/// <summary>
/// Interface defining characteristics of Brachylagus (genus).
/// </summary>
public interface IBrachylagus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
