namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peroryctidae.Rhynchomeles;

/// <summary>
/// Interface defining characteristics of Rhynchomeles (genus).
/// </summary>
public interface IRhynchomeles
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
