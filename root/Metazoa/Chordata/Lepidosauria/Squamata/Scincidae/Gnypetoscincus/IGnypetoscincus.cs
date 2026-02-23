namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Gnypetoscincus;

/// <summary>
/// Interface defining characteristics of Gnypetoscincus (genus).
/// </summary>
public interface IGnypetoscincus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
